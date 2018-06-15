/*************************************************************************************
    * 类 名 称：       DevStyle
    * 命名空间：       YIEternalMIS.Library
    * 文 件 名：       DevStyle
    * 创建时间：       2017/6/2 13:20:12
    * 作    者：        王宏巍
    * 说   明：        DevGridView样式设置
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using System.Collections.Specialized;
using System.Drawing;
using System.Collections;
using YIEternalMIS.Common;


namespace YIEternalMIS.Library
{

    /// <summary>
    /// 设置控件显示样式.
    /// </summary>
    public class DevStyle
    {
        /// <summary>
        /// 设置RepositoryItemCheckEdit组件的绑定样式.
        /// </summary>
        /// <param name="propCheckEdit">RepositoryItemCheckEdit</param>
        private static void SetCheckEditLayout(RepositoryItemCheckEdit propCheckEdit)
        {
            if (propCheckEdit == null) return;
            propCheckEdit.ValueChecked = "1"; //当值为Y勾选
            propCheckEdit.ValueGrayed = ""; //当值为空变为灰色
            propCheckEdit.ValueUnchecked = "0";//当值为N取消勾选
            propCheckEdit.NullStyle = StyleIndeterminate.Unchecked;
        }

        /// <summary>
        /// 批量设置CheckEdit的绑定样式.
        /// </summary>
        /// <param name="checkEdits">CheckEdit数组</param>
        public static void SetCheckEditLayout(params CheckEdit[] checkEdits)
        {
            foreach (CheckEdit edit in checkEdits)
            {
                SetCheckEditLayout((RepositoryItemCheckEdit)edit.Properties);
            }
        }

        /// <summary>
        /// 批量设置表格内所有RepositoryItemCheckEdit属性
        /// </summary>
        /// <param name="columns">RepositoryItemCheckEdit所在的列数组</param>
        public static void SetCheckEditColumnConfig(params GridColumn[] columns)
        {
            foreach (GridColumn col in columns)
            {
                if (col.ColumnEdit != null)
                    SetCheckEditLayout((RepositoryItemCheckEdit)col.ColumnEdit);
            }
        }

        /// <summary>
        /// 设置ButtonEdit的读写状态
        /// </summary>
        /// <param name="edit"></param>
        /// <param name="access"></param>
        public static void SetEditorStyle(ButtonEdit edit, bool access)
        {
            edit.Properties.Buttons[0].Enabled = access;
            edit.Properties.ReadOnly = !access;
        }

        /// <summary>
        /// 设置输入控件的读写状态,可读为白底黑字,不可读为灰底黑字
        /// </summary>
        /// <param name="edit">输入控件</param>
        /// <param name="access">是否可读</param>
        public static void SetEditorStyle(BaseEdit edit, bool access)
        {
            edit.Properties.ReadOnly = !access;
            if (access)
            {
                if (!(edit is CheckEdit))
                {
                    edit.BackColor = System.Drawing.Color.White;
                    edit.ForeColor = System.Drawing.Color.Black;
                }
            }
            else
            {
                if (!(edit is CheckEdit))
                {
                    edit.BackColor = System.Drawing.Color.AliceBlue;
                    edit.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        /// <summary>
        /// 设置栏位的过虑条件
        /// </summary>
        public static void SetDetailColumnFilter(GridColumn col, string filter)
        {
            ColumnFilterInfo finfo = new ColumnFilterInfo(filter, "");
            col.FilterInfo = finfo;
        }

        /// <summary>
        /// 设置Column.LookupEdit(属性为ColumnEdit)控件参数
        /// </summary>        
        public static void SetLookupEditLayout(RepositoryItemLookUpEdit propLookUpEdit)
        {
            if (propLookUpEdit == null) return;
            propLookUpEdit.ImmediatePopup = false;
            propLookUpEdit.ShowHeader = true;
            propLookUpEdit.ShowPopupShadow = true;
            propLookUpEdit.NullText = "";
            propLookUpEdit.TextEditStyle = TextEditStyles.Standard;
        }

        /// <summary>
        /// 设置明细表格布局. OptionsView,OptionsCustomization设置
        /// </summary>        
        public static void SetSummaryGridViewLayout(GridView gridView)
        {
            gridView.GridControl.BeginInit();
            gridView.PaintStyleName = "Skin";
            gridView.OptionsBehavior.Editable = false; //Summary页不可编辑
            gridView.OptionsSelection.EnableAppearanceFocusedRow = true;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsView.ShowGroupPanel = true;
            gridView.OptionsView.ColumnAutoWidth = true;
            //gridView.Appearance.OddRow.Options.UseBackColor = SystemConfig.CurrentConfig.GridAllowOddColor;
            //gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromName(SystemConfig.CurrentConfig.GridOddColorName);            
            gridView.GridControl.EndInit();
        }

        /// <summary>
        /// 设置明细表格的显示样式
        /// </summary>
        /// <param name="gridView">明细表格</param>
        /// <param name="useOddColor">奇偶行高亮显示</param>
        public static void SetDetailGridViewLayout(GridView gridView, bool useOddColor)
        {
            SetDetailGridViewLayout(gridView);
            if (!useOddColor)
            {
                gridView.GridControl.BeginInit();
                gridView.OptionsView.EnableAppearanceOddRow = false;
                gridView.Appearance.OddRow.Options.UseBackColor = false;
                gridView.Appearance.OddRow.BackColor = Color.Empty;
                gridView.GridControl.EndInit();
            }
        }

        /// <summary>
        /// 设置明细表格布局. OptionsView,OptionsCustomization设置
        /// </summary>        
        public static void SetDetailGridViewLayout(GridView gridView)
        {
            DevStyle.SetGridReadColumnStyle(gridView);

            gridView.GridControl.BeginInit();
            gridView.OptionsNavigation.EnterMoveNextColumn = false;//注意: 禁止Grid管理Enter键            
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ColumnAutoWidth = true;
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            gridView.OptionsView.EnableAppearanceOddRow = true;
            SetOddANDEvenRowColor(gridView);
            gridView.OptionsCustomization.AllowFilter = false;
            gridView.OptionsCustomization.AllowSort = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = true;
            foreach (GridColumn col in gridView.Columns)
            {
                if ((col.OptionsColumn.AllowEdit == false) || (col.OptionsColumn.ReadOnly == true))
                {
                    col.AppearanceCell.BackColor = SystemColors.ButtonFace;
                }
            }
            gridView.GridControl.EndInit();
        }

        /// <summary>
        /// 设置所有只读栏位的显示样式
        /// </summary>
        /// <param name="view"></param>
        public static void SetGridReadColumnStyle(GridView view)
        {
            foreach (GridColumn col in view.Columns)
            {
                if (col.OptionsColumn.AllowEdit) continue;
                //col.AppearanceCell.BackColor = Color.FromName(SystemConfig.CurrentConfig.GridReadOnlyColorName);
                col.AppearanceCell.ForeColor = Color.FromName("Black");
                col.AppearanceCell.Options.UseBackColor = true;
                col.AppearanceCell.Options.UseForeColor = true;
            }
        }

        /// <summary>
        /// 设置表格控件的布局. 比如按钮设置.
        /// </summary>        
        public static void SetGridControlLayout(GridControl grid, bool allowEdit)
        {
            //ControlNavigatorButtons btns = grid.EmbeddedNavigator.Buttons;

            grid.BeginInit();
            //grid.EmbeddedNavigator.ButtonStyle = BorderStyles.Default;
            //grid.UseEmbeddedNavigator = true;
            //btns.Append.Visible = false;
            //btns.CancelEdit.Visible = false;
            //btns.Edit.Visible = false;
            //btns.Remove.Visible = false;
            //btns.EndEdit.Visible = false;
            //btns.NextPage.Visible = false;
            //btns.PrevPage.Visible = false;

            ((GridView)grid.Views[0]).OptionsBehavior.Editable = allowEdit; //允许编辑状态

            //if (allowEdit)//增加两个自定义按钮(ADD,INSERT,DELETE)
            //{
            //    ImageList img = new ImageList();
            //    img.Images.Add(Globals.LoadImage("16_Add.ico"));
            //    img.Images.Add(Globals.LoadImage("16_Insert.ico"));
            //    img.Images.Add(Globals.LoadImage("16_Delete.ico"));
            //    grid.EmbeddedNavigator.Buttons.ImageList = img;

            //    btns.CustomButtons.Clear();
            //    NavigatorCustomButton btnDtlAdd = new NavigatorCustomButton((int)DetailButtons.Add, "新增记录");
            //    NavigatorCustomButton btnDtlInsert = new NavigatorCustomButton((int)DetailButtons.Insert, "插入记录");
            //    NavigatorCustomButton btnDtlDelete = new NavigatorCustomButton((int)DetailButtons.Delete, "删除记录");
            //    btns.CustomButtons.AddRange(new NavigatorCustomButton[] { btnDtlAdd, btnDtlInsert, btnDtlDelete });
            //}
            grid.EndInit();
        }

        /// <summary>
        /// 在表格导航按钮内增加一个自定义按钮
        /// </summary>
        /// <param name="grid">表格控件</param>
        /// <param name="buttonID">按钮编号</param>
        /// <param name="buttonImage">按钮图片</param>
        /// <param name="buttonHint">按钮提示消息</param>
        public static void AddCustomButton(GridControl grid, int buttonID, Image buttonImage, string buttonHint)
        {
            grid.BeginInit();
            ImageList list = grid.EmbeddedNavigator.Buttons.ImageList as ImageList;
            list.Images.Add(buttonImage);
            NavigatorCustomButton btn = new NavigatorCustomButton(buttonID, buttonHint);
            grid.EmbeddedNavigator.Buttons.CustomButtons.AddRange(new NavigatorCustomButton[] { btn });
            grid.EndInit();
        }


        public static void SetOddANDEvenRowColor(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            gv.Appearance.OddRow.BackColor = Color.OldLace;
            gv.Appearance.EvenRow.BackColor = Color.Transparent;
            gv.OptionsView.EnableAppearanceEvenRow = true;
            gv.OptionsView.EnableAppearanceOddRow = true;
        }

        /// <summary>
        /// GridView  显示行号   设置行号列的宽度
        /// </summary>
        /// <param name="gv">GridView 控件名称</param>
        /// <param name="width">行号列的宽度 如果为null或为0 默认为30</param>
        public static void DrawRowIndicator(DevExpress.XtraGrid.Views.Grid.GridView gv, int width)
        {
            gv.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(gv_CustomDrawRowIndicator);
            if (width != null)
            {
                if (width != 0)
                {
                    gv.IndicatorWidth = width;
                }
                else
                {
                    gv.IndicatorWidth = 30;
                }
            }
            else
            {
                gv.IndicatorWidth = 30;
            }

        }


        /// <summary>
        /// 设置行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void gv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

    }
}
