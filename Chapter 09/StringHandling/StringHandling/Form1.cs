using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
			// TODO: Add code to parse name
			string fullName = txtFullName.Text;
			fullName = fullName.Trim();
			string[] names = fullName.Split(' ');

			string firstName = "";
			string middleName = "";
			string lastName = "";			

			names = ToinitialCap(names);

			if (names.Count() == 3)
			{ 
			    firstName = names[0];
				middleName = names[1];
				lastName = names[2];
			}
			else
			{ 
				firstName = names[0];
				lastName = names[1];
			}
			
			MessageBox.Show("First name:" + "\t" + firstName + "\n\n" + 
							"Middle name:" + "\t" + middleName + "\n\n" + 
							"Last name" + "\t" + lastName,"Parse Name");
		}

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
			// TODO: Add code to edit the phone number
			string phoneNumber = txtPhoneNumber.Text;
			string cleanPhoneNumber = string.Empty;

			foreach (char c in phoneNumber)
			{
				if (c.Equals('0'))
					cleanPhoneNumber += Convert.ToString(c);
				else if (c.Equals('1'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('2'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('3'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('4'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('5'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('6'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('7'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('8'))
					cleanPhoneNumber += Convert.ToString(c);
				else if(c.Equals('9'))
					cleanPhoneNumber += Convert.ToString(c);

			}

			string entered = Convert.ToString(cleanPhoneNumber);
			entered = entered.Insert(0,"(");
			entered = entered.Insert(4, ") ");
			entered = entered.Insert(9, "-");

			string standard = Convert.ToString(cleanPhoneNumber);
			standard = standard.Insert(3,"-");
			standard = standard.Insert(7, "-");

			MessageBox.Show("Entered:" + "\t\t" + entered + "\n\n" +
							"Digits only:" + "\t" + cleanPhoneNumber + "\n\n" +
							"Standrd format:" + "\t" + standard );
        }

        // TODO: Add ToInitialCap method here
		public string[] ToinitialCap(string[] names)
		{
			string upperName = "";
			int i = 0;

			foreach (string name in names)
			{
				string firstLetter = name.Substring(0, 1).ToUpper();
				string otherLetters = name.Substring(1).ToLower();
				upperName = firstLetter + otherLetters;
				names[i] = upperName;
				i++;
			}

			return names;
		}

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}