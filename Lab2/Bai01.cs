using System;
using System.IO;
using System.Windows.Forms;

namespace TestLab2
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input1.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            txtFileContent.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            string output = txtFileContent.Text.ToUpper();
            writer.WriteLine(output);
            writer.Close();
        }
    }
}
