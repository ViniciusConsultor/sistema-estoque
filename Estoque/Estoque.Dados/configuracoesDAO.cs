using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Estoque.Module;

namespace Estoque.Dados
{
    public class configuracoesDAO
    {

        #region Construtor

        public configuracoesDAO()
        {

        }

        #endregion

        #region Métodos

        public bool salvaServidor(Configuracoes config)
        {

            #region Declaração

            #endregion

            #region Implementação

            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return true;
            #endregion
        }

        #endregion

    }
}
