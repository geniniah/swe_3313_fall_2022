namespace CoffeePointOfSale.Forms;

sealed partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnOrderDrink = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.Location = new System.Drawing.Point(237, 404);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(200, 71);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // btnOrderDrink
            // 
            this.btnOrderDrink.Location = new System.Drawing.Point(590, 404);
            this.btnOrderDrink.Name = "btnOrderDrink";
            this.btnOrderDrink.Size = new System.Drawing.Size(175, 71);
            this.btnOrderDrink.TabIndex = 1;
            this.btnOrderDrink.Text = "Order Drink";
            this.btnOrderDrink.UseVisualStyleBackColor = true;
            this.btnOrderDrink.Click += new System.EventHandler(this.btnOrderDrink_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Location = new System.Drawing.Point(933, 404);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(175, 71);
            this.btnCustomerList.TabIndex = 2;
            this.btnCustomerList.Text = "Customer List";
            this.btnCustomerList.UseVisualStyleBackColor = true;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.btnOrderDrink);
            this.Controls.Add(this.btnManagement);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private Button btnManagement;
    private Button btnOrderDrink;
    private Button btnCustomerList;
}