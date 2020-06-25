using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum_3_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Instance
            Bilgisayar laptop = new Bilgisayar();
            laptop.Marka = txtMarka.Text;
            laptop.Model = txtModel.Text;
            laptop.EkranBoyutu = Convert.ToDouble(txtEkranBoyutu.Text);
            laptop.EkranKarti = txtEkranKarti.Text;
            laptop.IsletimSistemi = txtIsletimSistemi.Text;
            laptop.Islemci = txtIslemci.Text;
            laptop.Ram = Convert.ToInt32(txtRam.Text);
            laptop.HdKapasite = Convert.ToInt32(txtHdKapasite.Text);
            laptop.Fiyat = nudFiyat.Value;
            
            listBox1.Items.Add($"{laptop.Marka} {laptop.Model} {laptop.EkranBoyutu} {laptop.EkranKarti} {laptop.EkranKarti} {laptop.IsletimSistemi} {laptop.Islemci} {laptop.Ram} {laptop.HdKapasite} {laptop.KdvDahilFiyat}");

        }
    }
}
