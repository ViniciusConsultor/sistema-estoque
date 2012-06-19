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
  public partial class frmCadProdutos : Form
  {

    Configuracoes config = null;

    #region Construtor

    public frmCadProdutos()
    {
      InitializeComponent();
    }

    #endregion

    #region Métodos

    private void frmCadProdutos_Load(object sender, EventArgs e)
    {

      #region Declaração

      produtosControler produtos = null;
      dataBase db = null;
      List<string> categoriasDB = null;

      #endregion

      #region Implementação

      config = new Configuracoes();
      db = new dataBase();
      produtos = new produtosControler();
      categoriasDB = new List<string>();

      config = db.iserirConexao();

      categoriasDB = produtos.categoriaBanco(config);

      cbCategorias.DataSource = categoriasDB;
      #endregion
    }

    #endregion

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      
    }
  }

}
