using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Otel_Otomasyonu
{
    class mkayit
    {
        public string kisiadsoyad { get; set; }
        VeriT vt = new VeriT();
        public void oda(string oda, string kisi)
        {
            if (vt.baglanti.State==System.Data.ConnectionState.Open)
            {
                vt.baglanti.Close();
            }
            try
            {
                vt.baglanti.Open();
                SqlCommand yenile = new SqlCommand("update OdaD set OdayiAlan=@kisi,Durumu=@durum where OdaAdi=@odaAdi  ", vt.baglanti);
                yenile.Parameters.AddWithValue("@kisi", kisi);
                yenile.Parameters.AddWithValue("@durumu", "Dolu");
                yenile.Parameters.AddWithValue("@OdaAdi", oda);
                yenile.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                vt.baglanti.Close();
            }
        }
        public void kayit(string ad,string soyad,string cinsiyet,string telefon,string mail,string tc,string odaadi,string ücret,DateTime giris,DateTime cikis)
        {
            if (vt.baglanti.State==System.Data.ConnectionState.Open)
            {
                vt.baglanti.Close();
            }
            try
            {
                vt.baglanti.Open();
                SqlCommand kayit0 = new SqlCommand("insert into MusteriKayit values(@Ad,@Soyad,@Cinsiyet,@Telefon,@Mail,@TCNo,@Odano,@Ucret,@Giris,@Cikis)", vt.baglanti);
                kayit0.Parameters.AddWithValue("@Ad",ad);
                kayit0.Parameters.AddWithValue("@Soyad",soyad);
                kayit0.Parameters.AddWithValue("@Cinsiyer",cinsiyet);
                kayit0.Parameters.AddWithValue("@Telefon",telefon);
                kayit0.Parameters.AddWithValue("@Mail",mail);
                kayit0.Parameters.AddWithValue("@TCNo",tc);
                kayit0.Parameters.AddWithValue("@Odano",odaadi);
                kayit0.Parameters.AddWithValue("@Ucret",ücret);
                kayit0.Parameters.AddWithValue("@Giris",giris);
                kayit0.Parameters.AddWithValue("@Cikis",cikis);
                kayit0.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Müşteri kayıt işlemi başarılı bir şekilde tamamlandı:" + odaadi + "isimli oda:" + ad + " " + soyad + "isimli kişiye verilmiştir.","İşlem",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                kayit0.Dispose();

                kisiadsoyad = ad + " " + soyad;
                oda(odaadi, kisiadsoyad);


            }
            catch(Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
            }
            finally
            {
                vt.baglanti.Close();
            }


        }
        

    }
}
