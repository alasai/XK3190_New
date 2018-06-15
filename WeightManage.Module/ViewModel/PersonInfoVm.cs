using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WeightManage.Module.ViewModel
{
    public class PersonInfoVm: ReactiveObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        private string _batchId;
        public string BatchId
        {
            get => _batchId;
            set => this.RaiseAndSetIfChanged(ref _batchId, value);
        }
        /// <summary>
        /// 是否在称重中
        /// </summary>
        private bool _weighting;
        public bool Weighting
        {
            get => _weighting;
            set => this.RaiseAndSetIfChanged(ref _weighting, value);
        }
        /// <summary>
        /// 产品价格
        /// </summary>
        private decimal _price = 0.00M;
        public decimal Price
        {
            get => _price;
            set => this.RaiseAndSetIfChanged(ref _price, value);
        }

        //送宰人
        private string _name;
        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }
        //身份证
        private string _idNumber;
        public string IdNumber
        {
            get => _idNumber;
            set => this.RaiseAndSetIfChanged(ref _idNumber, value);
        }
        //联系电话
        private string _tel;
        public string Tel
        {
            get => _tel;
            set => this.RaiseAndSetIfChanged(ref _tel, value);
        }

        /// <summary>
        /// 皮重
        /// </summary>
        private decimal _piWeight = 0.00M;
        public decimal PiWeight
        {
            get => _piWeight;
            set => this.RaiseAndSetIfChanged(ref _piWeight, value);
        }
        /// <summary>
        /// 数量
        /// </summary>
        private int _num;
        public int Num
        {
            get => _num;
            set => this.RaiseAndSetIfChanged(ref _num, value);
        }
        /// <summary>
        /// 默认钩数量
        /// </summary>
        private int _hookNum;
        public int HookNum
        {
            get => _hookNum;
            set => this.RaiseAndSetIfChanged(ref _hookNum, value);
        }
        /// <summary>
        /// 毛重
        /// </summary>
        private decimal _maoWeight = 0.00M;
        public decimal MaoWeight
        {
            get => _maoWeight;
            set => this.RaiseAndSetIfChanged(ref _maoWeight, value);
        }

        /// <summary>
        /// 是否追溯
        /// </summary>
        private bool _isTrace;
        public bool IsTrace
        {
            get => _isTrace;
            set => this.RaiseAndSetIfChanged(ref _isTrace, value);
        }
        /// <summary>
        /// 当前用户信息
        /// </summary>
        private string _lblName;
        public string LblName
        {
            get => _lblName;
            set => this.RaiseAndSetIfChanged(ref _lblName, value);
        }

        /// <summary>
        /// 当前批次表格中的数量
        /// </summary>
        private int _weightGridRowCount;
        public int WeightGridRowCount
        {
            get => _weightGridRowCount;
            set => this.RaiseAndSetIfChanged(ref _weightGridRowCount, value);
        }
        public void UpdateCurrentName()
        {
            LblName = "当前称重：" + Name;
        }
        public void ClearCurrentName()
        {
            LblName = "当前称重：";
        }


        public void Reset()
        {
            BatchId = string.Empty;
            Weighting = false;
            Price = 0.00M;
            Name = string.Empty;
            IdNumber = string.Empty;
            Tel = string.Empty;
            LblName = "当前称重：";
            WeightGridRowCount = 0;
            IsTrace = false;
        }
    }
}
