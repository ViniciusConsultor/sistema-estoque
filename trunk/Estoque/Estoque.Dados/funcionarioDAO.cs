using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
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

    public List<Cidade> carregaCidades(string strConn, int idEstado)
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

        conn.ConnectionString = strConn;
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;

        cidades = new List<Cidade>();

        sql = "SELECT ci.CidadeId,ci.Nome FROM Cidade AS ci WHERE ci.EstadoId = " + idEstado;

        cmd.CommandText = sql;

        conn.Open();

        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
          cidade = new Cidade();
          cidade.Id = int.Parse(dr["CidadeId"].ToString());
          cidade.Nome = dr["Nome"].ToString();

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

    public List<Estado> carregaEstados(string strConn)
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

        conn.ConnectionString = strConn;
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

    public int insertFuncionario(string strConn, Funcionario funcionario, Usuario usuario)
    {

      #region Declaração

      SqlConnection conn = null;
      SqlCommand cmd = null;
      string sql = string.Empty;
      int ID = 0;

      #endregion

      #region Implementação

      conn = new SqlConnection();
      cmd = new SqlCommand();
      try
      {

        conn.ConnectionString = strConn;
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //sql = @"INSERT INTO dbo.Funcionario (nome, dataNascimento, usuario, senha, perfil, email, cpf, rg, ctps, ctpsSerie, telefone, celular, rua, casaNum, idCidade, idEstado, cargo, Referencia)
        //VALUES (@nome, @datanascimento, @usuario, @senha, @perfil, @email, @cpf, @rg, @ctps, @ctpsserie, @telefone, @celular, @rua, @casanum, @idcidade, @idestado, @cargo, @referencia) set @id = @@identity";

        cmd.CommandText = "sp_insert_funcionario";

        cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
        cmd.Parameters.AddWithValue("@datanascimento", funcionario.DataNascimento);
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
        cmd.Parameters.Add("@id", 0).Direction = System.Data.ParameterDirection.Output;

        conn.Open();

        cmd.ExecuteNonQuery();

        ID = Convert.ToInt32(cmd.Parameters["@id"].Value);

        if (usuario.Acesso == true)
        {

          conn.Close();

          cmd = null;
          cmd = new SqlCommand();

          conn.ConnectionString = strConn;
          cmd.Connection = conn;
          cmd.CommandType = System.Data.CommandType.StoredProcedure;

          cmd.CommandText = "sp_insert_usuario";

          cmd.Parameters.AddWithValue("@usuario", usuario.User);
          cmd.Parameters.AddWithValue("@senha", usuario.Senha);
          cmd.Parameters.AddWithValue("@perfil", usuario.Perfil);
          cmd.Parameters.AddWithValue("idfuncionario", ID);
          cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);

          conn.Open();

          cmd.ExecuteNonQuery();

        }
        

        return ID;

      }
      catch (Exception ex)
      {
        return ID;
      }
      finally
      {
        conn.Close();
      }

      #endregion

    }

    public DataTable Buscar(string tipoPesquisa, string pesquisa, string strConn)
    {

      #region Declaração

      SqlConnection conn = null;
      SqlCommand cmd = null;
      SqlDataAdapter da = null;
      DataTable dt = null;
      string sql = string.Empty;

      #endregion

      #region Implementação

      switch (tipoPesquisa)
      {
        default:
          sql = @"SELECT funci.idFuncionario, funci.nome, funci.dataNascimento, funci.email, funci.cpf, funci.rg, funci.ctps, funci.ctpsSerie, funci.telefone, funci.celular,
                funci.cargo, funci.rua, funci.casaNum, funci.Referencia, funci.idCidade, funci.idEstado, funci.LastEditDate, funci.CreationDate, funci.excluido, cid.Nome
                FROM dbo.Funcionario AS funci INNER JOIN Cidade AS cid ON cid.CidadeId = funci.idCidade";
          break;
        case "Matricula":
          sql = @"SSELECT funci.idFuncionario, funci.nome, funci.dataNascimento, funci.email, funci.cpf, funci.rg, funci.ctps, funci.ctpsSerie, funci.telefone, funci.celular,
                funci.cargo, funci.rua, funci.casaNum, funci.Referencia, funci.idCidade, funci.idEstado, funci.LastEditDate, funci.CreationDate, funci.excluido, cid.Nome
                FROM dbo.Funcionario AS funci INNER JOIN Cidade AS cid ON cid.CidadeId = funci.idCidade WHERE funci.idFuncionario = " + pesquisa;
          break;
        case "Nome":
          sql = @"SELECT funci.idFuncionario, funci.nome, funci.dataNascimento, funci.email, funci.cpf, funci.rg, funci.ctps, funci.ctpsSerie, funci.telefone, funci.celular,
                funci.cargo, funci.rua, funci.casaNum, funci.Referencia, funci.idCidade, funci.idEstado, funci.LastEditDate, funci.CreationDate, funci.excluido, cid.Nome
                FROM dbo.Funcionario AS funci INNER JOIN Cidade AS cid ON cid.CidadeId = funci.idCidade WHERE funci.nome LIKE '" + pesquisa + "'";
          break;
        case "CPF":
          sql = @"SELECT funci.idFuncionario, funci.nome, funci.dataNascimento, funci.email, funci.cpf, funci.rg, funci.ctps, funci.ctpsSerie, funci.telefone, funci.celular,
                funci.cargo, funci.rua, funci.casaNum, funci.Referencia, funci.idCidade, funci.idEstado, funci.LastEditDate, funci.CreationDate, funci.excluido, cid.Nome
                FROM dbo.Funcionario AS funci INNER JOIN Cidade AS cid ON cid.CidadeId = funci.idCidade WHERE funci.cpf LIKE '" + pesquisa + "'";
          break;
        case "RG":
          sql = @"SELECT funci.idFuncionario, funci.nome, funci.dataNascimento, funci.email, funci.cpf, funci.rg, funci.ctps, funci.ctpsSerie, funci.telefone, funci.celular,
                funci.cargo, funci.rua, funci.casaNum, funci.Referencia, funci.idCidade, funci.idEstado, funci.LastEditDate, funci.CreationDate, funci.excluido, cid.Nome
                FROM dbo.Funcionario AS funci INNER JOIN Cidade AS cid ON cid.CidadeId = funci.idCidade WHERE funci.rg LIKE '" + pesquisa + "'";
          break;
        case "Ativos":
          sql = @"SELECT funci.idFuncionario, funci.nome, funci.dataNascimento, funci.email, funci.cpf, funci.rg, funci.ctps, funci.ctpsSerie, funci.telefone, funci.celular,
                funci.cargo, funci.rua, funci.casaNum, funci.Referencia, funci.idCidade, funci.idEstado, funci.LastEditDate, funci.CreationDate, funci.excluido, cid.Nome
                FROM dbo.Funcionario AS funci INNER JOIN Cidade AS cid ON cid.CidadeId = funci.idCidade WHERE funci.excluido = 0";
          break;
        case "Inativos":
          sql = @"SELECT funci.idFuncionario, funci.nome, funci.dataNascimento, funci.email, funci.cpf, funci.rg, funci.ctps, funci.ctpsSerie, funci.telefone, funci.celular,
                funci.cargo, funci.rua, funci.casaNum, funci.Referencia, funci.idCidade, funci.idEstado, funci.LastEditDate, funci.CreationDate, funci.excluido, cid.Nome
                FROM dbo.Funcionario AS funci INNER JOIN Cidade AS cid ON cid.CidadeId = funci.idCidade WHERE funci.excluido = 1";
          break;
      }

      try
      {

        conn = new SqlConnection();
        conn.ConnectionString = strConn;

        cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sql;
        cmd.Connection = conn;

        conn.Open();

        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        da.GetFillParameters();

        dt = new DataTable();
        da.Fill(dt);

        return dt;

      }
      catch (Exception ex)
      {
        return dt;
      }
      finally
      {
        conn.Close();
      }


      #endregion
    }

    public bool Update(string strConn, Funcionario funcionario)
    {

      #region Declaração

      #endregion

      #region Implementação

      #endregion
    }
    #endregion

  }
}
