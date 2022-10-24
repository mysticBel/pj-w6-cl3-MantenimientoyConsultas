using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// agregamos
using System.Data;
using System.Data.SqlClient;


namespace POOI_CL3_MazaAuccatincoMaribel
{
    public class DAOEnfermero
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();


        //1.a.Registrar Nuevo Enfermero
        public DataTable nuevoEnfermero()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_NUEVOENFERMERO", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //1.b. Actualizar datos de Enfermeros
        public DataTable actualizarEnfermero()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_ACTUALIZAENFERMERO", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //1.c. Listado de Enfermeros
        public DataTable listadoEnfermeros()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARENFERMERO", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //1.d. Listado de Especialidades
        public DataTable listadoEspecialidades()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARESPECIALIDAD", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}


