namespace Lab01
{
    partial class Lab01_Bai01
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
            this.lbFirstNum = new System.Windows.Forms.Label();
            this.lbSecondNum = new System.Windows.Forms.Label();
            this.FirstNumValue = new System.Windows.Forms.TextBox();
            this.SecondNumValue = new System.Windows.Forms.TextBox();
            this.SumValue = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.bntCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirstNum
            // 
            this.lbFirstNum.AutoSize = true;
            this.lbFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstNum.Location = new System.Drawing.Point(132, 56);
            this.lbFirstNum.Name = "lbFirstNum";
            this.lbFirstNum.Size = new System.Drawing.Size(100, 29);
            this.lbFirstNum.TabIndex = 0;
            this.lbFirstNum.Text = "Số thứ 1";
            // 
            // lbSecondNum
            // 
            this.lbSecondNum.AutoSize = true;
            this.lbSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondNum.Location = new System.Drawing.Point(132, 120);
            this.lbSecondNum.Name = "lbSecondNum";
            this.lbSecondNum.Size = new System.Drawing.Size(100, 29);
            this.lbSecondNum.TabIndex = 1;
            this.lbSecondNum.Text = "Số thứ 2";
            // 
            // FirstNumValue
            // 
            this.FirstNumValue.Location = new System.Drawing.Point(303, 56);
            this.FirstNumValue.Name = "FirstNumValue";
            this.FirstNumValue.Size = new System.Drawing.Size(167, 26);
            this.FirstNumValue.TabIndex = 2;
            this.FirstNumValue.TextChanged += new System.EventHandler(this.FirstNumValue_TextChanged);
            // 
            // SecondNumValue
            // 
            this.SecondNumValue.Location = new System.Drawing.Point(303, 124);
            this.SecondNumValue.Name = "SecondNumValue";
            this.SecondNumValue.Size = new System.Drawing.Size(167, 26);
            this.SecondNumValue.TabIndex = 3;
            this.SecondNumValue.TextChanged += new System.EventHandler(this.SecondNumValue_TextChanged);
            // 
            // SumValue
            // 
            this.SumValue.Location = new System.Drawing.Point(303, 190);
            this.SumValue.Name = "SumValue";
            this.SumValue.ReadOnly = true;
            this.SumValue.Size = new System.Drawing.Size(167, 26);
            this.SumValue.TabIndex = 5;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(132, 186);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(95, 29);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "Kết quả";
            // 
            // bntCalculate
            // 
            this.bntCalculate.AutoSize = true;
            this.bntCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalculate.Location = new System.Drawing.Point(330, 242);
            this.bntCalculate.Name = "bntCalculate";
            this.bntCalculate.Size = new System.Drawing.Size(107, 41);
            this.bntCalculate.TabIndex = 6;
            this.bntCalculate.Text = "Tính";
            this.bntCalculate.UseVisualStyleBackColor = true;
            this.bntCalculate.Click += new System.EventHandler(this.bntCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(137, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 39);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab01_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 323);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bntCalculate);
            this.Controls.Add(this.SumValue);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.SecondNumValue);
            this.Controls.Add(this.FirstNumValue);
            this.Controls.Add(this.lbSecondNum);
            this.Controls.Add(this.lbFirstNum);
            this.Name = "Lab01_Bai01";
            this.Text = "Bài 1: Tính tổng 2 số nguyên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstNum;
        private System.Windows.Forms.Label lbSecondNum;
        private System.Windows.Forms.TextBox FirstNumValue;
        private System.Windows.Forms.TextBox SecondNumValue;
        private System.Windows.Forms.TextBox SumValue;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button bntCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}