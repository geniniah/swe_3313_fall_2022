using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;
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
        private bool UpperRightPanelDrinkSize(bool status)
        {
            button1.Visible = status;
            btnMediumCupSize.Visible = status;
            btnLargeCupSize.Visible = status;


            return status;
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

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }




        //Activating Methods with Click Events 
        private Button SelectedTrue(Button button)
        {
            button.Text = "Selected";
            button.BackColor = Color.Gray;
            return button;

        }

        private Button SelectedFalse(Button button)
        {
            button.Text = "Select";
            button.BackColor = Color.White;
            return button;
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

            
        }

        private void btnIcedLatte_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnIcedLatte);
            SelectedFalse(btnLatte);
            SelectedFalse(btnCoffee);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnIcedWater);
            UpperRightPanelDrinkSize(true);
            LabelSizeOfDrinkLeft.Text = label2.Text;


        }

        private void btnGreenLatte_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnGreenLatte);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnCoffee);
            SelectedFalse(btnLatte);
            SelectedFalse(btnIcedWater);
            UpperRightPanelDrinkSize(true);

            
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnCoffee);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnLatte);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnIcedWater);
            UpperRightPanelDrinkSize(true);
            
        }

        private void btnIcedWater_Click(object sender, EventArgs e)
        {
            SelectedTrue(btnIcedWater);
            SelectedFalse(btnIcedLatte);
            SelectedFalse(btnCoffee);
            SelectedFalse(btnGreenLatte);
            SelectedFalse(btnLatte);
            UpperRightPanelDrinkSize(true);
            
        }

       

        private void OrderDrink_Load(object sender, EventArgs e)
        {
            UpperRightPanelDrinkSize(false);
            UpperRightPanelQuantity(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpperRightPanelQuantity(true);
            SelectedTrue(button1);
            SelectedFalse(btnMediumCupSize);
            SelectedFalse(btnLargeCupSize);
        }

        private void btnMediumCupSize_Click(object sender, EventArgs e)
        {
            UpperRightPanelQuantity(true);
            SelectedFalse(button1);
            SelectedTrue(btnMediumCupSize);
            SelectedFalse(btnLargeCupSize);
        }

        private void btnLargeCupSize_Click(object sender, EventArgs e)
        {
            UpperRightPanelQuantity(true);
            SelectedFalse(button1);
            SelectedFalse(btnMediumCupSize);
            SelectedTrue(btnLargeCupSize);

            //Add
        }
    }
}
