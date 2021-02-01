namespace Invoice_Total
{
    partial class Invoice_Total
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
            this.Calculate_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Sub_Total_TextBox = new System.Windows.Forms.TextBox();
            this.Sub_Total = new System.Windows.Forms.Label();
            this.Discount_Percent = new System.Windows.Forms.Label();
            this.Disocunt_Percent_TextBox = new System.Windows.Forms.TextBox();
            this.DiscountAmount_TextBox = new System.Windows.Forms.TextBox();
            this.Discount_Amount = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Total_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculate_Btn
            // 
            this.Calculate_Btn.Location = new System.Drawing.Point(179, 342);
            this.Calculate_Btn.Name = "Calculate_Btn";
            this.Calculate_Btn.Size = new System.Drawing.Size(123, 41);
            this.Calculate_Btn.TabIndex = 0;
            this.Calculate_Btn.Text = "Calculate";
            this.Calculate_Btn.UseVisualStyleBackColor = true;
            this.Calculate_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Location = new System.Drawing.Point(443, 342);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(123, 41);
            this.Exit_Btn.TabIndex = 1;
            this.Exit_Btn.Text = "Exit";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sub_Total_TextBox
            // 
            this.Sub_Total_TextBox.Location = new System.Drawing.Point(403, 84);
            this.Sub_Total_TextBox.Name = "Sub_Total_TextBox";
            this.Sub_Total_TextBox.Size = new System.Drawing.Size(185, 22);
            this.Sub_Total_TextBox.TabIndex = 1;
            // 
            // Sub_Total
            // 
            this.Sub_Total.AutoSize = true;
            this.Sub_Total.Location = new System.Drawing.Point(176, 87);
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.Size = new System.Drawing.Size(73, 17);
            this.Sub_Total.TabIndex = 0;
            this.Sub_Total.Text = "Sub Total:";
            this.Sub_Total.Click += new System.EventHandler(this.label1_Click);
            // 
            // Discount_Percent
            // 
            this.Discount_Percent.AutoSize = true;
            this.Discount_Percent.Location = new System.Drawing.Point(176, 139);
            this.Discount_Percent.Name = "Discount_Percent";
            this.Discount_Percent.Size = new System.Drawing.Size(120, 17);
            this.Discount_Percent.TabIndex = 2;
            this.Discount_Percent.Text = "Discount Percent:";
            this.Discount_Percent.Click += new System.EventHandler(this.label2_Click);
            // 
            // Disocunt_Percent_TextBox
            // 
            this.Disocunt_Percent_TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Disocunt_Percent_TextBox.Location = new System.Drawing.Point(403, 136);
            this.Disocunt_Percent_TextBox.Name = "Disocunt_Percent_TextBox";
            this.Disocunt_Percent_TextBox.ReadOnly = true;
            this.Disocunt_Percent_TextBox.Size = new System.Drawing.Size(185, 22);
            this.Disocunt_Percent_TextBox.TabIndex = 3;
            this.Disocunt_Percent_TextBox.TabStop = false;
            this.Disocunt_Percent_TextBox.Text = "10.0%";
            // 
            // DiscountAmount_TextBox
            // 
            this.DiscountAmount_TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DiscountAmount_TextBox.Location = new System.Drawing.Point(403, 189);
            this.DiscountAmount_TextBox.Name = "DiscountAmount_TextBox";
            this.DiscountAmount_TextBox.ReadOnly = true;
            this.DiscountAmount_TextBox.Size = new System.Drawing.Size(185, 22);
            this.DiscountAmount_TextBox.TabIndex = 5;
            this.DiscountAmount_TextBox.TabStop = false;
            this.DiscountAmount_TextBox.TextChanged += new System.EventHandler(this.DiscountAmount_TextBox_TextChanged);
            // 
            // Discount_Amount
            // 
            this.Discount_Amount.AutoSize = true;
            this.Discount_Amount.Location = new System.Drawing.Point(176, 192);
            this.Discount_Amount.Name = "Discount_Amount";
            this.Discount_Amount.Size = new System.Drawing.Size(119, 17);
            this.Discount_Amount.TabIndex = 7;
            this.Discount_Amount.Text = "Discount Amount:";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(176, 251);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 17);
            this.Total.TabIndex = 8;
            this.Total.Text = "Total:";
            // 
            // Total_TextBox
            // 
            this.Total_TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Total_TextBox.Location = new System.Drawing.Point(403, 248);
            this.Total_TextBox.Name = "Total_TextBox";
            this.Total_TextBox.ReadOnly = true;
            this.Total_TextBox.Size = new System.Drawing.Size(185, 22);
            this.Total_TextBox.TabIndex = 5;
            this.Total_TextBox.TabStop = false;
            // 
            // Invoice_Total
            // 
            this.AcceptButton = this.Calculate_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit_Btn;
            this.ClientSize = new System.Drawing.Size(751, 484);
            this.Controls.Add(this.Total_TextBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Discount_Amount);
            this.Controls.Add(this.DiscountAmount_TextBox);
            this.Controls.Add(this.Disocunt_Percent_TextBox);
            this.Controls.Add(this.Discount_Percent);
            this.Controls.Add(this.Sub_Total);
            this.Controls.Add(this.Sub_Total_TextBox);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.Calculate_Btn);
            this.Name = "Invoice_Total";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_Btn;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.TextBox Sub_Total_TextBox;
        private System.Windows.Forms.Label Sub_Total;
        private System.Windows.Forms.Label Discount_Percent;
        private System.Windows.Forms.TextBox Disocunt_Percent_TextBox;
        private System.Windows.Forms.TextBox DiscountAmount_TextBox;
        private System.Windows.Forms.Label Discount_Amount;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox Total_TextBox;
    }
}

