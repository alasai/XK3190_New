/*************************************************************************************
    * 类 名 称：       DataConverter
    * 命名空间：       Common
    * 文 件 名：       DataConverter
    * 创建时间：       2017/6/2 14:13:42
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.ComponentModel;
using System.Xml;

namespace YIEternalMIS.Common
{

    /// <summary>
    /// DataTable-Object 互转换工具
    /// </summary>
    public class DataConverter
    {

        /// <summary>
        /// 根据类型创建表结构
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static DataTable CreateTable(Type t)
        {
            return BuiltTable(t.GetProperties());
        }

        /// <summary>
        /// 根据对象的属性创建数据表
        /// </summary>
        private static DataTable BuiltTable(PropertyInfo[] pinfo)
        {
            try
            {
                if (pinfo == null) return null;
                DataTable table = new DataTable();
                foreach (PropertyInfo info in pinfo)
                {
                    Type type = info.PropertyType;
                    if (info.PropertyType.IsGenericType)
                        type = info.PropertyType.GetGenericArguments()[0];
                    DataColumn column = new DataColumn(info.Name, type);
                    column.AllowDBNull = true;
                    table.Columns.Add(column);
                }
                return table;
            }
            catch { return null; }
        }

        /// <summary>
        /// Object to Object. 将一个对象转换为指定类型的对象.
        /// 注意: destination内的Property必需在source内存在.
        /// </summary>
        public static object CopyProperties(object source, Type destination)
        {
            try
            {
                if (source == null) return null;
                object destObj = destination.Assembly.CreateInstance(destination.FullName);
                PropertyInfo[] propsDest = destObj.GetType().GetProperties();
                foreach (PropertyInfo infoDest in propsDest)
                {
                    object value = GetValueOfObject(source, infoDest.Name);
                    if (CanShallowCopyProperty(value)) SetPropertyValue(destObj, infoDest, value);
                }
                return destObj;
            }
            catch { return null; }
        }

        /// <summary>
        /// 指定参数是否可用于浅拷贝
        /// </summary>
        private static bool CanShallowCopyProperty(object propValue)
        {
            if (propValue == null) return true;
            if (propValue.GetType().IsValueType || propValue is string) return true;
            return false;
        }

        /// <summary>
        /// 复制对象属性.
        /// </summary>
        public static void CopyProperties(object source, object destObj)
        {
            try
            {
                if (source == null || destObj == null) return;
                PropertyInfo[] propsDest = destObj.GetType().GetProperties();
                foreach (PropertyInfo infoDest in propsDest)
                {
                    object value = GetValueOfObject(source, infoDest.Name);
                    if (CanShallowCopyProperty(value)) SetPropertyValue(destObj, infoDest, value);
                }
            }
            catch { }
        }

        /// <summary>
        /// 复制对象. 浅拷贝.
        /// </summary>
        public static object CloneObject(object source)
        {
            try
            {
                if (source == null) return null;
                Type objType = source.GetType();
                object destObj = objType.Assembly.CreateInstance(objType.FullName);
                PropertyInfo[] propsSource = objType.GetProperties();
                foreach (PropertyInfo infoSource in propsSource)
                {
                    object value = GetValueOfObject(source, infoSource.Name);
                    if (CanShallowCopyProperty(value)) SetPropertyValue(destObj, infoSource, value);
                }
                return destObj;
            }
            catch { return null; }
        }

        /// <summary>
        /// 复制一个对象数组.
        /// </summary>
        public static ArrayList CloneObjects(IList source)
        {
            if (source == null) return null;
            ArrayList ret = new ArrayList();
            foreach (object o in source) ret.Add(CloneObject(o));
            return ret;
        }

        /// <summary>
        /// 获取对象指定属性的值
        /// </summary>
        public static object GetValueOfObject(object obj, string property)
        {
            try
            {
                if (obj == null) return null;
                Type type = obj.GetType();
                PropertyInfo[] pinfo = type.GetProperties();
                foreach (PropertyInfo info in pinfo)
                {
                    if (info.Name.ToUpper() == property.ToUpper())
                        return info.GetValue(obj, null);
                }
                return null;
            }
            catch { return null; }
        }

        /// <summary>
        /// 纵对象数据组取出某一个对象. 返回对象指定属性名称(returnPropName)的值
        /// </summary>
        public static object GetObjectValueByKey(IList objects, string keyPropName, object keyValue, string returnPropName)
        {
            object o = GetObjectByKey(objects, keyPropName, keyValue);
            if (o != null)
                return GetValueOfObject(o, returnPropName);
            else
                return null;
        }

        /// <summary>
        /// 纵对象数据组取出某一个对象. 参数指定关键字段名称(keyPropName)及值(keyValue).
        /// </summary>
        public static object GetObjectByKey(IList objects, string keyPropName, object keyValue)
        {
            foreach (object o in objects)
            {
                object value = GetValueOfObject(o, keyPropName);
                if (value == null) continue;
                if (value.ToString().ToLower() == keyValue.ToString().ToLower())
                {
                    return o;
                }
            }
            return null;
        }

        /// <summary>
        /// 查找对象包含指定属性.
        /// </summary>
        public static bool FindProperty(object obj, string property)
        {
            try
            {
                if (obj == null) return false;
                Type type = obj.GetType();
                PropertyInfo[] pinfo = type.GetProperties();
                foreach (PropertyInfo info in pinfo)
                {
                    if (info.Name.ToUpper() == property.ToUpper())
                        return true;
                }
                return false;
            }
            catch { return false; }
        }

        /// <summary>
        /// 给记录的字段赋值
        /// </summary>
        /// <param name="dr">记录</param>
        /// <param name="field">字段名</param>
        /// <param name="value">值</param>
        public static void SetValueofDataRow(DataRow dr, string field, object value)
        {
            try
            {
                if (dr == null) return;
                dr[field] = value;

            }
            catch
            {

            }
        }

        /// <summary>
        /// 设置对象某个属性的值
        /// </summary>
        public static void SetValueOfObject(object obj, string property, object value)
        {
            try
            {
                if (obj == null) return;
                Type type = obj.GetType();
                PropertyInfo[] pinfo = type.GetProperties();
                foreach (PropertyInfo info in pinfo)
                {
                    if (info.Name.ToUpper() == property.ToUpper())
                    {
                        SetPropertyValue(obj, info, value);
                        break;
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// 给对象的属性赋值
        /// </summary>
        /// <param name="instance">对象实例</param>
        /// <param name="prop">属性</param>
        /// <param name="value">值</param>
        public static void SetPropertyValue(object instance, PropertyInfo prop, object value)
        {
            try
            {
                if (prop == null) return;
                if (prop.PropertyType.ToString() == "System.String")
                { }
                else if (prop.PropertyType.ToString() == "System.Decimal")
                    value = Decimal.Parse(value.ToString());
                else if (prop.PropertyType.ToString() == "System.Int32")
                    value = int.Parse(value.ToString());
                else if (prop.PropertyType.ToString() == "System.Single")
                    value = Single.Parse(value.ToString());
                else if (prop.PropertyType.ToString() == "System.DateTime")
                    value = DateTime.Parse(value.ToString());
                prop.SetValue(instance, value, null);
            }
            catch { }
        }

        /// <summary>
        /// C#.NET数据类型集合
        /// </summary>
        /// <returns></returns>
        public static IList CSharpDataTypes()
        {
            ArrayList list = new ArrayList();
            list.Add(typeof(System.DateTime));
            list.Add(typeof(System.Byte));
            list.Add(typeof(System.SByte));
            list.Add(typeof(System.Int16));
            list.Add(typeof(System.Int32));
            list.Add(typeof(System.Int64));
            list.Add(typeof(System.IntPtr));
            list.Add(typeof(System.UInt16));
            list.Add(typeof(System.UInt32));
            list.Add(typeof(System.UInt64));
            list.Add(typeof(System.UIntPtr));
            list.Add(typeof(System.Single));
            list.Add(typeof(System.Double));
            list.Add(typeof(System.Decimal));
            list.Add(typeof(System.Boolean));
            list.Add(typeof(System.Char));
            list.Add(typeof(System.String));
            return list;
        }

        /// <summary>
        /// SQL SERVER数据类型（如：varchar）转换为SqlDbType类型
        /// </summary>
        /// <param name="sqlTypeString">SQL SERVER数据类型</param>
        /// <returns>返回SqlDbType类型</returns>
        public static SqlDbType SqlTypeString2SqlType(string sqlTypeString)
        {
            SqlDbType dbType = SqlDbType.Variant;//默认为Object

            switch (sqlTypeString)
            {
                case "int":
                    dbType = SqlDbType.Int;
                    break;
                case "varchar":
                    dbType = SqlDbType.VarChar;
                    break;
                case "bit":
                    dbType = SqlDbType.Bit;
                    break;
                case "datetime":
                    dbType = SqlDbType.DateTime;
                    break;
                case "decimal":
                    dbType = SqlDbType.Decimal;
                    break;
                case "float":
                    dbType = SqlDbType.Float;
                    break;
                case "image":
                    dbType = SqlDbType.Image;
                    break;
                case "money":
                    dbType = SqlDbType.Money;
                    break;
                case "ntext":
                    dbType = SqlDbType.NText;
                    break;
                case "nvarchar":
                    dbType = SqlDbType.NVarChar;
                    break;
                case "smalldatetime":
                    dbType = SqlDbType.SmallDateTime;
                    break;
                case "smallint":
                    dbType = SqlDbType.SmallInt;
                    break;
                case "text":
                    dbType = SqlDbType.Text;
                    break;
                case "bigint":
                    dbType = SqlDbType.BigInt;
                    break;
                case "binary":
                    dbType = SqlDbType.Binary;
                    break;
                case "char":
                    dbType = SqlDbType.Char;
                    break;
                case "nchar":
                    dbType = SqlDbType.NChar;
                    break;
                case "numeric":
                    dbType = SqlDbType.Decimal;
                    break;
                case "real":
                    dbType = SqlDbType.Real;
                    break;
                case "smallmoney":
                    dbType = SqlDbType.SmallMoney;
                    break;
                case "sql_variant":
                    dbType = SqlDbType.Variant;
                    break;
                case "timestamp":
                    dbType = SqlDbType.Timestamp;
                    break;
                case "tinyint":
                    dbType = SqlDbType.TinyInt;
                    break;
                case "uniqueidentifier":
                    dbType = SqlDbType.UniqueIdentifier;
                    break;
                case "varbinary":
                    dbType = SqlDbType.VarBinary;
                    break;
                case "xml":
                    dbType = SqlDbType.Xml;
                    break;
            }
            return dbType;
        }

        /// <summary>
        /// 数据表是否存在指定的列(Column)
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="columnName">列的名称</param>
        /// <returns></returns>
        public static bool ColumnExists(DataTable dt, string columnName)
        {
            if (dt == null) return false;
            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName.ToLower() == columnName.ToLower())
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 根据对象的属性取字段的值
        /// </summary>
        private static object GetFieldValue(DataRow row, string propertyName)
        {
            if (row == null) return null;
            if (row.Table.Columns.IndexOf(propertyName) >= 0)
            {
                object value = row[propertyName];
                if (value != null && value is DateTime)
                {
                    if ((DateTime)value <= DateTime.MinValue.AddDays(1))
                        value = null;
                }
                return value;
            }
            return null;
        }

        /// <summary>
        /// 由某对象更新资料行,字段名称必须与对象属性对应，(ORM模型)
        /// </summary>
        /// <param name="row">资料行</param>
        /// <param name="o">对象实例</param>
        /// <returns></returns>
        public static DataRow UpdateDataRowFromObject(DataRow row, object o)
        {
            PropertyInfo[] pinfo = o.GetType().GetProperties();
            foreach (PropertyInfo info in pinfo)
            {
                if (row.Table.Columns.IndexOf(info.Name) >= 0)
                    SetDataRowValue(row, info.Name, info.GetValue(o, null));
            }
            return row;
        }

        /// <summary>
        /// 新增一条记录
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="o">ORM模型</param>
        /// <returns></returns>
        public static DataRow AddDataRowFromObject(DataTable dt, object o)
        {
            DataRow row = dt.NewRow();
            PropertyInfo[] pinfo = o.GetType().GetProperties();
            foreach (PropertyInfo info in pinfo)
            {
                if (dt.Columns.IndexOf(info.Name) >= 0)
                    SetDataRowValue(row, info.Name, info.GetValue(o, null));
            }
            dt.Rows.Add(row);
            return row;
        }

        /// <summary>
        /// 给资料行赋值
        /// </summary>
        /// <param name="row">资料行</param>
        /// <param name="fieldName">字段名</param>
        /// <param name="value">值</param>
        public static void SetDataRowValue(DataRow row, string fieldName, object value)
        {
            row[fieldName] = (value == null || Convertto.ToString(value) == Globals.DEF_NULL_VALUE) ? DBNull.Value : value;
        }

        /// <summary>
        /// 从源行中对相同字段名的列付值
        /// </summary>
        /// <param name="drSouce"></param>
        /// <param name="drTo"></param>
        public static void SetTwoRowSameColValue(DataRow drSource, DataRow drTo)
        {
            for (int i = 0; i < drSource.Table.Columns.Count; i++)
            {
                string fieldname = drSource.Table.Columns[i].ColumnName;
                DataColumn col = drTo.Table.Columns[fieldname];
                if (col != null)
                {
                    drTo[fieldname] = drSource[fieldname];
                }
            }

        }

        /// <summary>
        /// 数据行(DataRow)转换为对象,对象的Type由type参数决定.
        /// </summary>
        public static object DataRowToObject(DataRow row, Type type)
        {
            if (null == row) return null;
            try
            {
                object o = type.Assembly.CreateInstance(type.FullName);
                PropertyInfo[] pinfo = type.GetProperties();
                foreach (PropertyInfo info in pinfo)
                    SetPropertyValue(o, info, GetFieldValue(row, info.Name));
                return o;
            }
            catch { return null; }
        }

        /// <summary>
        /// ArrayList转换为对象数组.
        /// </summary>
        public static object[] ToObjects(IList source)
        {
            if (null == source) return null;
            object[] ret = new object[source.Count];
            for (int i = 0; i < source.Count; i++) ret[i] = source[i];
            return ret;
        }

        /// <summary>
        /// 对象数组转换为ArrayList.
        /// </summary>
        public static ArrayList ToArrayList(IList list)
        {
            if (list == null) return null;
            ArrayList arrlist = new ArrayList();
            foreach (object o in list) arrlist.Add(o);
            return arrlist;
        }

        /// <summary>
        /// 对象数组转换为ArrayList.
        /// </summary>
        public static ArrayList ToArrayList(object[] source)
        {
            if (null != source)
                return new ArrayList((ICollection)source);
            else //如果来源数据为null,返回一个空的ArrayList.
                return new ArrayList();
        }

        /// <summary>
        /// 把字符串以逗号分格，转换成数据库格式in('a','b') 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToSQLInDataFormat(string input)
        {
            string HQL = string.Empty;
            if (input == string.Empty)
                return HQL;

            string[] sArray = input.Split(',');
            foreach (string str in sArray)
            {
                if (str.Length == 0) continue;
                HQL += "'" + str + "',";
            }
            if (HQL.Substring(HQL.Length - 1, 1) == ",")
                HQL = HQL.Substring(0, HQL.Length - 1);
            return HQL;

        }

        /// <summary>
        /// 把字符串以逗号分格，转换成数据库格式''a'',''b'' 
        /// </summary>
        public static string ToSQLInDataFormatTwo(string input)
        {
            string HQL = string.Empty;
            if (input == string.Empty)
                return HQL;

            string[] sArray = input.Split(',');
            foreach (string str in sArray)
            {
                if (str.Length == 0) continue;
                HQL += "''" + str + "'',";
            }
            if (HQL.Substring(HQL.Length - 1, 1) == ",")
                HQL = HQL.Substring(0, HQL.Length - 1);
            return HQL;
        }

        /// <summary>
        /// 修改对表的某列的值
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="value"></param>
        public static bool UpdateTableCol(DataTable dt, string fieldName, object value)
        {
            try
            {
                if (dt.Columns.IndexOf(fieldName) < 0)
                    throw new Exception("表没有" + fieldName + "列！");

                foreach (DataRow dr in dt.Rows)
                {
                    dr[fieldName] = value;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 以逗号分格字符串，返回数组
        /// 如果第一个和最后一个字符为, 去掉
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] ToStringSplit(string str)
        {
            if (str.Length > 0)
            {
                if (str[0] == ',')
                    str = str.Substring(1, str.Length - 1);
                if (str[str.Length - 1] == ',')
                    str = str.Substring(0, str.Length - 1);
            }
            string[] sArray = str.Split(',');
            return sArray;
        }


        /// <summary>
        /// 把一个行的数据新增一个表中
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static DataTable AddTableRowByRow(DataTable dt, DataRow dr)
        {

            bool b = false;
            DataRow drNew = dt.NewRow();
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                string colname = dr.Table.Columns[i].ColumnName;
                if (dt.Columns.IndexOf(colname) >= 0)
                {
                    drNew[colname] = dr[colname];
                    b = true;
                }
            }

            if (b)
                dt.Rows.Add(drNew);
            return dt;
        }

    }
}
