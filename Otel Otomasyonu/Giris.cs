using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel_Otomasyonu
{
    class Giris
    {
        VeriT VT = new VeriT();
        public string adtut { get; set; }
        public string sifretut { get; set; }
        public string dogrulama { get; set; }
        
        



        public void giris(string kullaniciadi, string kullanicisifre,DateTime Tarih)
        {

            
            if(VT.baglanti.State == System.Data.ConnectionState.Open)
            {
                VT.baglanti.Close();

            }
            try
            {
                VT.baglanti.Open();
                SqlCommand girisisim = new SqlCommand("select kullaniciadi from giris where kullaniciadi=@ad", VT.baglanti);
                girisisim.Parameters.AddWithValue("@ad", kullaniciadi);
                SqlDataReader Ad_oku = girisisim.ExecuteReader();
                if (Ad_oku.Read())
                {

                    Ad_oku.Close();
                    adtut = Ad_oku["kullaniciadi"].ToString();
                    SqlCommand girissifre = new SqlCommand("select kullanicisifre from giris where kullanicisifre=@sifre", VT.baglanti);
                    girissifre.Parameters.AddWithValue("@sifre", kullanicisifre);
                    SqlDataReader sifre_oku = girissifre.ExecuteReader();
                    
                    if (sifre_oku.Read())
                    {
                        sifre_oku.Close();
                        sifretut = sifre_oku["kullanicisifre"].ToString();
                        dogrulama = adtut + " " + sifretut;
                        
                        SqlCommand dateUpdate = new SqlCommand("update giris set giristarihi=@tarih where kullaniciadi=@Ad AND kullanicisifre=@sifre", VT.baglanti);
                        dateUpdate.Parameters.AddWithValue("@tarih", Tarih);
                        dateUpdate.Parameters.AddWithValue("@ad", adtut);
                        dateUpdate.Parameters.AddWithValue("@sifre", sifretut);
                        dateUpdate.ExecuteNonQuery();
                        
                        
                        


                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı şifresini yanlış girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        

                    }




                }
                else
                {
                    MessageBox.Show("Kullanıcı adını yanlış girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                }
                


            }
            catch
            {

            }
            finally
            {
                VT.baglanti.Close();

            }


        }



    }
}
