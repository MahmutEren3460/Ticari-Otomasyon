using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    class baglanti
    {
        public SqlConnection baglantisi()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6F9GQRG\SQLEXPRESS;Initial Catalog=Dbo_Ticari_Otomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
