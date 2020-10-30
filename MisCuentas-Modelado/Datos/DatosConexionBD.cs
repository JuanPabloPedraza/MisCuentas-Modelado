using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexionBD
    {
        #region Atributos
        public SqlConnection conexion;
        public string cadenaConexion = "Server =(localdb)\\MSSQLLocalDB; DataBase = MisCuentas; Integrated Security = True";
        public SqlCommand comando = new SqlCommand();
        #endregion

        #region Constructor 
        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        #endregion


        #region Metodos
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();

            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
        #endregion



    }
}
