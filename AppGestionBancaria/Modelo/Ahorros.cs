using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Modelo
{
    public class Ahorros:Cuentas
    {
        
        #region "Atributos"
        private string depositar;
        private string retirar;
        #endregion

        #region "Propiedades"
        public string Depositar
        {
            get { return depositar; }
            set { depositar = value; }
        }
        public string Retirar
        {
            get { return retirar; }
            set { retirar = value; }
        }
        #endregion

        #region "Constructores"
        public Ahorros():base()
        {
            this.depositar = "Deposito Dinero";
            this.retirar = "Retiro Dinero";
            
        }

        public Ahorros(string identificacion, string idcliente, string balance, string depositar,string retirar)
            : base(identificacion, idcliente, balance)
        {
            this.retirar = retirar;
            this.depositar = depositar;
        }
        #endregion

        #region "Métodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                   "\nRetiro Dinero: " + this.retirar +
                   "\nDeposito Dinero: " + this.depositar;
        }

        public override bool Equals(object obj)
        {
            Ahorros s = (Ahorros)obj;
            bool result = false;

            if (base.Equals(s) &&
               (this.retirar == s.retirar) &&
                (this.depositar == s.depositar));
                
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

#endregion
    }
}