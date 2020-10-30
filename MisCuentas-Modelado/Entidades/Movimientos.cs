using System;

namespace Entidades
{
    public class Movimientos
    {
        #region Atributos

        private float importe;
        private string tipoMovimiento;
        #endregion

        #region Propiedades
        public float Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        #endregion
        public string TipoMovimiento
        {
            get { return tipoMovimiento; }
            set { tipoMovimiento = value; }
        }

        #region Constructores
        public Movimientos()//por defecto
        { }
        public Movimientos(float Imp, string tipoM )
        {
            Importe = Imp;
            TipoMovimiento = tipoM;

        }
        #endregion

    }
}
