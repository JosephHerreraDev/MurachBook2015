using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
			// TODO: Add code to calculate the days until due date
			DateTime futureDate;
			DateTime.TryParse(txtFutureDate.Text,out futureDate);

			DateTime currentDate = DateTime.Today;

			TimeSpan timeTillDue = futureDate.Subtract(currentDate);
			int daysTillDue = timeTillDue.Days;

			MessageBox.Show("Current date: " + "\t" + Convert.ToString(currentDate.ToShortDateString()) + "\n\n" +
							"Future date: " + "\t" + Convert.ToString(futureDate.ToShortDateString()) + "\n\n" +
							"Days until due: " + "\t" + Convert.ToString(daysTillDue),"Due Days Calculation");
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
			// TODO: Add code to calculate the age
			DateTime birthDate;
			DateTime.TryParse(txtBirthDate.Text, out birthDate);
			int birthYear = birthDate.Year;

			DateTime currentDate = DateTime.Today;
			int currentYear = currentDate.Year;

			int yearsTillDue = currentYear - birthYear;

			MessageBox.Show("Current date: " + "\t" + Convert.ToString(currentDate.ToLongDateString()) + "\n\n" +
							"Future date: " + "\t" + Convert.ToString(birthDate.ToLongDateString()) + "\n\n" +
							"Age: " + "\t\t" + Convert.ToString(yearsTillDue),"Age Calculation");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}