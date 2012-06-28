using System;
using System.Windows.Forms;

namespace Estoque.View
{
  public partial class frmPrincipal : Form
  {
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
      frmCadFuncionario funcionario = new frmCadFuncionario();

      funcionario.MdiParent = this;

      funcionario.Show();
    }

    private void frmPrincipal_Load(object sender, EventArgs e)
    {

    }
  }
}
