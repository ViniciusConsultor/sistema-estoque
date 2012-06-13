using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{
    public class Configuracoes
    {

        #region Propriedades

        public string servidor { get; set; }

        public string database { get; set; }

        public string user { get; set; }

        public string senha { get; set; }

        public bool conectado { get; set; }

        public string conectionString { get; set; }

        
       
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
