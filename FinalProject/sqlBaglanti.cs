using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject
{
    class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-847PRS4\\SQLEXPRESS;Initial Catalog=ARACKİRALAMADB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
