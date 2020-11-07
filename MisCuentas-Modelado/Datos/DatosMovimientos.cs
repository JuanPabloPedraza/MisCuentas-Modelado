using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosMovimientos : DatosConexionBD
    {
        public int abmMovimiento(string accion, Movimientos objMovimiento)
        {
            int resultado = -1;
            //string orden = string.Empty;
            if (accion == "Alta")
            {
                try
                {
                    Abrirconexion();
                    SqlCommand cmd = new SqlCommand("INSERT INTO  Movimientos  VALUES(@tipoMovimiento,@importe)", conexion);
                    cmd.Parameters.Add(new SqlParameter("@tipoMovimiento", objMovimiento.TipoMovimiento));
                    cmd.Parameters.Add(new SqlParameter("@importe", objMovimiento.Importe));
                    cmd.ExecuteNonQuery();
                    Cerrarconexion();

                }
                catch (Exception e)
                {
                    throw new Exception("Error al tratar de guardar,borrar o modificar el tipo de Movimiento", e);
                }
            }
            return resultado;


        }

        public DataSet listadoMovimientos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Profesionales where CodProf = " + int.Parse(cual) + ";";
            else
                orden = "select * from Movimientos order by id desc;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Movimientos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }





    }
    
}
