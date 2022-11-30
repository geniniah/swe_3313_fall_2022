using CoffeePointOfSale.Configuration;
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
    public partial class FormReceipt : Base.FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        public FormReceipt(IAppSettings? appSettings) : this()
        {
            _appSettings = appSettings;
        }

        public FormReceipt()
        {
            InitializeComponent();
        }

        private void OnLoadFormReceipt(object sender, EventArgs e)
        {
             
        }
        private void OnClickBtnClose(object sender, EventArgs e)
        {
            Globals.CreditCard = string.Empty;
            Globals.Drink = string.Empty;
            Globals.Tax = string.Empty;
            Globals.Total = string.Empty;
            Globals.SubTotal = string.Empty;
            Globals.IsAnonymous = false;
            Globals.Custimizations = string.Empty;
            Globals.PayMethod = string.Empty;
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            labCardNum.Text = labCardNum.Text + Globals.CreditCard;
            labSizeCust.Text = Globals.Custimizations;
            labSubTotal.Text = labSubTotal.Text + Globals.SubTotal;
            labTax.Text = labTax.Text +Globals.Tax;
            labTotal.Text = labTotal.Text + Globals.Total;
            labDrinkQuantity.Text = Globals.Drink;

            if (Globals.IsAnonymous)
            {
                labPaymentMeth.Text = labPaymentMeth.Text + "Credit Card";
                labCustID.Text = labCustID.Text + "0";
            }
            else
            {
                labCustID.Text = labCustID.Text + "1";
                if (Globals.PayMethod == "credit")
                {
                    labPaymentMeth.Text = labPaymentMeth.Text + "Credit Card";
                }
                else
                {
                    labPaymentMeth.Text = labPaymentMeth.Text + "Reward Points";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
