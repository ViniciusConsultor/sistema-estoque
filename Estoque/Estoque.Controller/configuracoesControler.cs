using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Estoque.Module;
using Estoque.Dados;

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

    //public bool salvaConf(Configuracoes config)
    //{

    //    #region Declaração
    //    dataBase data = null;
    //    #endregion

    //    #region Implementação

    //    data = new dataBase();
    //    return data.salvaConfiguracoes(config);

    //    #endregion
    //}

    //public SqlConnection carregaConfiguracao(Configuracoes config)
    //{

    //    #region Declaração

    //    dataBase data = null;
    //    #endregion

    //    #region Implementação

    //    data = new dataBase();

    //    return data.conectar(config);
    //    #endregion
    //}

    //public void carregaString()
    //{

    //    #region Declaração
    //    dataBase data = null;
    //    Configuracoes config = null;
    //    #endregion

    //    #region Implementação
    //    config = new Configuracoes();

    //    data = new dataBase();

    //    return data.iserirConexao();
    //    #endregion
    //}

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

    #endregion

  }
}
