using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class CapaNegocioMovimientos
    {
        DatosMovimientos objDatosMovimientos = new DatosMovimientos();

        public int abmMovimiento(string accion, Movimientos objMovimiento)
        {
            return objDatosMovimientos.abmMovimiento(accion, objMovimiento);
        }


        public DataSet listadoMovimientos(string cual)
        {
            return objDatosMovimientos.listadoMovimientos(cual);
        }


    }

   



}
