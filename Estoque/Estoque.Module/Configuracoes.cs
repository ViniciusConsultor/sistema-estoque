using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;

namespace Estoque.Module
{
  public class Configuracoes
  {

    #region Atributos

    private static string servidor;
    private static string database;
    private static string user;
    private static string senha;
    private string conectionString;
    private List<string> _servidores;
    private List<string> _databases;
    private Server _sqlServer;
    private string _fileName;
    private BackupDevice _bkpDevice;
    private List<string> _arquivosRestore;
    private string _path;

    #endregion

    #region Propriedades

    /// <summary>
    /// Servidor Sql
    /// </summary>
    public string Servidor
    {
      get { return servidor; }
      set { servidor = value; }
    }

    /// <summary>
    /// Banco do Servidor
    /// </summary>
    public string Database
    {
      get { return database; }
      set { database = value; }
    }

    /// <summary>
    /// Usuário do Banco
    /// </summary>
    public string User
    {
      get { return user; }
      set { user = value; }
    }

    /// <summary>
    /// Senha do Banco
    /// </summary>
    public string Senha
    {
      get { return senha; }
      set { senha = value; }
    }

    /// <summary>
    /// String para Conexão
    /// </summary>
    public string ConectionString
    {
      get { return conectionString; }
      set { conectionString = value; }
    }

    /// <summary>
    /// Lista de Servidores SQL
    /// </summary>
    public List<string> Servidores
    {
      get { return _servidores; }
      set { _servidores = value; }
    }

    /// <summary>
    /// Lista de Banco no Servidor
    /// </summary>
    public List<string> Databases
    {
      get { return _databases; }
      set { _databases = value; }
    }

    /// <summary>
    /// Todas as Configuraçãos para Backup e Restore
    /// </summary>
    public Server SqlServer
    {
      get { return _sqlServer; }
      set { _sqlServer = value; }
    }

    /// <summary>
    /// Nome do arquivo para Backup
    /// </summary>
    public string FileName
    {
      get { return _fileName; }
      set { _fileName = value; }
    }

    public BackupDevice BkpDevice
    {
      get { return _bkpDevice; }
      set { _bkpDevice = value; }
    }

    public List<string> ArquivosRestore
    {
      get { return _arquivosRestore; }
      set { _arquivosRestore = value; }
    }

    public string Path
    {
      get { return _path; }
      set { _path = value; }
    }
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
