using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class Customers : FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        private decimal _taxRate;
        private decimal _rewardPerDollar;
        public Customers()
        {
            InitializeComponent();
        }
        public Customers(IAppSettings appSettings) : this()
        {
            _appSettings = appSettings;
            _rewardPerDollar = appSettings.Rewards.PointsPerDollar;
            _taxRate = appSettings.Tax.Rate;
        }
    }
}
