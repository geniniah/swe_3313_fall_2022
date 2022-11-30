namespace CoffeePointOfSale.Forms
{
    partial class FormReceipt
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
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labDrinkQuantity = new System.Windows.Forms.Label();
            this.labSizeCust = new System.Windows.Forms.Label();
            this.labCustID = new System.Windows.Forms.Label();
            this.labPaymentMeth = new System.Windows.Forms.Label();
            this.labCardNum = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.labTax = new System.Windows.Forms.Label();
            this.labSubTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.btnClose.Location = new System.Drawing.Point(1085, 672);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 143);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Receipt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labDrinkQuantity);
            this.panel2.Controls.Add(this.labSizeCust);
            this.panel2.Controls.Add(this.labCustID);
            this.panel2.Controls.Add(this.labPaymentMeth);
            this.panel2.Controls.Add(this.labCardNum);
            this.panel2.Controls.Add(this.labTotal);
            this.panel2.Controls.Add(this.labTax);
            this.panel2.Controls.Add(this.labSubTotal);
            this.panel2.Location = new System.Drawing.Point(442, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 507);
            this.panel2.TabIndex = 6;
            // 
            // labDrinkQuantity
            // 
            this.labDrinkQuantity.AutoSize = true;
            this.labDrinkQuantity.Location = new System.Drawing.Point(50, 43);
            this.labDrinkQuantity.Name = "labDrinkQuantity";
            this.labDrinkQuantity.Size = new System.Drawing.Size(0, 20);
            this.labDrinkQuantity.TabIndex = 7;
            // 
            // labSizeCust
            // 
            this.labSizeCust.AutoSize = true;
            this.labSizeCust.Location = new System.Drawing.Point(50, 107);
            this.labSizeCust.Name = "labSizeCust";
            this.labSizeCust.Size = new System.Drawing.Size(0, 20);
            this.labSizeCust.TabIndex = 6;
            // 
            // labCustID
            // 
            this.labCustID.AutoSize = true;
            this.labCustID.Location = new System.Drawing.Point(50, 380);
            this.labCustID.Name = "labCustID";
            this.labCustID.Size = new System.Drawing.Size(94, 20);
            this.labCustID.TabIndex = 5;
            this.labCustID.Text = "CustomerID: ";
            // 
            // labPaymentMeth
            // 
            this.labPaymentMeth.AutoSize = true;
            this.labPaymentMeth.Location = new System.Drawing.Point(50, 423);
            this.labPaymentMeth.Name = "labPaymentMeth";
            this.labPaymentMeth.Size = new System.Drawing.Size(128, 20);
            this.labPaymentMeth.TabIndex = 4;
            this.labPaymentMeth.Text = "Payment Method: ";
            // 
            // labCardNum
            // 
            this.labCardNum.AutoSize = true;
            this.labCardNum.Location = new System.Drawing.Point(50, 465);
            this.labCardNum.Name = "labCardNum";
            this.labCardNum.Size = new System.Drawing.Size(105, 20);
            this.labCardNum.TabIndex = 3;
            this.labCardNum.Text = "Card Number: ";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(50, 325);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(49, 20);
            this.labTotal.TabIndex = 2;
            this.labTotal.Text = "Total: ";
            this.labTotal.Click += new System.EventHandler(this.labTotal_Click);
            // 
            // labTax
            // 
            this.labTax.AutoSize = true;
            this.labTax.Location = new System.Drawing.Point(50, 276);
            this.labTax.Name = "labTax";
            this.labTax.Size = new System.Drawing.Size(37, 20);
            this.labTax.TabIndex = 1;
            this.labTax.Text = "Tax: ";
            this.labTax.Click += new System.EventHandler(this.label3_Click);
            // 
            // labSubTotal
            // 
            this.labSubTotal.AutoSize = true;
            this.labSubTotal.Location = new System.Drawing.Point(50, 230);
            this.labSubTotal.Name = "labSubTotal";
            this.labSubTotal.Size = new System.Drawing.Size(72, 20);
            this.labSubTotal.TabIndex = 0;
            this.labSubTotal.Text = "Subtotal: ";
            this.labSubTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnClose;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label labTax;
        private Label labSubTotal;
        private Label labTotal;
        private Label labCustID;
        private Label labPaymentMeth;
        private Label labCardNum;
        private Label labDrinkQuantity;
        private Label labSizeCust;
    }
}