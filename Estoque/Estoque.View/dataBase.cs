using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Estoque.Controller;
using Estoque.Module;

namespace Estoque.View
{
  public class dataBase
  {

    #region Construtor

    public dataBase()
    {
    }
    #endregion

    #region Declaração

    SqlConnection conn = null;
    Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

    SqlConnectionStringBuilder myCSB = new SqlConnectionStringBuilder();

    #endregion

    #region Implementação

    public SqlConnection conectar(Configuracoes config)
    {
      conn = new SqlConnection();
      try
      {
        conn.ConnectionString = config.ConectionString;

        conn.Open();

      }
      catch
      {
        if (conn.State != ConnectionState.Open)
        {
          return conn;
        }
      }

      return conn;
    }

    public bool salvaConfiguracoes(Configuracoes config)
    {
      AppSettingsSection appSetSec = configFile.AppSettings;


      appSetSec.Settings["servidor"].Value = config.Servidor;
      appSetSec.Settings["database"].Value = config.Database;
      appSetSec.Settings["user"].Value = config.User;
      appSetSec.Settings["senha"].Value = config.Senha;
      appSetSec.Settings["connectionString"].Value = config.ConectionString;

      configFile.AppSettings.Settings.Remove("connectionString");

      configFile.AppSettings.Settings.Add("connectionString", "Data Source=GSJP01PD011\\SQLEXPRESS;Initial Catalog=estoque;User ID=estoque;Password=estoque");

      configFile.Save();

      return true;
    }

    public Configuracoes iserirConexao()
    {
      AppSettingsSection appSetSec = configFile.AppSettings;
      configuracoesControler configControl = new configuracoesControler();
      Configuracoes config = new Configuracoes();

      config = configControl.CarregaServidor(config);
      //config = configControl.CarregaBanco(config);

      config.Servidor = appSetSec.Settings["servidor"].Value;
      config.Database = appSetSec.Settings["database"].Value;
      config.User = appSetSec.Settings["user"].Value;
      config.Senha = appSetSec.Settings["senha"].Value;
      config.ConectionString = appSetSec.Settings["connectionString"].Value;

      return config;
    }

    #endregion
  }
}
