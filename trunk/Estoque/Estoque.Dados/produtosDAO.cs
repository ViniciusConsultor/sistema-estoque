using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    #endregion

    #region Atributos

    #endregion

    #region Métodos

    /// <summary>
    /// Carrega as Categorias do Banco
    /// </summary>
    /// <param name="config"> Configuração da ConnectionString</param>
    /// <returns>List<string> Categoria</returns>
    public List<string> carregaCatProd(Configuracoes config)
    {

      #region Declaração

      string sql = string.Empty;
      SqlConnection conn = null;
      SqlCommand cmd = null;
      List<string> Categorias = null;
      #endregion

      #region Implementação
      Categorias = new List<string>();

      try
      {
        conn = new SqlConnection(config.ConectionString);
        cmd = new SqlCommand();
        SqlDataReader dr = null;
        sql = "SELECT idCategoria, categoria FROM dbo.categoria";

        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;
        cmd.CommandText = sql;

        if (conn.State == ConnectionState.Closed)
          conn.Open();

        dr = cmd.ExecuteReader();

        int i = 0;
        while (dr.Read())
        {
          Categorias.Add(dr[i].ToString().Trim());
          i++;
        }

        return Categorias;
      }
      catch (Exception ex)
      {
        return Categorias;
      }
      finally
      {
        if (conn.State == ConnectionState.Open)
          conn.Close();
      }

      #endregion


    }
    #endregion
  }







}
