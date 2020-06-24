using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
	{
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		// TODO: declare class variables for array and list here
		decimal[] invoiceTotals = new decimal[5];
		List<decimal> invoiceTotalsList = new List<decimal>();
		int index = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
		{
            try
            {

                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show(
                        "Subtotal is a required field.", "Entry Error");
                }
                else
                {
			        decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                    if (subtotal > 0 && subtotal < 10000)
                    {
                        decimal discountPercent = 0m;
                        if (subtotal >= 500)
                            discountPercent = .2m;
                        else if (subtotal >= 250 & subtotal < 500)
                            discountPercent = .15m;
                        else if (subtotal >= 100 & subtotal < 250)
                            discountPercent = .1m;
                        decimal discountAmount = subtotal * discountPercent;
			            decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString();
                        txtTotal.Text = invoiceTotal.ToString();

						invoiceTotals[index] = invoiceTotal;
						index++;

						invoiceTotalsList.Add(invoiceTotal);

					}
                    else
                    {
                        MessageBox.Show(
                            "Subtotal must be greater than 0 and less than 10,000.", 
                            "Entry Error");
                    }
                }
            }
			catch(IndexOutOfRangeException ex)
			{
				MessageBox.Show(ex.Message);
			}
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.", 
                    "Entry Error");
            }
            txtSubtotal.Focus();
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
			string message = "";
			string messageList = "";
			Array.Sort(invoiceTotals);
			invoiceTotalsList.Sort();

			// TODO: add code that displays dialog boxes here
			foreach (decimal elem in invoiceTotals)
			{
				if (elem != 0)
					message += "$" + elem.ToString() + "\n";
				
			}
			MessageBox.Show(message, "Order Totals");

			foreach (decimal elem in invoiceTotalsList)
			{
				if(elem != 0)
					messageList += "$" + elem.ToString() + "\n";
			}			
			MessageBox.Show(messageList, "Order Totals");

			this.Close();
		}

	}
}