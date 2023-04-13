using System;
using System.Collections;
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
    public partial class Odalar : Form
    {
        public SqlConnection eslesme;
        SqlCommand komut;
        public SqlConnection odadurumu;
        SqlCommand odakomut;
        SqlDataReader odaoku;
        SqlDataAdapter odada;
        
        int ucret;
        int tek ;
        bool dolux ;
        string dolu = "Dolu";


        public Odalar()
        {
            InitializeComponent();
        }
        
        

        
        
        private void Ver_Click(object sender, EventArgs e)
        {
            
            if (Ad0.Text == string.Empty || Soyad0.Text == string.Empty || Cinsiyet0.Text == string.Empty || Telnoxx.Text == string.Empty || Mail.Text == string.Empty || Kimno.Text == string.Empty || Odaxx.Text == string.Empty || Ucretxx.Text == string.Empty)
            {
                MessageBox.Show("Boş alanları doldur!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                eslesme = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
                string musteri = "INSERT into MusteriKayit(Ad,Soyad,Cinsiyet,Telefon,Mail,TCNo,Odano,Ucret,Giris,Cikis) VALUES(@Ad,@Soyad,@Cinsiyet,@tel,@mail,@tc,@odan,@Ucret,@Giris,@cikis)";
                komut = new SqlCommand(musteri, eslesme);
                komut.Parameters.AddWithValue("@Ad", Ad0.Text);
                komut.Parameters.AddWithValue("@Soyad", Soyad0.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet0.Text);
                komut.Parameters.AddWithValue("@tel", Telnoxx.Text);
                komut.Parameters.AddWithValue("@mail", Mail.Text);
                komut.Parameters.AddWithValue("@tc", Kimno.Text);
                komut.Parameters.AddWithValue("@odan", Odaxx.Text);
                komut.Parameters.AddWithValue("@Ucret", Ucretxx.Text);
                komut.Parameters.AddWithValue("@Giris", DateTime.Parse(Girisxx.Text));
                komut.Parameters.AddWithValue("@cikis", DateTime.Parse(Cikisxx.Text));

                
                 
                string musterix = "UPDATE odadurum0 SET durum=@durumz WHERE odaid=@id";
                odakomut = new SqlCommand(musterix, odadurumu);
                odakomut.Parameters.AddWithValue("@id", durumxx.Text);
                odakomut.Parameters.AddWithValue("@durumz", durumxx1.Text);
                odadurumu.Open();
                eslesme.Open();
                komut.ExecuteNonQuery();
                odakomut.ExecuteNonQuery();

                odadurumu.Close();
                eslesme.Close();
                MessageBox.Show("Müşteri kaydı yapıldı.", "İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
            }
        }

        

        private void Odalar_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            
            odadurumu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
            odatt();
            
            
            
            
            
        }
        void odadurummx()
        {
            SqlConnection odadurumuz = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
            odadurumuz.Open();
            string durumd = "SELECT  * FROM odadurum0";
            SqlCommand durum01 = new SqlCommand(durumd, odadurumuz);
            SqlDataReader doxx = durum01.ExecuteReader();
            
            while (doxx.Read())
            {
                if (doxx["odaid"].ToString() == "1" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda01but.BackColor = Color.Red;
                    Oda01but.Text = "Dolu!";
                    Oda01but.Enabled = false;
                }
                

                else if (doxx["odaid"].ToString() == "2" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda02but.BackColor = Color.Red;
                    Oda02but.Text = "Dolu!";
                    Oda02but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "3" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda03but.BackColor = Color.Red;
                    Oda03but.Text = "Dolu!";
                    Oda03but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "4" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda04but.BackColor = Color.Red;
                    Oda04but.Text = "Dolu!";
                    Oda04but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "5" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda05but.BackColor = Color.Red;
                    Oda05but.Text = "Dolu!";
                    Oda05but.Enabled = false;
                }
                else if (doxx["odaid"].ToString() == "15" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda06but.BackColor = Color.Red;
                    Oda06but.Text = "Dolu!";
                    Oda06but.Enabled = false;
                }
               

                else if (doxx["odaid"].ToString() == "7" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda07but.BackColor = Color.Red;
                    Oda07but.Text = "Dolu!";
                    Oda07but.Enabled = false;
                }
                else if (doxx["odaid"].ToString() == "8" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda08but.BackColor = Color.Red;
                    Oda08but.Text = "Dolu!";
                    Oda08but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "9" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda09but.BackColor = Color.Red;
                    Oda09but.Text = "Dolu!";
                    Oda09but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "10" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda10but.BackColor = Color.Red;
                    Oda10but.Text = "Dolu!";
                    Oda10but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "11" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda11but.BackColor = Color.Red;
                    Oda11but.Text = "Dolu!";
                    Oda11but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "12" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda12but.BackColor = Color.Red;
                    Oda12but.Text = "Dolu!";

                    Oda12but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "13" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda13but.BackColor = Color.Red;
                    Oda13but.Text = "Dolu!";
                    Oda13but.Enabled = false;
                }

                else if (doxx["odaid"].ToString() == "14" && doxx["durum"].ToString() == "Dolu")
                {

                    Oda14but.BackColor = Color.Red;
                    Oda14but.Text = "Dolu!";

                    Oda14but.Enabled = false;
                }


            }
            
            odadurumu.Close();
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

        private void Oda01but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "01";
            tek = ucret / 2;
            Ucretxx.Text = tek.ToString();
            durumxx.Text = "1";
            durumxx1.Text = "Dolu";






        }

        private void Telnoxx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Oda02but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "02";
            tek = ucret / 2;
            Ucretxx.Text = tek.ToString();
            durumxx.Text = "2";
            durumxx1.Text = "Dolu";



        }

        private void Oda03but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "03";
            tek = ucret / 2;
            Ucretxx.Text = tek.ToString();
            durumxx.Text = "3";
            durumxx1.Text = "Dolu";


        }

        private void Oda04but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "04";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "4";
            durumxx1.Text = "Dolu";


        }

        private void Oda05but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "05";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "5";
            durumxx1.Text = "Dolu";


        }

        private void Oda06but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "06";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "6";
            durumxx1.Text = "Dolu";


        }

        private void Oda07but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "07";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "7";
            durumxx1.Text = "Dolu";


        }

        private void Oda08but_Click(object sender, EventArgs e)
        {
            
            Odaxx.Text = "08";
            tek = ucret / 2;
            Ucretxx.Text = tek.ToString();
            durumxx.Text = "8";
            durumxx1.Text = "Dolu";


        }

        private void Oda09but_Click(object sender, EventArgs e)
        {
            Odaxx.Text = "09";
            tek = ucret / 2;
            Ucretxx.Text = tek.ToString();
            durumxx.Text = "9";
            durumxx1.Text = "Dolu";
        }

        private void Oda10but_Click(object sender, EventArgs e)
        {
            Odaxx.Text = "10";
            tek = ucret / 2;
            Ucretxx.Text = tek.ToString();
            durumxx.Text = "10";
            durumxx1.Text = "Dolu";
        }

        private void Oda11but_Click(object sender, EventArgs e)
        {
            Odaxx.Text = "11";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "11";
            durumxx1.Text = "Dolu";
        }

        private void Oda12but_Click(object sender, EventArgs e)
        {
            Odaxx.Text = "12";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "12";
            durumxx1.Text = "Dolu";
        }

        private void Oda13but_Click(object sender, EventArgs e)
        {
            Odaxx.Text = "13";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "13";
            durumxx1.Text = "Dolu";
        }

        private void Oda14but_Click(object sender, EventArgs e)
        {
            Odaxx.Text = "14";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "14";
            durumxx1.Text = "Dolu";
        }

        private void Cikisxx_ValueChanged(object sender, EventArgs e)
        {
            DateTime GirisTxx = Convert.ToDateTime(Girisxx.Text);
            DateTime CikisTxx = Convert.ToDateTime(Cikisxx.Text);
            TimeSpan aralik;
            aralik = CikisTxx - GirisTxx;
            gunxx.Text = aralik.TotalDays.ToString();
            ucret = Convert.ToInt32(gunxx.Text) * 800;
            
            Ucretxx.Text = ucret.ToString();
        }

       

        private void button23_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //durumxx.Text = "Dolu";
            odadurummx();
        }

        private void odat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            durumxx.Text = odat.CurrentRow.Cells[0].Value.ToString();
            durumxx1.Text = odat.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ad0.Text = string.Empty;
            Soyad0.Text = string.Empty;
            Cinsiyet0.Text = string.Empty;
            Telnoxx.Text = string.Empty;
            Mail.Text = string.Empty;
            Kimno.Text = string.Empty;
            Odaxx.Text = string.Empty;
            Ucretxx.Text = string.Empty;
            
            }

        private void Kimno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Oda06but_Click_1(object sender, EventArgs e)
        {
            Odaxx.Text = "06";
            Ucretxx.Text = ucret.ToString();
            durumxx.Text = "15";
            durumxx1.Text = "Dolu";
        }
    }
}
