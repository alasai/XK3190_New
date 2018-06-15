/*************************************************************************************
    * 类 名 称：       ValiControlRule
    * 命名空间：       Common
    * 文 件 名：       ValiControlRule
    * 创建时间：       2017/6/2 9:13:53
    * 作    者：        王宏巍
    * 说   明：        系统控件验证类
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
    public class ValiControlRule
    {
        
        public Control control;
        public ValidationRule rule;

        public ValiControlRule(Control control, ValidationRule rule)
        {
            this.control = control;
            this.rule = rule;
        }

        /// <summary>
        /// 判断控件是否为空
        /// </summary>
        /// <returns></returns>
        public static ConditionValidationRule NotEmpty()
        {
            ConditionValidationRule rule = new ConditionValidationRule();
            rule.ConditionOperator = ConditionOperator.IsNotBlank;
            rule.ErrorText = "该值不允许为空！";
            return rule;
        }

        /// <summary>
        /// 判断是否大于等于某个数
        /// </summary>
        /// <param name="number">数值</param>
        public static ConditionValidationRule NoLessNumber(decimal number)
        {
            ConditionValidationRule rule = new ConditionValidationRule();
            rule.ConditionOperator = ConditionOperator.GreaterOrEqual;
            rule.ErrorText = string.Format("该值不能小于{0}！", number);
            rule.Value1 = number;
            return rule;
        }

        /// <summary>
        /// 判断是否大于某个数
        /// </summary>
        /// <param name="number">数值</param>
        public static ConditionValidationRule GreaterNumber(decimal number)
        {
            ConditionValidationRule rule = new ConditionValidationRule();
            rule.ConditionOperator = ConditionOperator.Greater;
            rule.ErrorText = string.Format("该值必须大于{0}！", number);
            rule.Value1 = number;
            return rule;
        }

        /// <summary>
        /// 判断是否在指定数（包含）之间
        /// </summary>
        /// <param name="small">小数</param>
        /// <param name="big">大数</param>
        /// <returns></returns>
        public static ConditionValidationRule BetweenNumbers(decimal small, decimal big)
        {
            ConditionValidationRule rule = new ConditionValidationRule();
            rule.ConditionOperator = ConditionOperator.Between;
            rule.ErrorText = string.Format("该值不能小于{0}且不能大于{1}！", small, big);
            rule.Value1 = small;
            rule.Value2 = big;
            return rule;
        }

        /// <summary>
        /// 判断结束时间是否不小于指定时间
        /// </summary>
        /// <param name="startTime">指定时间</param>
        public static ConditionValidationRule NoLessDate(DateTime startTime)
        {
            ConditionValidationRule rule = new ConditionValidationRule();
            rule.ErrorText = string.Format("结束时间不能小于开始时间！");
            rule.ConditionOperator = ConditionOperator.GreaterOrEqual;
            rule.Value1 = startTime;
            return rule;
        }

        /// <summary>
        /// 调用正则表达式判断输入格式
        /// </summary>
        /// <param name="strRex">正则表达式</param>
        /// <param name="isnotblank">是否允许为空</param>
        public static ValiCustomRuleByRegex AddValueRex(string strRex, bool isnotblank)
        {
            ValiCustomRuleByRegex rule = new ValiCustomRuleByRegex(strRex, isnotblank);
            rule.ErrorText = "输入格式不正确，请重新输入！";
            return rule;
        }

        /// <summary>
        /// 判断Text是否和输入的文本相同
        /// </summary>
        /// <param name="strText">是否和输入的文本相同</param>
        /// <param name="isnotblank">是否允许为空</param>
        /// <returns></returns>
        public static ValiCustomRuleUniformity IsUniformity(string strText , bool isnotblank)
        {
            ValiCustomRuleUniformity rule = new ValiCustomRuleUniformity(strText, isnotblank);
            rule.ErrorText = "两次输入不一致";
            return rule;
        }
    }
}
