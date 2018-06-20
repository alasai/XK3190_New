using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WeightManage.Module.ViewModel
{
    public class FactoryVm: ReactiveObject
    {
        /// <summary>
        /// 工厂编号
        /// </summary>
        private string _factoryId;
        public string factoryId
        {
            get => _factoryId;
            set => this.RaiseAndSetIfChanged(ref _factoryId, value);
        }
        /// <summary>
        /// 工厂名称
        /// </summary>
        private string _factoryName;
        public string factoryName {
            get => _factoryName;
            set => this.RaiseAndSetIfChanged(ref _factoryName, value);
        }
        /// <summary>
        /// 单只钩终
        /// </summary>
        private decimal _hookWeight;
        public decimal hookWeight
        {
            get => _hookWeight;
            set => this.RaiseAndSetIfChanged(ref _hookWeight, value);
        }
        /// <summary>
        /// 出肉率
        /// </summary>
        private decimal _meatRate;
        public decimal meatRate {
            get => _meatRate;
            set => this.RaiseAndSetIfChanged(ref _meatRate, value);
        }

        /// <summary>
        /// 溯源地址
        /// </summary>
        private string _traceURL;
        public string traceURL
        {
            get => _traceURL;
            set => this.RaiseAndSetIfChanged(ref _traceURL, value);
        }
        /// <summary>
        /// 域名
        /// </summary>
        private string _serverUrl;
        public string serverUrl {
            get => _serverUrl;
            set => this.RaiseAndSetIfChanged(ref _serverUrl, value);
        }
        /// <summary>
        /// 含骨率
        /// </summary>
        private decimal _bonedRate;
        public decimal bonedRate
        {
            get => _bonedRate;
            set => this.RaiseAndSetIfChanged(ref _bonedRate, value);
        }
        /// <summary>
        /// 总钩重
        /// </summary>
        private decimal _hooksWeight;
        public decimal hooksWeight
        {
            get => _hooksWeight;
            set => this.RaiseAndSetIfChanged(ref _hooksWeight, value);
        }
        /// <summary>
        /// 钩数量
        /// </summary>
        private int _hookCount;
        public int hookCount
        {
            get => _hookCount;
            set => this.RaiseAndSetIfChanged(ref _hookCount, value);
        }
    }
}
