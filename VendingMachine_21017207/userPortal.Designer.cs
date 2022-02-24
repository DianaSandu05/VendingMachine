
namespace VendingMachine_21017207
{
    partial class userPortal
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
            this.buyBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoxStock = new System.Windows.Forms.TextBox();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBoxDueBalance = new System.Windows.Forms.RichTextBox();
            this.TxtBoxBalance = new System.Windows.Forms.RichTextBox();
            this.TxtBoxCoinInserted = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buyBtn.Location = new System.Drawing.Point(46, 212);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(106, 42);
            this.buyBtn.TabIndex = 0;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = false;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select an item to buy below";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ready for your order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.QuantityComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtBoxStock);
            this.groupBox2.Controls.Add(this.TxtBoxPrice);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 137);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Quantity:";
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.QuantityComboBox.Location = new System.Drawing.Point(13, 51);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(153, 37);
            this.QuantityComboBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // TxtBoxStock
            // 
            this.TxtBoxStock.Location = new System.Drawing.Point(395, 51);
            this.TxtBoxStock.Name = "TxtBoxStock";
            this.TxtBoxStock.Size = new System.Drawing.Size(114, 35);
            this.TxtBoxStock.TabIndex = 17;
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Location = new System.Drawing.Point(530, 51);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(114, 35);
            this.TxtBoxPrice.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aqua Carpatica",
            "Coke",
            "Water",
            "Snickers",
            "Pepsi",
            "Seven Up",
            "Diet Coke",
            "Mars",
            "Lion"});
            this.comboBox1.Location = new System.Drawing.Point(193, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 37);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "In Stock";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtBoxDueBalance);
            this.groupBox3.Controls.Add(this.TxtBoxBalance);
            this.groupBox3.Controls.Add(this.buyBtn);
            this.groupBox3.Controls.Add(this.TxtBoxCoinInserted);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(660, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 270);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Due balance";
            // 
            // TxtBoxDueBalance
            // 
            this.TxtBoxDueBalance.Location = new System.Drawing.Point(162, 94);
            this.TxtBoxDueBalance.Name = "TxtBoxDueBalance";
            this.TxtBoxDueBalance.Size = new System.Drawing.Size(191, 36);
            this.TxtBoxDueBalance.TabIndex = 8;
            this.TxtBoxDueBalance.Text = "";
            this.TxtBoxDueBalance.TextChanged += new System.EventHandler(this.TxtBoxDueBalance_TextChanged);
            // 
            // TxtBoxBalance
            // 
            this.TxtBoxBalance.Location = new System.Drawing.Point(162, 139);
            this.TxtBoxBalance.Name = "TxtBoxBalance";
            this.TxtBoxBalance.Size = new System.Drawing.Size(187, 36);
            this.TxtBoxBalance.TabIndex = 7;
            this.TxtBoxBalance.Text = "";
            this.TxtBoxBalance.TextChanged += new System.EventHandler(this.TxtBoxBalance_TextChanged);
            // 
            // TxtBoxCoinInserted
            // 
            this.TxtBoxCoinInserted.Location = new System.Drawing.Point(162, 47);
            this.TxtBoxCoinInserted.Name = "TxtBoxCoinInserted";
            this.TxtBoxCoinInserted.Size = new System.Drawing.Size(187, 36);
            this.TxtBoxCoinInserted.TabIndex = 6;
            this.TxtBoxCoinInserted.Text = "";
            this.TxtBoxCoinInserted.TextChanged += new System.EventHandler(this.TxtBoxCoinInserted_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert coins here: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coin entry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnMainMenu.Location = new System.Drawing.Point(6, 0);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(106, 42);
            this.BtnMainMenu.TabIndex = 14;
            this.BtnMainMenu.Text = "MainMenu";
            this.BtnMainMenu.UseVisualStyleBackColor = false;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.BtnMainMenu);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(-2, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1045, 41);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add Product";
            // 
            // userPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 321);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "userPortal";
            this.Text = "userPortal";
            this.Load += new System.EventHandler(this.userPortal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox TxtBoxDueBalance;
        private System.Windows.Forms.RichTextBox TxtBoxBalance;
        private System.Windows.Forms.RichTextBox TxtBoxCoinInserted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtBoxStock;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
    }
}