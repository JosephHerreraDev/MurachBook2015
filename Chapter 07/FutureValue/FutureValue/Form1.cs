using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
			try
			{
				if(IsValidData())
				{ 
					decimal monthlyInvestment = 
						Convert.ToDecimal(txtMonthlyInvestment.Text);
					decimal yearlyInterestRate = 
						Convert.ToDecimal(txtInterestRate.Text);
					int years = Convert.ToInt32(txtYears.Text);

					int months = years * 12;
					decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

					decimal futureValue = this.CalculateFutureValue(
						monthlyInvestment, monthlyInterestRate, months);

					txtFutureValue.Text = futureValue.ToString("c");
					txtMonthlyInvestment.Focus();
				}


				//throw new Exception();
			}
			//catch (FormatException)
			//{
			//	MessageBox.Show(
			//		"A format exception has ocurred. Please check all entries.",
			//		"Entry Error");
			//}
			//catch (OverflowException)
			//{
			//	MessageBox.Show(
			//		"A overflow exception has ocurred. Please enter smaller values.",
			//		"Entry Error");
			//}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + 
					ex.GetType().ToString() + 
					ex.StackTrace.ToString());				
			}
		}

        private decimal CalculateFutureValue(decimal monthlyInvestment, 
            decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		public bool IsValidData()
		{
			return

			IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
			IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
			IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

			IsPresent(txtInterestRate, "Yearly Interest Rate") &&
			IsDecimal(txtInterestRate, "Yearly Interest Rate") &&
			IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 20) &&

			IsPresent(txtYears, "Number of Years") &&
			IsInt32(txtYears, "Number of Years") &&
			IsWithinRange(txtYears, "Number of Years", 1, 40);

		}

		public bool IsPresent(TextBox textBox, string name)
		{
			if(textBox.Text == "")
			{
				MessageBox.Show(name + " is a required field.", "Entry Error");
				textBox.Focus();
				return false;
			}
			return true;
		}

		public bool IsDecimal(TextBox textBox, string name)
		{
			decimal number = 0m;
			if (Decimal.TryParse(textBox.Text,out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(name + " must be a decimal value.", "Entry Error");
				textBox.Focus();
				return false;
			}
		}

		public bool IsInt32(TextBox textBox, string name)
		{
			int number = 0;
			if (Int32.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(name + " must be a integer value.", "Entry Error");
				textBox.Focus();
				return false;
			}
		}

		public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if(number < min || number > max)
			{
				MessageBox.Show(name + " must be between" + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
				textBox.Focus();
				return false;
			}
			return true;
		}


    }
}