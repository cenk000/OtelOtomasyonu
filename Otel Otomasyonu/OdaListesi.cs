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
    public partial class OdaListesi : Form
    {
        public SqlConnection eslesme;
        SqlCommand komut;
        public SqlConnection odadurumu;
        SqlCommand odakomut;
        SqlDataReader odaoku;
        SqlDataAdapter odada;
        Odalar durum = new Odalar();
        public OdaListesi()
        {
            InitializeComponent();
        }
        SqlConnection eslesmexx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Initial Catalog=Movies;Integrated Security=True");


        private void Oda01but_Click(object sender, EventArgs e)
        {

        }

        private void OdaListesi_Load(object sender, EventArgs e)
        {

            timer1.Start();
                
            
            
               
            
            

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

            odadurumuz.Close();
            doxx.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            odadurummx();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
