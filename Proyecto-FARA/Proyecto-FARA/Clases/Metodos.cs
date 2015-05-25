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
            try
            {
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
            }
            catch { 
                            
            }
            this.cnn.Close();
            return resultado;
        }

        private void CreateUser(string p)
        {
            //Consultar JOIN para extrael todos los datos del usuario
            this.sql = string.Format(@"SELECT U.USR,U.PWD,A.NOMBRE,A.APE_PAT,A.APE_MAT,A.EDAD,A.DIRECCION,A.TEL,A.EMAIL,TA.TAFIL,TU.TUSR,U.ACTIVO,U.ULT_ACT FROM USR U INNER JOIN AFIL A ON U.ID_AFIL=A.ID INNER JOIN TUSR TU ON TU.ID=U.ID_TUSR INNER JOIN TAFIL TA ON TA.ID=A.ID_TAFIL WHERE U.USR='{0}'", p);
            this.cmdsql0 = new SqlCommand(this.sql, this.cnn);
            try
            {
                SqlDataReader cus = null;
                cus = this.cmdsql0.ExecuteReader();
                cus.Read();
                //Crear el objeto tipo USUARIO
                User u = new User(cus["USR"].ToString(), cus["PWD"].ToString(), cus["NOMBRE"].ToString(), cus["APE_PAT"].ToString(), cus["APE_MAT"].ToString(), cus["DIRECCION"].ToString(), cus["TEL"].ToString(), cus["EMAIL"].ToString(), cus["TAFIL"].ToString(), cus["TUSR"].ToString(), cus["ACTIVO"].ToString(), cus["EDAD"].ToString());
                // Asignar usuario a nuestra variable global
                UsuarioON = u;
            }
            catch
            {

            }
         }


        public  User Iniciado()
        {
            //Regresa nuestra variable global de tipo Usuario
            return UsuarioON;
        }

        public SqlDataAdapter BusquedaC(string cmd)
        {
            try
            {
                this.sql = string.Format(@"{0}", cmd);
                this.cmdsql = new SqlCommand(this.sql, this.cnn);
                this.cnn.Open();
                                               
            }
            catch {    }

            this.cnn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmdsql);
            return da;
        }

        public static int ConsultaIds(string cmd)
        {
            int total = 0;
            SqlConnection cnn = conect();
            SqlCommand cmdsql= new SqlCommand(cmd, cnn);
            cnn.Open();
            try
            {
                SqlDataReader lector = cmdsql.ExecuteReader();
                while (lector.Read())
                {
                    total++;
                }
            }
            catch { }
            return total;
        }

        public static int ConfirmaUSR(string usr)
        {
            int total = 0;
            string cmd = string.Format(@"SELECT * FROM USR WHERE USR = '{0}'", usr);
            SqlConnection cnn = conect();
            SqlCommand cmdsql = new SqlCommand(cmd, cnn);
            cnn.Open();
            try
            {
                SqlDataReader lector = cmdsql.ExecuteReader();
                if (lector.Read())
                {
                    total=1;
                }
            }
            catch { }
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
            try
            {
                SqlDataReader lector = cmdsql.ExecuteReader();
                int c = 0;

                while (lector.Read())
                {
                    temp[c] = lector.GetInt32(lector.GetOrdinal("ID"));
                    c++;
                }
            }
            catch { }
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
                case "afiliado":
                    querysql = string.Format(@"SELECT * FROM AFIL WHERE ID = {0}", id);
                    break;
                case "usuario":
                    querysql = string.Format(@"SELECT u.id,U.USR,U.PWD,tu.TUSR as TUSR,tu.id as idtusr,u.ACTIVO,ta.descr as TAFIL,A.NOMBRE,a.APE_PAT,a.APE_MAT,a.EDAD,a.DIRECCION,a.TEL,a.EMAIL,U.ULT_ACT FROM USR U INNER JOIN AFIL A ON U.ID_AFIL=A.ID inner join TUSR tu on u.ID_TUSR=tu.id inner join tafil ta on a.id_tafil=ta.id WHERE u.ID = {0}", id);
                    break;

                    //*******
                case "animal":
                    querysql = string.Format(@"SELECT * FROM ANIMAL WHERE ID = {0}", id);
                    break;
                    //*******
            }

            try{
            SqlCommand cmdsql = new SqlCommand(querysql, cnn);
            SqlDataReader lector = cmdsql.ExecuteReader();
            while (lector.Read())
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
                        tAfil = (lector.GetInt32(lector.GetOrdinal("ID_TAFIL"))).ToString();

                        UA = (lector.GetDateTime(lector.GetOrdinal("ULT_ACT"))).ToString();

                        break;
                    case "afiliado":
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

                    case "usuario":
                        ID = (lector.GetInt32(lector.GetOrdinal("ID"))).ToString();
                        Usr = lector.GetString(lector.GetOrdinal("USR"));
                        Pwd = lector.GetString(lector.GetOrdinal("PWD"));
                        tAfil = lector.GetString(lector.GetOrdinal("TAFIL"));
                        activo = (lector.GetBoolean(lector.GetOrdinal("ACTIVO"))).ToString();
                        tUsr = lector.GetString(lector.GetOrdinal("TUSR"));
                        Nom = lector.GetString(lector.GetOrdinal("NOMBRE"));
                        ApeP = lector.GetString(lector.GetOrdinal("APE_PAT"));
                        ApeM = lector.GetString(lector.GetOrdinal("APE_MAT"));
                        Edad = (lector.GetInt32(lector.GetOrdinal("EDAD"))).ToString();

                        Tel = lector.GetString(lector.GetOrdinal("TEL"));
                        Dir = lector.GetString(lector.GetOrdinal("DIRECCION"));
                        Email = lector.GetString(lector.GetOrdinal("EMAIL"));
                        UA = (lector.GetDateTime(lector.GetOrdinal("ULT_ACT"))).ToString();
                        IdTUsr = lector.GetInt32(lector.GetOrdinal("idtusr"));

                        break;

                }
            

                r = true;
            }


            }
            catch { }

            return r;

        }




        //-----Variables de consulta----//
        
        public static string Pwd { get; set; }
        
        public static string Usr { get; set; }

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

        public static string tAfil { get; set; }

        public static string tUsr { get; set; }

        public static string activo { get; set; }

        public static int IdTUsr { get; set; }

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

            try
            {

                SqlCommand cmd = new SqlCommand(sqlInvH, con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(sqlInv, con);
                cmd.ExecuteNonQuery();
            }
            catch { }

            con.Close();
        }

        internal static void bajaInv(string id, string cant,string concep)
        {
            string usrU = UsuarioON.usr;
            string cadena = string.Format(@"SELECT * FROM INVENTARIO WHERE ID_PRODUCTO = " + id);
            string sqlInvH = string.Format(@"INSERT INTO INV_HIST(ID_AFILIADO,ID_PRODUCTO,CANTIDAD,DESCR,CADUCIDAD,ID_DONANTE,ID_EVENTO,ALTA_BAJA,ULT_ACT) SELECT (SELECT ID_AFIL FROM USR WHERE USR='{0}'),{1},{2},'{3}','',null,null,0,GETDATE()", usrU, id, cant, concep);
            string sqlInv;

            SqlConnection con = conect();
            con.Open();

            int[] ids = Metodos.colecDatos(cadena);

            sqlInv = string.Format(@"UPDATE INVENTARIO SET CANTIDAD = CANTIDAD - " + cant + " WHERE ID = " + ids[0]);

            try
            {
                SqlCommand cmd = new SqlCommand(sqlInvH, con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(sqlInv, con);
                cmd.ExecuteNonQuery();

            }
            catch { }

            con.Close();
        }

        internal static void AltaUsr(string usr, string pwd, string ida, string idtusr)
        {
            string sqlusr = string.Format(@"INSERT INTO USR(USR,PWD,ID_AFIL,ID_TUSR,ACTIVO,ULT_ACT) VALUES ('{0}','{1}',{2},{3},1,GETDATE())", usr, pwd, ida, idtusr);
            SqlConnection con = conect();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlusr, con);
                cmd.ExecuteNonQuery();
                                
            }
            catch { }

            con.Close();
        }

        public static List<catalogos> LlenarCombo(string llenado)
        {
            List<catalogos> val = new List<catalogos>();
            SqlConnection cnn = conect();
            string cmd = string.Format(@"SELECT * FROM {0}",llenado);
            
            cnn.Open();
            SqlCommand cmdsql = new SqlCommand(cmd, cnn);
            try
            {
                SqlDataReader lector = cmdsql.ExecuteReader();

                while (lector.Read())
                {
                    catalogos cat = new catalogos();
                    
                    cat.ID = lector.GetInt32(lector.GetOrdinal("ID"));
                    cat.Nombre = lector.GetString(lector.GetOrdinal(llenado));
                    
                    val.Add(cat);
                }
            }
            catch { }

            return val;
        }
    }
}
