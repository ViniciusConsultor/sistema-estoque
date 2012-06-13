using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Estoque.Module;

namespace Estoque.Dados
{
    public class dataBase
    {

        #region Construtor

        public dataBase()
        {
        }
        #endregion

        #region Declaração

        Configuracoes config = null;

        String strConn = ConfigurationManager.ConnectionStrings["meta"].ConnectionString;

        SqlConnection conn = new SqlConnection();

        SqlConnectionStringBuilder myCSB = new SqlConnectionStringBuilder();

        
        
        #endregion

        #region Implementação

        public SqlConnection conectar()
        {
            config.conectionString = strConn;

            try
            {
                conn.ConnectionString = strConn;

                conn.Open();

            }
            catch
            {
                if (conn.State != ConnectionState.Open)
                {
                    myCSB.DataSource = config.servidor;
                    myCSB.InitialCatalog = config.database;
                    myCSB.UserID = config.user;
                    myCSB.Password = config.senha;

                    conn.ConnectionString = myCSB.ConnectionString;

                    try
                    {
                        conn.Open();
                    }
                    catch
                    {
                        return conn;
                    }
                }
            }

            return conn;
        }

        public string createStringConnection()
        {
            myCSB.DataSource = config.servidor;
            myCSB.InitialCatalog = config.database;
            myCSB.UserID = config.user;
            myCSB.Password = config.senha;

            return myCSB.ConnectionString;
        }

        public void iserirConexao()
        {
            config.servidor = ConfigurationManager.AppSettings["servidor"];
        }
        #endregion
    }
}
