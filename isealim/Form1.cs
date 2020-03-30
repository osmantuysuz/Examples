using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isealim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = "", soyad = "", adres = "", telefon = "", aciklama = "", egitimSeviyesi = "";
            int tarih;
            decimal tc;
            int bugun = int.Parse(DateTime.Now.Year.ToString());

            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            telefon = txtTelefon.Text;

            if (ad!="" & soyad!="" & telefon!="" & txtTc.Text!="")
            {
                tc = Convert.ToDecimal(txtTc.Text);
                aciklama = txtAciklama.Text;
                adres = txtAdres.Text;
                tarih = int.Parse(dtpTarih.Value.Year.ToString());
                egitimSeviyesi = cbEgitim.SelectedItem.ToString();
                if (bugun - tarih>=20 && bugun<=40)
                {
                    if (rbErkek.Checked)
                    {
                        if (rbYapildi.Checked || rbTecilli.Checked)
                        {
                            if (((chkAlmanca.Checked) || (chkIngilizce.Checked && chkFransizca.Checked)) && ((chkVeriTabani.Checked && chkYazilim.Checked) || chkSistem.Checked) && (egitimSeviyesi=="Doktora" || egitimSeviyesi=="Lisans"))
                            {
                                MessageBox.Show("Yeterli Düzeydesiniz, İşe Alınabilirsiniz..");
                            }
                            else
                            {
                                MessageBox.Show("Yeterli Düzeyde Değilsiniz Fakat Değerlendirileceksiniz..");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Askerlik Hizmeti Tamamlanmamış!");
                        }
                    }
                    else if (rbKiz.Checked)
                    {
                        if (((chkArapca.Checked) || (chkRusca.Checked && chkFransizca.Checked)) && ((chkOffice.Checked && chkSistem.Checked) || chkWebTasarim.Checked) && (egitimSeviyesi == "Lise" || egitimSeviyesi != "Doktora"))
                        {
                            MessageBox.Show("Yeterli Düzeydesiniz, İşe Alınabilirsiniz..");
                        }
                        else
                        {
                            MessageBox.Show("Yeterli Düzeyde Değilsiniz Fakat Değerlendirileceksiniz..");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir Cinsiyet Seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Yaş aralığı 20 ile 40 olmalı.");
                }
            }
            else
            {
                MessageBox.Show("Gerekli Kısımlar Seçilmelidir! (Ad, Soyad, Telefon, Tc)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbAskerlik.Visible = false;
        }

        private void rbKiz_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Visible = false;
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Visible = true;
        }
    }
}
