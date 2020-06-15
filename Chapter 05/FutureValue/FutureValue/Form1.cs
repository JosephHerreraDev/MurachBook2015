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

		private void BtnCalculate_Click(object sender, EventArgs e)
		{
			decimal MonthlyInvestment =
				Convert.ToDecimal(txtMonthlyInvestment.Text);
			decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
			int years = Convert.ToInt32(txtNumberYears.Text);

			int months = years * 12;
			decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

			decimal futureValue = 0m;
			for(int i = 0; i < months; i++)
			{
				futureValue = (futureValue + MonthlyInvestment)
							* (1 + monthlyInterestRate);
			}

			txtFutureValue.Text = futureValue.ToString("c");
			txtMonthlyInvestment.Focus();
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
