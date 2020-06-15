using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
	public partial class frmInvoiceTotal : Form
	{
        public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Decimal.Parse(txtSubtotal.Text);
			decimal discountPercent = .25m;
			decimal discountAmount = subtotal * discountPercent;
			decimal invoiceTotal = subtotal - discountAmount;

			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = String.Format("{0:c2}",discountAmount);
			txtTotal.Text = string.Format("{0:c2}",invoiceTotal);

			txtSubtotal.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}