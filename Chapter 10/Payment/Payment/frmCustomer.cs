using System;
using System.Windows.Forms;

namespace Payment
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

		bool isDataSaved = true;

		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			cboNames.Items.Add("Mike Smith");
			cboNames.Items.Add("Nancy Jones");
		}

		private void DataChanged(object sender, EventArgs e)
		{
			isDataSaved = false;
		}

		private void BtnSelectPayment_Click(object sender, EventArgs e)
		{
			Form paymentForm = new frmPayment();
			DialogResult selectedButton = paymentForm.ShowDialog();
			if(selectedButton == DialogResult.OK)
			{
				lblPayment.Text = (string) paymentForm.Tag;
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if(IsValidData())
			{
				SaveData();
			}
		}

		private void SaveData()
		{
			cboNames.SelectedIndex = -1;
			lblPayment.Text = "";
			isDataSaved = true;
			cboNames.Focus();
		}

		private bool IsValidData()
		{
			if(cboNames.SelectedIndex == -1)
			{
				MessageBox.Show("You must select a customer.", "Entry Error");
				cboNames.Focus();
				return false;
			}
			if(lblPayment.Text == "")
			{
				MessageBox.Show("You must enter a payment.", "Entry Error");
				return false;
			}
			return true;
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(isDataSaved == false)
			{
				string message =
					"This form contains unsaved data. \n\n" +
					"Do you want to save it?";

				DialogResult button =
					MessageBox.Show(message, "Customer",
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Warning);

				if(button == DialogResult.Yes)
				{
					if (IsValidData())
						this.SaveData();
					else
						e.Cancel = true;
				}
				if(button == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
			}
		}
	}
}