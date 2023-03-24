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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void InputValue_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(InputValue.Text, out txt);
            if (isnumber == false && InputValue.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                InputValue.Text = "";
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            switch (Int32.Parse(InputValue.Text))
            {
                case 0:
                    Result.Text = "Không";
                    break;
                case 1:
                    Result.Text = "Một";
                    break;
                case 2:
                    Result.Text = "Hai";
                    break;
                case 3:
                    Result.Text = "Ba";
                    break;
                case 4:
                    Result.Text = "Bốn";
                    break;
                case 5:
                    Result.Text = "Năm";
                    break;
                case 6:
                    Result.Text = "Sáu";
                    break;
                case 7:
                    Result.Text = "Bảy";
                    break;
                case 8:
                    Result.Text = "Tám";
                    break;
                case 9:
                    Result.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                    InputValue.Text = "";
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InputValue.Text = "";
            Result.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
