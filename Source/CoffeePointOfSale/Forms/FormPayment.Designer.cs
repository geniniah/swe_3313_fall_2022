﻿namespace CoffeePointOfSale.Forms
{
    partial class FormPayment
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
            this.txtBoxCreditCard = new System.Windows.Forms.TextBox();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.labError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labIsAnonymous = new System.Windows.Forms.Label();
            this.labCustStat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labSubtotal = new System.Windows.Forms.Label();
            this.labTax = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labPointsLeft = new System.Windows.Forms.Label();
            this.labTotalPointC = new System.Windows.Forms.Label();
            this.labRedeemableP = new System.Windows.Forms.Label();
            this.btnRedeem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.btnClose.Location = new System.Drawing.Point(1023, 479);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // txtBoxCreditCard
            // 
            this.txtBoxCreditCard.Location = new System.Drawing.Point(72, 85);
            this.txtBoxCreditCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxCreditCard.Name = "txtBoxCreditCard";
            this.txtBoxCreditCard.Size = new System.Drawing.Size(154, 23);
            this.txtBoxCreditCard.TabIndex = 1;
            this.txtBoxCreditCard.TextChanged += new System.EventHandler(this.txtBoxCreditCard_TextChanged);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.btnCreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.btnCreditCard.Location = new System.Drawing.Point(97, 157);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(98, 39);
            this.btnCreditCard.TabIndex = 3;
            this.btnCreditCard.Text = "Submit Credit Card";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.BtnCreditCard_Click);
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(32, 128);
            this.labError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(0, 15);
            this.labError.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-6, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 101);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.labIsAnonymous);
            this.panel3.Controls.Add(this.labCustStat);
            this.panel3.Location = new System.Drawing.Point(567, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 57);
            this.panel3.TabIndex = 12;
            // 
            // labIsAnonymous
            // 
            this.labIsAnonymous.AutoSize = true;
            this.labIsAnonymous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.labIsAnonymous.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labIsAnonymous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labIsAnonymous.Location = new System.Drawing.Point(216, 17);
            this.labIsAnonymous.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labIsAnonymous.Name = "labIsAnonymous";
            this.labIsAnonymous.Size = new System.Drawing.Size(108, 37);
            this.labIsAnonymous.TabIndex = 7;
            this.labIsAnonymous.Text = "Existing";
            // 
            // labCustStat
            // 
            this.labCustStat.AutoSize = true;
            this.labCustStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labCustStat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labCustStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.labCustStat.Location = new System.Drawing.Point(15, 17);
            this.labCustStat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCustStat.Name = "labCustStat";
            this.labCustStat.Size = new System.Drawing.Size(222, 37);
            this.labCustStat.TabIndex = 5;
            this.labCustStat.Text = "Customer Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(38, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.panel2.Controls.Add(this.labSubtotal);
            this.panel2.Controls.Add(this.labTax);
            this.panel2.Controls.Add(this.labTotal);
            this.panel2.Location = new System.Drawing.Point(27, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 295);
            this.panel2.TabIndex = 11;
            // 
            // labSubtotal
            // 
            this.labSubtotal.AutoSize = true;
            this.labSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.labSubtotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labSubtotal.Location = new System.Drawing.Point(64, 42);
            this.labSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSubtotal.Name = "labSubtotal";
            this.labSubtotal.Size = new System.Drawing.Size(130, 37);
            this.labSubtotal.TabIndex = 6;
            this.labSubtotal.Text = "Subtotal :";
            // 
            // labTax
            // 
            this.labTax.AutoSize = true;
            this.labTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.labTax.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labTax.Location = new System.Drawing.Point(64, 118);
            this.labTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTax.Name = "labTax";
            this.labTax.Size = new System.Drawing.Size(67, 37);
            this.labTax.TabIndex = 5;
            this.labTax.Text = "Tax :";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.labTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labTotal.Location = new System.Drawing.Point(64, 190);
            this.labTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(87, 37);
            this.labTotal.TabIndex = 4;
            this.labTotal.Text = "Total :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtBoxCreditCard);
            this.panel4.Controls.Add(this.labError);
            this.panel4.Controls.Add(this.btnCreditCard);
            this.panel4.Location = new System.Drawing.Point(331, 133);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 197);
            this.panel4.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(10, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(10, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Credit Card Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(346, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Credit Card Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(633, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Reward Points";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.panel5.Controls.Add(this.labPointsLeft);
            this.panel5.Controls.Add(this.labTotalPointC);
            this.panel5.Controls.Add(this.labRedeemableP);
            this.panel5.Controls.Add(this.btnRedeem);
            this.panel5.Location = new System.Drawing.Point(623, 133);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 197);
            this.panel5.TabIndex = 15;
            // 
            // labPointsLeft
            // 
            this.labPointsLeft.AutoSize = true;
            this.labPointsLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.labPointsLeft.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labPointsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labPointsLeft.Location = new System.Drawing.Point(10, 116);
            this.labPointsLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPointsLeft.Name = "labPointsLeft";
            this.labPointsLeft.Size = new System.Drawing.Size(131, 31);
            this.labPointsLeft.TabIndex = 15;
            this.labPointsLeft.Text = "Points Left :";
            // 
            // labTotalPointC
            // 
            this.labTotalPointC.AutoSize = true;
            this.labTotalPointC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.labTotalPointC.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labTotalPointC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labTotalPointC.Location = new System.Drawing.Point(10, 67);
            this.labTotalPointC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTotalPointC.Name = "labTotalPointC";
            this.labTotalPointC.Size = new System.Drawing.Size(183, 31);
            this.labTotalPointC.TabIndex = 14;
            this.labTotalPointC.Text = "Total Point Cost :";
            // 
            // labRedeemableP
            // 
            this.labRedeemableP.AutoSize = true;
            this.labRedeemableP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.labRedeemableP.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labRedeemableP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.labRedeemableP.Location = new System.Drawing.Point(10, 18);
            this.labRedeemableP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRedeemableP.Name = "labRedeemableP";
            this.labRedeemableP.Size = new System.Drawing.Size(220, 31);
            this.labRedeemableP.TabIndex = 13;
            this.labRedeemableP.Text = "Redeemable Points :";
            // 
            // btnRedeem
            // 
            this.btnRedeem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.btnRedeem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.btnRedeem.Location = new System.Drawing.Point(104, 157);
            this.btnRedeem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(78, 31);
            this.btnRedeem.TabIndex = 3;
            this.btnRedeem.Text = "Redeem";
            this.btnRedeem.UseVisualStyleBackColor = false;
            this.btnRedeem.Click += new System.EventHandler(this.btnRedeem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(633, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 13;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClose;
        private TextBox txtBoxCreditCard;
        private Button btnCreditCard;
        private Label labError;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label labSubtotal;
        private Label labTax;
        private Label labTotal;
        private Panel panel3;
        private Label labCustStat;
        private Label labIsAnonymous;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private Label label5;
        private Panel panel5;
        private Label labPointsLeft;
        private Label labTotalPointC;
        private Label labRedeemableP;
        private Button btnRedeem;
        private Label label7;
        private Label label6;
    }
}