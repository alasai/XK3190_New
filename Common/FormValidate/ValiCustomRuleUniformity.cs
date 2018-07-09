/*************************************************************************************
    * 类 名 称：       ValiCustomRuleUniformity
    * 命名空间：       YIEternalMIS.Common
    * 文 件 名：       ValiCustomRuleUniformity
    * 创建时间：       2017/6/19 11:59:35
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;

namespace YIEternalMIS.Common
{
    public class ValiCustomRuleUniformity : ValidationRule
    {
        string sValiString;
        bool bIsNotBlank;
        public ValiCustomRuleUniformity(string sText , bool IsNotBlank )
        {
            sValiString = sText;
            bIsNotBlank = IsNotBlank;
        }

       public override bool Validate(Control control, object value)
        {
            bool flag;
            try
            {
                if (value == null || value.ToString().Trim() == string.Empty)
                {
                    if (bIsNotBlank)
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
                    flag = value.ToString() == sValiString;
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
