namespace Lab01
{
    partial class Lab01_Bai04
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
            this.lbForeignCurrency = new System.Windows.Forms.Label();
            this.lbVietNamCurrency = new System.Windows.Forms.Label();
            this.lbExchangeRate = new System.Windows.Forms.Label();
            this.ForeignCurrencyValue = new System.Windows.Forms.TextBox();
            this.VietNamCurrencyValue = new System.Windows.Forms.TextBox();
            this.ExchangeRateInfo = new System.Windows.Forms.TextBox();
            this.Currency = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lbConverter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbForeignCurrency
            // 
            this.lbForeignCurrency.AutoSize = true;
            this.lbForeignCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForeignCurrency.Location = new System.Drawing.Point(48, 76);
            this.lbForeignCurrency.Name = "lbForeignCurrency";
            this.lbForeignCurrency.Size = new System.Drawing.Size(172, 29);
            this.lbForeignCurrency.TabIndex = 0;
            this.lbForeignCurrency.Text = "Số tiền cần đổi";
            // 
            // lbVietNamCurrency
            // 
            this.lbVietNamCurrency.AutoSize = true;
            this.lbVietNamCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVietNamCurrency.Location = new System.Drawing.Point(48, 215);
            this.lbVietNamCurrency.Name = "lbVietNamCurrency";
            this.lbVietNamCurrency.Size = new System.Drawing.Size(161, 29);
            this.lbVietNamCurrency.TabIndex = 1;
            this.lbVietNamCurrency.Text = "Số tiền đã đổi";
            // 
            // lbExchangeRate
            // 
            this.lbExchangeRate.AutoSize = true;
            this.lbExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExchangeRate.Location = new System.Drawing.Point(48, 299);
            this.lbExchangeRate.Name = "lbExchangeRate";
            this.lbExchangeRate.Size = new System.Drawing.Size(163, 29);
            this.lbExchangeRate.TabIndex = 2;
            this.lbExchangeRate.Text = "Tỷ giá quy đổi";
            // 
            // ForeignCurrencyValue
            // 
            this.ForeignCurrencyValue.Location = new System.Drawing.Point(244, 76);
            this.ForeignCurrencyValue.Name = "ForeignCurrencyValue";
            this.ForeignCurrencyValue.Size = new System.Drawing.Size(186, 26);
            this.ForeignCurrencyValue.TabIndex = 3;
            this.ForeignCurrencyValue.TextChanged += new System.EventHandler(this.ForeignCurrencyValue_TextChanged);
            // 
            // VietNamCurrencyValue
            // 
            this.VietNamCurrencyValue.Location = new System.Drawing.Point(244, 215);
            this.VietNamCurrencyValue.Name = "VietNamCurrencyValue";
            this.VietNamCurrencyValue.ReadOnly = true;
            this.VietNamCurrencyValue.Size = new System.Drawing.Size(186, 26);
            this.VietNamCurrencyValue.TabIndex = 4;
            // 
            // ExchangeRateInfo
            // 
            this.ExchangeRateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeRateInfo.Location = new System.Drawing.Point(244, 299);
            this.ExchangeRateInfo.Name = "ExchangeRateInfo";
            this.ExchangeRateInfo.ReadOnly = true;
            this.ExchangeRateInfo.Size = new System.Drawing.Size(186, 26);
            this.ExchangeRateInfo.TabIndex = 5;
            // 
            // Currency
            // 
            this.Currency.FormattingEnabled = true;
            this.Currency.Items.AddRange(new object[] {
            "USD (Đô la Mỹ)",
            "EUR (Euro)",
            "GBP (Bảng Anh)",
            "SGD (Đô la Singapore)",
            "JPY (Yên Nhật)"});
            this.Currency.Location = new System.Drawing.Point(473, 74);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(171, 28);
            this.Currency.TabIndex = 7;
            this.Currency.SelectedIndexChanged += new System.EventHandler(this.Currency_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSize = true;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(53, 137);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(377, 39);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lbConverter
            // 
            this.lbConverter.AutoSize = true;
            this.lbConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConverter.Location = new System.Drawing.Point(46, 22);
            this.lbConverter.Name = "lbConverter";
            this.lbConverter.Size = new System.Drawing.Size(292, 37);
            this.lbConverter.TabIndex = 9;
            this.lbConverter.Text = "Chuyển đổi tiền tệ";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(473, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 70);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab01_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 388);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbConverter);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.ExchangeRateInfo);
            this.Controls.Add(this.VietNamCurrencyValue);
            this.Controls.Add(this.ForeignCurrencyValue);
            this.Controls.Add(this.lbExchangeRate);
            this.Controls.Add(this.lbVietNamCurrency);
            this.Controls.Add(this.lbForeignCurrency);
            this.Name = "Lab01_Bai04";
            this.Text = "Bài 4: Đổi tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbForeignCurrency;
        private System.Windows.Forms.Label lbVietNamCurrency;
        private System.Windows.Forms.Label lbExchangeRate;
        private System.Windows.Forms.TextBox ForeignCurrencyValue;
        private System.Windows.Forms.TextBox VietNamCurrencyValue;
        private System.Windows.Forms.TextBox ExchangeRateInfo;
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lbConverter;
        private System.Windows.Forms.Button btnExit;
    }
}