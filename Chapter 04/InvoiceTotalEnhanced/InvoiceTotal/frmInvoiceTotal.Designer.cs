namespace InvoiceTotal
{
	partial class frmInvoiceTotal
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
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtDiscountPercent = new System.Windows.Forms.TextBox();
			this.txtDiscountAmount = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
			this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
			this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtLargestInvoice = new System.Windows.Forms.TextBox();
			this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Subtotal:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Discount Percent:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Discount Amount:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Total:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(120, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 13);
			this.label5.TabIndex = 4;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(120, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 13);
			this.label6.TabIndex = 5;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(120, 131);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 6;
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(107, 39);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.ReadOnly = true;
			this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
			this.txtSubtotal.TabIndex = 1;
			this.txtSubtotal.TabStop = false;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(192, 153);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 2;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(354, 153);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtDiscountPercent
			// 
			this.txtDiscountPercent.Location = new System.Drawing.Point(107, 65);
			this.txtDiscountPercent.Name = "txtDiscountPercent";
			this.txtDiscountPercent.ReadOnly = true;
			this.txtDiscountPercent.Size = new System.Drawing.Size(100, 20);
			this.txtDiscountPercent.TabIndex = 10;
			this.txtDiscountPercent.TabStop = false;
			// 
			// txtDiscountAmount
			// 
			this.txtDiscountAmount.Location = new System.Drawing.Point(107, 92);
			this.txtDiscountAmount.Name = "txtDiscountAmount";
			this.txtDiscountAmount.ReadOnly = true;
			this.txtDiscountAmount.Size = new System.Drawing.Size(100, 20);
			this.txtDiscountAmount.TabIndex = 11;
			this.txtDiscountAmount.TabStop = false;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(107, 118);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 12;
			this.txtTotal.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(213, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Number of invoices:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(213, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Total of invoices:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(213, 68);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(87, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Invoice average:";
			// 
			// txtNumberOfInvoices
			// 
			this.txtNumberOfInvoices.Location = new System.Drawing.Point(320, 12);
			this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
			this.txtNumberOfInvoices.ReadOnly = true;
			this.txtNumberOfInvoices.Size = new System.Drawing.Size(100, 20);
			this.txtNumberOfInvoices.TabIndex = 16;
			this.txtNumberOfInvoices.TabStop = false;
			// 
			// txtTotalOfInvoices
			// 
			this.txtTotalOfInvoices.Location = new System.Drawing.Point(320, 38);
			this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
			this.txtTotalOfInvoices.ReadOnly = true;
			this.txtTotalOfInvoices.Size = new System.Drawing.Size(100, 20);
			this.txtTotalOfInvoices.TabIndex = 17;
			this.txtTotalOfInvoices.TabStop = false;
			// 
			// txtInvoiceAverage
			// 
			this.txtInvoiceAverage.Location = new System.Drawing.Point(320, 65);
			this.txtInvoiceAverage.Name = "txtInvoiceAverage";
			this.txtInvoiceAverage.ReadOnly = true;
			this.txtInvoiceAverage.Size = new System.Drawing.Size(100, 20);
			this.txtInvoiceAverage.TabIndex = 18;
			this.txtInvoiceAverage.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(273, 153);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Clear Totals";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 13);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "Enter subtotal:";
			// 
			// txtEnterSubtotal
			// 
			this.txtEnterSubtotal.Location = new System.Drawing.Point(107, 10);
			this.txtEnterSubtotal.Name = "txtEnterSubtotal";
			this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 20);
			this.txtEnterSubtotal.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(213, 95);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 13);
			this.label12.TabIndex = 22;
			this.label12.Text = "Largest invoice:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(213, 123);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 13);
			this.label13.TabIndex = 23;
			this.label13.Text = "Smallest invoice:";
			// 
			// txtLargestInvoice
			// 
			this.txtLargestInvoice.Location = new System.Drawing.Point(320, 92);
			this.txtLargestInvoice.Name = "txtLargestInvoice";
			this.txtLargestInvoice.ReadOnly = true;
			this.txtLargestInvoice.Size = new System.Drawing.Size(100, 20);
			this.txtLargestInvoice.TabIndex = 24;
			this.txtLargestInvoice.TabStop = false;
			// 
			// txtSmallestInvoice
			// 
			this.txtSmallestInvoice.Location = new System.Drawing.Point(320, 116);
			this.txtSmallestInvoice.Name = "txtSmallestInvoice";
			this.txtSmallestInvoice.ReadOnly = true;
			this.txtSmallestInvoice.Size = new System.Drawing.Size(100, 20);
			this.txtSmallestInvoice.TabIndex = 25;
			this.txtSmallestInvoice.TabStop = false;
			// 
			// frmInvoiceTotal
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(441, 184);
			this.Controls.Add(this.txtSmallestInvoice);
			this.Controls.Add(this.txtLargestInvoice);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtEnterSubtotal);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtInvoiceAverage);
			this.Controls.Add(this.txtTotalOfInvoices);
			this.Controls.Add(this.txtNumberOfInvoices);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtDiscountAmount);
			this.Controls.Add(this.txtDiscountPercent);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmInvoiceTotal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Total";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtDiscountPercent;
		private System.Windows.Forms.TextBox txtDiscountAmount;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtNumberOfInvoices;
		private System.Windows.Forms.TextBox txtTotalOfInvoices;
		private System.Windows.Forms.TextBox txtInvoiceAverage;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtEnterSubtotal;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtLargestInvoice;
		private System.Windows.Forms.TextBox txtSmallestInvoice;
	}
}

