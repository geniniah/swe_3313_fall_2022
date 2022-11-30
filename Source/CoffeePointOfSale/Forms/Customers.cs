using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
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
    public partial class Customers : FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        private ICustomerService _customerService;
        private decimal _taxRate;
        private decimal _rewardPerDollar;
        public Customers()
        {
            InitializeComponent();
        }
        public Customers(IAppSettings appSettings, ICustomerService customerService) : this()
        {
            _customerService = customerService;
            _appSettings = appSettings;
            _rewardPerDollar = appSettings.Rewards.PointsPerDollar;
            _taxRate = appSettings.Tax.Rate;
        }
        private void OnLoadCustomers(object sender, EventArgs e)
        {
            
            var customerList = _customerService.Customers.List;
            int i = 0;
            for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
            {
                var customer = customerList[customerIdx];
                string phone_data = customer.Phone;
                string first_data = customer.FirstName;
                string last_data = customer.LastName;
                // If you are going to be moving these then know that they are spaced 277 pixels apart and 53 up and down.
                Label last = new Label();
                last.Name = "last" + i;
                last.Text = last_data;
                last.Location = new Point(217, 226 + (i * 50));
                last.AutoSize= true;
                last.Font = new Font("Calibri", 12);
                last.Padding = new Padding(5);

                this.Controls.Add(last);

                Label first = new Label();
                first.Name = "first" + i;
                first.Text = first_data;
                first.Location = new Point(494, 226 + (i * 50));
                first.AutoSize = true;
                first.Font = new Font("Calibri", 12);
                first.Padding = new Padding(5);

                this.Controls.Add(first);

                Label phone = new Label();
                phone.Name = "phone" + i;
                phone.Text = phone_data;
                phone.Location = new Point(771, 226 + (i * 50));
                phone.AutoSize = true;
                phone.Font = new Font("Calibri", 12);
                phone.Padding = new Padding(5);

                this.Controls.Add(phone);

                Button OrderDrink = new Button();
                OrderDrink.Name = "OrderDrink" + i;
                OrderDrink.Text = "Order Drink";
                OrderDrink.Location = new Point(1048, 226 + (i * 50));
                OrderDrink.Size = new System.Drawing.Size(277, 53);
                OrderDrink.Font = new Font("Calibri", 12);
                OrderDrink.Padding = new Padding(5);
                OrderDrink.Click += new System.EventHandler(OnClickBtnOrder);

                this.Controls.Add(OrderDrink);

                i++;
            }

        }
        private void OnClickBtnClose(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }
        private void OnClickBtnOrder(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<OrderDrink>().Show(); //re-opens the main form
        }
        private void OnClickBtnAddCustomer(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormAddCustomer>().Show(); //opens add customer form
        }
    }
}
