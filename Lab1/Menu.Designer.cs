namespace Lab01
{
    partial class Lab01
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
            this.Bai01 = new System.Windows.Forms.Button();
            this.Bai02 = new System.Windows.Forms.Button();
            this.Bai03 = new System.Windows.Forms.Button();
            this.Bai04 = new System.Windows.Forms.Button();
            this.Bai05 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bai01
            // 
            this.Bai01.Location = new System.Drawing.Point(87, 52);
            this.Bai01.Name = "Bai01";
            this.Bai01.Size = new System.Drawing.Size(309, 63);
            this.Bai01.TabIndex = 0;
            this.Bai01.Text = "Bài 1";
            this.Bai01.UseVisualStyleBackColor = true;
            this.Bai01.Click += new System.EventHandler(this.Bai01_Click);
            // 
            // Bai02
            // 
            this.Bai02.Location = new System.Drawing.Point(479, 52);
            this.Bai02.Name = "Bai02";
            this.Bai02.Size = new System.Drawing.Size(309, 63);
            this.Bai02.TabIndex = 1;
            this.Bai02.Text = "Bài 2";
            this.Bai02.UseVisualStyleBackColor = true;
            this.Bai02.Click += new System.EventHandler(this.Bai02_Click);
            // 
            // Bai03
            // 
            this.Bai03.Location = new System.Drawing.Point(87, 177);
            this.Bai03.Name = "Bai03";
            this.Bai03.Size = new System.Drawing.Size(309, 63);
            this.Bai03.TabIndex = 2;
            this.Bai03.Text = "Bài 3";
            this.Bai03.UseVisualStyleBackColor = true;
            this.Bai03.Click += new System.EventHandler(this.Bai03_Click);
            // 
            // Bai04
            // 
            this.Bai04.Location = new System.Drawing.Point(479, 177);
            this.Bai04.Name = "Bai04";
            this.Bai04.Size = new System.Drawing.Size(309, 63);
            this.Bai04.TabIndex = 3;
            this.Bai04.Text = "Bài 4";
            this.Bai04.UseVisualStyleBackColor = true;
            this.Bai04.Click += new System.EventHandler(this.Bai04_Click);
            // 
            // Bai05
            // 
            this.Bai05.Location = new System.Drawing.Point(87, 308);
            this.Bai05.Name = "Bai05";
            this.Bai05.Size = new System.Drawing.Size(309, 63);
            this.Bai05.TabIndex = 4;
            this.Bai05.Text = "Bài 5";
            this.Bai05.UseVisualStyleBackColor = true;
            this.Bai05.Click += new System.EventHandler(this.Bai05_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Lab01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 407);
            this.Controls.Add(this.Bai05);
            this.Controls.Add(this.Bai04);
            this.Controls.Add(this.Bai03);
            this.Controls.Add(this.Bai02);
            this.Controls.Add(this.Bai01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Lab01";
            this.Text = "Lab01";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai01;
        private System.Windows.Forms.Button Bai02;
        private System.Windows.Forms.Button Bai03;
        private System.Windows.Forms.Button Bai04;
        private System.Windows.Forms.Button Bai05;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

