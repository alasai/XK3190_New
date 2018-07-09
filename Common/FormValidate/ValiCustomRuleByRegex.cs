/*************************************************************************************
    * 类 名 称：       ValiCustomRuleByRegex
    * 命名空间：       Common
    * 文 件 名：       ValiCustomRuleByRegex
    * 创建时间：       2017/6/2 9:13:53
    * 作    者：        王宏巍
    * 说   明：        自定义控件验证条件
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace YIEternalMIS.Common
{
    public class ValiCustomRuleByRegex : ValidationRule
    {
        
        string regex;
        bool isnotblank;//是否为空
        /// <summary>
        /// 是否为数字
        /// </summary>
        public static string strIsNumeric = "^[\\+\\-]?[0-9]*\\.?[0-9]+$";
        /// <summary>
        /// 电话号码
        /// </summary>
        public static string strPhone = @"(^(\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$|(1(([35][0-9])|(47)|[8][01236789]))\d{8}$";

        /// <summary>
        /// 使用正则表达式验证
        /// </summary>
        /// <param name="regex">正则表达式</param>
        /// <param name="isnotblank">是否允许为空</param>
        public ValiCustomRuleByRegex(string regex, bool isnotblank)
        {
            this.regex = regex;
            this.isnotblank = isnotblank;
        }

        public override bool Validate(Control control, object value)
        {
            bool flag;
            try
            {
                if (value == null || value.ToString().Trim() == string.Empty)
                {
                    if (isnotblank)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        this.ErrorText = "该值不允许为空！";
                    }
                }
                else
                {
                    flag = Regex.IsMatch((string)value, regex);
                }
            }
            catch (Exception ex)
            {
                this.ErrorText = ex.Message;
                flag = false;
            }
            return flag;
        }
    }
}
