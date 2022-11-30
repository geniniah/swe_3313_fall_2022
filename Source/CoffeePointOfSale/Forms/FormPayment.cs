using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.FormFactory;
using CreditCardValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private CalculatingTotal _orderInfoPaymentScreen;
    
        public FormPayment(IAppSettings appSettings) : this()
        {
            _appSettings = appSettings;
        }

        public FormPayment()
        {
            InitializeComponent();
        }

        private void OnLoadFormPayment(object sender, EventArgs e)
        {

        }
        private void OnClickBtnClose(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {

        }
        static private bool CreditChanged = false;
        private void txtBoxCreditCard_TextChanged(object sender, EventArgs e)
        {
            CreditChanged= true;
        }
        private void BtnCreditCard_Click(object sender, EventArgs e)
        {
            if (CreditChanged)
            {
                CreditCardDetector detector = new CreditCardDetector(txtBoxCreditCard.Text);
                if (detector.IsValid())
                {
                    //Change to Reciept screen here
                    Close(); //closes this form
                    FormFactory.Get<FormReceipt>().Show(); //re-opens the main form
                }
                else
                {
                    //Write to an error Label that is normally hidden from view
                    labError.Text = "Please enter a valid credit card.";
                }
            }
            else
            {
                labError.Text = "You suck.";
                //multiply total amount by 10 and if the user has that many reward points go to receipt screen otherwise keep it here.
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void getOrder()
        {

        }
    }
}
