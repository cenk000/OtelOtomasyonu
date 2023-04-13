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
    public partial class Personel : Form
    {

        public SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter DA;
        int ks = 0;
        
        public Personel()
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
        

        private void Personel_Load(object sender, EventArgs e)
        {
            personelekle();
            timer1.Start();
            

        }
        
        
        private void Ptablo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = Ptablo.CurrentRow.Cells[0].Value.ToString();
            Ad.Text = Ptablo.CurrentRow.Cells[1].Value.ToString();
            Soyad.Text = Ptablo.CurrentRow.Cells[2].Value.ToString();
            Cinsiyet.Text = Ptablo.CurrentRow.Cells[3].Value.ToString();
            TC.Text = Ptablo.CurrentRow.Cells[4].Value.ToString();
            Tel.Text = Ptablo.CurrentRow.Cells[5].Value.ToString();
            mail.Text = Ptablo.CurrentRow.Cells[6].Value.ToString();
            Dtarihi.Text = Ptablo.CurrentRow.Cells[7].Value.ToString();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (Ad.Text == string.Empty || Soyad.Text == string.Empty || Cinsiyet.Text == string.Empty || Tel.Text == string.Empty || mail.Text == string.Empty || TC.Text == string.Empty )
            {
                MessageBox.Show("Boş alanları doldur!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string ekle = "INSERT INTO Personel(Adı,Soyadı,Cinsiyeti,TC,Telefon,Email,DoğumTarihi) VALUES(@Ad,@Soyad,@Cinsiyet,@tc,@tel,@mail,@dt)";
                komut = new SqlCommand(ekle, baglanti);

                komut.Parameters.AddWithValue("@Ad", Ad.Text);
                komut.Parameters.AddWithValue("@Soyad", Soyad.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet.Text);
                komut.Parameters.AddWithValue("@tc", TC.Text);
                komut.Parameters.AddWithValue("@tel", Tel.Text);
                komut.Parameters.AddWithValue("@mail", mail.Text);
                komut.Parameters.AddWithValue("@dt", DateTime.Parse(Dtarihi.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                personelekle();
                Ad.Text = String.Empty;
                Soyad.Text = String.Empty;
                Cinsiyet.Text = String.Empty;
                TC.Text = String.Empty;
                Tel.Text = String.Empty;
                mail.Text = String.Empty;
            }

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            string sil = "Delete From Personel WHERE id=@id";
            komut = new SqlCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(Id.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            personelekle();
            Ad.Text = String.Empty;
            Soyad.Text = String.Empty;
            Cinsiyet.Text = String.Empty;
            TC.Text = String.Empty;
            Tel.Text = String.Empty;
            mail.Text = String.Empty;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string update = "UPDATE Personel SET Adı=@ad,Soyadı=@Soyad,Cinsiyeti=@Cinsiyet,TC=@tc,Telefon=@tel,Email=@mail,DoğumTarihi=@dt Where id=@id";
            komut = new SqlCommand(update, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(Id.Text));
            komut.Parameters.AddWithValue("@Ad", Ad.Text);
            komut.Parameters.AddWithValue("@Soyad", Soyad.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet.Text);
            komut.Parameters.AddWithValue("@tc", TC.Text);
            komut.Parameters.AddWithValue("@tel", Tel.Text);
            komut.Parameters.AddWithValue("@mail", mail.Text);
            komut.Parameters.AddWithValue("@dt", DateTime.Parse(Dtarihi.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            personelekle();

        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ks = Ptablo.RowCount;
            label9.Text = ks.ToString();
            
        }

        private void TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ad.Text = String.Empty;
            Soyad.Text = String.Empty;
            Cinsiyet.Text = String.Empty;
            TC.Text = String.Empty;
            Tel.Text = String.Empty;
            mail.Text = String.Empty;
        }
    }
}
