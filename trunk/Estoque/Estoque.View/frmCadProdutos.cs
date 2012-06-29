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
    bool carregado = false;

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



      #endregion

      #region Implementação



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
      produto.IdCategoria = int.Parse(cbCategorias.SelectedValue.ToString());
      produto.CodigoBarras = tbCodBarras.Text;
      produto.Quantidade = tbQuantidade.Text;
      produto.Disponivel = cbxDisponivel.Checked;
      produto.IdFornecedor = int.Parse(tbCodForne.Text);
      produto.ValoraVista = valorVista;
      produto.ValorBase = valorBase;
      produto.ValorAPrazo = valorPrazo;
      produto.ValorCrediario = valorCredito;

      if (produtoControl.cadastraProduto(produto, config))
      {
        MessageBox.Show("Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK);
      }
      else
      {
        MessageBox.Show("Não foi possivel acessar a base!", "Erro", MessageBoxButtons.OK);
      }

      #endregion
    }



    private void btnNovo_Click(object sender, EventArgs e)
    {
      #region Declaração

      int Id = 0;
      dataBase db = null;
      List<Categoria> categoriasDB = null;

      #endregion

      #region Implementação

      produtosControler prodControl = new produtosControler();

      config = new Configuracoes();
      db = new dataBase();
      categoriasDB = new List<Categoria>();

      config = db.iserirConexao();

      categoriasDB = prodControl.categoriaBanco(config);

      if (categoriasDB.Count > 0)
      {

        cbCategorias.DataSource = categoriasDB;

        if (carregado == false) //verifica se ja foi clicado uma vez no botão Novo
        {
          Id = prodControl.LastID(config);
          Id++;
          tbCodigoPro.Text = Convert.ToString(Id);
          carregado = true; //Seta para true para nao carregar as Categorias novamente
        }
        

        btnSalvar.Enabled = true;
        btnPesForne.Enabled = false;
        tbNomePro.Enabled = true;
        tbCodBarras.Enabled = true;
        tbQuantidade.Enabled = true;
        cbCategorias.Enabled = true;
        cbxDisponivel.Enabled = true;
        gbFornecedor.Enabled = true;
        gbPrecos.Enabled = true;
        //btnPesForne.Enabled = true; Habilitar após criar a Tabela no banco

        

        limpaForm();

      }
      else
      {
        MessageBox.Show("Erro ao carregar Dados","Erro");
      }
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
    

    private void btnPesForne_Click(object sender, EventArgs e)
    {


    }

    #endregion

  }

}
