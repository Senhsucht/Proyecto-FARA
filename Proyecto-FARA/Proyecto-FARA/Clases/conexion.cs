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
        protected SqlCommand cmdsql0;
        protected string mensaje;

        public conexion()
        {

            this.cadenaconexion = (@"Data Source = KASUMI-II\SQLEXPRESS; Initial Catalog = PROYECTO_FARA; integrated security=true;" + "Trusted_Connection=True;MultipleActiveResultSets=True;");
            this.cnn = new SqlConnection(this.cadenaconexion);
            
        }

        public static SqlConnection conect()


        {
            string cc = (@"Data Source = KASUMI-II\SQLEXPRESS; Initial Catalog = PROYECTO_FARA; integrated security=true;" + "Trusted_Connection=True;MultipleActiveResultSets=True;");
            SqlConnection cnn = new SqlConnection(cc);
            return cnn;
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
