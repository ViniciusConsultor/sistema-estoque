using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Estoque.Module;
//using SQLDMO;

namespace Estoque.Dados
{
    public class configuracoesDAO
    {

        #region Construtor

        public configuracoesDAO()
        {

        }

        #endregion

        #region Métodos

        public bool salvaServidor(Configuracoes config)
        {

            #region Declaração

            #endregion

            #region Implementação

            System.Configuration.Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return true;


            #endregion
        }

        public Configuracoes carregaServer(Configuracoes config)
        {

          #region Declaração

          DataTable dtServers = null;

          #endregion

          #region Implementação
          dtServers = new DataTable();
          dtServers = SmoApplication.EnumAvailableSqlServers(true);
          //Instancia uma nova Lista
          config.Servidores = new List<string>();
          if (dtServers.Rows.Count > 0)
          {
            foreach (DataRow drServer in dtServers.Rows)
            {
              config.Servidores.Add(drServer["Name"].ToString());
            }
          }

           return config;
          #endregion
        }

        public Configuracoes ListaBanco(Configuracoes config)
        {

          #region Declaração
          ServerConnection srConn = null;
          Server server = null;

          #endregion

          #region Implementação

          srConn = new ServerConnection(config.Servidor);

          srConn.LoginSecure = false;

          srConn.Login = config.User;

          srConn.Password = config.Senha;

          server = new Server(srConn);

          config.SqlServer = server;

          config.Databases = new List<string>();

          foreach ( Microsoft.SqlServer.Management.Smo.Database  dbserver in server.Databases)
          {
            config.Databases.Add(dbserver.Name);
          }
          
          return config;

          #endregion

        }

        public bool BackupDataBase(Configuracoes config)
        {

          #region Declaração

          if (config.SqlServer != null)
          {

            Backup bkpDataBase = null;
            string data = DateTime.Now.Date.ToString("dd-mm-yyyy");
            BackupDeviceItem bkpDeviceItem = null;
            string fileName = string.Empty;
            string path = string.Empty;
          #endregion

          #region Implementação

            fileName = "Backup_" + data + ".bak";

            bkpDataBase = new Backup();
            bkpDeviceItem = new BackupDeviceItem();

            bkpDataBase.Action = BackupActionType.Database;
            bkpDataBase.Database = config.Database;

            path = "C:\\Sistema\\Backup\\";

            if (!Directory.Exists(path))
            {
              Directory.CreateDirectory(path);
            }

            path = path + fileName.Replace(" ","_").Replace("/","_").Replace(":","_");

            if (!File.Exists(path))
            {
              File.CreateText(path);
            }

            bkpDataBase.Incremental = false;
            bkpDataBase.BackupSetName = fileName;

            bkpDataBase.Checksum = true;
            bkpDataBase.Devices.Add(new BackupDeviceItem(path, DeviceType.File));

            bkpDataBase.SqlBackup(config.SqlServer);

            return true;

          }
          else
            return false;


          #endregion

        }

        public bool RestoreDataBase(Configuracoes config)
        {

          #region Declaração

          Restore rstDataBase = null;
          BackupDeviceItem bkpDevice = null;
          
          #endregion
          
          #region Implementação
          var sc = new SqlConnection("Data Source=GSJP01PD011\\SQLEXPRESS;Initial Catalog=master;User ID=estoque;Password=estoque");

          String sql = @"USE [master]; RESTORE DATABASE "+config.Database +" FROM DISK = '"+config.Path+"' WITH REPLACE;";

          var cmd = new SqlCommand(sql, sc);
          sc.Open();

          cmd.ExecuteNonQuery();
          //var serverConn = new ServerConnection(sc);
          //var server = new Server(serverConn);
          //server.ConnectionContext.DatabaseName = "master";
          

          //Database db = server.Databases[config.Database];
          //var restore = new Restore();

          //server.KillAllProcesses(config.Database);
          //db.Alter(TerminationClause.RollbackTransactionsImmediately);
          //restore.Action = RestoreActionType.Database;
          
 
          //restore.Database = config.Database;
          //restore.ReplaceDatabase = true;
          //restore.Devices.AddDevice(config.Path, DeviceType.File);
          //restore.ReplaceDatabase = true;
          //restore.NoRecovery = false;

          //restore.SqlRestore(server);

          return true;
          #endregion
        }

        public Configuracoes ListaArquivos(Configuracoes config)
        {

          #region Declaração

          DirectoryInfo dirInfo = null;
          FileInfo[] arquivos = null;
          string path = string.Empty;

          #endregion

          #region Implementação

          path = "C:\\Sistema\\Backup\\";

          dirInfo = new DirectoryInfo(path);
          config.Path = path;

          arquivos = dirInfo.GetFiles("*.bak");

          if (arquivos.Length > 0)
          {
            config.ArquivosRestore = new List<string>();

            foreach (FileInfo fileinfo in arquivos)
            {
              config.ArquivosRestore.Add(fileinfo.Name);
            }
            return config;
          }
          else
            return config;
          #endregion

        }
        #endregion

    }
}
