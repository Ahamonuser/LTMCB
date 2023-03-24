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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            double NumValue1 = 0, NumValue2 = 0, NumValue3 = 0, Max = 0, Min = 0;
            NumValue1 = Convert.ToDouble(Num1Value.Text);
            NumValue2 = Convert.ToDouble(Num2Value.Text);
            NumValue3 = Convert.ToDouble(Num3Value.Text);
            Max = FindMaxValue(NumValue1, NumValue2, NumValue3);
            Min = FindMinValue(NumValue1, NumValue2, NumValue3);
            MaxValue.Text = Convert.ToString(Max);
            MinValue.Text = Convert.ToString(Min);
        }

        private double FindMaxValue(double value1, double value2, double value3)
        {
            double max = 0;
            max = value1;
            if (max < value2)
            {
                max = value2;
            }
            if (max < value3)
            {
                max = value3;
            }
            return max;
        }
        
        private double FindMinValue(double value1, double value2, double value3)
        {
            double min = 0;
            min = value1;
            if (min > value2)
            {
                min = value2;
            }
            if (min > value3)
            {
                min = value3;
            }
            return min;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Num1Value.Text = Num2Value.Text = Num3Value.Text = MaxValue.Text = MinValue.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Num1Value_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = Double.TryParse(Num1Value.Text, out txt);
            if (isnumber == false && Num1Value.Text != "" && Num1Value.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập đúng!", "Warning!");
                Num1Value.Text = "";
            }
        }

        private void Num2Value_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = Double.TryParse(Num2Value.Text, out txt);
            if (isnumber == false && Num2Value.Text != "" && Num2Value.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập đúng!", "Warning!");
                Num2Value.Text = "";
            }
        }

        private void Num3Value_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = Double.TryParse(Num3Value.Text, out txt);
            if (isnumber == false && Num3Value.Text != "" && Num3Value.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập đúng!", "Warning!");
                Num3Value.Text = "";
            }
        }
    }
}

