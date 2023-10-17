using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            float ortalama =
            ortalama = Convert.ToSingle(txtNot.Text);
            if (ortalama < 0)
            {
                lblSonuc.Text="Negatif sayı girmeyin.";
            }
            else if (ortalama < 50)
            {
                lblSonuc.Text = "KALDINIZ.";
            }
            else if (ortalama < 70)
            {
                lblSonuc.Text = "GEÇTİNİZ.";
            }
            else if (ortalama < 85)
            {
                lblSonuc.Text = "TEŞEKKÜR BELGESİ ALDINIZ.";
            }
            else if(ortalama < 100)
            {
                lblSonuc.Text = "TAKDİR BELGESİ ALDINIZ.";
            }
            else
            {
                lblSonuc.Text = "100'den küçük sayı yazın.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = " ";
        }
    }
}
