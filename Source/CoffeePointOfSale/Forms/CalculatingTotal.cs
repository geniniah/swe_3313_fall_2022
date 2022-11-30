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
        private decimal drinkCost;
        private decimal drinkCostSize;
        private decimal drinkCostCustom;
        private decimal _subTotal;
        private decimal _total;
        private decimal _tax;
        
     
        public CalculatingTotal(IAppSettings appSettings) 
        {
            _appSettings = appSettings;
            _rewardPerDollar = appSettings.Rewards.PointsPerDollar;
            _taxRate = appSettings.Tax.Rate;


        }
        public decimal CalculateBaseDrinkPrice(string baseDrinkPrice)
        {
            if (baseDrinkPrice.Equals("Latte"))
            {
                drinkCost = 4.00m;
            }
            if (baseDrinkPrice.Equals("Iced Latte"))
            {
                drinkCost = 5.25m;
            }
            if (baseDrinkPrice.Equals("Coffee"))
            {
                drinkCost = 2.50m;
            }
            if (baseDrinkPrice.Equals("Iced Matcha Green Tea Latte"))
            {
                drinkCost = 4.00m;
            }
            if (baseDrinkPrice.Equals("Iced Water"))
            {
                drinkCost = 0.00m;
            }

            return drinkCost;
        }

        public decimal CalculateSize(string size)
        {
            if (size.Equals("S"))
            {
                drinkCostSize = -1.00m;
            }
            if (size.Equals("L"))
            {
                drinkCostSize = 1.00m;
            }
            if (size.Equals("M"))
            {
                drinkCostSize = 0.00m;
            }
      

          
            return drinkCostSize;
        }

        public decimal CalculateCostCustom(string custom)
        {
            if (custom.Equals("Soy Milk"))
            {
                drinkCostCustom = 1.50m;
            }
            if (custom.Equals("Almond Milk"))
            {
                drinkCostCustom = 1.50m;
            }
            if (custom.Equals("Oat Milk"))
            {
                drinkCostCustom = 1.50m;
            }
            if (custom.Equals("Espresso"))
            {
                drinkCostCustom = 1.25m;
            }

            return drinkCostCustom;
        }

        public decimal totalPrice(string baseDrinkPrice, string size, string custom, int quantity)
        {
            //Sales tax = list price * sales tax rate.
            //Total price including tax = list price + sales tax,

            _subTotal = (CalculateBaseDrinkPrice(baseDrinkPrice) + CalculateSize(size) + CalculateCostCustom(custom)) * quantity;
             _tax = _subTotal * _taxRate;
            _total = _subTotal + _tax;

            return _total;
            
        }

        public decimal subTotalPrice(string baseDrinkPrice, string size, string custom, int quantity)
        {
            //Sales tax = list price * sales tax rate.
            //Total price including tax = list price + sales tax,

            _subTotal = (CalculateBaseDrinkPrice(baseDrinkPrice) + CalculateSize(size) + CalculateCostCustom(custom)) * quantity;
            

            return _subTotal;

        }



    }
}
