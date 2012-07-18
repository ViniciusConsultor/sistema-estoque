using System;
using System.Windows.Forms;
using Estoque.Module;

namespace Estoque.View
{
  public partial class frmPrincipal : Form
  {
    string strConn = string.Empty;
    
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmConfiguracao frmconfig = new frmConfiguracao();

      frmconfig.MdiParent = this;

      frmconfig.Show();
    }

    private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmCadProdutos cadPro = new frmCadProdutos();

      cadPro.MdiParent = this;

      cadPro.Show();
    }

    private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      frmCadFuncionario funcionario = new frmCadFuncionario(strConn);

      funcionario.MdiParent = this;

      funcionario.Show();
    }

    private void frmPrincipal_Load(object sender, EventArgs e)
    {
      dataBase db = new dataBase();
      Configuracoes config = new Configuracoes();
      config = db.iserirConexao();

      if (config != null)
      {
        this.strConn = config.ConectionString;
      }
    }

    private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      frmAltFuncionario altFunc = new frmAltFuncionario(strConn);

      altFunc.MdiParent = this;

      altFunc.Show();
    }

    private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
    {
       frmCadFornecedor cadForne = new frmCadFornecedor(strConn);

       cadForne.MdiParent = this;

       cadForne.Show();
    }
  }
}
