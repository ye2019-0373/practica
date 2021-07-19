using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PrimeraPract
{
    class Conexion
    {
        private SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");

    }
}
