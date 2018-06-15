///*************************************************************************/
///*
///* 文件名    ：frmGridCustomize.cs                              
///* 程序说明  : 用户自定义表格配置窗体
///*               如注册了配置表格功能，在表格中点右键会弹出该窗体
///* 原创作者  ：孙中吕 
///* 
///* Copyright 2010-2011 C/S框架网 www.LZHBaseFrame.com
///*
///**************************************************************************/

using System;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YIEternalMIS.Common;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;

namespace YIEternalMIS.Library
{
    public partial class frmGridCustomize : YIEternalMIS.Base.BaseForm
    {
        public frmGridCustomize()
        {
            InitializeComponent();
        }




        private GridView _View = null; //表格组件
        private Form _Form = null;//表格组件所在的窗体

        private bool _Changed = false; //是否做修改
        private bool _SaveConfig = true; //是否保存配置

        /// <summary>
        /// 表格组件列表,用于保存已登记的Grid组件
        /// </summary>
        private static Hashtable _grids = new Hashtable();


        private frmGridCustomize(bool saveConfig)
            : this()
        {
            _SaveConfig = saveConfig;
        }

        private void frmGridCustomize_Load(object sender, EventArgs e)
        {
            //
        }

        private void Customize(GridView view)
        {
            if (view == null) return;
            _View = view;
            _Form = view.GridControl.FindForm();
            if (_SaveConfig) new GridConfig(view).ReadGridConfig(); //读取之前保存的信息.
            LoadGridColumns(view);
            this.ShowDialog();
        }

        /// <summary>
        /// 将表格组件的列加载到列选择框CheckedListBoxControl
        /// </summary>
        /// <param name="view"></param>
        private void LoadGridColumns(GridView view)
        {
            chkListColumns.Items.Clear();

            //加载栏位列表.
            foreach (GridColumn col in view.Columns)
            {
                chkListColumns.Items.Add(col.Caption, col.Visible);
            }
        }

        //根据栏位(Column)显示名称获取表格对应的栏位对象.
        private GridColumn GetColumnByCaption(string caption)
        {
            GridColumn col = null;
            foreach (GridColumn c in _View.Columns)
                if (c.Caption == caption) return c;
            return col;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_Changed)
            {
                if (Msg.AskQuestion("您已经修改了配置，要保存吗?"))
                {
                    btnSave.PerformClick();
                }
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListColumns.Items.Count; i++)
            {
                _View.Columns[i].Visible = chkListColumns.Items[i].CheckState == CheckState.Checked;
            }

            //保存当前表格的配置
            if (_SaveConfig) new GridConfig(_View).WriteGridConfig();

            _Changed = false;
            this.Close();
        }

