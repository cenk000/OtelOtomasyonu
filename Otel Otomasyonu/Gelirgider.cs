using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Otel_Otomasyonu
{
    public partial class Gelirgider : Form
    {
        public SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter DA;
        int ks = 0;
        int permaas = 1000;
        int faturalar;
        int aa;
        int bb;
        int cc;
        public Gelirgider()
        {
            InitializeComponent();
        }
        void personelekle()
        {
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
            baglanti.Open();
            DA = new SqlDataAdapter("SELECT *FROM Personel", baglanti);
            DataTable Tablo = new DataTable();
            DA.Fill(Tablo);
            Ptablo.DataSource = Tablo;
            baglanti.Close();


        }
        void fatura()
        {
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
            baglanti.Open();
            DA = new SqlDataAdapter("SELECT *FROM MusteriKayit", baglanti);
            DataTable Tablo = new DataTable();
            DA.Fill(Tablo);
            fat.DataSource = Tablo;
            baglanti.Close();


        }
        SqlConnection eslesmexx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
        private void Gelirgider_Load(object sender, EventArgs e)
        {
            fatura();
                personelekle();
                timer1.Start();
            eslesmexx.Open();





            SqlCommand komtxx = new SqlCommand("SELECT SUM(Ucret) AS TOPLAM FROM MusteriKayit", eslesmexx);
                SqlDataReader doxx = komtxx.ExecuteReader();
                while (doxx.Read())
                {
                    kasa.Text = doxx["TOPLAM"].ToString();
                }
                doxx.Close();
                SqlCommand komtxxx = new SqlCommand("SELECT SUM(fiyatı) AS TOPLAM FROM Yemek", eslesmexx);
                SqlDataReader doxxx = komtxxx.ExecuteReader();
                while (doxxx.Read())
                {
                    
                    label11.Text = doxxx["TOPLAM"].ToString();
                
                }
                doxxx.Close();
                SqlCommand komtxxxx = new SqlCommand("SELECT SUM(satis) AS TOPLAM FROM Yemek", eslesmexx);
                SqlDataReader doxxxx = komtxxxx.ExecuteReader();
                while (doxxxx.Read())
                {


                

                label6.Text= doxxxx["TOPLAM"].ToString();
                aa = Convert.ToInt32(label6.Text);
            }


                doxxxx.Close();
            SqlCommand komtxxxxx = new SqlCommand("SELECT SUM(miktar) AS TOPLAM FROM Yemek", eslesmexx);
            SqlDataReader doxxxxx = komtxxxxx.ExecuteReader();
            while (doxxxxx.Read())
            {
                
                label8.Text = doxxxxx["TOPLAM"].ToString();

                bb = Convert.ToInt32(label8.Text);
                saa.Text = Convert.ToString(aa * bb);

                cc = Convert.ToInt32(label11.Text);
                au.Text = Convert.ToString(bb * cc);




            }
             eslesmexx.Close();
            
            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            


                int a;
                int b;
                int c;
            if (Ptablo.RowCount==0)
            {
                pm.Text = "0";
            }
                ks = Ptablo.RowCount * permaas;
            if (fat.RowCount == 0)
            {
                fa.Text = "0";
            }
            if (kasa.Text==string.Empty)
            {
                kasa.Text = "0";
            }
            faturalar = fat.RowCount * 450;
                fa.Text = faturalar.ToString();

                label4.Text = ks.ToString();
                pm.Text = label4.Text;
                a = Convert.ToInt32(kasa.Text);
            if (au.Text==string.Empty)
            {
                au.Text = "0";
            }
            if(saa.Text == string.Empty)
            {
                saa.Text = "0";
            }
            b = faturalar + ks + Convert.ToInt32(au.Text);
                c = Convert.ToInt32(saa.Text);
                gg.Text = (a - b + c).ToString();
            
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
