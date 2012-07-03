using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Estoque.Module;

namespace Estoque.Dados
{
  public class produtosDAO
  {
    #region Construtor

    public produtosDAO()
    {
    }

    #endregion Construtor

    #region Atributos

    #endregion Atributos

    #region Métodos

    /// <summary>
    /// Carrega as Categorias do Banco
    /// </summary>
    /// <param name="config"> Configuração da ConnectionString</param>
    /// <returns>List<string> Categoria</returns>
    public List<Categoria> carregaCatProd(Configuracoes config)
    {

      #region Declaração

      string sql = string.Empty;
      SqlConnection conn = null;
      SqlCommand cmd = null;

      #endregion Declaração

      #region Implementação

      Categoria categoria = null;
      List<Categoria> listCategoria = null;
      try
      {
        conn = new SqlConnection(config.ConectionString);
        cmd = new SqlCommand();

        listCategoria = new List<Categoria>();

        SqlDataReader dr = null;
        sql = "SELECT idCategoria, categoria FROM dbo.categoria";

        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;
        cmd.CommandText = sql;

        if (conn.State == ConnectionState.Closed)
          conn.Open();

        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
          categoria = new Categoria();
          categoria.IdCategoria = int.Parse(dr["idCategoria"].ToString().Trim());
          categoria.CategoriaP = dr["categoria"].ToString().Trim();

          listCategoria.Add(categoria);
        }

        return listCategoria;
      }
      catch (Exception ex)
      {
        return listCategoria;
      }
      finally
      {
        if (conn.State == ConnectionState.Open)
          conn.Close();
      }

      #endregion Implementação

    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="produto">Objeto Produto</param>
    /// <returns>true ou flase</returns>
    public bool cadastraProduto(Produto produto, Configuracoes config)
    {

      #region Declaração

      string sql = string.Empty;
      SqlConnection conn = null;
      SqlCommand cmd = null;
      string data = DateTime.Now.ToString("dd-MM-yyyy");

      #endregion Declaração

      #region Implementação

      conn = new SqlConnection(config.ConectionString);
      cmd = new SqlCommand();
      cmd.CommandType = CommandType.Text;
      cmd.Connection = conn;
      try
      {

        sql = @"INSERT INTO dbo.Produtos (nome, idCategoria, codigoBarras, quantidade, diponivel, idFornecedor, valorAVista, valorBase, valorPrazo, valorCredito, cadastradoEm, cadstradoPor)
                VALUES (@nome, @idcategoria, @codigobarras, @quantidade, @disponivel, @idfornecedor, @valoravista, @valorbase, @valorprazo, @valorcredito, @cadastradoem, @cadstradopor)";

        cmd.CommandText = sql;

        cmd.Parameters.AddWithValue("@nome", produto.Nome);
        cmd.Parameters.AddWithValue("@idcategoria", int.Parse(produto.IdCategoria.ToString()));
        cmd.Parameters.AddWithValue("@codigobarras", produto.CodigoBarras);
        cmd.Parameters.AddWithValue("@quantidade", int.Parse(produto.Quantidade.ToString()));
        cmd.Parameters.AddWithValue("@disponivel", produto.Disponivel);
        cmd.Parameters.AddWithValue("@idfornecedor", int.Parse(produto.IdFornecedor.ToString()));
        cmd.Parameters.AddWithValue("@valoravista", int.Parse(produto.ValoraVista.ToString()));
        cmd.Parameters.AddWithValue("@valorbase", int.Parse(produto.ValorBase.ToString()));
        cmd.Parameters.AddWithValue("@valorprazo", int.Parse(produto.ValorAPrazo.ToString()));
        cmd.Parameters.AddWithValue("@valorcredito", int.Parse(produto.ValorCrediario.ToString()));
        cmd.Parameters.AddWithValue("@cadastradoem", DateTime.Now);
        cmd.Parameters.AddWithValue("@cadstradopor", int.Parse("1"));

        conn.Open();

        cmd.ExecuteNonQuery();

        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
      finally
      {
        if (conn.State == ConnectionState.Open)
          conn.Close();
        cmd.Dispose();
        conn.Dispose();

      }

      #endregion Implementação

    }

    /// <summary>
    /// Carrega o ultimo registro do banco
    /// </summary>
    /// <param name="config">Configuraçções da conexão</param>
    /// <returns>Int - ultimo registro do banco</returns>
    public int carregaUltimoRegistro(Configuracoes config)
    {

      #region Declaração

      SqlConnection conn = null;
      SqlCommand cmd = null;
      string sql = string.Empty;
      int ultimoRegistro = 0;

      #endregion

      #region Implementação

      conn = new SqlConnection(config.ConectionString);

      sql = @"SELECT ident_current('dbo.Produtos')";

      conn.Open();

      cmd = new SqlCommand(sql, conn);

      SqlDataReader dr = cmd.ExecuteReader();

      if (dr.HasRows)
      {
        while (dr.Read())
        {
          ultimoRegistro = Convert.ToInt32(dr[0].ToString());
        }
      }
      return ultimoRegistro;

      #endregion

    }

    public Fornecedor PesquisaFornecedor(Configuracoes config)
    {

      #region Declaração

      SqlConnection conn = null;
      SqlCommand cmd = null;
      string sql = string.Empty;
      Fornecedor fornecedor = null;

      #endregion

      #region Implementação

      conn = new SqlConnection(config.ConectionString);
      fornecedor = new Fornecedor();

      sql = @"SELECT ident_current('dbo.Produtos')";

      conn.Open();

      cmd = new SqlCommand(sql, conn);

      SqlDataReader dr = cmd.ExecuteReader();

      if (dr.HasRows)
      {
        while (dr.Read())
        {
          fornecedor.IdFornecedor = Convert.ToInt32(dr[0].ToString());
        }
      }
      return fornecedor;

      #endregion
    }
    #endregion Métodos

  }
}