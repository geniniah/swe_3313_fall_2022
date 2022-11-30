using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Forms
{
     class CalculatingTotal : OrderDrink
    {
        private IAppSettings? _appSettings;
        private decimal _taxRate = 0.06m;
        private decimal _rewardPerDollar;
        public decimal drinkCost;
        public decimal drinkCostSize;
        public decimal drinkCostCustom;
        public decimal _subTotal;
        public decimal _total;
        public decimal _tax;
        public decimal quantity1;
        public string customization;

        public CalculatingTotal()
        {
            

        }
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

        public string getCustom()
        {
            return customization;
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
                customization = custom;
            }
            if (custom.Equals("Almond Milk"))
            {
                drinkCostCustom = 1.50m;
                customization = custom;

            }
            if (custom.Equals("Oat Milk"))
            {
                drinkCostCustom = 1.50m;
                customization = custom;
            }
            if (custom.Equals("Espresso"))
            {
                drinkCostCustom = 1.25m;
                customization = custom;
            }
            if (custom.Equals("Select"))
            {
                drinkCostCustom = 0.00m;
                customization = "";
            }
            else
            {
                drinkCostCustom = 0.00m;
            }
           

            return drinkCostCustom;
        }

        public decimal totalPrice()
        {
            //Sales tax = list price * sales tax rate.
            //Total price including tax = list price + sales tax,

            _subTotal = (drinkCost + drinkCostCustom + drinkCostSize) * quantity1;
            _tax = _subTotal * _taxRate;
            _total = _subTotal + _tax;

            return _total;
            
        }
        public decimal calcTax()
        {
            _tax = _subTotal * _taxRate;
            return _tax;
        }

        public decimal subTotalPrice(int quantity)
        {
            //Sales tax = list price * sales tax rate.
            //Total price including tax = list price + sales tax,
            quantity1 = quantity;

            _subTotal = (drinkCost + drinkCostCustom + drinkCostSize) * quantity;
            

            return _subTotal;

        }



    }
}
