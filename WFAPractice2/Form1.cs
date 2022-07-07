using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPractice2
{
    public partial class Form1 : Form
    {
        int saniye = 60, puan = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHarf_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int deger = rnd.Next(65, 91);

            do
            {
                deger = rnd.Next(65, 91);

            } while (deger == 74 || deger == 81 || deger == 87 || deger == 88);

            lblHarf.Text = Convert.ToChar(deger).ToString();

        }

        private void btnZaman_Click(object sender, EventArgs e)
        {
            if (lblHarf.Text != "")
            {
                timer1.Start();
                lblSure.Text = saniye.ToString();
                btnZaman.Enabled = false;

                txtIsim.Enabled = true;
                txtSehir.Enabled = true;
                txtHayvan.Enabled = true;
                txtBitki.Enabled = true;
                txtEsya.Enabled = true;
                txtUnlu.Enabled = true;
                btnKontrol.Enabled = true;
                btnHarf.Enabled = false;
                btnZaman.Enabled = false;
            }
            else
                MessageBox.Show("Lütfen Harf Seçiniz!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            lblSure.Text = saniye.ToString();

            if (saniye == 0)
            {
                timer1.Stop();
                btnZaman.Enabled = true;
                txtIsim.Enabled = false;
                txtSehir.Enabled = false;
                txtHayvan.Enabled = false;
                txtBitki.Enabled = false;
                txtEsya.Enabled = false;
                txtUnlu.Enabled = false;
                btnKontrol.Enabled = false;
                MessageBox.Show("Süre Doldu!" + Environment.NewLine + "Puanınız=0");
            }
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text.Substring(0, 1).ToUpper() == lblHarf.Text && txtIsim.Text.Length >= 2)
            {
                puan += 10;
            }
            if (txtSehir.Text.Substring(0, 1).ToUpper() == lblHarf.Text && txtSehir.Text.Length >= 3)
            {
                puan += 10;
            }
            if (txtHayvan.Text.Substring(0, 1).ToUpper() == lblHarf.Text && txtHayvan.Text.Length >= 2)
            {
                puan += 10;
            }
            if (txtBitki.Text.Substring(0, 1).ToUpper() == lblHarf.Text && txtBitki.Text.Length >= 3)
            {
                puan += 10;
            }
            if (txtEsya.Text.Substring(0, 1).ToUpper() == lblHarf.Text && txtEsya.Text.Length >= 3)
            {
                puan += 10;
            }
            if (txtUnlu.Text.Substring(0, 1).ToUpper() == lblHarf.Text && txtUnlu.Text.Length >= 5)
            {
                puan += 10;
                
                timer1.Stop();
                MessageBox.Show("Puanınız: " + puan);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIsim.Enabled = false;
            txtSehir.Enabled = false;
            txtHayvan.Enabled = false;
            txtBitki.Enabled = false;
            txtEsya.Enabled = false;
            txtUnlu.Enabled = false;
            btnKontrol.Enabled = false;
        }

    }
}
