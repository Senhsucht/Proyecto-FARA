using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    class User:conexion
    {
        private string usr;
        private string pwd;
        private int id_afil;
        private int id_tusr;

        public User()
        {
            usr = string.Empty;
            pwd = string.Empty;
            id_afil = 0;
            id_tusr = 0;
            this.sql = string.Empty;
        }

        public string user
        {
            get { return this.usr; }
            set { this.usr = value; }
        }

        public string contraseña
        {
            get { return this.pwd; }
            set { this.pwd = value; }
        }

        public int afiliado
        {
            get { return this.id_afil; }
            set { this.id_afil = value; }
        }

        public int tusuario
        {
            get { return this.id_tusr; }
            set { this.id_tusr = value; }
        }

        public bool Buscar()
        {
            bool resultado = false;
            this.sql = string.Format(@"SELECT ACTIVO FROM USR WHERE USR ='{0}' AND PWD='{1}'", this.usr, this.pwd);
            this.cmdsql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.cmdsql.ExecuteReader();
            if (reg.Read())
            {
                resultado = true;
                this.mensaje = "Bienvenido";
            }

            else
            {
                this.mensaje = "Datos incorrectos, verifique por favor";
            }

            this.cnn.Close();
            return resultado;
        }

    }
}
