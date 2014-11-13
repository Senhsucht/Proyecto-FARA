using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    class Metodos:conexion
    {

        public bool Buscar(string usr, string pwd)
        {
            bool resultado = false;
            this.sql = string.Format(@"SELECT ACTIVO FROM USR WHERE USR ='{0}' AND PWD='{1}'", usr, pwd);
            this.cmdsql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.cmdsql.ExecuteReader();
            reg.Read();
            if (reg["ACTIVO"].ToString() == "True")
            {
                resultado = true;
                this.mensaje = "Bienvenido " + usr.ToString();
                CreateUser(usr);
            }

            else
            {
                this.mensaje = "Datos incorrectos, verifique por favor";
            }

            this.cnn.Close();
            return resultado;
        }

        private void CreateUser(string p)
        {

            this.sql = string.Format(@"SELECT U.USR,U.PWD,A.NOMBRE,A.APE_PAT,A.APE_MAT,A.EDAD,A.DIRECCION,A.TEL,A.EMAIL,TA.TAFIL,TU.TUSR,U.ACTIVO,U.ULT_ACT FROM USR U INNER JOIN AFIL A ON U.ID_AFIL=A.ID INNER JOIN TUSR TU ON TU.ID=U.ID_TUSR INNER JOIN TAFIL TA ON TA.ID=A.ID_TAFIL WHERE U.USR='{0}'", p);
            this.cmdsql0 = new SqlCommand(this.sql, this.cnn);
            SqlDataReader cus = null;
            cus = this.cmdsql0.ExecuteReader();
            cus.Read();
            User UsuarioON = new User(cus["USR"].ToString(), cus["PWD"].ToString(), cus["NOMBRE"].ToString(), cus["APE_PAT"].ToString(), cus["APE_MAT"].ToString(), cus["DIRECCION"].ToString(), cus["TEL"].ToString(), cus["EMAIL"].ToString(), cus["TAFIL"].ToString(), cus["TUSR"].ToString(), cus["ACTIVO"].ToString(), cus["EDAD"].ToString());
            // usuario.

        }


    }
}
