using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estoque.Module;
using Estoque.Controller;

namespace Estoque.View
{
  public partial class frmRestoreDataBase : Form
  {

    #region Construtor

    Configuracoes config = null;
    public frmRestoreDataBase(Configuracoes config)
    {
      InitializeComponent();
      this.config = config;
    }

    #endregion

    #region Metodos
    private void frmRestoreDataBase_Load(object sender, EventArgs e)
    {

      #region Declaração

      configuracoesControler configControl = null;
      #endregion

      #region Implementação
      configControl = new configuracoesControler();

      config = configControl.ListaArquivos(config);

      if (config.ArquivosRestore != null)
        ltbArquivos.DataSource = config.ArquivosRestore;
      else
        MessageBox.Show("Não há arquivos de restauração!", "Erro");

      #endregion

    }


    private void btnRestaurar_Click(object sender, EventArgs e)
    {

      #region Declaração

      configuracoesControler configControl = null;
      #endregion

      #region Implementação

      configControl = new configuracoesControler();

      config.Path = config.Path + ltbArquivos.Text;

      if (configControl.Restore(config))
      {
        MessageBox.Show("Restaurado com Sucesso", "Sucesso");
      }
      else
        MessageBox.Show("O banco não pode ser restaurado!", "Erro");
      #endregion

    }

    #endregion

  }
}
