using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRatio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKisaKenar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(ch == 46 && txtKisaKenar.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch !=8 && ch!=44)
            {
                e.Handled = true;
            }
        }

        private void txtUzunKenar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtUzunKenar.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void txtKucukAci_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtKucukAci.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void txtBuyukAci_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtBuyukAci.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            double kisakenar, uzunkenar, altinOran;
            kisakenar = double.Parse(txtKisaKenar.Text);
            uzunkenar = double.Parse(txtUzunKenar.Text);
            /*
            kisakenar = Convert.ToDouble(txtKisaKenar.Text);
            uzunkenar = Convert.ToDouble(txtUzunKenar.Text);
            */
            altinOran = (1.618);

            if ((uzunkenar / kisakenar) == altinOran)
            {
                MessageBox.Show("Altın Dikdörtgendir.");
            }
            else
            {
                MessageBox.Show("Kenar uzunluklarını değiştirerek tekrar deneyiniz..!");
            }

            txtBuyukAci.Clear();
            txtKucukAci.Clear();
            txtKisaKenar.Clear();
            txtUzunKenar.Clear();
        }


        private void btnUcgen_Click(object sender, EventArgs e)
        {
            int kucukAci, buyukAci;
            kucukAci = Convert.ToInt32(txtKucukAci.Text);
            buyukAci = Convert.ToInt32(txtBuyukAci.Text);

            if (kucukAci == 36 && buyukAci == 72)
            {
                MessageBox.Show("Altın Üçgendir.");
            }
            else
            {
                MessageBox.Show("İç açılarını değiştirerek tekrar deneyiniz..!");
            }

            txtBuyukAci.Clear();
            txtKucukAci.Clear();
            txtKisaKenar.Clear();
            txtUzunKenar.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKisaKenar;
        }

    }
}
