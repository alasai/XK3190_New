using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WeightManage.Module.ViewModel
{
    public class WeightInfoVm: ReactiveObject
    {
        private decimal _piWeight;
        public decimal PiWeight
        {
            get => _piWeight;
            set => this.RaiseAndSetIfChanged(ref _piWeight, value);
        }
        private int _num;
        public int Num
        {
            get => _num;
            set => this.RaiseAndSetIfChanged(ref _num, value);
        }
        private decimal _maoWeight;
        public decimal MaoWeight
        {
            get => _maoWeight;
            set => this.RaiseAndSetIfChanged(ref _maoWeight, value);
        }
    }
}
