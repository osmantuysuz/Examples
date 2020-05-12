using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal decFiyat = nmDomatesFiyat.Value * nmDomatesKilo.Value;
            nmDomatesToplamKilo.Value += nmDomatesKilo.Value;
            nmToplamFiyat.Value += decFiyat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal decFiyat = nmBiberFiyat.Value * nmBiberKilo.Value;
            nmBiberToplamKilo.Value += nmBiberKilo.Value;
            nmToplamFiyat.Value += decFiyat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal decFiyat = nmPatlicanFiyat.Value * nmPatlicanKilo.Value;
            nmPatlicanToplamKilo.Value += nmPatlicanKilo.Value; 
            nmToplamFiyat.Value += decFiyat;
        }

        private void yeniMusteri_Click(object sender, EventArgs e)
        {
            nmDomatesKilo.Value = 0;
            nmBiberKilo.Value = 0;
            nmPatlicanKilo.Value = 0;

            nmToplamFiyat.Value = 0;
            
            nmDomatesToplamKilo.Value = 0;
            nmBiberToplamKilo.Value = 0;
            nmPatlicanToplamKilo.Value = 0;                      
        }
    }
}