        private void chkListColumns_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            _Changed = true;
        }

        /// <summary>
        /// 在表格内点右键弹出菜单(菜单自动创建)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            if (GridMenuType.Row == e.MenuType || GridMenuType.User == e.MenuType)
            {
                GridViewMenu rowMenu = new GridViewMenu(view);

                CreatePopupMenuItem(rowMenu, "打开配置窗体", Globals.LoadImage("skin16.ico"), menuItemCustomize_Click, false);
                CreatePopupMenuItem(rowMenu, "保存配置", Globals.LoadImage("BtnSaveWindow.png"), menuItemSaveGridConfig_Click, true);
                CreatePopupMenuItem(rowMenu, "还原预设配置", Globals.LoadImage("cslogo16.ico"), menuItemRestoreGridConfig_Click, true);
                CreatePopupMenuItem(rowMenu, "导出资料", Globals.LoadImage("ExportToExcel.png"), menuItemExport_Click, true);
                CreatePopupMenuItem(rowMenu, "复制单元格", Globals.LoadImage("cell.png"), menuItemCopyCellText_Click, true);

                CreateExtraMenuItem(view, rowMenu);//附加其它自定义菜单
                e.Menu = rowMenu;
            }
        }

        #region 注册一个表格控件, 这个表格可以用户自定义配制.
        /// <summary>
        /// 注册表格配置功能
        /// </summary>
        /// <param name="view"></param>
        public static void RegisterGrid(GridView view)
        {
            new GridConfig(view).ReadGridConfig(); //读取之前保存的信息.
            view.ShowGridMenu += new GridMenuEventHandler(frmGridCustomize.OnShowGridMenu);
        }

        #endregion

        /// <summary>
        /// 创建菜单项DXMenuItem
        /// </summary>
        /// <param name="owner">GridViewMenu</param>
        /// <param name="caption">菜单标题</param>
        /// <param name="image">菜单图片</param>
        /// <param name="clickEvent">Click 事件</param>
        /// <param name="beginGroup"></param>
        private static void CreatePopupMenuItem(GridViewMenu owner, string caption, Image image, EventHandler clickEvent, bool beginGroup)
        {
            DXMenuItem item = new DXMenuItem(caption);
            item.Image = image;
            item.Click += new EventHandler(clickEvent);
            item.Tag = owner.View;//保存GridView引用，在DXMenuItem事件内快速找到GridView
            item.BeginGroup = beginGroup;
            owner.Items.Add(item);
        }

        /// <summary>
        /// 附加其它自定义菜单
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="rowMenu"></param>
        private static void CreateExtraMenuItem(GridView grid, GridViewMenu rowMenu)
        {
            //附加其它自定义菜单
            if (IsInstalled(grid))
            {
                Hashtable items = (Hashtable)_grids[grid];
                foreach (object o in items.Values)
                {
                    if (o is DXMenuItem)
                        rowMenu.Items.Add(o as DXMenuItem);
                }
            }
        }

        public static void SetGridContextMenuOpeningEvent(GridControl gridControl, CancelEventHandler handle)
        {
            gridControl.ContextMenuStrip.Opening += new CancelEventHandler(handle);
        }

        #region 弹出菜单事件

        private static void menuItemCopyCellText_Click(object sender, EventArgs e)
        {//复制单元格内容
            try
            {
                DXMenuItem item = sender as DXMenuItem;
                GridView view = (GridView)item.Tag;
                object o = view.GetFocusedValue();
                if (o != null) Clipboard.SetText(o.ToString());
            }
            catch
            {

            }
        }

        private static void menuItemExport_Click(object sender, EventArgs e)
        {//导出数据
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF file(*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DXMenuItem item = sender as DXMenuItem;
                    GridView view = (GridView)item.Tag;
                    view.ExportToPdf(dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private static void menuItemCustomize_Click(object sender, EventArgs e)
        {//自定义表格配置
            DXMenuItem item = sender as DXMenuItem;
            GridView view = (GridView)item.Tag;
            new frmGridCustomize().Customize(view);
        }

        private static void menuItemSaveGridConfig_Click(object sender, EventArgs e)
        {//保存表格配置
            DXMenuItem item = sender as DXMenuItem;
            GridView view = (GridView)item.Tag;
            new GridConfig(view).WriteGridConfig();
            Msg.ShowInformation("已保存表格配置。");
        }

        private static void menuItemRestoreGridConfig_Click(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            GridView view = (GridView)item.Tag;
            new GridConfig(view).DeleteGridConfig();
            Msg.ShowInformation("已还原表格配置，请重新打开窗体。");
        }

        #endregion

        /// <summary>
        /// 是否已登记当前表格组件
        /// </summary>
        /// <param name="view">当前表格组件</param>
        /// <returns></returns>
        public static bool IsInstalled(GridView view)
        {
            return _grids.ContainsKey(view);
        }

        /// <summary>
        /// 附加其它自定义菜单
        /// </summary>
        public static void AddMenuItem(GridView view, string menuText, Image image, EventHandler onclick, bool beginGroup)
        {
            if (menuText == "-") throw new Exception("不支持分隔条，请使用BeginGroup属性！");

            if (!IsInstalled(view)) _grids.Add(view, new Hashtable());

            Hashtable hs = (Hashtable)_grids[view];
            if (!hs.ContainsKey(menuText))
            {
                DXMenuItem item = new DXMenuItem(menuText);
                item.Click += new EventHandler(onclick);
                item.Image = image;
                item.Tag = view;//保存GridView引用，在DXMenuItem事件内快速找到GridView
                item.BeginGroup = beginGroup;
                hs.Add(menuText, item);
            }
        }
    }

    /// <summary>
    /// 表格配置
    /// </summary>
    public class GridConfig
    {
        private string _XMLPath;
        private string _GridFullName;
        private GridView _View;
        private XmlDocument _XMLDoc = new XmlDocument();

        public GridConfig(GridView view)
        {
            _View = view;
            _GridFullName = view.GridControl.FindForm().GetType().FullName + @"\" + view.Name;
            _XMLPath = GetConfigPath() + "GridSettings.xml";
        }

        //获取表格配置文件路径.
        private string GetConfigPath()
        {
            return Application.StartupPath + @"\Config\";
        }

        //创建一个空的XML文件.只包含一个根结点.
        private void CreateXML()
        {
            try
            {
                XmlDeclaration title = _XMLDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
                XmlElement root = _XMLDoc.CreateElement("Root");
                _XMLDoc.AppendChild(title);
                _XMLDoc.AppendChild(root);
                _XMLDoc.Save(_XMLPath);
            }
            catch { }
        }

        //保存表格配置信息.
        private void CreateNewGridConfig()
        {
            try
            {
                XmlElement grid;
                XmlElement column;

                XmlNode root = _XMLDoc.SelectSingleNode("Root");
                grid = _XMLDoc.CreateElement("Grid");
                grid.SetAttribute("Name", _GridFullName);
                root.AppendChild(grid);
                foreach (GridColumn col in _View.Columns)
                {
                    column = _XMLDoc.CreateElement("Column");
                    SetColumnConfig(col, column);
                    grid.AppendChild(column);
                }
                _XMLDoc.Save(_XMLPath);
            }
            catch { }
        }

        /// <summary>
        /// 本地是否有GridView配置信息
        /// </summary>
        public bool IsGridRegister(string gridViewName)
        {
            try
            {
                if (!File.Exists(_XMLPath)) return false;
                _XMLDoc.Load(_XMLPath); //加载XML文件.
                string srh = string.Format("Root/Grid[@Name='{0}']", _GridFullName);
                XmlNode node = _XMLDoc.SelectSingleNode(srh);
                return node != null;
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
                return false;
            }
        }

        /// <summary>
        /// 删除配置信息
        /// </summary>
        public void DeleteGridConfig()
        {
            if (!File.Exists(_XMLPath)) CreateXML();
            _XMLDoc.Load(_XMLPath); //加载XML文件.
            string srh = string.Format("Root/Grid[@Name='{0}']", _GridFullName);
            XmlNode node = _XMLDoc.SelectSingleNode(srh);
            if (node != null)
            {
                node.ParentNode.RemoveChild(node);
                _XMLDoc.Save(_XMLPath);
            }
        }

        //从XML文件获取表格配置信息.
        public void ReadGridConfig()
        {
            if (!Directory.Exists(GetConfigPath()))
                Directory.CreateDirectory(GetConfigPath());

            if (!File.Exists(_XMLPath)) CreateXML();
            _XMLDoc.Load(_XMLPath); //加载XML文件.
            string srh = string.Format("Root/Grid[@Name='{0}']", _GridFullName);
            XmlNode node = _XMLDoc.SelectSingleNode(srh);
            if (null == node)
                this.CreateNewGridConfig();
            else
            {
                this.GetGridConfigFromXML(node);
            }
        }

        //从XML文件获取指定表格的配置信息.
        private void GetGridConfigFromXML(XmlNode gridNode)
        {
            string colName;
            _View.GridControl.BeginInit();
            foreach (XmlElement ele in gridNode.ChildNodes)
            {
                colName = ele.GetAttribute("Name");
                GridColumn column = GetColumnByName(colName);
                if (column != null) //column found
                {
                    column.Width = int.Parse(ele.GetAttribute("Width"));
                    column.Visible = bool.Parse(ele.GetAttribute("Visible"));
                    column.VisibleIndex = int.Parse(ele.GetAttribute("VisibleIndex"));
                }
            }
            _View.GridControl.EndInit();
        }

        //跟据列名获取列对象
        private GridColumn GetColumnByName(string colName)
        {
            GridColumn col = null;
            foreach (GridColumn c in _View.Columns)
                if (c.Name == colName) return c;
            return col;
        }

        //保存表格配置信息.
        public void WriteGridConfig()
        {
            try
            {
                if (!File.Exists(_XMLPath)) CreateXML();
                _XMLDoc.Load(_XMLPath); //加载XML文件.
                string srh = string.Format("Root/Grid[@Name='{0}']", _GridFullName);
                XmlNode node = _XMLDoc.SelectSingleNode(srh);
                if (null == node) //没有当前表格的配置信息.
                    this.CreateNewGridConfig(); //保存当前表格的信息
                else
                {
                    XmlNodeList columns = node.ChildNodes; //columns
                    foreach (GridColumn column in _View.Columns)
                    {
                        bool _exist = false; //tjy 20081218 如果这个字段在xml中没有的话再加进去(适用于动态字段）
                        foreach (XmlNode n in columns)
                        {
                            if (((XmlElement)n).GetAttribute("Name") == column.Name)
                            {
                                SetColumnConfig(column, (XmlElement)n);
                                _exist = true;
                                continue;
                            }
                        }

                        if (!_exist)
                        {
                            XmlElement element = _XMLDoc.CreateElement("Column");
                            SetColumnConfig(column, element);
                            node.AppendChild(element);
                        }
                    }
                }
                _XMLDoc.Save(_XMLPath);
            }
            catch { }
        }

        /// <summary>
        /// 设置栏位属性
        /// </summary>
        /// <param name="col">栏位,列</param>
        /// <param name="columnNode">XmlElement</param>
        private void SetColumnConfig(GridColumn col, XmlElement columnNode)
        {
            columnNode.SetAttribute("Name", col.Name);
            columnNode.SetAttribute("Caption", col.Caption);
            columnNode.SetAttribute("Width", col.Width.ToString());
            columnNode.SetAttribute("Visible", col.Visible.ToString());
            columnNode.SetAttribute("VisibleIndex", col.VisibleIndex.ToString());
        }
    }
}
