/*************************************************************************************
    * 类 名 称：       SysDBParm
    * 命名空间：       YIEternalMIS.DataDictionary
    * 文 件 名：       SysDBParm
    * 创建时间：       2017/6/5 12:58:32
    * 作    者：        王宏巍
    * 说   明：        数据库参数类
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YIEternalMIS.DataDictionary
{
    public static class SysDBParm
    {
        static string _parm1, _parm2, _parm3, _parm4, _parm5, _parm6, _parm7, _parm8, _parm9, _parm10, _parm11, _parm12, _parm13, _parm14, _parm15, _parm16, _parm17;
        
        //参数1功能：
        public static string Parm1
        {
            get { return Common.StringISNULL.Isnull(_parm1, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm2
        {
            get { return Common.StringISNULL.Isnull(_parm2, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm3
        {
            get { return Common.StringISNULL.Isnull(_parm3, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm4
        {
            get { return Common.StringISNULL.Isnull(_parm4, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm5
        {
            get { return Common.StringISNULL.Isnull(_parm5, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm7
        {
            get { return Common.StringISNULL.Isnull(_parm7, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm6
        {
            get { return Common.StringISNULL.Isnull(_parm6, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm8
        {
            get { return Common.StringISNULL.Isnull(_parm8, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm9
        {
            get { return Common.StringISNULL.Isnull(_parm9, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm10
        {
            get { return Common.StringISNULL.Isnull(_parm10, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm11
        {
            get { return Common.StringISNULL.Isnull(_parm11, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm12
        {
            get { return Common.StringISNULL.Isnull(_parm12, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm13
        {
            get { return Common.StringISNULL.Isnull(_parm13, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm14
        {
            get { return Common.StringISNULL.Isnull(_parm14, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm15
        {
            get { return Common.StringISNULL.Isnull(_parm15, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm16
        {
            get { return Common.StringISNULL.Isnull(_parm16, "0"); }
        }
        /// <summary>
        /// 参数功能
        /// </summary>
        public static string Parm17
        {
            get { return Common.StringISNULL.Isnull(_parm17, "0"); }
        }
      
      
        
        public static  void LoadDBParm()
        {
            string strWhere , sSwith ;
            _parm1 = _parm2 = _parm3 = _parm4 = _parm5 = _parm6 = _parm7 = _parm8 = _parm9 = _parm10 = _parm11 = _parm12 = _parm13 = _parm14 = _parm15 = _parm16 = _parm17 = "";
            DateTime dt;
            dt = GetServerDateTime();
            strWhere = "SysSdate <= '" + Common.Convertto.ToCharYYYY_MM_DD_HHMMSS(dt) + "' AND SysEdate >= '" + Common.Convertto.ToCharYYYY_MM_DD_HHMMSS(dt) + "' and zfbz = '0'  ";
            DataTable _DBParm; 
            _DBParm  = new BLL.YIESysParameter().GetList( strWhere ).Tables[0];
            if(_DBParm.Rows.Count > 0 )
            {
                for(int i = 0 ; i < _DBParm.Rows.Count;i++)
                {
                    sSwith = _DBParm.Rows[i]["Sysxh"].ToString();
                    switch(sSwith)
                    {
                        case "1":
                            _parm1 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "2":
                            _parm2 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "3":
                            _parm3 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "4":
                            _parm4 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "5":
                            _parm5 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "6":
                            _parm6 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "7":
                            _parm7 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "8":
                            _parm8 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "9":
                            _parm9 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "10":
                            _parm10 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "11":
                            _parm11 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "12":
                            _parm12 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "13":
                            _parm13 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "14":
                            _parm14 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "15":
                            _parm15 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "16":
                            _parm1 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                        case "17":
                            _parm17 = _DBParm.Rows[i]["SysValue"].ToString();
                            break;
                    }
                    

                }
            }
        }

        public static DateTime GetServerDateTime()
        {
            return new BLL.YIESysRegister().GetServerDateTime();
        }

    }
}
