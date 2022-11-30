using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        private string _latte;

        public OrderDrink()
        {
            InitializeComponent();
        }
        public OrderDrink(IAppSettings appSettings) : this()
        {
            _appSettings = appSettings;
            _rewardPerDollar = appSettings.Rewards.PointsPerDollar;
            _taxRate = appSettings.Tax.Rate;
            _latte = appSettings.DrinkMenu.Name;

        }
        private bool UpperRightPanelDrinkSize(bool status)
        {
            button1.Visible = status;
            btnMediumCupSize.Visible = status;
            btnLargeCupSize.Visible = status;


            return status;
        }
        private void resetMenu()
        {
            UpperRightPanelDrinkSize(false);
            UpperRightPanelQuantity(false);
            quantityValue = 0;
           
            SelectedFalse(btnLatte);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnIcedWater);
            SelectedFalse(btnCoffee);
            comboBoxCustomizations.Visible = false;
            
        }

        private void UpperRightPanelQuantity(bool status)
        {
            btnIncreaseQuantity.Visible = status;
            btnDecreaseQuantity.Visible = status;
        }

        private void btnCancelOrderDrinkScreen_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void btnPaymentOrderDrinkScreen_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }




        //Activating Methods with Click Events 
        private void SelectedTrue(Button button)
        {
            button.Text = "Selected";
            button.BackColor = Color.Gray;
           

        }

        private void SelectedFalse(Button button)
        {
            button.Text = "Select";
            button.BackColor = Color.White;
          
        }

       
        private void btnLatte_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnLatte);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnCoffee);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnIcedWater);
            UpperRightPanelDrinkSize(true);
            label5.Text = label1.Text;
            label7.Text = label1.Text;



        }

        private void btnIcedLatte_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnIcedLatte);
            SelectedFalse(btnLatte);
            SelectedFalse(btnCoffee);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnIcedWater);
            UpperRightPanelDrinkSize(true);
            label5.Text = label2.Text;
            label7.Text = label2.Text;


        }

        private void btnGreenLatte_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnGreenLatte);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnCoffee);
            SelectedFalse(btnLatte);
            SelectedFalse(btnIcedWater);
            UpperRightPanelDrinkSize(true);
            label5.Text = label3.Text;
            label7.Text = label3.Text;


        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnCoffee);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnLatte);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnIcedWater);
            UpperRightPanelDrinkSize(true);
            label5.Text = label4.Text;
            label7.Text = label4.Text;

        }

        private void btnIcedWater_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnIcedWater);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnCoffee);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnLatte);
            UpperRightPanelDrinkSize(true);
            label5.Text = label6.Text;
            label7.Text = label6.Text;

        }

       

        //OnLoad Method
        private void OrderDrink_Load(object sender, EventArgs e)
        {
            // base.OnLoad();
            UpperRightPanelDrinkSize(false);
            UpperRightPanelQuantity(false);
            btnAddToOrder.Visible = false;
            labelQuantityNumber.Visible = true;
            btnPaymentOrderDrinkScreen.Visible = false;
            comboBoxCustomizations.Visible = false;
            string labellatte = _latte;
            label7.Text = labellatte;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpperRightPanelQuantity(true);
            SelectedTrue(button1);
            SelectedFalse(btnMediumCupSize);
            SelectedFalse(btnLargeCupSize);
            LabelSizeOfDrinkLeft.Text = "Small";
            label8.Text = "Small";
            btnAddToOrder.Visible = true;
            labelQuantityNumber.Visible = true;
            comboBoxCustomizations.Visible = true;

        }

        private void btnMediumCupSize_Click(object sender, EventArgs e)
        {
            UpperRightPanelQuantity(true);
            SelectedFalse(button1);
            SelectedTrue(btnMediumCupSize);
            SelectedFalse(btnLargeCupSize);
            LabelSizeOfDrinkLeft.Text = "Medium";
            label8.Text = "Medium";
            btnAddToOrder.Visible = true;
            labelQuantityNumber.Visible = true;
            comboBoxCustomizations.Visible = true;
        }

        private void btnLargeCupSize_Click(object sender, EventArgs e)
        {
            UpperRightPanelQuantity(true);
            SelectedFalse(button1);
            SelectedFalse(btnMediumCupSize);
            SelectedTrue(btnLargeCupSize);
            LabelSizeOfDrinkLeft.Text = "Large";
            label8.Text = "Large";
            btnAddToOrder.Visible = true;
            labelQuantityNumber.Visible = true;
            comboBoxCustomizations.Visible = true;

            //Add
        }

       
        private int quantityValue = 1;
        private string displayQuantityValue = "1";
        private void btnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            quantityValue += 1;
            displayQuantityValue = quantityValue.ToString();
            labelQuantityNumber.Text = displayQuantityValue;
        }

        private void btnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            quantityValue -= 1;
            if (quantityValue < 0)
            {
                quantityValue = 0;
            }
            displayQuantityValue = quantityValue.ToString();
            labelQuantityNumber.Text = displayQuantityValue;
        }
        //Reads in values from Calculating Total
        private CalculatingTotal _orderInfo;


     
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            string quantityLabel = labelQuantityNumber.Text;
            int quantity = Int16.Parse(quantityLabel);
            _orderInfo = new CalculatingTotal();
            _orderInfo.CalculateBaseDrinkPrice(label5.Text);
            _orderInfo.CalculateSize(LabelSizeOfDrinkLeft.Text);
            _orderInfo.CalculateCostCustom(LabelCustomizationsLeft.Text);
            btnPaymentOrderDrinkScreen.Visible = true;

           

            decimal subTotalPricelabel = _orderInfo.subTotalPrice(quantity);
           
            label13.Text = subTotalPricelabel.ToString();

            decimal taxPricelabel = _orderInfo.calcTax();
            label14.Text = taxPricelabel.ToString();

            decimal totalPriceLabel = _orderInfo.totalPrice();
            label15.Text = totalPriceLabel.ToString();

            label9.Text = _orderInfo.getCustom();

            resetMenu();
        }


        private string comboBoxCustomizations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selected = comboBoxCustomizations.Items.GetType().Name;
            return selected;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
