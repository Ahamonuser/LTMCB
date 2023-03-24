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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void ValueA_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(ValueA.Text, out txt);
            if (isnumber == false && ValueA.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                ValueA.Text = "";
            }
        }

        private void ValueB_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(ValueB.Text, out txt);
            if (isnumber == false && ValueB.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                ValueB.Text = "";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int factA = 0, factB = 0, sumA = 0, sumB = 0;
            int valueA = Convert.ToInt32(ValueA.Text);
            int valueB = Convert.ToInt32(ValueB.Text);
            double sumExpon = 0;
            factA = CalculateFactorial(valueA);
            factB = CalculateFactorial(valueB);
            sumA = CalculateSum(valueA);
            sumB = CalculateSum(valueB);
            sumExpon = CalculateSumOfExponentiation(valueA, valueB);
            txtResult.Text = "A! = " + String.Format("{0:#,##0.##}", factA) +
                             "\r\nB! = " + String.Format("{0:#,##0.##}", factB) +
                             "\r\nS1 = 1 + 2 + 3 + 4 + ... + A = " + String.Format("{0:#,##0.##}", sumA) +
                             "\r\nS2 = 1 + 2 + 3 + 4 + ... + B = " + String.Format("{0:#,##0.##}", sumB) +
                             "\r\nS3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + String.Format("{0:#,##0.##}", sumExpon);
        }
        int CalculateFactorial(int number)
        {
            int fact = 1;
            for(int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        int CalculateSum(int number)
        {
            int sum = 0;
            for(int i = 1; i <= number;i++)
            {
                sum += i;
            }
            return sum;
        }

        double CalculateSumOfExponentiation(int numberA, int numberB)
        {
            double sum_expon = 0;
            for( int i = 1; i <= numberB; i++)
            {
                sum_expon += Math.Pow(numberA, i);
            }
            return sum_expon;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ValueA.Text = "";
            ValueB.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
