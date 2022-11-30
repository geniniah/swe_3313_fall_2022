namespace CoffeePointOfSale.Forms
{
    partial class OrderDrink
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
            this.btnLatte = new System.Windows.Forms.Button();
            this.btnIcedLatte = new System.Windows.Forms.Button();
            this.btnGreenLatte = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCustomizations = new System.Windows.Forms.ComboBox();
            this.labelQuantityNumber = new System.Windows.Forms.Label();
            this.btnDecreaseQuantity = new System.Windows.Forms.Button();
            this.btnIncreaseQuantity = new System.Windows.Forms.Button();
            this.LabelCustomizationsLeft = new System.Windows.Forms.Label();
            this.LabelSizeOfDrinkLeft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLargeCupSize = new System.Windows.Forms.Button();
            this.btnMediumCupSize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIcedWater = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPaymentOrderDrinkScreen = new System.Windows.Forms.Button();
            this.btnCancelOrderDrinkScreen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLatte
            // 
            this.btnLatte.Location = new System.Drawing.Point(21, 46);
            this.btnLatte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(89, 52);
            this.btnLatte.TabIndex = 0;
            this.btnLatte.Text = "Select";
            this.btnLatte.UseVisualStyleBackColor = true;
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // btnIcedLatte
            // 
            this.btnIcedLatte.Location = new System.Drawing.Point(135, 46);
            this.btnIcedLatte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIcedLatte.Name = "btnIcedLatte";
            this.btnIcedLatte.Size = new System.Drawing.Size(89, 52);
            this.btnIcedLatte.TabIndex = 1;
            this.btnIcedLatte.Text = "Select";
            this.btnIcedLatte.UseVisualStyleBackColor = true;
            this.btnIcedLatte.Click += new System.EventHandler(this.btnIcedLatte_Click);
            // 
            // btnGreenLatte
            // 
            this.btnGreenLatte.Location = new System.Drawing.Point(273, 90);
            this.btnGreenLatte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGreenLatte.Name = "btnGreenLatte";
            this.btnGreenLatte.Size = new System.Drawing.Size(89, 52);
            this.btnGreenLatte.TabIndex = 2;
            this.btnGreenLatte.Text = "Select";
            this.btnGreenLatte.UseVisualStyleBackColor = true;
            this.btnGreenLatte.Click += new System.EventHandler(this.btnGreenLatte_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(27, 446);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(497, 94);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.comboBoxCustomizations);
            this.panel1.Controls.Add(this.labelQuantityNumber);
            this.panel1.Controls.Add(this.btnDecreaseQuantity);
            this.panel1.Controls.Add(this.btnIncreaseQuantity);
            this.panel1.Controls.Add(this.LabelCustomizationsLeft);
            this.panel1.Controls.Add(this.LabelSizeOfDrinkLeft);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLargeCupSize);
            this.panel1.Controls.Add(this.btnMediumCupSize);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnIcedWater);
            this.panel1.Controls.Add(this.btnCoffee);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLatte);
            this.panel1.Controls.Add(this.btnGreenLatte);
            this.panel1.Controls.Add(this.btnIcedLatte);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 422);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxCustomizations
            // 
            this.comboBoxCustomizations.FormattingEnabled = true;
            this.comboBoxCustomizations.Items.AddRange(new object[] {
            "Soy Milk",
            "Almond Milk",
            "Oat Milk",
            "Whole Milk",
            "Non-Fat Milk",
            "Decaffeinated",
            "Espresso",
            "1 Sweet\'N Low",
            "1 Stevia",
            "1 Sugar",
            "Very Hot",
            "Less Hot",
            "Extra Ice",
            "No Ice"});
            this.comboBoxCustomizations.Location = new System.Drawing.Point(319, 318);
            this.comboBoxCustomizations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCustomizations.Name = "comboBoxCustomizations";
            this.comboBoxCustomizations.Size = new System.Drawing.Size(147, 28);
            this.comboBoxCustomizations.TabIndex = 21;
            this.comboBoxCustomizations.Text = "Select";
            // 
            // labelQuantityNumber
            // 
            this.labelQuantityNumber.AutoSize = true;
            this.labelQuantityNumber.Location = new System.Drawing.Point(273, 290);
            this.labelQuantityNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantityNumber.Name = "labelQuantityNumber";
            this.labelQuantityNumber.Size = new System.Drawing.Size(0, 20);
            this.labelQuantityNumber.TabIndex = 20;
            // 
            // btnDecreaseQuantity
            // 
            this.btnDecreaseQuantity.Location = new System.Drawing.Point(202, 304);
            this.btnDecreaseQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecreaseQuantity.Name = "btnDecreaseQuantity";
            this.btnDecreaseQuantity.Size = new System.Drawing.Size(56, 52);
            this.btnDecreaseQuantity.TabIndex = 19;
            this.btnDecreaseQuantity.Text = "-";
            this.btnDecreaseQuantity.UseVisualStyleBackColor = true;
            this.btnDecreaseQuantity.Click += new System.EventHandler(this.btnDecreaseQuantity_Click);
            // 
            // btnIncreaseQuantity
            // 
            this.btnIncreaseQuantity.Location = new System.Drawing.Point(202, 236);
            this.btnIncreaseQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncreaseQuantity.Name = "btnIncreaseQuantity";
            this.btnIncreaseQuantity.Size = new System.Drawing.Size(56, 52);
            this.btnIncreaseQuantity.TabIndex = 18;
            this.btnIncreaseQuantity.Text = "+";
            this.btnIncreaseQuantity.UseVisualStyleBackColor = true;
            this.btnIncreaseQuantity.Click += new System.EventHandler(this.btnIncreaseQuantity_Click);
            // 
            // LabelCustomizationsLeft
            // 
            this.LabelCustomizationsLeft.AutoSize = true;
            this.LabelCustomizationsLeft.Location = new System.Drawing.Point(335, 290);
            this.LabelCustomizationsLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCustomizationsLeft.Name = "LabelCustomizationsLeft";
            this.LabelCustomizationsLeft.Size = new System.Drawing.Size(110, 20);
            this.LabelCustomizationsLeft.TabIndex = 17;
            this.LabelCustomizationsLeft.Text = "Customizations";
            // 
            // LabelSizeOfDrinkLeft
            // 
            this.LabelSizeOfDrinkLeft.AutoSize = true;
            this.LabelSizeOfDrinkLeft.Location = new System.Drawing.Point(376, 252);
            this.LabelSizeOfDrinkLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSizeOfDrinkLeft.Name = "LabelSizeOfDrinkLeft";
            this.LabelSizeOfDrinkLeft.Size = new System.Drawing.Size(0, 20);
            this.LabelSizeOfDrinkLeft.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 15;
            // 
            // btnLargeCupSize
            // 
            this.btnLargeCupSize.Location = new System.Drawing.Point(21, 346);
            this.btnLargeCupSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLargeCupSize.Name = "btnLargeCupSize";
            this.btnLargeCupSize.Size = new System.Drawing.Size(89, 52);
            this.btnLargeCupSize.TabIndex = 14;
            this.btnLargeCupSize.Text = "L";
            this.btnLargeCupSize.UseVisualStyleBackColor = true;
            this.btnLargeCupSize.Click += new System.EventHandler(this.btnLargeCupSize_Click);
            // 
            // btnMediumCupSize
            // 
            this.btnMediumCupSize.Location = new System.Drawing.Point(21, 290);
            this.btnMediumCupSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMediumCupSize.Name = "btnMediumCupSize";
            this.btnMediumCupSize.Size = new System.Drawing.Size(89, 52);
            this.btnMediumCupSize.TabIndex = 13;
            this.btnMediumCupSize.Text = "M";
            this.btnMediumCupSize.UseVisualStyleBackColor = true;
            this.btnMediumCupSize.Click += new System.EventHandler(this.btnMediumCupSize_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Iced Water";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Coffee";
            // 
            // btnIcedWater
            // 
            this.btnIcedWater.Location = new System.Drawing.Point(135, 136);
            this.btnIcedWater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIcedWater.Name = "btnIcedWater";
            this.btnIcedWater.Size = new System.Drawing.Size(89, 52);
            this.btnIcedWater.TabIndex = 8;
            this.btnIcedWater.Text = "Select";
            this.btnIcedWater.UseVisualStyleBackColor = true;
            this.btnIcedWater.Click += new System.EventHandler(this.btnIcedWater_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Location = new System.Drawing.Point(21, 136);
            this.btnCoffee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(89, 52);
            this.btnCoffee.TabIndex = 6;
            this.btnCoffee.Text = "Select";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iced Matcha Green Tea Latte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iced Latte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Latte";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(571, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 422);
            this.panel2.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(357, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "0.00";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(347, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tax";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "SubTotal";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Customizations";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Size of Drink";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Drink Here You Got";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnPaymentOrderDrinkScreen
            // 
            this.btnPaymentOrderDrinkScreen.Location = new System.Drawing.Point(571, 446);
            this.btnPaymentOrderDrinkScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentOrderDrinkScreen.Name = "btnPaymentOrderDrinkScreen";
            this.btnPaymentOrderDrinkScreen.Size = new System.Drawing.Size(241, 94);
            this.btnPaymentOrderDrinkScreen.TabIndex = 6;
            this.btnPaymentOrderDrinkScreen.Text = "Proceed To Payment";
            this.btnPaymentOrderDrinkScreen.UseVisualStyleBackColor = true;
            this.btnPaymentOrderDrinkScreen.Click += new System.EventHandler(this.btnPaymentOrderDrinkScreen_Click);
            // 
            // btnCancelOrderDrinkScreen
            // 
            this.btnCancelOrderDrinkScreen.Location = new System.Drawing.Point(809, 446);
            this.btnCancelOrderDrinkScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelOrderDrinkScreen.Name = "btnCancelOrderDrinkScreen";
            this.btnCancelOrderDrinkScreen.Size = new System.Drawing.Size(241, 94);
            this.btnCancelOrderDrinkScreen.TabIndex = 7;
            this.btnCancelOrderDrinkScreen.Text = "Cancel";
            this.btnCancelOrderDrinkScreen.UseVisualStyleBackColor = true;
            this.btnCancelOrderDrinkScreen.Click += new System.EventHandler(this.btnCancelOrderDrinkScreen_Click);
            // 
            // OrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.btnCancelOrderDrinkScreen);
            this.Controls.Add(this.btnPaymentOrderDrinkScreen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10, 18, 10, 18);
            this.Name = "OrderDrink";
            this.Text = "OrderDrink";
            this.Load += new System.EventHandler(this.OrderDrink_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLatte;
        private Button btnIcedLatte;
        private Button btnGreenLatte;
        private Button btnAddToOrder;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnIcedWater;
        private Button btnCoffee;
        private Label label6;
        private Button btnLargeCupSize;
        private Button btnMediumCupSize;
        private Button button1;
        private Label label5;
        private Label labelQuantityNumber;
        private Button btnDecreaseQuantity;
        private Button btnIncreaseQuantity;
        private Label LabelCustomizationsLeft;
        private Label LabelSizeOfDrinkLeft;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnPaymentOrderDrinkScreen;
        private Button btnCancelOrderDrinkScreen;
        private ComboBox comboBoxCustomizations;
        private Label label10;
        private Label label11;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}