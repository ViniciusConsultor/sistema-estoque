using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{
    public class Configuracoes
    {

        #region Propriedades

        private static string servidor;

        public string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }

        private static string database;

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        private static string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private static string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool conectado;

        private string conectionString;

        public string ConectionString
        {
            get { return conectionString; }
            set { conectionString = value; }
        }

        
       
        #endregion

        #region Construtor

        public Configuracoes()
        {

        }
        #endregion

        #region Métodos


        #endregion
    }
}
