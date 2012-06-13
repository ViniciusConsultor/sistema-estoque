using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Estoque.Module;
using Estoque.Dados;

namespace Estoque.Controller
{
    public class configuracoesControler
    {

        #region Construtor

        public configuracoesControler()
        {

        }
        #endregion

        #region Métodos

        public bool servidorSQL(Configuracoes config)
        {

            #region Declaração

            #endregion

            #region Implementação

            return true;
            #endregion
        }

        public SqlConnection carregaConfiguracao()
        {

            #region Declaração

            dataBase data = null;
            #endregion

            #region Implementação

            data = new dataBase();

            return data.conectar();
            #endregion
        }

        public Configuracoes carregaString()
        {

            #region Declaração

            #endregion

            #region Implementação

            #endregion
        }

        #endregion
    }
}
