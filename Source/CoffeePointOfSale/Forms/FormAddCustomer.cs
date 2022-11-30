using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
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
    public partial class FormAddCustomer : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private ICustomerService _customerService;

        public FormAddCustomer(IAppSettings appSettings, ICustomerService customerService) : this()
        {
            _appSettings = appSettings;
            _customerService = customerService;
        }

        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void OnLoadFormAddCustomer(object sender, EventArgs e)
        {

        }

        private void OnClickBtnClose(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }
        // This is used to make sure the phone number is unique
        static private bool Unique = true;
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            Unique = true;
            if((txtBoxFirstName.Text == string.Empty)||(txtBoxLastName.Text == string.Empty))
            {
                labError.Text = "Please fill out the customer's name.";
            }
            else if(txtBoxPhoneNumber.Text== string.Empty)
            {
                labError.Text = "Please type in a phone number.";
            }
            else
            {
                if(txtBoxPhoneNumber.Text.Length == 10)
                {
                    if(int.TryParse(txtBoxPhoneNumber.Text, out int value)){
                        var customerList = _customerService.Customers.List;
                        foreach (var customer in customerList)
                        {
                            if(customer.Phone == txtBoxPhoneNumber.Text)
                            {
                                Unique = false;
                            }
                        }
                        if (Unique)
                        {
                            // Put into Json here
                            labError.Text = "All inputs are good.";
                            Close(); //closes this form
                            FormFactory.Get<OrderDrink>().Show(); //re-opens the main form
                        }
                        else
                        {
                            labError.Text = "That phone number already exists as a customer.";
                        }
                    }
                    else
                    {
                        // There is an issue here with the TryParse not being able to tell anything with 404 in front of it apart.
                        labError.Text = "Please do not include anything that is not a number in the phone number";
                    }
                }
                else
                {
                    labError.Text = "Please enter a 10 digit phone number, no dashes.";
                }
            }
        }
    }
}
