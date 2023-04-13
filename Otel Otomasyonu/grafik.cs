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
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();
        }
        SqlConnection grafikxx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Integrated Security=True");
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void grafik_Load(object sender, EventArgs e)
        {
            grafikxx.Open();

            string durumd = "SELECT durum * FROM odadurum0";
            SqlCommand komut=new SqlCommand(durumd,grafikxx);
            SqlDataReader gok = komut.ExecuteReader();
            while (gok.Read())
            {
                chart1.Series["Dolu"].Points.AddXY(gok[1].ToString(), gok[0].ToString());
            }

        }
    }
}
