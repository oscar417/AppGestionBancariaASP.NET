using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Modelo
{
    public class Cheques : Cuentas
    {

        #region "Atributos"
        private string cambiarcheque;
        private string retirarcheque;
        #endregion

        #region "Propiedades"

        public string CambiarCheque
        {
            get { return cambiarcheque; }
            set { retirarcheque = value; }
        }
        public string RetirarCheque
        {
            get { return cambiarcheque; }
            set { retirarcheque = value; }
        }
        #endregion

        #region "Constructores"

        public Cheques()
            : base()
        {
            this.cambiarcheque = "Cambio Cheque";
            this.retirarcheque = "Retiro Dinero";

        }

        public Cheques(string identificacion, string idcliente, string balance, string cambiarcheque, string retirarcheque)
            : base(identificacion, idcliente, balance)
        {
            this.cambiarcheque = cambiarcheque;
            this.retirarcheque = retirarcheque;
        }
        #endregion
    }
}