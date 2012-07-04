using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estoque.Dados;
using Estoque.Module;

namespace Estoque.Controller
{
    public class funcionarioControler
    {

      #region Métodos

      public int? ultimoRegistro(Configuracoes config)
      {

        #region Declaração

        funcionarioDAO funcDAO = null;
        #endregion

        #region Implementação

        funcDAO = new funcionarioDAO();

        return funcDAO.LastID(config);
        #endregion

      }

      public int cadastrar(Configuracoes config, Funcionario func)
      {

        #region Declaração

        funcionarioDAO funcionario = null;

        #endregion

        #region Implementação

        funcionario = new funcionarioDAO();

        return funcionario.insertFuncionario(config, func);

        #endregion

      }

      public List<Estado> lstEstados(Configuracoes config)
      {

        #region Declaração

        funcionarioDAO func = null;

        #endregion

        #region Implementação

        func = new funcionarioDAO();

        return func.carregaEstados(config);

        #endregion
      }

      public List<Cidade> lstCidades(Configuracoes config, int idEstado)
      {

        #region Declaração

        funcionarioDAO func = null;

        #endregion

        #region Implementação

        func = new funcionarioDAO();

        return func.carregaCidades(config,idEstado);

        #endregion

      }

      #endregion
    }
}
