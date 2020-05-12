using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasimiBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYasimiBul_Click(object sender, EventArgs e)
        {
            DateTime dtDogum = dtDogumTarihi.Value;
            DateTime dtSimdi = DateTime.Now;
            int yas = dtSimdi.Year - dtDogum.Year;

            txtYas.Text = yas.ToString();
            txtToplamGun.Text = (dtSimdi - dtDogum).TotalDays.ToString("#,###");
            txtToplamSaat.Text = (dtSimdi - dtDogum).TotalHours.ToString("#,###");
            txtToplamDakika.Text = (dtSimdi - dtDogum).TotalMinutes.ToString("#,###");

            tmrYasam.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtDogum = dtDogumTarihi.Value;
            DateTime dtSimdi = DateTime.Now;
            int yas = dtSimdi.Year - dtDogum.Year;

            txtYas.Text = yas.ToString();
            txtToplamGun.Text = (dtSimdi - dtDogum).TotalDays.ToString("#,###");
            txtToplamSaat.Text = (dtSimdi - dtDogum).TotalHours.ToString("#,###");
            txtToplamDakika.Text = (dtSimdi - dtDogum).TotalMinutes.ToString("#,###");
        }
    }
}
