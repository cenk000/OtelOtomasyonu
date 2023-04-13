using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel_Otomasyonu
{
    public partial class Ekle : Form
    {

        SqlConnection odadurumu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
        SqlDataAdapter odada;
        SqlCommand komut;
        int Id = 0;
        int ucret;

        public Ekle()
        {
            InitializeComponent();
        }
        SqlConnection eslesmex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
        private void VeriGetirxx()
        {
            Liste.Items.Clear();
            eslesmex.Open();
            komut = new SqlCommand("SELECT *from MusteriKayit",eslesmex);
            SqlDataReader DO = komut.ExecuteReader();
            while (DO.Read())
            {
                ListViewItem getir = new ListViewItem();
                getir.Text = DO["id"].ToString();
                getir.SubItems.Add(DO["Ad"].ToString());
                getir.SubItems.Add(DO["Soyad"].ToString());
                getir.SubItems.Add(DO["Cinsiyet"].ToString());
                getir.SubItems.Add(DO["Telefon"].ToString());
                getir.SubItems.Add(DO["Mail"].ToString());
                getir.SubItems.Add(DO["TCNo"].ToString());
                getir.SubItems.Add(DO["Odano"].ToString());
                getir.SubItems.Add(DO["Ucret"].ToString());
                getir.SubItems.Add(DO["Giris"].ToString());
                getir.SubItems.Add(DO["Cikis"].ToString());
                Liste.Items.Add(getir);
            }
            eslesmex.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ekle_Load(object sender, EventArgs e)
        {

            odatt();
            timer1.Start();
        }

        void odatt()
        {

            odadurumu.Open();
            odada = new SqlDataAdapter("SELECT *FROM odadurum0", odadurumu);
            DataTable Tablo = new DataTable();
            odada.Fill(Tablo);
            odat.DataSource = Tablo;
            odadurumu.Close();

        }

        private void Ekle0_Click(object sender, EventArgs e)
        {
            
            



        }

        private void VG_Click(object sender, EventArgs e)
        {
            VeriGetirxx();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Id = int.Parse(Liste.SelectedItems[0].SubItems[0].Text);
            Ad0.Text = Liste.SelectedItems[0].SubItems[1].Text;
            Soyad0.Text = Liste.SelectedItems[0].SubItems[2].Text;
            Cinsiyet0.Text = Liste.SelectedItems[0].SubItems[3].Text;
            Telnoxx.Text = Liste.SelectedItems[0].SubItems[4].Text;
            Mail.Text = Liste.SelectedItems[0].SubItems[5].Text;
            Kimno.Text = Liste.SelectedItems[0].SubItems[6].Text;
            Odaxx.Text = Liste.SelectedItems[0].SubItems[7].Text;
            Ucretxx.Text = Liste.SelectedItems[0].SubItems[8].Text;
            Girisxx.Text = Liste.SelectedItems[0].SubItems[9].Text;
            Cikisxx.Text = Liste.SelectedItems[0].SubItems[10].Text;

            label2.Text = Liste.SelectedItems[0].SubItems[0].Text;
        }

        private void Silbut_Click(object sender, EventArgs e)
        {
            eslesmex.Open();
            SqlCommand komutx = new SqlCommand("DELETE from MusteriKayit WHERE id=(" + Id + ")", eslesmex);
            komutx.ExecuteNonQuery();
            eslesmex.Close();
            VeriGetirxx();
            odadurumu.Open();
            string musterix = "UPDATE odadurum0 SET durum=@durumz WHERE odaid=@id";
            SqlCommand odakomut = new SqlCommand(musterix, odadurumu);
            odakomut.Parameters.AddWithValue("@id", durumxx.Text);
            odakomut.Parameters.AddWithValue("@durumz", durumxx1.Text);
            odakomut.ExecuteNonQuery();
            odadurumu.Close();
            Ad0.Text = string.Empty;
            Soyad0.Text = string.Empty;
            Cinsiyet0.Text = string.Empty;
            Telnoxx.Text = string.Empty;
            Mail.Text = string.Empty;
            Kimno.Text = string.Empty;
            Odaxx.Text = string.Empty;
            Ucretxx.Text = string.Empty;
        }

        private void Güncel_Click(object sender, EventArgs e)
        {
            if (Ad0.Text == string.Empty || Soyad0.Text == string.Empty || Cinsiyet0.Text == string.Empty || Telnoxx.Text == string.Empty || Mail.Text == string.Empty || Kimno.Text == string.Empty || Odaxx.Text == string.Empty || Ucretxx.Text == string.Empty)
            {
                MessageBox.Show("Boş alan var güncelleme yapamazsın!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {


                komut = new SqlCommand("UPDATE MusteriKayit set Ad=@Ad,Soyad=@Soyad,Cinsiyet=@Cinsiyet,Telefon=@tel,Mail=@mail,TCNo=@tc,Odano=@odan,Ucret=@uc,Giris=@gir,Cikis=@cik Where id=@id", eslesmex);

                komut.Parameters.AddWithValue("@id", label2.Text);
                komut.Parameters.AddWithValue("@Ad", Ad0.Text);
                komut.Parameters.AddWithValue("@Soyad", Soyad0.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet0.Text);
                komut.Parameters.AddWithValue("@tel", Telnoxx.Text);
                komut.Parameters.AddWithValue("@mail", Mail.Text);
                komut.Parameters.AddWithValue("@tc", Kimno.Text);
                komut.Parameters.AddWithValue("@odan", Odaxx.Text);
                komut.Parameters.AddWithValue("@uc", Ucretxx.Text);
                komut.Parameters.AddWithValue("@gir", DateTime.Parse(Girisxx.Text));
                komut.Parameters.AddWithValue("@cik", DateTime.Parse(Cikisxx.Text));
                eslesmex.Open();
                komut.ExecuteNonQuery();
                eslesmex.Close();
                VeriGetirxx();
            }
        }

        private void Arabut_Click(object sender, EventArgs e)
        {
            Liste.Items.Clear();
            eslesmex.Open();
            komut = new SqlCommand("SELECT *from MusteriKayit where TCNo LIKE '%"+tcara.Text+"%'", eslesmex);
            SqlDataReader DO = komut.ExecuteReader();
            while (DO.Read())
            {
                ListViewItem getir = new ListViewItem();
                getir.Text = DO["id"].ToString();
                getir.SubItems.Add(DO["Ad"].ToString());
                getir.SubItems.Add(DO["Soyad"].ToString());
                getir.SubItems.Add(DO["Cinsiyet"].ToString());
                getir.SubItems.Add(DO["Telefon"].ToString());
                getir.SubItems.Add(DO["Mail"].ToString());
                getir.SubItems.Add(DO["TCNo"].ToString());
                getir.SubItems.Add(DO["Odano"].ToString());
                getir.SubItems.Add(DO["Ucret"].ToString());
                getir.SubItems.Add(DO["Giris"].ToString());
                getir.SubItems.Add(DO["Cikis"].ToString());
                Liste.Items.Add(getir);
            }
            eslesmex.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (Odaxx.Text == "01")
            {

                durumxx.Text = "1";
            }
            else if (Odaxx.Text == "02")
            {

                durumxx.Text = "2";
            }
            else if (Odaxx.Text == "03")
            {

                durumxx.Text = "3";
            }
            else if (Odaxx.Text == "04")
            {

                durumxx.Text = "4";
            }
            else if (Odaxx.Text == "05")
            {

                durumxx.Text = "5";
            }
            else if (Odaxx.Text == "06")
            {

                durumxx.Text = "6";
            }
            else if (Odaxx.Text == "07")
            {

                durumxx.Text = "7";
            }
            else if (Odaxx.Text == "08")
            {

                durumxx.Text = "8";
            }
            else if (Odaxx.Text == "09")
            {

                durumxx.Text = "9";
            }
            else if (Odaxx.Text == "10")
            {

                durumxx.Text = "10";
            }
            else if (Odaxx.Text == "11")
            {

                durumxx.Text = "11";
            }
            else if (Odaxx.Text == "12")
            {

                durumxx.Text = "12";
            }
            else if (Odaxx.Text == "13")
            {

                durumxx.Text = "13";
            }
            else if (Odaxx.Text == "14")
            {

                durumxx.Text = "14";
            }
            durumxx1.Text = "BOŞ";
            tekkk();
        }

        private void Kimno_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kimno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Cikisxx_ValueChanged(object sender, EventArgs e)
        {
            DateTime GirisTxx = Convert.ToDateTime(Girisxx.Text);
            DateTime CikisTxx = Convert.ToDateTime(Cikisxx.Text);
            TimeSpan aralik;
            aralik = CikisTxx - GirisTxx;
            gunxx.Text = aralik.TotalDays.ToString();
            ucret = Convert.ToInt32(gunxx.Text) * 800;

            
            SqlConnection odadurumuz = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
            odadurumuz.Open();
            string durumd = "SELECT  * FROM Musterikayit";
            SqlCommand durum01 = new SqlCommand(durumd, odadurumuz);
            SqlDataReader doxx = durum01.ExecuteReader();

            while (doxx.Read())
            {
                if (doxx["Odano"].ToString() == "01")
                {
                    int asd;
                    asd = ucret / 2;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "02")
                {
                    int asd;
                    asd = ucret / 2;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "03")
                {
                    int asd;
                    asd = ucret / 2;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "08")
                {
                    int asd;
                    asd = ucret / 2;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "09")
                {
                    int asd;
                    asd = ucret / 2;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "10")
                {
                    int asd;
                    asd = ucret / 2;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "04")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "05")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "06")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "07")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "11")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "12")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "13")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }
                else if (doxx["Odano"].ToString() == "14")
                {
                    int asd;
                    asd = ucret ;
                    Ucretxx.Text = asd.ToString();
                }


            }
        }
        void tekkk()
        {
            
            }
    }
}
