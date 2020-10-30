using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class SaldosEstablecidos
    {
        #region Atributos

        private int gastoPermitido;
        
        #endregion

        #region Propiedades
        public int GastoPermitido
        {
            get { return gastoPermitido; }
            set { gastoPermitido = value; }
        }
        #endregion

        #region Constructores
        public SaldosEstablecidos()//por defecto
        { }
        public SaldosEstablecidos(int GastoP)
        {
            GastoPermitido = GastoP;

        }
        #endregion
    }
}
