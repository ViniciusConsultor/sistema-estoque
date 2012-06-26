using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Estoque.Module;
using Estoque.Dados;
using Microsoft.SqlServer.Management.Smo;

namespace Estoque.Controller
{
  public class configuracoesControler
  {

    #region Construtor

    public configuracoesControler()
    {

    }
    #endregion

    #region Métodos

    /// <summary>
    /// Carrega os Servidores Sql Rodando na maquina
    /// </summary>
    /// <param name="config">Passa a Classe Configurações</param>
    /// <returns>Configurações</returns>
    public Configuracoes CarregaServidor(Configuracoes config)
    {

      #region Declaração

      configuracoesDAO configDAO = null;

      #endregion

      #region Implementação

      configDAO = new configuracoesDAO();

      return configDAO.carregaServer(config);

      #endregion

    }

    /// <summary>
    /// Carrega os Banco de dados presentes no Sevidor
    /// </summary>
    /// <param name="config">Configurações</param>
    /// <returns>Configurações</returns>
    public Configuracoes CarregaBanco(Configuracoes config)
    {

      #region Declaração

      configuracoesDAO configDAO = null;

      #endregion

      #region Implementação

      configDAO = new configuracoesDAO();

      return configDAO.ListaBanco(config);

      #endregion

    }

    public bool Backup(Configuracoes config)
    {

      #region Declaração

      configuracoesDAO configDAO = null;

      #endregion

      #region Implementação

      configDAO = new configuracoesDAO();

      return configDAO.BackupDataBase(config);

      #endregion

    }

    public bool Restore(Configuracoes config)
    {

      #region Declaração

      configuracoesDAO configDAO = null;

      #endregion

      #region Implementação

      configDAO = new configuracoesDAO();

      return configDAO.RestoreDataBase(config);

      #endregion

    }

    public Configuracoes ListaArquivos(Configuracoes config)
    {

      #region Declaração

      configuracoesDAO configDAO = null;

      #endregion

      #region Implementação

      configDAO = new configuracoesDAO();

      return configDAO.ListaArquivos(config);

      #endregion

    }
    #endregion

  }
}
