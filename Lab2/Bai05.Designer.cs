namespace TestLab2
{
    partial class Bai05
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
            this.btnZip = new System.Windows.Forms.Button();
            this.btnUnzip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZip
            // 
            this.btnZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZip.Location = new System.Drawing.Point(172, 177);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(203, 105);
            this.btnZip.TabIndex = 0;
            this.btnZip.Text = "Zip";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnUnzip
            // 
            this.btnUnzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnzip.Location = new System.Drawing.Point(411, 177);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(203, 105);
            this.btnUnzip.TabIndex = 2;
            this.btnUnzip.Text = "Unzip";
            this.btnUnzip.UseVisualStyleBackColor = true;
            this.btnUnzip.Click += new System.EventHandler(this.btnUnzip_Click);
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnzip);
            this.Controls.Add(this.btnZip);
            this.Name = "Bai05";
            this.Text = "Bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btnUnzip;
    }
}