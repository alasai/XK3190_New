using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppService;
using DevExpress.XtraGrid.Views.Grid;
using DeviceSDK;
using ReactiveUI;
using Utils;
using Utils.DataId;
using WeightManage.AppService;
using WeightManage.Models;
using WeightManage.Models.Db;
using WeightManage.Models.Dto;
using WeightManage.Module.SerialPortUtil;
using WeightManage.Module.ViewModel;
using WeightManage.Module.Views.FactoryInfo;
using YIEternalMIS.Base;
using YIEternalMIS.Common;

namespace WeightManage.Module
{
    public partial class WeightForm : BaseForm, IViewFor<PersonInfoVm>
    {
       
        public WeightForm()
        {
            InitializeComponent();
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(0, 0, this.Width, this.Height);
            //btnSingle.Region = new Region(path);
            InitMvvm();
        }
        /// <summary>
        /// 称重串口
        /// </summary>
        private  ElectronicScale _electronicScale = null;
        //sqlite数据操作
        private  SqliteAppService _sqliteApp = null;
        /// <summary>
        /// 称重业务服务
        /// </summary>
        private WeightAppService _weightApp = null;
        //勾标
        private PTDevice _device;
        private string _previousTagId = string.Empty;
        private string _currentTagId = string.Empty;
       
        //去头耳号
        private PTDevice _earDevice;
        private string _previousEarTagId = string.Empty;
        private Queue<string> _earNumQueue = new Queue<string>();

        //表格数据
        BindingList<WeightGridDto> _weightGridList=new BindingList<WeightGridDto>();

