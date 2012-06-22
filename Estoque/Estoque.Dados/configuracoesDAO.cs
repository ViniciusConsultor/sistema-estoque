using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Server;
using System.Data;
using Estoque.Module;

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

          foreach (Database  dbserver in server.Databases)
          {
            config.Servidores.Add(dbserver.Name);
          }
          #endregion
          return config;
        }

        public bool BackupDataBase(Configuracoes config)
        {

          #region Declaração
          if (config.SqlServer != null)
          {

            Backup bkpDataBase = null;
            BackupDeviceItem bkpDevItem = null;
            DateTime data = DateTime.Now;
            string fileName = string.Empty;
          #endregion

            #region Implementação

            bkpDataBase = new Backup();
            bkpDevItem = new BackupDeviceItem();

            bkpDataBase.Action = BackupActionType.Database;
            bkpDataBase.Database = config.Database;
            fileName = "Backup_" + data + ".bak";

            bkpDevItem.Name = fileName;

            bkpDataBase.Devices.Add(bkpDevItem);
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
          return true;
          #endregion
        }
        #endregion

    }
}
