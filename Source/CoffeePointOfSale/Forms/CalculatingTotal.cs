using CoffeePointOfSale.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Forms
{
    internal class CalculatingTotal : OrderDrink
    {
        private IAppSettings? _appSettings;
        private decimal _taxRate;
        private decimal _rewardPerDollar;
        private string _latte;
        public CalculatingTotal(IAppSettings appSettings) 
        {
            _appSettings = appSettings;
            _rewardPerDollar = appSettings.Rewards.PointsPerDollar;
            _taxRate = appSettings.Tax.Rate;
            _latte = appSettings.DrinkMenu.Name;

        }
    }
}
