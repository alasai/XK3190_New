/*************************************************************************************
    * 类 名 称：       MainChildInit
    * 命名空间：       YIEternalMIS.Business
    * 文 件 名：       MainChildInit
    * 创建时间：       2017/6/21 14:24:17
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YIEternalMIS.Interfaces;
using DevExpress.XtraNavBar;
using System.Data;
using YIEternalMIS.Common;

namespace YIEternalMIS.Business
{
    public class MainChildInit : IMainChildInit
    {
        /// <summary>
        /// 初始化待办事项
        /// </summary>
        /// <param name="obj"></param>
        public void InitNavbusiness(object obj)
        {
            NavBarControl BusinessCon = new NavBarControl();
            if (BusinessCon.GetType() != ((NavBarControl)obj).GetType()) return;
            BusinessCon = (NavBarControl)obj;
            //以下填写待办事宜的查询添加

        }

        /// <summary>
        /// 初始化公告
        /// </summary>
        /// <param name="obj"></param>
        public void InitNavMessage(object obj)
        {
            //判断控件类型
            NavBarControl MsgNavControl = new NavBarControl();
            if (MsgNavControl.GetType() != ((NavBarControl)obj).GetType()) return;
            MsgNavControl = (NavBarControl)obj;
            IGetChildMainDataTable MsgChild = new GetMSGDataTable();


            //获取公告数据表
            DataTable Msgdt =  MsgChild.GetDataTable() ;
            string sBarformat = "     ";
            Msgdt.DefaultView.Sort = "MsgUp DESC , MSGSdate DESC ";


            //给Navbar添加公告数据
            if (Msgdt.Rows.Count > 0)
            {
                NavBarGroup Navgp1 = new NavBarGroup();
                Navgp1.Name = "NavGp1";
                Navgp1.Caption = Globals.MsgType1;
                foreach (DataRowView ldr in Msgdt.DefaultView)
                {
                    NavBarItem addItem = new NavBarItem();
                    if(ldr["MsgUp"].ToString() == "1") 
                    {
                        sBarformat =  "     [ 置顶 ]";
                        addItem.SmallImage = Globals.LoadImage(Globals.MsgUpImg, 16);
                    }
                    else
                    {
                        sBarformat = "     ";
                        addItem.SmallImage = Globals.LoadImage(Globals.MsgImg, 16);
                    }
                    addItem.Caption = sBarformat +  ldr["MsgTitle"].ToString() + "  "+ Convertto.ToDateString( (DateTime)ldr["MsgRelease"] ,"yyyy-MM-dd") +"   "+ ldr["LoginName"].ToString() + "  发布";
                    addItem.Name = ldr["MsgID"].ToString();
                    
                    addItem.LinkClicked += new NavBarLinkEventHandler(addItem_LinkClicked);
                    Navgp1.ItemLinks.Add(addItem);
                }
                MsgNavControl.Groups.Add(Navgp1);
                Navgp1.Expanded = true;
            }
            
            
            
        }

        void addItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //信息窗口弹出 
            Msg.AskQuestion("弹出信息窗口");
        }

        /// <summary>
        /// 初始化统计查询
        /// </summary>
        /// <param name="obj"></param>
        public void InitNavSearch(object obj)
        {

        }

        /// <summary>
        /// 获取待办事宜
        /// </summary>
        /// <returns></returns>
        private DataTable GetBusiness()
        {
            DataTable rtnTable = new DataTable();
            //以下填写获取事宜的相关内容


            return rtnTable;


        }

        
    }

    public class GetMSGDataTable : IGetChildMainDataTable
    {
        public DataTable GetDataTable()
        {
            DataTable rtnDT = null;
            try
            {
                string ldtServer = Convertto.ToDateString(BLL.YIEDoFun.DoGetServerDateTime(), "yyyy-MM-dd HH:mm:ss");
                BLL.YIESystemMSG MSG = new BLL.YIESystemMSG();
                rtnDT = MSG.GetList(" MSGSdate <= '" + ldtServer + "' AND MSGEdate >= '" + ldtServer + "'").Tables[0];
            }
            catch{}


            return rtnDT;

            
        }
    }
}
