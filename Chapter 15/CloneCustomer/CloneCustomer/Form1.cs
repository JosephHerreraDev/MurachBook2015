using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer;
        private CustomerList customers = new CustomerList();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            customer = new Customer("John", "Mendez", "jmendez@msysco.com");
            lblCustomer.Text = customer.GetDisplayText();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

		private void btnClone_Click(object sender, EventArgs e)
		{
           if(Validator.IsPresent(txtCopies) & Validator.IsInt32(txtCopies))
           {
                for (int i = 0; i < Convert.ToInt32(txtCopies.Text); i++)
				{
                    Customer c = (Customer)customer.Clone();
                    customers.Add(c);
                }
                int x = 0;
                foreach (Customer c in customers)
                {
                    lstCustomers.Items.Add(customers.ElementAt(x).GetDisplayText() + "\n");
                    x++;
                }
            }
		}
	}
}