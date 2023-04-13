using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonu
{
    public partial class Girisekrani : Form
    {

        public Girisekrani()
        {
            InitializeComponent();
        }

        




        private void Form3_Load(object sender, EventArgs e)
        {
            sifre.PasswordChar = '*';
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (ad.Text == string.Empty || sifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adını ve şifreni gir.", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                string kulad = ad.Text;

                string kulsi = sifre.Text;



                


                Kullanicigirisi Giris = new Kullanicigirisi();

                Giris.girisyap(kulad, kulsi,DateTime.Now, this);

            }


        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


