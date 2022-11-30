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
    public partial class FormAddCustomer : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        public FormAddCustomer(IAppSettings appSettings) : this()
        {
            _appSettings = appSettings;
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
    }
}
