using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Estoque.Module;

namespace Estoque.Dados
{
  public class funcionarioDAO
  {

    #region Construtor

    public funcionarioDAO()
    {
    }

    #endregion

    #region Métodos

    /// <summary>
    /// Retorna o Ultimo Indice da Tabela
    /// </summary>
    /// <param name="config">Configurações</param>
    /// <returns>Ultimo ID da Tabela</returns>
    public int LastID(Configuracoes config)
    {

      #region Declaração

      SqlConnection conn = null;
      SqlCommand cmd = null;
      string sql = string.Empty;
      int ultimoRegistro = 0;
      string id = "";

      #endregion

      #region Implementação

      conn = new SqlConnection(config.ConectionString);

      sql = @"SELECT MAX(idFuncionario) FROM Funcionario";

      conn.Open();

      cmd = new SqlCommand(sql, conn);

      SqlDataReader dr = cmd.ExecuteReader();

      if (dr.HasRows)
      {
        while (dr.Read())
        {
          id = dr[0].ToString();
        }
      }
      if (id == "")
      {
        id = "0";
        ultimoRegistro = Convert.ToInt32(id);
      }

      return ultimoRegistro;

      #endregion

    }

    public bool insertFuncionario(Configuracoes config, Funcionario funcionario)
    {

      #region Declaração

      SqlConnection conn = null;
      SqlCommand cmd = null;
      string sql = string.Empty;

      #endregion

      #region Implementação

      conn = new SqlConnection();
      cmd = new SqlCommand();
      try
      {

        conn.ConnectionString = config.ConectionString;
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;

        sql = @"INSERT INTO dbo.Funcionario (nome, dataNascimento, usuario, senha, perfil, email, cpf, rg, ctps, ctpsSerie, telefone, celular, rua, casaNum, idCidade, idEstado, cargo, Referencia)
VALUES (@nome, @datanascimento, @usuario, @senha, @perfil, @email, @cpf, @rg, @ctps, @ctpsserie, @telefone, @celular, @rua, @casanum, @idcidade, @idestado, @cargo, @referencia)";

        cmd.CommandText = sql;

        cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
        cmd.Parameters.AddWithValue("@datanascimento", funcionario.DataNascimento);
        cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
        cmd.Parameters.AddWithValue("@senha", funcionario.Senha);
        cmd.Parameters.AddWithValue("@perfil", funcionario.Perfil);
        cmd.Parameters.AddWithValue("@email", funcionario.Email);
        cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
        cmd.Parameters.AddWithValue("@rg", funcionario.Rg);
        cmd.Parameters.AddWithValue("@ctps", funcionario.Ctps);
        cmd.Parameters.AddWithValue("@ctpsserie", funcionario.CtpsSerie);
        cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
        cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
        cmd.Parameters.AddWithValue("@rua", funcionario.Rua);
        cmd.Parameters.AddWithValue("@casanum", funcionario.CasaNumero);
        cmd.Parameters.AddWithValue("@idcidade", funcionario.IdCidade);
        cmd.Parameters.AddWithValue("@idestado", funcionario.IdEstado);
        cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
        cmd.Parameters.AddWithValue("@referencia", funcionario.Referencia);

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
        conn.Close();
      }

      #endregion
    }

    public List<Estado> carregaEstados(Configuracoes config)
    {

      #region Declaração

      string sql = string.Empty;
      SqlConnection conn = null;
      SqlCommand cmd = null;
      SqlDataReader dr = null;
      Estado estado = null;
      List<Estado> estados = null;

      #endregion

      #region Implementação


      try
      {
        conn = new SqlConnection();
        cmd = new SqlCommand();

        conn.ConnectionString = config.ConectionString;
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;

        estados = new List<Estado>();

        sql = "SELECT es.EstadoId,es.Sigla FROM Estado AS es";

        cmd.CommandText = sql;

        conn.Open();

        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
          estado = new Estado();
          estado.Id = int.Parse(dr["EstadoId"].ToString());
          estado.Sigla = dr["Sigla"].ToString();

          estados.Add(estado);
        }
        return estados;

      }
      catch
      {
        return estados;
      }
      finally
      {
        conn.Close();
      }
      #endregion

    }

    public List<Cidade> carregaCidades(Configuracoes config, int idEstado)
    {

      #region Declaração

      string sql = string.Empty;
      SqlConnection conn = null;
      SqlCommand cmd = null;
      SqlDataReader dr = null;
      Cidade cidade = null;
      List<Cidade> cidades = null;

      #endregion

      #region Implementação


      try
      {
        conn = new SqlConnection();
        cmd = new SqlCommand();

        conn.ConnectionString = config.ConectionString;
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;

        cidades = new List<Cidade>();

        sql = "SELECT ci.CidadeId,ci.Nome FROM Cidade AS ci WHERE ci.EstadoId" + idEstado;

        cmd.CommandText = sql;

        conn.Open();

        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
          cidade = new Cidade();
          cidade.Id = int.Parse(dr["CidadeId"].ToString());
          cidade.Cidade = dr["Nome"].ToString();

          cidades.Add(cidade);
        }
        return cidades;

      }
      catch
      {
        return cidades;
      }
      finally
      {
        conn.Close();
      }
      #endregion

    }
    #endregion
  }
}
