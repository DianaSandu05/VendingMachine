
namespace VendingMachine_21017207
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
            this.buyBtn = new System.Windows.Forms.Button();
            this.machineMng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(166, 182);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(137, 63);
            this.buyBtn.TabIndex = 0;
            this.buyBtn.Text = "Buy Button";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // machineMng
            // 
            this.machineMng.Location = new System.Drawing.Point(511, 183);
            this.machineMng.Name = "machineMng";
            this.machineMng.Size = new System.Drawing.Size(157, 62);
            this.machineMng.TabIndex = 1;
            this.machineMng.Text = "Machine management";
            this.machineMng.UseVisualStyleBackColor = true;
            this.machineMng.Click += new System.EventHandler(this.machineMng_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select one of the following options: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machineMng);
            this.Controls.Add(this.buyBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button machineMng;
        private System.Windows.Forms.Label label1;
    }
}

