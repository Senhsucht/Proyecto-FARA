using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    class User:conexion
    {
        public string usr { get; set; }
        public string pwd { get; set; }
        public string nombre { get; set; }
        public string ape_pat { get; set; }
        public string ape_mat { get; set; }
        public string edad { get; set; }
        public string direccion { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string tafil { get; set; }
        public string tusr { get; set; }
        public string activo { get; set; }
        
        public User(string usuario, string pass, string name,string apepat,string apemat,string direc, string tele, string mail,string tafiliado,string tusuario,string active,string edadU)
        {
            usr = usuario;
            pwd = pass;
            nombre = name;
            ape_pat = apepat;
            ape_mat = apemat;
            direccion = direc;
            tel = tele;
            email = mail;
            tafil = tafiliado;
            tusr = tusuario;
            activo = active;
            edad = edadU;
            this.sql = string.Empty;
        }

/*

        public string tafiliado
        {
            get { return this.tafil; }
            set { this.tafil = value; }
        }

        public string tusuario
        {
            get { return this.tusr; }
            set { this.tusr = value; }
        }

        public bool Buscar()
        {
            bool resultado = false;
            this.sql = string.Format(@"SELECT ACTIVO FROM USR WHERE USR ='{0}' AND PWD='{1}'", this.usr, this.pwd);
            this.cmdsql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.cmdsql.ExecuteReader();
            reg.Read();
            if (reg["ACTIVO"].ToString() == "True")
            {
                    resultado = true;
                    this.mensaje = "Bienvenido "+this.usr.ToString();
                    CreateUser(this.usr);
            }

            else
            {
                this.mensaje = "Datos incorrectos, verifique por favor";
            }

            this.cnn.Close();
            return resultado;
        }

        public void CreateUser(string p)
        {
            
            this.sql = string.Format(@"SELECT U.USR,U.PWD,A.NOMBRE,A.APE_PAT,A.APE_MAT,A.EDAD,A.DIRECCION,A.TEL,A.EMAIL,TA.TAFIL,TU.TUSR,U.ACTIVO,U.ULT_ACT FROM USR U INNER JOIN AFIL A ON U.ID_AFIL=A.ID INNER JOIN TUSR TU ON TU.ID=U.ID_TUSR INNER JOIN TAFIL TA ON TA.ID=A.ID_TAFIL WHERE U.USR='{0}'", p);
            this.cmdsql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.cmdsql.ExecuteReader();
            reg.Read();
            User UsuarioON = new User(reg["USR"].ToString(), reg["PWD"].ToString(), reg["NOMBRE"].ToString(), reg["APE_PAT"].ToString(), reg["APE_MAT"].ToString(), reg["DIRECCION"].ToString(), reg["TEL"].ToString(), reg["EMAIL"].ToString(), reg["TAFIL"].ToString(), reg["TUSR"].ToString(), reg["ACTIVO"].ToString(), reg["EDAD"].ToString());
           // usuario.
            
        }
        */

    }
}
