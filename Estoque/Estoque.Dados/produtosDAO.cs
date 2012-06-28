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
      List<string> Categorias = null;

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

      #endregion Declaração

      #region Implementação

      conn = new SqlConnection(config.ConectionString);
      cmd = new SqlCommand();
      cmd.CommandType = CommandType.Text;

      try
      {
        sql = "";

        cmd.CommandText = sql;

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
      }

      #endregion Implementação
    }


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

      sql = @"SELECT count('dbo.Proutos')";

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
    #endregion Métodos
  }
}