using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Estoque.Dados;
using Estoque.Module;

namespace Estoque.Controller
{
    public class funcionarioControler
    {

      #region Construtor

      public funcionarioControler()
      {
      }

      #endregion

      #region Métodos

      public int cadastrar(string strConn, Funcionario func, Usuario user)
      {

        #region Declaração

        funcionarioDAO funcionario = null;

        #endregion

        #region Implementação

        funcionario = new funcionarioDAO();

        return funcionario.insertFuncionario(strConn, func, user);

        #endregion

      }

      public List<Estado> lstEstados(string strConn)
      {

        #region Declaração

        funcionarioDAO func = null;

        #endregion

        #region Implementação

        func = new funcionarioDAO();

        return func.carregaEstados(strConn);

        #endregion

      }

      public List<Cidade> lstCidades(string strConn, int idEstado)
      {

        #region Declaração

        funcionarioDAO func = null;

        #endregion

        #region Implementação

        func = new funcionarioDAO();

        return func.carregaCidades(strConn,idEstado);

        #endregion

      }

      public DataTable pesquisar(string tipoPesquisa, string pesquisa, string strConn)
      {

        #region Declaração
        funcionarioDAO func = null;

        #endregion

        #region Implementação

        func = new funcionarioDAO();

        return func.Buscar(tipoPesquisa, pesquisa, strConn);

        #endregion

      }

      public bool update(string strConn, Funcionario funcio)
      {

         #region Declaração
         funcionarioDAO func = null;

         #endregion

         #region Implementação

         func = new funcionarioDAO();

         return func.Update(strConn, funcio);

         #endregion

      }
      #endregion
    }
}
