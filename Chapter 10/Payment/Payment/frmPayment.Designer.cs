namespace Payment
{
	partial class frmPayment
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
			this.rdoCreditCard = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lstCreditCardType = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCardNumber = new System.Windows.Forms.TextBox();
			this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
			this.cboExpirationYear = new System.Windows.Forms.ComboBox();
			this.chkDefault = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoBillCustomer);
			this.groupBox1.Controls.Add(this.rdoCreditCard);
			this.groupBox1.Location = new System.Drawing.Point(9, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(296, 54);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Billing";
			// 
			// rdoBillCustomer
			// 
			this.rdoBillCustomer.AutoSize = true;
			this.rdoBillCustomer.Location = new System.Drawing.Point(144, 19);
			this.rdoBillCustomer.Name = "rdoBillCustomer";
			this.rdoBillCustomer.Size = new System.Drawing.Size(84, 17);
			this.rdoBillCustomer.TabIndex = 1;
			this.rdoBillCustomer.Text = "Bill customer";
			this.rdoBillCustomer.UseVisualStyleBackColor = true;
			// 
			// rdoCreditCard
			// 
			this.rdoCreditCard.AutoSize = true;
			this.rdoCreditCard.Checked = true;
			this.rdoCreditCard.Location = new System.Drawing.Point(18, 19);
			this.rdoCreditCard.Name = "rdoCreditCard";
			this.rdoCreditCard.Size = new System.Drawing.Size(77, 17);
			this.rdoCreditCard.TabIndex = 0;
			this.rdoCreditCard.TabStop = true;
			this.rdoCreditCard.Text = "Credit Card";
			this.rdoCreditCard.UseVisualStyleBackColor = true;
			this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.RdoCreditCard_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Credit card type:";
			// 
			// lstCreditCardType
			// 
			this.lstCreditCardType.FormattingEnabled = true;
			this.lstCreditCardType.Location = new System.Drawing.Point(102, 91);
			this.lstCreditCardType.Name = "lstCreditCardType";
			this.lstCreditCardType.Size = new System.Drawing.Size(203, 56);
			this.lstCreditCardType.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Card number:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Expiration date:";
			// 
			// txtCardNumber
			// 
			this.txtCardNumber.Location = new System.Drawing.Point(102, 162);
			this.txtCardNumber.Name = "txtCardNumber";
			this.txtCardNumber.Size = new System.Drawing.Size(203, 20);
			this.txtCardNumber.TabIndex = 3;
			// 
			// cboExpirationMonth
			// 
			this.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboExpirationMonth.FormattingEnabled = true;
			this.cboExpirationMonth.Location = new System.Drawing.Point(102, 198);
			this.cboExpirationMonth.Name = "cboExpirationMonth";
			this.cboExpirationMonth.Size = new System.Drawing.Size(96, 21);
			this.cboExpirationMonth.TabIndex = 4;
			// 
			// cboExpirationYear
			// 
			this.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboExpirationYear.FormattingEnabled = true;
			this.cboExpirationYear.Location = new System.Drawing.Point(219, 198);
			this.cboExpirationYear.Name = "cboExpirationYear";
			this.cboExpirationYear.Size = new System.Drawing.Size(86, 21);
			this.cboExpirationYear.TabIndex = 5;
			// 
			// chkDefault
			// 
			this.chkDefault.AutoSize = true;
			this.chkDefault.Checked = true;
			this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDefault.Location = new System.Drawing.Point(15, 237);
			this.chkDefault.Name = "chkDefault";
			this.chkDefault.Size = new System.Drawing.Size(158, 17);
			this.chkDefault.TabIndex = 6;
			this.chkDefault.Text = "Set as default billing method";
			this.chkDefault.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(149, 274);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 7;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(230, 274);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// frmPayment
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(311, 311);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.chkDefault);
			this.Controls.Add(this.cboExpirationYear);
			this.Controls.Add(this.cboExpirationMonth);
			this.Controls.Add(this.txtCardNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstCreditCardType);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frmPayment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payment";
			this.Load += new System.EventHandler(this.FrmPayment_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoBillCustomer;
		private System.Windows.Forms.RadioButton rdoCreditCard;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstCreditCardType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCardNumber;
		private System.Windows.Forms.ComboBox cboExpirationMonth;
		private System.Windows.Forms.ComboBox cboExpirationYear;
		private System.Windows.Forms.CheckBox chkDefault;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}