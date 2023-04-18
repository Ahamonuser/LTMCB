namespace TestLab2
{
    partial class Bai01
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.AutoSize = true;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(12, 130);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(187, 91);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.AutoSize = true;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(12, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(187, 91);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtFileContent
            // 
            this.txtFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileContent.Location = new System.Drawing.Point(205, 12);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(767, 310);
            this.txtFileContent.TabIndex = 2;
            this.txtFileContent.Text = "";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 346);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Name = "Bai01";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox txtFileContent;
    }
}