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
    public partial class YH : Form
    {
        double a;
        double b;
        int c = 10;
        double d;
        public SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter DA;
        public YH()
        {
            InitializeComponent();
        }
        void yh0()
        {
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
            baglanti.Open();
            DA = new SqlDataAdapter("SELECT *FROM Yemek", baglanti);
            DataTable Tablo = new DataTable();
            DA.Fill(Tablo);
            YP.DataSource = Tablo;
            baglanti.Close();
        }

        private void YH_Load(object sender, EventArgs e)
        {
            yh0();
            timer1.Start();
            
        }

        private void YP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void YP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = YP.CurrentRow.Cells[0].Value.ToString();
            AD.Text = YP.CurrentRow.Cells[1].Value.ToString();
            fiyat.Text = YP.CurrentRow.Cells[2].Value.ToString();
            satis.Text = YP.CurrentRow.Cells[3].Value.ToString();
            miktar.Text = YP.CurrentRow.Cells[4].Value.ToString();
            TF.Text = YP.CurrentRow.Cells[5].Value.ToString();


        }

        private void EKLE_Click(object sender, EventArgs e)
        {
            if (AD.Text == string.Empty || fiyat.Text == string.Empty || satis.Text == string.Empty)
            {
                MessageBox.Show("Boş alanları doldur!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                string ekle = "INSERT INTO Yemek(Ad,fiyatı,satis,miktar,toplam) VALUES(@Ad,@fiyat,@satis,@miktar,@toplam)";

                komut = new SqlCommand(ekle, baglanti);
                komut.Parameters.AddWithValue("@Ad", AD.Text);
                komut.Parameters.AddWithValue("@fiyat", fiyat.Text);
                komut.Parameters.AddWithValue("@satis", satis.Text);
                komut.Parameters.AddWithValue("@miktar", miktar.Text);
                komut.Parameters.AddWithValue("@toplam", TF.Text);


                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                yh0();
                AD.Text = string.Empty;
                fiyat.Text = string.Empty;
                satis.Text = string.Empty;
                miktar.Text = string.Empty;
                TF.Text = string.Empty;
            }
        }

        private void SIL_Click(object sender, EventArgs e)
        {
            string sil = "Delete From Yemek WHERE id=@id";
            komut = new SqlCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            yh0();
            AD.Text = string.Empty;
            fiyat.Text = string.Empty;
            satis.Text = string.Empty;
            miktar.Text = string.Empty;
            TF.Text = string.Empty;
        }

        private void ÇIKIŞ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (fiyat.Text == string.Empty || miktar.Text == string.Empty)
            {
                fiyat.Text = "0";

                miktar.Text = "0";
                

            }
            else
            {
                
            a = Convert.ToDouble(fiyat.Text);
            b = Convert.ToDouble(miktar.Text);
            satis.Text = Convert.ToString(Math.Round( a+(a*105/100)));
                TF.Text = Convert.ToString(Math.Round(b*a));
                

            }
        }

        private void fiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
