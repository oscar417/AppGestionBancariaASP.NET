using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Modelo
{
    public class Cuentas
    {
        #region "Atributos"
        private string identificacion;
        private string idcliente;
        private string balance;
        #endregion

        #region "Propoiedades"
        // <summary>
        /// Establece o retorna el valor de la identificación
        /// </summary>
        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        /// <summary>
        /// Establece o retorna los identificacion del los clientes
        /// </summary>
        public string IdClientes
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        /// <summary>
        /// Establece o retorna el estado en que se encuentra el balance de cuentas de los clientes
        /// </summary>
        public string Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        #endregion

        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Cuentas
        ///</summary>
        public Cuentas()
        {
            this.identificacion = "123456789";
            this.idcliente = "Nombre y apellido";
            this.balance = "";
        }

        ///<summary>
        ///Contructor de inicialización Cuentas
        ///</summary>
        ///<param name="identificacion"> Identificacion del cliente</param>
        ///<param name="idcliente"> Nombres y Apaellidos del cliente</param>
        ///<param name="balance">Balance de la cuenta del cliente</param>
        ///
        public Cuentas(string identificacion, string idcliente, string balance)
        {
            this.identificacion = identificacion;
            this.idcliente = idcliente;
            this.balance = balance;
        }
        #endregion

        #region "Metodos sobreescritos"
        /// <summary>
        /// Retorna el valor del objeto representado en la cadena
        /// </summary>
        public override string ToString()
        {
            return "\n=============================================\n" +
                     "Identificación:  " + this.identificacion + "\n" +
                     "IdCliente:  " + this.idcliente + "\n" +
                     "Balance:" + this.balance;
        }
        // <summary>
        /// Método para comparar los objetos
        /// </summary>
        public override bool Equals(object obj)
        {
            Cuentas x = (Cuentas)obj;
            bool result = false;

            if (base.Equals(x) &&
               (this.identificacion == x.identificacion) &&
                (this.idcliente == x.idcliente) &&
                (this.balance == x.balance)
                ) ;
            result = true;

            return result;
        }

        /// <summary>
        /// Devuelve la identificación del objecto
        /// </summary>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion;

    }
}