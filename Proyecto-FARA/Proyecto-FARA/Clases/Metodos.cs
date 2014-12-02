using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_FARA
{

    class Metodos:conexion
    {
        public static User UsuarioON = null;

        //Buscar el usuario
        public bool Buscar(string usr, string pwd)
        {
            bool resultado = false;
            //Buscar el usuario en la base de datos
            this.sql = string.Format(@"SELECT ACTIVO FROM USR WHERE USR ='{0}' AND PWD='{1}'", usr, pwd);
            this.cmdsql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.cmdsql.ExecuteReader();
            reg.Read();
            //Comprobar que el usuario se encuentra activo
            if (reg["ACTIVO"].ToString() == "True")
            {
                resultado = true;
                this.mensaje = "Bienvenido " + usr.ToString();
                //Crear objeto Usuario
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
            //Consultar JOIN para extrael todos los datos del usuario
            this.sql = string.Format(@"SELECT U.USR,U.PWD,A.NOMBRE,A.APE_PAT,A.APE_MAT,A.EDAD,A.DIRECCION,A.TEL,A.EMAIL,TA.TAFIL,TU.TUSR,U.ACTIVO,U.ULT_ACT FROM USR U INNER JOIN AFIL A ON U.ID_AFIL=A.ID INNER JOIN TUSR TU ON TU.ID=U.ID_TUSR INNER JOIN TAFIL TA ON TA.ID=A.ID_TAFIL WHERE U.USR='{0}'", p);
            this.cmdsql0 = new SqlCommand(this.sql, this.cnn);
            SqlDataReader cus = null;
            cus = this.cmdsql0.ExecuteReader();
            cus.Read();
            //Crear el objeto tipo USUARIO
            User u = new User(cus["USR"].ToString(), cus["PWD"].ToString(), cus["NOMBRE"].ToString(), cus["APE_PAT"].ToString(), cus["APE_MAT"].ToString(), cus["DIRECCION"].ToString(), cus["TEL"].ToString(), cus["EMAIL"].ToString(), cus["TAFIL"].ToString(), cus["TUSR"].ToString(), cus["ACTIVO"].ToString(), cus["EDAD"].ToString());
            // Asignar usuario a nuestra variable global
             UsuarioON = u;
         }


        public  User Iniciado()
        {
            //Regresa nuestra variable global de tipo Usuario
            return UsuarioON;
        }

        public SqlDataAdapter BusquedaC(string cmd)
        {
            
            this.sql = string.Format(@"{0}", cmd);
            this.cmdsql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmdsql);
            
            this.cnn.Close();

            return da;

        }

        public static int ConsultaIds(string cmd)
        {
            int total = 0;
            SqlConnection cnn = conect();
            SqlCommand cmdsql= new SqlCommand(cmd, cnn);
            cnn.Open();
            SqlDataReader lector = cmdsql.ExecuteReader();
            while (lector.Read())
            {
                total++;
            }

            return total;
        }

        public static int[] colecDatos(string cmd)
        {
            SqlConnection cnn = conect();

            int[] temp = new int[1];
            int total = ConsultaIds(cmd);
            Array.Resize(ref temp, total);
            cnn.Open();
            SqlCommand cmdsql = new SqlCommand(cmd, cnn);
            SqlDataReader lector = cmdsql.ExecuteReader();
            int c = 0;

            while (lector.Read())
            {
                temp[c]=lector.GetInt32(lector.GetOrdinal("ID"));
                c++;
            }

            return temp;
        }

        public static Boolean consultarDatos(int id, string tcon)
        {
            Boolean r = false;

            SqlConnection cnn = conect();
            cnn.Open();

            string querysql = string.Empty;

            switch (tcon)
            {
                case "donante":
                     querysql = string.Format(@"SELECT * FROM DONANTE WHERE ID = {0}",id);
                    break;
                case "producto":
                     querysql = string.Format(@"SELECT * FROM PRODUCTO WHERE ID = {0}", id);
                    break;
                case "evento":
                     querysql = string.Format(@"SELECT * FROM EVENTO WHERE ID = {0}", id);
                    break;
                case "adoptante":
                    querysql = string.Format(@"SELECT * FROM ADOPTANTE WHERE ID = {0}", id);
                    break;
                case "conInv":
                    querysql = string.Format(@"SELECT I.ID,P.NOMBRE,P.MARCA,I.CANTIDAD,P.CNETO,I.DESCR,I.ULT_ACT  FROM [INVENTARIO] I INNER JOIN [PRODUCTO] P ON I.ID_PRODUCTO=P.ID WHERE I.ID = {0}", id);
                    break;

                    //*******
                case "animal":
                    querysql = string.Format(@"SELECT * FROM ANIMAL WHERE ID = {0}", id);
                    break;
                    //*******
            }

            SqlCommand cmdsql = new SqlCommand(querysql, cnn);
            SqlDataReader lector = cmdsql.ExecuteReader();
            while(lector.Read())
            {
                switch (tcon)
                {
                    case "conInv":
                        Cantidad = (lector.GetInt32(lector.GetOrdinal("CANTIDAD"))).ToString();

                        if (lector.IsDBNull(lector.GetOrdinal("DESCR")))
                        {
                            Descr = "";
                        }
                        else
                        {
                            Descr = lector.GetString(lector.GetOrdinal("DESCR"));

                        }

                        Nom = lector.GetString(lector.GetOrdinal("NOMBRE"));
                        if (lector.IsDBNull(lector.GetOrdinal("MARCA")))
                        {
                            MarPro = "";

                        }
                        else
                        {
                            MarPro = lector.GetString(lector.GetOrdinal("MARCA"));

                        }

                        if (lector.IsDBNull(lector.GetOrdinal("CNETO")))
                        {
                            CNetPro = "";

                        }
                        else
                        {
                            CNetPro = lector.GetString(lector.GetOrdinal("CNETO"));

                        }


                        break;
                    case "adoptante":
                        ID = (lector.GetInt32(lector.GetOrdinal("ID"))).ToString();
                        Nom = lector.GetString(lector.GetOrdinal("NOMBRE"));
                        ApeP = lector.GetString(lector.GetOrdinal("APE_PAT"));
                        ApeM = lector.GetString(lector.GetOrdinal("APE_MAT"));
                        Edad = (lector.GetInt32(lector.GetOrdinal("EDAD"))).ToString();

                        Tel = lector.GetString(lector.GetOrdinal("TEL"));
                        Dir = lector.GetString(lector.GetOrdinal("DIRECCION"));
                        Email = lector.GetString(lector.GetOrdinal("EMAIL"));
                        UA = (lector.GetDateTime(lector.GetOrdinal("ULT_ACT"))).ToString();

                        break;
                    case "animal":
                        ID = (lector.GetInt32(lector.GetOrdinal("ID"))).ToString();
                        Nom = lector.GetString(lector.GetOrdinal("NOMBRE"));
                        rAni = (lector.GetInt32(lector.GetOrdinal("ID_RAZA"))).ToString();
                        Edad = (lector.GetInt32(lector.GetOrdinal("EDAD"))).ToString();
                        UA = (lector.GetDateTime(lector.GetOrdinal("ULT_ACT"))).ToString();

                        break;
                    case "donante":
                        ID = (lector.GetInt32(lector.GetOrdinal("ID"))).ToString();
                        Nom = lector.GetString(lector.GetOrdinal("NOMBRE"));
                        ApeP = lector.GetString(lector.GetOrdinal("APE_PAT"));
                        ApeM = lector.GetString(lector.GetOrdinal("APE_MAT"));

                        if (lector.IsDBNull(lector.GetOrdinal("RFC")))
                        {
                            RFCD = "";
                        }
                        else
                        {
                            RFCD = lector.GetString(lector.GetOrdinal("RFC"));
                            
                        }
                        Tel = lector.GetString(lector.GetOrdinal("TEL"));
                        Dir = lector.GetString(lector.GetOrdinal("DIRECCION"));
                        UA = (lector.GetDateTime(lector.GetOrdinal("ULT_ACT"))).ToString();

                        break;

                    case "producto":
                        ID = (lector.GetInt32(lector.GetOrdinal("ID"))).ToString();
                        Nom = lector.GetString(lector.GetOrdinal("NOMBRE"));
                        if (lector.IsDBNull(lector.GetOrdinal("MARCA")))
                        {
                            MarPro = "";

                        }
                        else
                        {
                            MarPro = lector.GetString(lector.GetOrdinal("MARCA"));

                        }
                       // MarPro = lector.GetString(lector.GetOrdinal("MARCA"));

                        if (lector.IsDBNull(lector.GetOrdinal("CNETO")))
                        {
                            CNetPro = "";

                        }
                        else
                        {
                            CNetPro = lector.GetString(lector.GetOrdinal("CNETO"));

                        }
                        //CNetPro = lector.GetString(lector.GetOrdinal("CNETO"));
                        UA = (lector.GetDateTime(lector.GetOrdinal("ULT_ACT"))).ToString();

                        break;

                    case "evento":
                        ID = (lector.GetInt32(lector.GetOrdinal("ID"))).ToString();
                        Nom = lector.GetString(lector.GetOrdinal("NOMBRE"));
                        //Descr = lector.GetString(lector.GetOrdinal("DESCR"));

                        if (lector.IsDBNull(lector.GetOrdinal("DESCR")))
                        {
                            Descr = "";

                        }
                        else
                        {
                            Descr = lector.GetString(lector.GetOrdinal("DESCR"));
                        }

                        LugEve = lector.GetString(lector.GetOrdinal("LUGAR"));
                        FecEve = (lector.GetDateTime(lector.GetOrdinal("FECHA"))).ToString();
                        IDtEve = (lector.GetInt32(lector.GetOrdinal("ID_TEVENTO"))).ToString();
                        EveEdo = (lector.GetInt32(lector.GetOrdinal("ID_EVE_EDO"))).ToString();
                        UA = (lector.GetDateTime(lector.GetOrdinal("ULT_ACT"))).ToString();
                        
                        break;

                }
                r = true;
            }



            return r;

        }




        //-----Variables de consulta----//

        public static string Nom { get; set; }

        public static string RFCD { get; set; }

        public static string Tel { get; set; }

        public static string Dir { get; set; }

        public static string UA { get; set; }

        public static string ID { get; set; }

        public static string ApeP { get; set; }

        public static string ApeM { get; set; }

        public static string MarPro { get; set; }

        public static string CNetPro { get; set; }

        public static string Descr { get; set; }

        public static string LugEve { get; set; }

        public static string FecEve { get; set; }

        public static string IDtEve { get; set; }

        public static string EveEdo { get; set; }
        
        public static string Edad { get; set; }

        public static string tAni { get; set; }

        public static string rAni { get; set; }

        public static string Email { get; set; }

        public static string Cantidad { get; set; }

        //---- ******* -----//



        internal static void AltaInv(string idDon, string Cant, string idProd, string idEve)
        {
            string usrU = UsuarioON.usr;
            string cadena = string.Format(@"SELECT * FROM INVENTARIO WHERE ID_PRODUCTO = " + idProd);
            string sqlInvH = string.Format(@"INSERT INTO INV_HIST(ID_AFILIADO,ID_PRODUCTO,CANTIDAD,DESCR,CADUCIDAD,ID_DONANTE,ID_EVENTO,ALTA_BAJA,ULT_ACT) SELECT (SELECT ID_AFIL FROM USR WHERE USR='{0}'),{1},{2},'','TEMPORAL/PRUEBA',{3},{4},1,GETDATE()",usrU,idProd,Cant,idDon,idEve);
            string sqlInv;

            SqlConnection con = conect();
            con.Open();
            
            if (ConsultaIds(cadena) == 0)
            {
                sqlInv = string.Format(@"INSERT INTO INVENTARIO(ID_PRODUCTO,CANTIDAD,DESCR,ULT_ACT) VALUES ({0},{1},'',GETDATE());", idProd, Cant);
            }
            else
            {
                int[] ids = Metodos.colecDatos(cadena);

                sqlInv = string.Format(@"UPDATE INVENTARIO SET CANTIDAD = CANTIDAD + "+Cant+" WHERE ID = "+ ids[0]);
            }


            SqlCommand cmd = new SqlCommand(sqlInvH, con);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(sqlInv, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        internal static void bajaInv(string id, string cant,string concep)
        {
            string usrU = UsuarioON.usr;
            string cadena = string.Format(@"SELECT * FROM INVENTARIO WHERE ID_PRODUCTO = " + id);
            string sqlInvH = string.Format(@"INSERT INTO INV_HIST(ID_AFILIADO,ID_PRODUCTO,CANTIDAD,DESCR,CADUCIDAD,ID_DONANTE,ID_EVENTO,ALTA_BAJA,ULT_ACT) SELECT (SELECT ID_AFIL FROM USR WHERE USR='{0}'),{1},{2},'','{3}',null,null,0,GETDATE()", usrU, id, cant, concep);
            string sqlInv;

            SqlConnection con = conect();
            con.Open();

            int[] ids = Metodos.colecDatos(cadena);

            sqlInv = string.Format(@"UPDATE INVENTARIO SET CANTIDAD = CANTIDAD - " + cant + " WHERE ID = " + ids[0]);
        
            SqlCommand cmd = new SqlCommand(sqlInvH, con);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(sqlInv, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