        private WeightInitDto _weightInitDto = null;
        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightForm_Load(object sender, EventArgs e)
        {
            _sqliteApp = new SqliteAppService();
            _weightApp=new WeightAppService();
     


            //InitWeightPort();

            InitFormData();
        }
        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CloseSerialPort();
        }
        #region  Mvvm绑定
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (PersonInfoVm)value;
        }
        public PersonInfoVm ViewModel { get; set; }
        private void InitMvvm()
        {
            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.Price, v => v.txtPrice.Text));
                a(this.Bind(ViewModel, vm => vm.Name, v => v.txtName.Text));
                a(this.Bind(ViewModel, vm => vm.IdNumber, v => v.txtIdNumber.Text));
                a(this.Bind(ViewModel, vm => vm.Tel, v => v.txtTel.Text));
                a(this.Bind(ViewModel, vm => vm.Num, v => v.txtNumber.Text));
                a(this.Bind(ViewModel, vm => vm.PiWeight, v => v.txtPi.Text));
                a(this.Bind(ViewModel, vm => vm.MaoWeight, v => v.txtMao.Text));
                a(this.Bind(ViewModel, vm => vm.MaoWeight, v => v.weightLabel.Text));
                a(this.Bind(ViewModel, vm => vm.LblName, v => v.lblName.Text));
                //a(this.OneWayBind(ViewModel, vm => vm.HookNum, v => v.txtNumber.Text));
                //a(this.OneWayBind(PersonViewModel, vm => vm.Age, v => v.label3.Text));
            });
            ViewModel = new PersonInfoVm();
        }
        #endregion

        #region 串口初始化
        
        private void InitWeightPort()
        {
            try
            {
                //称重串口
                _electronicScale = new ElectronicScale();
                _electronicScale.InitScale(SerialPortConfig.WeightPort, SerialPortBaudRates.BaudRate_9600, Parity.None, SerialPortDatabits.EightBits, StopBits.One,10,2.2M,0.1M);
                _electronicScale.DataReceived += new WeightReceivedEventHandler(serialWeight_DataReceived);
                if (!_electronicScale.IsOpen)
                {
                    _electronicScale.OpenPort();
                }
            }
            catch (Exception e)
            {
               LogNHelper.Exception(e);
            }

            try
            {
                //读钩标
                _device = new PTDevice(SerialPortConfig.WeightHookPort, string.Empty);
                if (_device.Open())
                {
                    _device.TTFMonitor.Start(this);
                    _device.TTFMonitor.RecordNotify += ShowTagId;
                }
                else
                {
                    Msg.ShowError("感应器连接失败");
                }
            }
            //catch (DeviceException ex) 
            //{
            //    log4netHelper.Exception(ex);
            //}
            catch (Exception ex)
            {
                LogNHelper.Exception(ex.Message);
                Msg.ShowError("感应器连接失败");
            }

            //去头
            try
            {
                _earDevice = new PTDevice(SerialPortConfig.HeadHookPort, string.Empty);
                if (_earDevice.Open())
                {
                    _earDevice.TTFMonitor.Start(this);
                    _earDevice.TTFMonitor.RecordNotify += ShowEarTagId;
                    // _earDevice.TTFMonitor.TextNotify += ShowEarTagIdText;
                  
                }
                else
                {
                    Msg.ShowError("耳号感应器连接失败");
                }
            }
            catch (Exception ex)
            {
               LogNHelper.Exception(ex.Message);
              Msg.ShowError("感应器连接失败");
            }

        }
        /// <summary>
        /// 称重数据
        /// </summary>
        /// <param name="e"></param>
        void serialWeight_DataReceived(WeightReceivedEventArgs e)
        {

            ViewModel.MaoWeight = e.DataReceived;
            btnSingle.BackColor = Color.Green;
            this.richTxtTags.Invoke(new MethodInvoker(delegate
            {
                this.richTxtTags.AppendText(e.DataReceived + ";");
            }));
        }
        /// <summary>
        /// 称重勾标
        /// </summary>
        /// <param name="oSrc"></param>
        /// <param name="oTag"></param>
        private void ShowTagId(MonitorBase oSrc, Tag oTag)
        {
            if (oTag is ISO11784)
            {
                if (oTag.Id != _previousTagId)
                {
                    //_hookQueue.Enqueue(oTag.Id);
                    //Console.Beep();
                    _previousTagId = oTag.Id;

                    _currentTagId = oTag.Id;
                    //   waitForWeighing = true;  //等待称重

                   // AppNetInfo(currentTagId);
                }
            }
            else
            {
               LogNHelper.Exception("不可识别的ID: " + oTag.Id);
            }
        }
        /// <summary>
        /// 去头勾标
        /// </summary>
        /// <param name="oSrc"></param>
        /// <param name="oTag"></param>
        private void ShowEarTagId(MonitorBase oSrc, Tag oTag)
        {
            if (oTag is ISO11784)
            {
                if (oTag.Id != _previousEarTagId)
                {
                    _previousEarTagId = oTag.Id;
                    //_earNumQueue.Enqueue(oTag.Id);
                    
                }
            }
            else
            {
                LogNHelper.Exception("不可识别的id:" + oTag.Id);
            }
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        private void CloseSerialPort()
        {
            _electronicScale.ReadyClose = true;
            //关闭
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                //称重
                if (_electronicScale.IsOpen)
                {
                    while (_electronicScale.InReceive)
                    {
                        Application.DoEvents();
                    }
                    //打开时点击，则关闭串口
                    _electronicScale.ClosePort();
                    //LogNHelper.Info("关闭串口成功");
                }
                //钩标
                if (_device != null)
                {
                    _device.Close();
                    _device.Dispose();
                    _device = null;

                }
                //钩标
                if (_earDevice != null)
                {
                    _earDevice.Close();
                    _earDevice.Dispose();
                    _earDevice = null;
                }
            }
            catch (Exception ex)
            {
                LogNHelper.Exception(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        #endregion


        #region 界面数据初始化
        /// <summary>
        /// 基础数据初始化
        /// </summary>
        private  void InitFormData()
        {
            try
            {

                var model =  _weightApp.GetInitData();
       
                if (model == null)
                {
                    Msg.ShowError("数据初始化失败,请关闭程序");
                    return;
                }
                
                _weightInitDto = model;
                //批次信息
                var batch = model.BatchInfo;
                if (batch != null)
                {
                    ViewModel.IdNumber = batch.PIN;
                    ViewModel.Tel = batch.tel;
                    ViewModel.Name = batch.hostName;
                    ViewModel.BatchId = batch.batchId;
                    ViewModel.Weighting = true;
                    ViewModel.UpdateCurrentName();
                }
                ViewModel.PiWeight = model.HooksWeight;
                ViewModel.Num = model.HookCount;
                ViewModel.HookNum = model.HookCount;
                
                //货物价格
                comboProduct.DisplayMember = "animalTypeName";
                comboProduct.ValueMember = "animalTypeId";
                comboProduct.DataSource = _weightInitDto.Products;
                var price = _weightInitDto.Products.OrderBy(s => s.animalTypeId).Select(s => s.price).FirstOrDefault();
                ViewModel.Price = price;
            }
            catch (Exception e)
            {
              LogNHelper.Exception(e);
            }

            try
            {    //加载未完成批次的本地称重表格数据
                if (!string.IsNullOrEmpty(ViewModel.BatchId))
                {
                    var data = _sqliteApp.GetWeightGridList(ViewModel.BatchId.Trim());
                    ViewModel.WeightGridRowCount = data.Count;
                    _weightGridList = new BindingList<WeightGridDto>(data);
                    gridWeight.DataSource = _weightGridList;
                }
              

            }
            catch (Exception e)
            {
                LogNHelper.Exception(e);
            }

        }
        #endregion

        #region  界面按钮事件
        /// <summary>
        /// 开始称重
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ViewModel.Weighting)
            {
                Msg.ShowError("请先完成当前称重");
                return;
            }
            Msg.ShowInformation("开始称重");

         
            if (string.IsNullOrEmpty(ViewModel.Name))
            {
                Msg.ShowError("请输入送宰人信息");
                return;
            }
            if (string.IsNullOrEmpty(ViewModel.IdNumber))
            {
                Msg.ShowError("请输入身份证信息");
                return;
            }
            var batckId = DateTime.Now.ToString("yyyyMMdd");
            int yearNum = int.Parse(batckId);
            int animalType = (int)comboProduct.SelectedValue;
            var animaltypeName = comboProduct.Text;

            var model = new Batches();
            model.yearNum = yearNum;
            model.hostName = ViewModel.Name.Trim();
            model.PIN = ViewModel.IdNumber.Trim();
            model.tel = ViewModel.Tel ?? string.Empty;
            model.animalTypeId = animalType;
            model.animalTypeName = animaltypeName;
           string batchId= _weightApp.SaveBatchInfo(model);
            if (string.IsNullOrEmpty(batchId))
            {
                Msg.ShowError("开始称重失败，请重试！");
                return;
            }

            ViewModel.BatchId = batchId;
            ViewModel.Weighting = true;
            ViewModel.UpdateCurrentName();
        }

        /// <summary>
        /// 完成称重
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (!ViewModel.Weighting)
            {
                Msg.ShowError("新的称重还未开始");
                return;
            }
            if (Msg.AskQuestion("确定完成称重？"))
            {
                var unUploadWeights = _sqliteApp.GetUnUploadWeights(ViewModel.BatchId.Trim());
                bool leftDataSave = false;
                if (unUploadWeights.Any())
                {
                    foreach (var dto in unUploadWeights)
                    {
                        leftDataSave = SaveDataToServer(dto);
                        if (!leftDataSave)
                        {
                            break;
                        }
                    }
                }
                if (!leftDataSave)
                {
                    Msg.ShowError("完成失败,有部分数据没有提交成功，请联系管理员");
                    return;
                }
                var ret = _weightApp.CompleteWeight(ViewModel.BatchId.Trim());
                if (ret)
                {
                    ViewModel.Reset();
                    Msg.ShowInformation("称重完成");
                }
                else
                {
                    Msg.ShowError("完成失败，请联系管理员");
                }
                
            }
           
        }

        /// <summary>
        /// 保存称重数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (!ViewModel.Weighting)
            {
                Msg.ShowError("新的称重还未开始");
                return;
            }
            ViewModel.MaoWeight = 76.02M;
            //  Msg.ShowInformation("haha");
            if (ViewModel.MaoWeight == 0)
            {
                Msg.ShowError("请先称重");
                return;
            }
            if (ViewModel.Num == 0)
            {
                Msg.ShowError("称重数量不能为0");
                return;
            }
            //先将数据插入本地
            WeightGridDto _weightGridDto = new WeightGridDto();
            ViewModel.WeightGridRowCount += 1;
            _weightGridDto.Id =IdHelper.ObjectId();
            _weightGridDto.BatchId =ViewModel.BatchId.Trim();
            _weightGridDto.SerialNum = ViewModel.WeightGridRowCount;
            _weightGridDto.IdNumber = ViewModel.IdNumber.Trim();
            _weightGridDto.Name = ViewModel.Name.Trim();
            _weightGridDto.ProductName = comboProduct.Text;
            _weightGridDto.Num = ViewModel.Num;
            _weightGridDto.MaoWeight = ViewModel.MaoWeight;
            _weightGridDto.Price = ViewModel.Price;
            _weightGridDto.PiWeight = ViewModel.PiWeight;
            _weightGridDto.NetWeight = _weightGridDto.MaoWeight - _weightGridDto.PiWeight;
            _weightGridDto.TotalPrice = decimal.Round(_weightGridDto.Price * _weightGridDto.NetWeight,2);
            _weightGridDto.WeightTime=DateTime.Now;
            //list.Add(_weightGridDto);
            var ret = _sqliteApp.InsertWeightGrid(_weightGridDto);
            if (ret!=null)
            {
                //插入本地表格
                _weightGridList.Insert(0, _weightGridDto);
                ViewModel.Num = ViewModel.HookNum;

                // 将数据提交到服务器数据库
                SaveDataToServer(ret);
            }
            else
            {
                ViewModel.WeightGridRowCount -= 1;
                Msg.ShowError("插入失败");
            }
            
        }
        /// <summary>
        /// 将数据提交到服务器数据库
        /// </summary>
        /// <param name="dto"></param>
        private bool SaveDataToServer(WeightGridDto dto)
        {
            if (!string.IsNullOrEmpty(dto.Id))
            {
                //获取称重勾标
                var hooks = _sqliteApp.GetWeightHooks(dto.Num, dto.WeightTime);
                try
                {
                    //保存数据到服务器
                    bool ret = _weightApp.SaveDataToServer(hooks, ViewModel.IsTrace, dto);
                    if (!ret)
                    {
                        Msg.ShowError("数据提交到服务器失败，请联系管理员");
                        _weightGridList.RemoveAt(0);
                        _sqliteApp.DelLocalWeightById(dto.Id);
                    }

                    return ret;
                }
                catch (Exception e)
                {
                    LogNHelper.Exception(e);
                    Msg.ShowError("数据提交到服务器失败,请联系管理员");
                }
              
            }
            //else
            //{
            //    Msg.ShowInformation("没有数据需要提交");
            //}

            return false;
        }
        /// <summary>
        /// 标签文本框清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearTags_Click(object sender, EventArgs e)
        {
            richTxtTags.Clear();
        }
        #endregion


        #region 界面表格相关
        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var rows = this.gridView1.GetSelectedRows();
            if (rows.Length ==0)
            {
                Msg.Warning("请选择需要撤销的数据行");
            }
            else
            {
                var index = gridView1.FocusedRowHandle;
                if (index != 0)
                {
                    Msg.Warning("只允许撤销最新的一条称重数据");
                    return;
                }
                if (Msg.AskQuestion("确认撤销本条数据？"))
                {
                    var model = (WeightGridDto)gridView1.GetFocusedRow();
                    _weightGridList.RemoveAt(0);

                    var ret = _sqliteApp.DelLocalWeightById(model.Id.Trim());
                    if (ret)
                    {
                        Msg.ShowInformation("撤销成功");
                    }
                    else
                    {
                        Msg.ShowError("撤销失败，请重新尝试");
                    }
                }
            }
        }
        /// <summary>
        /// 货物编号价格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int animalType = (int)comboProduct.SelectedValue;
            var price = _weightInitDto.Products.Where(s => s.animalTypeId == animalType).Select(s => s.price).FirstOrDefault();
            ViewModel.Price = price;
        }


        #endregion


        /// <summary>
        /// 串口设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialPort_Click(object sender, EventArgs e)
        {
            Msg.ShowInformation(SerialPortConfig.WeightPort);
        }
        /// <summary>
        /// 毛重设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMao_Click(object sender, EventArgs e)
        {
            if (HookWeightForm.SetHookWeight())
            {
                
                ViewModel.PiWeight = HookWeightForm.HooksWeight;
                ViewModel.Num = HookWeightForm.HookCount;
                ViewModel.HookNum = ViewModel.Num;
            }
            //else
            //{
            //    Msg.ShowError("失败");
            //}
        }

        /// <summary>
        /// 刷新货物列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshProduct_Click(object sender, EventArgs e)
        {
            var list = _weightApp.GetProduct();
            _weightInitDto.Products = list;
            comboProduct.DisplayMember = "animalTypeName";
            comboProduct.ValueMember = "animalTypeId";
            comboProduct.DataSource = list;
            var price = list.OrderBy(s => s.animalTypeId).Select(s => s.price).FirstOrDefault();
            ViewModel.Price = price;
        }
    }



}
