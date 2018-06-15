/*************************************************************************************
    * 类 名 称：       DataBinder
    * 命名空间：       YIEternal.Core
    * 文 件 名：       DataBinder
    * 创建时间：       2017/6/2 13:27:55
    * 作    者：        王宏巍
    * 说   明：        数据源绑定类
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.IO;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using YIEternalMIS.Common;
using System.Data;


namespace YIEternalMIS.Library
{

    /// <summary>
    ///用于绑定输入控件的数据源
    /// </summary>
    public class DataBinder
    {
        /// <summary>
        /// 绑定参照字段的数据源
        /// </summary>
        /// <param name="edit">参照字段输入控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="displayMember">显示字段</param>
        /// <param name="valueMember">取值字段</param>
        public static void BindingLookupEditDataSource(LookUpEdit edit, object dataSource, string displayMember, string valueMember)
        {
            BindingLookupEditDataSource(edit.Properties, dataSource, displayMember, valueMember);
        }

        /// <summary>
        /// 绑定表格内列参照字段的数据源
        /// </summary>
        /// <param name="edit">参照字段控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="displayMember">显示字段</param>
        /// <param name="valueMember">取值字段</param>
        public static void BindingLookupEditDataSource(RepositoryItemLookUpEdit edit, object dataSource, string displayMember, string valueMember)
        {
            edit.DisplayMember = displayMember;
            edit.ValueMember = valueMember;
            edit.DataSource = dataSource;
        }

        /// <summary>
        /// 绑定RadioGroup组控件的数据源
        /// </summary>
        /// <param name="edit">RadioGroup组控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingRadioEdit(RadioGroup edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();

                Binding b = new Binding("EditValue", dataSource, bindField);
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定输入控件的数据源
        /// </summary>
        /// <param name="ctl">支持输入功能的控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        /// <param name="propertyName">控件的取值属性</param>
        public static void BindingControl(Control ctl, object dataSource, string bindField, string propertyName)
        {
            try
            {
                ctl.DataBindings.Clear();
                Binding b = new Binding(propertyName, dataSource, bindField);
                ctl.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定输入控件的数据源
        /// </summary>
        /// <param name="edit">控件框</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingTextEdit(TextEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        ///  绑定CheckedListBox的数据源
        /// </summary>
        /// <param name="control">CheckedListBox</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingCheckedListBox(Control control, object dataSource, string bindField)
        {
            try
            {
                control.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                control.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 显示数据
        /// </summary>
        /// <param name="listBoxControl">ListBoxControl</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="displayMember">显示字段</param>
        public static void BindingListBoxLookupData(ListBoxControl listBoxControl, object dataSource, string displayMember)
        {
            listBoxControl.DisplayMember = displayMember;
            listBoxControl.DataSource = dataSource;
        }

        /// <summary>
        /// 绑定ComboBoxEdit的数据源
        /// </summary>
        /// <param name="edit">ComboBoxEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingComboEdit(ComboBoxEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定CheckEdit的数据源
        /// </summary>
        /// <param name="edit">CheckEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingCheckEdit(CheckEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.NullValue = "0";
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }

        }

        /// <summary>
        /// 绑定日期输入控件的数据源
        /// </summary>
        /// <param name="edit">日期输入控件TimeEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingTextEditDateTime(TimeEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                //不能绑定日期控件的DateTime属性. 只能为EditValue!
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.NullValue = null;
                b.Parse += new ConvertEventHandler(DataBinder.DateStringToDate);
                b.Format += new ConvertEventHandler(DataBinder.DateToDateString);
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定日期输入控件的数据源
        /// </summary>
        /// <param name="edit">日期输入控件DateEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingTextEditDateTime(DateEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                //不能绑定日期控件的DateTime属性. 只能为EditValue!
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.NullValue = null;
                b.Parse += new ConvertEventHandler(DataBinder.DateStringToDate);
                b.Format += new ConvertEventHandler(DataBinder.DateToDateString);
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定图像控件的数据源
        /// </summary>
        /// <param name="edit">PictureEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingImageEdit(PictureEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("Image", dataSource, bindField);
                b.Parse += new ConvertEventHandler(ParseImageToByteArray);
                b.Format += new ConvertEventHandler(FormatByteArrayToImage);
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定金额输入控件的数据源
        /// </summary>
        /// <param name="edit">PictureEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingTextEditAmount(TextEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.NullValue = null;
                b.Parse += new ConvertEventHandler(DataBinder.CurrencyStringToDecimal);
                b.Format += new ConvertEventHandler(DataBinder.DecimalToCurrencyString);
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 日期控件(DateEdit)的EditValueChanged事件.
        /// 对象内定义为Nullable<DateTime>数据类型的属性,进行数据绑定后不能将值
        /// 保存在对象内,所以实现这个方法做特殊处理
        /// </summary>
        public static void OnDateEditValueChange(object sender, EventArgs e)
        {
            try
            {
                DateEdit edit = (DateEdit)sender;
                if (edit.DataBindings.Count <= 0) return; //无绑定数据源.
                object bindingObj = edit.DataBindings[0].DataSource; //取绑定的对象.
                if (bindingObj != null)
                {
                    string bindingField = edit.DataBindings[0].BindingMemberInfo.BindingField; //取绑定的成员字段.                
                    DataConverter.SetValueOfObject(bindingObj, bindingField, edit.EditValue); //给对象的字段赋值
                }
            }
            catch (Exception ex) { Msg.ShowException(ex); }
        }

        /// <summary>
        /// Byte[] to Image
        /// </summary>
        public static void FormatByteArrayToImage(object sender, ConvertEventArgs e)
        {
            try
            {
                if (e.Value != null)
                {
                    System.Drawing.Image img = (Image)ZipTools.DecompressionObject((byte[])e.Value);
                    e.Value = img;
                }
                else
                    e.Value = (Image)null;
            }
            catch
            {
                e.Value = (Image)null;
            }
        }

        /// <summary>
        /// Image to byte[]
        /// </summary>
        public static void ParseImageToByteArray(object sender, ConvertEventArgs e)
        {
            try
            {
                if (e.Value != null)
                {
                    e.Value = ZipTools.CompressionObject(e.Value as Image);
                }
                else
                    e.Value = DBNull.Value;
            }
            catch
            {
                e.Value = DBNull.Value;
            }
        }

        /// <summary>
        /// 绑定日期选择控件(DateEdit)的EditValueChanged事件.
        /// 原因请叁考OnDateEditValueChange方法描述.
        /// </summary>        
        public static void BindingDateEditValueChangeEvent(DateEdit dateEdit)
        {
            dateEdit.EditValueChanged += new EventHandler(OnDateEditValueChange);
        }

        /// <summary>
        /// 将INT类型转换为Boolean
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cevent"></param>
        public static void BoolBitToBool(object sender, ConvertEventArgs cevent)
        {
            try
            {
                if (cevent.DesiredType != typeof(int)) return;
                cevent.Value = bool.Parse(cevent.Value.ToString());
            }
            catch (Exception ex)
            {
                ShowError("数据转换错误!/n" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 将Bool转换为INT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cevent"></param>
        public static void BoolToBoolBit(object sender, ConvertEventArgs cevent)
        {
            try
            {
                if (cevent.DesiredType != typeof(bool)) return;
                if (cevent.Value.ToString() == string.Empty)
                    cevent.Value = false;
                cevent.Value = (bool)cevent.Value;
            }
            catch (Exception ex)
            {
                ShowError("数据转换错误!/n" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 日期字符串转换为日期类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cevent"></param>
        public static void DateStringToDate(object sender, ConvertEventArgs cevent)
        {
            try
            {
                Type type = cevent.DesiredType;

                //对泛型数据特殊处理.
                if (cevent.DesiredType.IsGenericType)
                    type = cevent.DesiredType.GetGenericArguments()[0];

                if (cevent.Value == null || type != typeof(DateTime) || cevent.Value.ToString() == string.Empty)
                    cevent.Value = null;
                else
                    cevent.Value = DateTime.Parse(cevent.Value.ToString(), DateTimeFormatInfo.CurrentInfo);
            }
            catch (Exception ex)
            {
                ShowError("数据转换错误!/n" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 将日期类型转换为带格式的日期字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cevent"></param>
        public static void DateToDateString(object sender, ConvertEventArgs cevent)
        {
            try
            {
                if (cevent.Value == null || cevent.DesiredType != typeof(string) || cevent.Value.ToString() == string.Empty)
                    cevent.Value = null;
                else
                    cevent.Value = ((DateTime)cevent.Value).ToString(Globals.DEF_DATE_FORMAT, DateTimeFormatInfo.CurrentInfo);
            }
            catch (Exception ex)
            {
                ShowError("数据转换错误!/n" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 将数字类型转换为带格式的字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cevent"></param>
        public static void DecimalToCurrencyString(object sender, ConvertEventArgs cevent)
        {
            try
            {
                if (cevent.DesiredType != typeof(string)) return;
                if (cevent.Value.ToString() == string.Empty)
                    cevent.Value = ((decimal)0).ToString("n");
                else
                    cevent.Value = ((decimal)cevent.Value).ToString("n"); //10,446.56
            }
            catch (Exception ex)
            {
                ShowError("数据转换错误!/n" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 将字符串转换为数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cevent"></param>
        public static void CurrencyStringToDecimal(object sender, ConvertEventArgs cevent)
        {
            try
            {
                if (cevent.DesiredType != typeof(decimal)) return;
                if (string.Empty == cevent.Value.ToString())
                    cevent.Value = 0;
                else
                    cevent.Value = Decimal.Parse(cevent.Value.ToString(), NumberStyles.Currency, null);
            }
            catch (Exception ex)
            {
                ShowError("数据转换错误!/n" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 显示错误
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="title">标题</param>
        private static void ShowError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }



        /// <summary>
        /// 给绑定数据源的输入控件赋值
        /// </summary>
        public static void SetEditorBindingValue(BaseEdit editor, object value)
        {
            try
            {
                editor.EditValue = value == DBNull.Value ? null : value;

                if (editor.DataBindings.Count > 0)
                {
                    object dataSource = editor.DataBindings[0].DataSource;
                    string field = editor.DataBindings[0].BindingMemberInfo.BindingField;
                    if (dataSource is DataTable)
                        (dataSource as DataTable).Rows[0][field] = value;
                    else
                        DataConverter.SetValueOfObject(dataSource, field, value);
                }
            }
            catch { } //这里不用显示异常信息. 
        }

    }
}
