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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void ForeignCurrencyValue_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = Double.TryParse(ForeignCurrencyValue.Text, out txt);
            if (isnumber == false && ForeignCurrencyValue.Text != "")
            {
                MessageBox.Show("Vui lòng nhập đúng!", "Warning!");
                ForeignCurrencyValue.Text = "";
            }
        }

        private void Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Currency.SelectedIndex)
            {
                case 0:
                    ExchangeRateInfo.Text = "1 USD = 22,775 VNĐ";
                    break;
                case 1:
                    ExchangeRateInfo.Text = "1 EUR = 28,132 VNĐ";
                    break;
                case 2:
                    ExchangeRateInfo.Text = "1 GBP = 31,538 VNĐ";
                    break;
                case 3:
                    ExchangeRateInfo.Text = "1 SGD = 17,286 VNĐ";
                    break;
                case 4:
                    ExchangeRateInfo.Text = "1 JPY = 214 VNĐ";
                    break;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double foreigncurrencyvalue = Convert.ToDouble(ForeignCurrencyValue.Text);
            double vietnamcurrencyvalue = 0;
            switch (Currency.SelectedIndex)
            {
                case 0:
                    vietnamcurrencyvalue = foreigncurrencyvalue * 22775;
                    break;
                case 1:
                    vietnamcurrencyvalue = foreigncurrencyvalue * 28132;
                    break;
                case 2:
                    vietnamcurrencyvalue = foreigncurrencyvalue * 31538;
                    break;
                case 3:
                    vietnamcurrencyvalue = foreigncurrencyvalue * 17286;
                    break;
                case 4:
                    vietnamcurrencyvalue = foreigncurrencyvalue * 214;
                    break;
            }
            VietNamCurrencyValue.Text = String.Format("{0:#,##0.##}", vietnamcurrencyvalue);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
