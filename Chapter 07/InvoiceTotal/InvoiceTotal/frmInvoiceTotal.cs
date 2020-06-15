using System;
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

			try
			{
				decimal subtotal = Decimal.Parse(txtSubtotal.Text);

				if(txtSubtotal.Text == "")
				{ 
					MessageBox.Show(
					"Please enter a value to Subtotal Field",
					"Entry Error");
				}

				if (subtotal <= 0)
				{
					MessageBox.Show(
					"Subtotal must be greater than 0.",
					"Entry Error");
					txtSubtotal.Focus();
				}
				else if (subtotal >= 1000)
				{
					MessageBox.Show(
					"Subtotal must be less than 1,000.",
					"Entry Error");
					txtSubtotal.Focus();
				}

				decimal discountPercent = .25m;
				decimal discountAmount = subtotal * discountPercent;
				decimal invoiceTotal = subtotal - discountAmount;

				discountAmount = Math.Round(discountAmount, 2);
				invoiceTotal = Math.Round(invoiceTotal, 2);

				txtDiscountPercent.Text = discountPercent.ToString("p1");
				txtDiscountAmount.Text = discountAmount.ToString();
				txtTotal.Text = invoiceTotal.ToString();

				txtSubtotal.Focus();
			}							
						

			catch (Exception ex)
			{
				MessageBox.Show(
					"Please enter a valid number for the Subtotal field",
					"Entry Error");
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}