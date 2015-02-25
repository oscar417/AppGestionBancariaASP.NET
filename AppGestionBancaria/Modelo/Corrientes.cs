using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Modelo
{
    public class Corrientes:Cuentas
    {
                #region "Atributos"
        private string depositarcc;
        private string retirarcc;
        #endregion

        #region "Propiedades"
        public string Depositar
        {
            get { return depositarcc; }
            set { depositarcc = value; }
        }
        public string Retirar
        {
            get { return retirarcc; }
            set { retirarcc = value; }
        }
        #endregion

        #region "Constructores"
        public Corrientes():base()
        {
            this.depositarcc = "Deposito Dinero";
            this.retirarcc = "Retiro Dinero";
            
        }

        public Corrientes(string identificacion, string idcliente, string balance, string depositar, string retirar)
            : base(identificacion, idcliente, balance)
        {
            this.retirarcc = retirar;
            this.depositarcc = depositar;
        }
        #endregion

        #region "Métodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                   "\nRetiro Dinero: " + this.retirarcc +
                   "\nDeposito Dinero: " + this.depositarcc;
        }

        public override bool Equals(object obj)
        {
            Corrientes o = (Corrientes)obj;
            bool result = false;

            if (base.Equals(o) &&
               (this.retirarcc == o.retirarcc) &&
                (this.depositarcc == o.depositarcc));
                
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