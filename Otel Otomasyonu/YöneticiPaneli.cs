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
    public partial class YöneticiPaneli : Form
    {
        public SqlConnection eslesme;
        SqlCommand komut;
        SqlDataAdapter DA;
        public YöneticiPaneli()
        {
            InitializeComponent();
        }
        void YP0()
        {

            eslesme = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
            eslesme.Open();
            DA = new SqlDataAdapter("SELECT *FROM giris", eslesme);
            DataTable Tablo = new DataTable();
            DA.Fill(Tablo);
            YP.DataSource = Tablo;
            eslesme.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YöneticiPaneli_Load(object sender, EventArgs e)
        {
            YP0();
        }

        private void YP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = YP.CurrentRow.Cells[0].Value.ToString();
            AD.Text = YP.CurrentRow.Cells[1].Value.ToString();
            SOYAD.Text = YP.CurrentRow.Cells[2].Value.ToString();
        }

        private void EKLE_Click(object sender, EventArgs e)
        {

            string ekle = "INSERT INTO giris(kullaniciadi,kullanicisifre) VALUES(@Ad,@Soyad)";
            komut = new SqlCommand(ekle, eslesme);

            
            komut.Parameters.AddWithValue("@Ad", AD.Text);
            komut.Parameters.AddWithValue("@Soyad", SOYAD.Text);
            
            eslesme.Open();
            komut.ExecuteNonQuery();
            eslesme.Close();
            YP0();


        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

        }

        private void SIL_Click(object sender, EventArgs e)
        {
            string sil = "Delete From giris WHERE id=@id";
            komut = new SqlCommand(sil, eslesme);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(ID.Text));
            eslesme.Open();
            komut.ExecuteNonQuery();
            eslesme.Close();
            YP0();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
