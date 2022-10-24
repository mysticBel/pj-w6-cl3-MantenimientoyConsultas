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


        // Generar Codigo
        public int generaCodigo()
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_NUEVOCODIGO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            cn.Close();
            return n;
        }


        //1.a.Registrar Nuevo Enfermero
        public int nuevoEnfermero(Enfermero objE)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_NUEVOENFERMERO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", objE.nom_enf);
            cmd.Parameters.AddWithValue("@ape", objE.ape_enf);
            cmd.Parameters.AddWithValue("@tel", objE.tel_enf);
            cmd.Parameters.AddWithValue("@esp", objE.ide_esp);
     

            try
            {
                int n = cmd.ExecuteNonQuery();
                return n;
            }
            catch (Exception)
            {
            }

            cn.Close();
            return 0;
        }

        //buscar enfermero
        public DataTable buscarEnfermero(int ide)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_BUSCARENFERMERO", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.Add("@ide",SqlDbType.Int).Value=ide;
            da.SelectCommand.Parameters.AddWithValue("@ide", ide);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }


        // actualiza datos del enfermero
        public int actualizarEnfermero(Enfermero objE)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZARENFERMERO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", objE.nom_enf);
            cmd.Parameters.AddWithValue("@ape", objE.ape_enf);
            cmd.Parameters.AddWithValue("@tel", objE.tel_enf);
            cmd.Parameters.AddWithValue("@esp", objE.ide_esp);

            try
            {
                int n = cmd.ExecuteNonQuery();
                return n;
            }
            catch (Exception)
            {
            }

            cn.Close();
            return 0;
        }


        /*public DataTable nuevoEnfermero()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_NUEVOENFERMERO", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        1.b. Actualizar datos de Enfermeros
        public DataTable actualizarEnfermero()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_ACTUALIZAENFERMERO", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }*/

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


