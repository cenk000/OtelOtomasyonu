using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel_Otomasyonu
{
    

    class Kullanicigirisi
    {
        public string adtut { get; set; }
        public string sifretut { get; set; }
        public string dogrulama { get; set; }
        VeriT VT = new VeriT();
        SqlCommand adkomut;
        SqlCommand sifrekomut;
        SqlCommand tarih;
        SqlDataReader adokuyucu;
        SqlDataReader sifreokuyucu;
        SqlDataReader tarihokuyucu;

        public void girisyap(string ad,string sifre,DateTime Tarih,Form frm)
        {

            adkomut=new SqlCommand("Select *from giris where kullaniciadi='"+ad+"'", VT.baglanti);
            //adkomut.Parameters.AddWithValue("@ad", ad);
            sifrekomut = new SqlCommand("Select *from giris where kullanicisifre='"+sifre+"'", VT.baglanti);
            tarih = new SqlCommand("Select from giris where giristarihi'"+Tarih+"'", VT.baglanti);
            
            VT.baglanti.Open();
            adokuyucu = adkomut.ExecuteReader();
            

            
            



            
            if (adokuyucu.Read())
            {

                adokuyucu.Close(); 
                
               // adkomut.Parameters.AddWithValue("@sifre", sifre);
                sifreokuyucu = sifrekomut.ExecuteReader();




                if (sifreokuyucu.Read())
                {

                    sifreokuyucu.Close();
                    Form2 frm2 = new Form2();

                    frm.Hide();

                    frm2.ShowDialog();
                    


                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Hatalı sifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                


            }
            
            else
            {
                MessageBox.Show("Hatalı isim", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                
            
            VT.baglanti.Close();
            adkomut.Dispose();
            sifrekomut.Dispose();




        }


    }
}
