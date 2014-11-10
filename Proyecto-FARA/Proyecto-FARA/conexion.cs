using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    class conexion
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand cmdsql;
        protected string mensaje;

        public conexion()
        {

            this.cadenaconexion = (@"Data Source = KASUMI-II\SQLEXPRESS; Initial Catalog = PROYECTO_FARA; integrated security=true");
            this.cnn = new SqlConnection(this.cadenaconexion);
            
        }

        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }

        }
    }
}
