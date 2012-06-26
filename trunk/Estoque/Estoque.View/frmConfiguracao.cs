using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estoque.Controller;
using Estoque.Module;

namespace Estoque.View
{
  public partial class frmConfiguracao : Form
  {
    public frmConfiguracao()
    {
      InitializeComponent();
    }

    Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    Configuracoes config = null;
    private void frmConfiguracao_Load(object sender, EventArgs e)
    {

      #region Declaração

      dataBase data = null;
      string conexao = string.Empty;


      #endregion

      #region Implementação

      data = new dataBase();

      config = data.iserirConexao();

      foreach (string item in config.Servidores)
      {
        cbListServer.Items.Add(item);
        cbListServer.DisplayMember = "";
        cbListServer.ValueMember = "";
      }
      tbUser.Text = config.User;
      tbSenha.Text = config.Senha;

      #endregion
    }

    private void btnTeste_Click(object sender, EventArgs e)
    {
      #region Declaração

      dataBase data = null;
      SqlConnection conn = null;

      #endregion

      #region Implementação
      if (cbDataBase.Text != "")
      {

        data = new dataBase();

        //config = data.iserirConexao();
        config.Servidor = cbListServer.Text;
        config.Database = cbDataBase.Text;
        config.User = tbUser.Text;
        config.Senha = tbSenha.Text;

        config = mudaConfigurações();

        conn = data.conectar(config);

        lbConString.Text = config.ConectionString;

        if (conn.State == ConnectionState.Open)
        {
          lbTeste.Text = "Conectado com Sucesso!";
          lbTeste.ForeColor = Color.Blue;
          btnBackup.Enabled = true;

        }
        else
        {
          lbTeste.Text = "Não foi possível conectar ao Banco de Dados";
          lbTeste.ForeColor = Color.Red;
        }
      }
      else
        MessageBox.Show("Selecione o Banco!", "Aviso");

      #endregion
    }

    public Configuracoes mudaConfigurações()
    {
      SqlConnectionStringBuilder myCSB = new SqlConnectionStringBuilder();
      ConnectionStringsSection csSection = new ConnectionStringsSection();

      #region Implementação

      myCSB.DataSource = config.Servidor;
      myCSB.InitialCatalog = config.Database;
      myCSB.UserID = config.User;
      myCSB.Password = config.Senha;

      config.ConectionString = myCSB.ConnectionString;

      return config;

      #endregion
    }

    private void btnBackup_Click(object sender, EventArgs e)
    {

      #region Declaração

      configuracoesControler configControl = null;

      #endregion

      #region Implementação

      configControl = new configuracoesControler();

        if (configControl.Backup(config))
        {
          MessageBox.Show("Criado com Sucesso!", "Sucesso");
        }
        else
          MessageBox.Show("Falha ao criar o arquivo!", "Sucesso");

      #endregion

    }

    private void btnRestore_Click(object sender, EventArgs e)
    {

      #region Implementação

      frmRestoreDataBase restore = new frmRestoreDataBase(config);
      restore.Show();

      #endregion
    }

    private void btnCarregaBanco_Click(object sender, EventArgs e)
    {

      #region Implementação

      config.Servidor = cbListServer.Text;

      configuracoesControler configColtrol = new configuracoesControler();

      config = configColtrol.CarregaBanco(config);

      cbDataBase.DataSource = config.Databases;

      if (config.Databases.Count > 0)
      {
        btnTeste.Enabled = true;
      }

      #endregion

    }

  }
}
