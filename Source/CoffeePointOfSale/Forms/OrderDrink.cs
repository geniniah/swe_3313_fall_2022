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
    public partial class OrderDrink : FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        private decimal _taxRate;
        private decimal _rewardPerDollar;
        public OrderDrink()
        {
            InitializeComponent();
        }
        public OrderDrink(IAppSettings appSettings) : this()
        {
            _appSettings = appSettings;
            _rewardPerDollar = appSettings.Rewards.PointsPerDollar;
            _taxRate = appSettings.Tax.Rate;

        }


    }
}
