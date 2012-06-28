using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Estoque.Controller;
using Estoque.Module;

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
      List<Categoria> categoriasDB = null;

      #endregion

      #region Implementação

      config = new Configuracoes();
      db = new dataBase();
      produtos = new produtosControler();
      categoriasDB = new List<Categoria>();

      config = db.iserirConexao();

      categoriasDB = produtos.categoriaBanco(config);

      cbCategorias.DataSource = categoriasDB;

      #endregion
    }


    private void btnSalvar_Click(object sender, EventArgs e)
    {

      #region Declaração
      Produto produto = null;
      produtosControler produtoControl = null;
      string valorVista = string.Empty;
      string valorBase = string.Empty;
      string valorPrazo = string.Empty;
      string valorCredito = string.Empty;

      #endregion

      #region Implementação

      produto = new Produto();

      produtoControl = new produtosControler();

      valorVista = mtbValor.Text.Replace(".", "").Replace("R$", "").Trim();
      valorBase = mtbValorBase.Text.Replace(".", "").Replace("R$", "").Trim();
      valorPrazo = mtbValorPrazo.Text.Replace(".", "").Replace("R$", "").Trim();
      valorCredito = mtbCrediario.Text.Replace(".", "").Replace("R$", "").Trim();

      produto.Nome = tbNomePro.Text;
      produto.IdCategoria = cbCategorias.SelectedIndex;
      produto.CodigoBarras = tbCodBarras.Text;
      produto.Quantidade = tbQuantidade.Text;
      produto.Disponivel = cbxDisponivel.Checked;
      produto.IdFornecedor = int.Parse(tbCodForne.Text);
      produto.ValoraVista = valorVista;
      produto.ValorBase = valorBase;
      produto.ValorAPrazo = valorPrazo;
      produto.ValorCrediario = valorCredito;

      #endregion
    }

    

    private void btnNovo_Click(object sender, EventArgs e)
    {

      #region Declaração

      int Id = 0;
      #endregion

      #region Implementação

      produtosControler prodControl = new produtosControler();
      Id = prodControl.LastID(config);
      Id++;
      tbCodigoPro.Text = Convert.ToString(Id);

      btnSalvar.Enabled = true;
      btnPesForne.Enabled = false;
      tbNomePro.Enabled = true;
      tbCodBarras.Enabled = true;
      tbQuantidade.Enabled = true;
      cbCategorias.Enabled = true;
      cbxDisponivel.Enabled = true;
      gbFornecedor.Enabled = true;
      gbPrecos.Enabled = true;

      limpaForm();

      #endregion
    }


    private void limpaForm()
    {

      #region Implementação
      tbNomePro.Text = string.Empty;
      tbCodForne.Text = string.Empty;
      cbCategorias.Text = string.Empty;
      tbCodBarras.Text = string.Empty;
      tbQuantidade.Text = string.Empty;
      tbNomeFor.Text = string.Empty;
      mtbValor.Text = string.Empty;
      mtbValorBase.Text = string.Empty;
      mtbValorPrazo.Text = string.Empty;
      mtbCrediario.Text = string.Empty;

      #endregion

    }
    #endregion
  }

}
