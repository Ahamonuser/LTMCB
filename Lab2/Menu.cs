using System;
using System.Windows.Forms;

namespace TestLab2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            bai01.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            bai02.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();
            bai03.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai04 bai04 = new Bai04();
            bai04.ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bai05 bai05 = new Bai05();
            bai05.ShowDialog();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            Bai06 bai06 = new Bai06();
            bai06.ShowDialog();
        }
    }
}
