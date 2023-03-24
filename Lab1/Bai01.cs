using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void FirstNumValue_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(FirstNumValue.Text, out txt);
            if (isnumber == false && FirstNumValue.Text != "" && FirstNumValue.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                FirstNumValue.Text = "";
            }
        }

        private void SecondNumValue_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(SecondNumValue.Text, out txt);
            if (isnumber == false && SecondNumValue.Text != "" && SecondNumValue.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                SecondNumValue.Text = "";
            }
        }

        private void bntCalculate_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            int NumValue1 = Int32.Parse(FirstNumValue.Text);
            int NumValue2 = Int32.Parse(SecondNumValue.Text);
            Sum = NumValue1 + NumValue2;
            SumValue.Text = Convert.ToString(Sum);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
