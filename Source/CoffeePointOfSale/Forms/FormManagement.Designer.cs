namespace CoffeePointOfSale.Forms
{
    partial class FormManagement
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
            this.txtDeleteThis = new System.Windows.Forms.TextBox();
            this.lblRemoveThis = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.btnClose.Location = new System.Drawing.Point(871, 404);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 82);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // txtDeleteThis
            // 
            this.txtDeleteThis.AcceptsReturn = true;
            this.txtDeleteThis.Location = new System.Drawing.Point(380, 187);
            this.txtDeleteThis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeleteThis.Multiline = true;
            this.txtDeleteThis.Name = "txtDeleteThis";
            this.txtDeleteThis.Size = new System.Drawing.Size(550, 100);
            this.txtDeleteThis.TabIndex = 1;
            // 
            // lblRemoveThis
            // 
            this.lblRemoveThis.AutoSize = true;
            this.lblRemoveThis.Location = new System.Drawing.Point(593, 155);
            this.lblRemoveThis.Name = "lblRemoveThis";
            this.lblRemoveThis.Size = new System.Drawing.Size(122, 20);
            this.lblRemoveThis.TabIndex = 2;
            this.lblRemoveThis.Text = "Csv Data Preview";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.button1.Location = new System.Drawing.Point(339, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Csv";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 136);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRemoveThis);
            this.Controls.Add(this.txtDeleteThis);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManagement";
            this.Text = "FormManagement";
            this.Load += new System.EventHandler(this.OnLoadFormManagement);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private TextBox txtDeleteThis;
        private Label lblRemoveThis;
        private Button button1;
        private Panel panel1;
        private Label label1;
    }
}