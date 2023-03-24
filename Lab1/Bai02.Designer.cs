namespace Lab01
{
    partial class Lab01_Bai02
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbNum3 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.Num1Value = new System.Windows.Forms.TextBox();
            this.MinValue = new System.Windows.Forms.TextBox();
            this.Num3Value = new System.Windows.Forms.TextBox();
            this.Num2Value = new System.Windows.Forms.TextBox();
            this.MaxValue = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(114, 38);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(69, 20);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Số thứ 1";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(114, 79);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(69, 20);
            this.lbNum2.TabIndex = 1;
            this.lbNum2.Text = "Số thứ 2";
            // 
            // lbNum3
            // 
            this.lbNum3.AutoSize = true;
            this.lbNum3.Location = new System.Drawing.Point(114, 121);
            this.lbNum3.Name = "lbNum3";
            this.lbNum3.Size = new System.Drawing.Size(69, 20);
            this.lbNum3.TabIndex = 2;
            this.lbNum3.Text = "Số thứ 3";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(56, 204);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(96, 20);
            this.lbMin.TabIndex = 3;
            this.lbMin.Text = "Số nhỏ nhất";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(291, 204);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(90, 20);
            this.lbMax.TabIndex = 4;
            this.lbMax.Text = "Số lớn nhất";
            // 
            // Num1Value
            // 
            this.Num1Value.Location = new System.Drawing.Point(196, 32);
            this.Num1Value.Name = "Num1Value";
            this.Num1Value.Size = new System.Drawing.Size(100, 26);
            this.Num1Value.TabIndex = 5;
            this.Num1Value.TextChanged += new System.EventHandler(this.Num1Value_TextChanged);
            // 
            // MinValue
            // 
            this.MinValue.Location = new System.Drawing.Point(158, 198);
            this.MinValue.Name = "MinValue";
            this.MinValue.ReadOnly = true;
            this.MinValue.Size = new System.Drawing.Size(100, 26);
            this.MinValue.TabIndex = 6;
            // 
            // Num3Value
            // 
            this.Num3Value.Location = new System.Drawing.Point(196, 115);
            this.Num3Value.Name = "Num3Value";
            this.Num3Value.Size = new System.Drawing.Size(100, 26);
            this.Num3Value.TabIndex = 7;
            this.Num3Value.TextChanged += new System.EventHandler(this.Num3Value_TextChanged);
            // 
            // Num2Value
            // 
            this.Num2Value.Location = new System.Drawing.Point(196, 73);
            this.Num2Value.Name = "Num2Value";
            this.Num2Value.Size = new System.Drawing.Size(100, 26);
            this.Num2Value.TabIndex = 8;
            this.Num2Value.TextChanged += new System.EventHandler(this.Num2Value_TextChanged);
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(387, 198);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.ReadOnly = true;
            this.MaxValue.Size = new System.Drawing.Size(100, 26);
            this.MaxValue.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.AutoSize = true;
            this.btnFind.Location = new System.Drawing.Point(413, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 30);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(413, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(413, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab01_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 265);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.Num2Value);
            this.Controls.Add(this.Num3Value);
            this.Controls.Add(this.MinValue);
            this.Controls.Add(this.Num1Value);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbNum3);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Name = "Lab01_Bai02";
            this.Text = "Bài 2: Tìm số lớn nhất, số nhỏ nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbNum3;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.TextBox Num1Value;
        private System.Windows.Forms.TextBox MinValue;
        private System.Windows.Forms.TextBox Num3Value;
        private System.Windows.Forms.TextBox Num2Value;
        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}