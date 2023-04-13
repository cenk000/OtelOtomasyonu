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
    public partial class Form2 : Form
    {
        int a = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            OdaListesi odalar = new OdaListesi();
            
           
            odalar.Show();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ekle ekle = new Ekle();
            ekle.Show();
        }

        private void personel_Click(object sender, EventArgs e)
        {
            OdaListesi men = new OdaListesi();
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            YöneticiPaneli YP = new YöneticiPaneli();
            
            
            YP.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YH yh = new YH();
            yh.Show();
        }

        

        public void toolStripButton1_Click(object sender, EventArgs e)
        {
           Personel personel = new Personel();
            
            personel.Name = "per";
            if (Application.OpenForms["per"] == null)
            {
                personel.MdiParent = this;
                personel.Show();
            }
        }

        

        private void MusList_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.Name = "ekle";
            if (Application.OpenForms["ekle"] == null)
            {
                ekle.MdiParent = this;
                ekle.Show();
            }
        }

        private void OdaK_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.Name = "oda";
            if (Application.OpenForms["oda"] == null)
            {
                odalar.MdiParent = this;
                odalar.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            YH yh = new YH();
            yh.Name = "yh";
            if (Application.OpenForms["yh"] == null)
            {
                yh.MdiParent = this;
                yh.Show();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            YöneticiPaneli YP = new YöneticiPaneli();
            YP.Name = "yp";
            if (Application.OpenForms["yp"] == null)
            {
                YP.MdiParent = this;
                YP.Show();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            time.Text = DateTime.Now.ToLongDateString();
            time1.Text = DateTime.Now.ToLongTimeString();
            
                
            
        }

        private void GG_Click(object sender, EventArgs e)
        {
            Gelirgider gg = new Gelirgider();
            gg.Name = "gg";
            if (Application.OpenForms["gg"] == null)
            {
                gg.MdiParent = this;
                gg.Show();
            }
        }

            private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Odalarlist_Click(object sender, EventArgs e)
        {
            OdaListesi odl = new OdaListesi();
            odl.Name = "odl";
            if (Application.OpenForms["odl"] == null)
            {
                odl.MdiParent = this;
                odl.Show();
            }
        }

        private void Hak_Click(object sender, EventArgs e)
        {
            Hakkında bilgi = new Hakkında();
            bilgi.Name = "bil";
            if (Application.OpenForms["bil"] == null)
            {
                bilgi.MdiParent = this;
                bilgi.Show();
            }
        }
    }
}
