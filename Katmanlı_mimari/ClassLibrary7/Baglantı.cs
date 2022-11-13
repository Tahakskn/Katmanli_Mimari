using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary7
{
    public class Baglantı
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=KESKIN\SQLEXPRESS;Initial Catalog=Dbokul;Integrated Security=True ");
    }
}
