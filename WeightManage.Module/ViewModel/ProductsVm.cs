using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WeightManage.Module.ViewModel
{
    public class ProductsVm: ReactiveObject
    {
        private int _productId;
        public int productId
        {
            get => _productId;
            set => this.RaiseAndSetIfChanged(ref _productId, value);
        }

        private string _productName;
        public string productName
        {
            get => _productName;
            set => this.RaiseAndSetIfChanged(ref _productName, value);
        }
        private string _shortName;
        public string shortName
        {
            get => _shortName;
            set => this.RaiseAndSetIfChanged(ref _shortName, value);
        }
        

        private string _productNo;
        public string productNo
        {
            get => _productNo;
            set => this.RaiseAndSetIfChanged(ref _productNo, value);
        }

        private string _spec;
        public string spec {
            get => _spec;
            set => this.RaiseAndSetIfChanged(ref _spec, value);
        }

        private string _barcode;
        public string barcode
        {
            get => _barcode;
            set => this.RaiseAndSetIfChanged(ref _barcode, value);
        }

        private string _comment;
        public string comment
        {
            get => _comment;
            set => this.RaiseAndSetIfChanged(ref _comment, value);
        }

        private bool _isFixedWeight;
        public bool isFixedWeight
        {
            get => _isFixedWeight;
            set => this.RaiseAndSetIfChanged(ref _isFixedWeight, value);
        }
        private decimal _nominalWeight;
        public decimal nominalWeight
        {
            get => _nominalWeight;
            set => this.RaiseAndSetIfChanged(ref _nominalWeight, value);
        }

        private string _ingredients;
        public string ingredients
        {
            get => _ingredients;
            set => this.RaiseAndSetIfChanged(ref _ingredients, value);
        }
        private string _expiration;
        public string expiration
        {
            get => _expiration;
            set => this.RaiseAndSetIfChanged(ref _expiration, value);
        }

        private string _storageCondition;
        public string storageCondition
        {
            get => _storageCondition;
            set => this.RaiseAndSetIfChanged(ref _storageCondition, value);
        }

        private bool _isBoned;
        public bool isBoned
        {
            get => _isBoned;
            set => this.RaiseAndSetIfChanged(ref _isBoned, value);
        }

    }
}
