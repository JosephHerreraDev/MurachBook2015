namespace FutureValue
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
			this.txtInterestRate = new System.Windows.Forms.TextBox();
			this.txtNumberYears = new System.Windows.Forms.TextBox();
			this.txtFutureValue = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Monthly Investment:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Yearly Interest Rate:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Number of Years:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Future Value:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtMonthlyInvestment
			// 
			this.txtMonthlyInvestment.Location = new System.Drawing.Point(117, 10);
			this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
			this.txtMonthlyInvestment.Size = new System.Drawing.Size(100, 20);
			this.txtMonthlyInvestment.TabIndex = 1;
			// 
			// txtInterestRate
			// 
			this.txtInterestRate.Location = new System.Drawing.Point(117, 39);
			this.txtInterestRate.Name = "txtInterestRate";
			this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
			this.txtInterestRate.TabIndex = 2;
			// 
			// txtNumberYears
			// 
			this.txtNumberYears.Location = new System.Drawing.Point(117, 65);
			this.txtNumberYears.Name = "txtNumberYears";
			this.txtNumberYears.Size = new System.Drawing.Size(100, 20);
			this.txtNumberYears.TabIndex = 3;
			// 
			// txtFutureValue
			// 
			this.txtFutureValue.Location = new System.Drawing.Point(117, 91);
			this.txtFutureValue.Name = "txtFutureValue";
			this.txtFutureValue.ReadOnly = true;
			this.txtFutureValue.Size = new System.Drawing.Size(100, 20);
			this.txtFutureValue.TabIndex = 7;
			this.txtFutureValue.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(142, 127);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(61, 127);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(244, 166);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtFutureValue);
			this.Controls.Add(this.txtNumberYears);
			this.Controls.Add(this.txtInterestRate);
			this.Controls.Add(this.txtMonthlyInvestment);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Future Value";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMonthlyInvestment;
		private System.Windows.Forms.TextBox txtInterestRate;
		private System.Windows.Forms.TextBox txtNumberYears;
		private System.Windows.Forms.TextBox txtFutureValue;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCalculate;
	}
}

