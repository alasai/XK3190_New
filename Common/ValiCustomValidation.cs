/*************************************************************************************
    * 类 名 称：       ValiCustomValidation
    * 命名空间：       Common
    * 文 件 名：       ValiCustomValidation
    * 创建时间：       2017/6/2 9:13:53
    * 作    者：        王宏巍
    * 说   明：        自定义控件集合验证
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
    public class ValiCustomValidation
    {
        
        private DXValidationProvider provider;

        /// <summary>
        /// 条件列表
        /// </summary>
        public List<ValiControlRule> RuleList { get; set; }

        public ValiCustomValidation()
        {
            provider = new DXValidationProvider();
        }

        /// <summary>
        /// 执行验证
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool flag = true;
            if (provider != null)
            {
                provider.Dispose();
            }
            if (RuleList != null)
            {
                foreach (ValiControlRule item in RuleList)
                {
                    provider.RemoveControlError(item.control);
                    provider.SetIconAlignment(item.control, ErrorIconAlignment.MiddleRight);
                    provider.SetValidationRule(item.control, item.rule);
                    //if (!provider.Validate() && flag)
                    //{
                    //    flag = false;
                    //}
                   
                }
                flag = provider.Validate();
                
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
