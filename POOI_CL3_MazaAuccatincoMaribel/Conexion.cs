using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace POOI_CL3_MazaAuccatincoMaribel
{
    public class Conexion
    {
        //Metodo de conexion 
        public SqlConnection getConecta()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager
                                          .ConnectionStrings["cn"].ConnectionString);
            return cn;
        }
    }
}
