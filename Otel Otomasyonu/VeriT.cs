using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Otel_Otomasyonu
{
    class VeriT
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
       // @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Otel Otomasyonu.mdf;Initial Catalog=Movies;Integrated Security=True"
    }
}
