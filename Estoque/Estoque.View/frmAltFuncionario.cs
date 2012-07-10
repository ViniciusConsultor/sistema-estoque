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
  public partial class frmAltFuncionario : Form
  {

    #region Declaração

    string strConn = string.Empty;
    string idEstado = string.Empty;
    string idCidade = string.Empty;

    #endregion

    #region Construtor

    public frmAltFuncionario(string conn)
    {
      this.strConn = conn;
      InitializeComponent();
    }

    #endregion

    #region Metodos

    private void btnPesquisar_Click(object sender, EventArgs e)
    {

      #region Declaração

      funcionarioControler funcioControl = null;
      DataTable dtFuncionario = null;
      #endregion

      #region Implementação

      funcioControl = new funcionarioControler();
      dtFuncionario = new DataTable();

      dgvFuncionarios.DataSource = null;

      dtFuncionario = funcioControl.pesquisar(cbTipoPesquisa.Text, tbPesquisa.Text, strConn);

      carregaDataGrid(dtFuncionario);

      #endregion
    }

    private void carregaDataGrid(DataTable dtFuncionario)
    {

      #region Implementação

      dgvFuncionarios.DataSource = dtFuncionario;


      //arruma as colunas corretamente
      dgvFuncionarios.Columns[0].HeaderText = "Matricula";
      dgvFuncionarios.Columns[0].Width = 70;
      dgvFuncionarios.Columns[1].HeaderText = "Nome";
      dgvFuncionarios.Columns[1].Width = 200;
      dgvFuncionarios.Columns[2].Visible = false;
      dgvFuncionarios.Columns[3].HeaderText = "Email";
      dgvFuncionarios.Columns[3].Width = 200;
      dgvFuncionarios.Columns[4].Visible = false;
      dgvFuncionarios.Columns[5].Visible = false;
      dgvFuncionarios.Columns[6].Visible = false;
      dgvFuncionarios.Columns[7].Visible = false;
      dgvFuncionarios.Columns[8].Visible = false;
      dgvFuncionarios.Columns[9].Visible = false;
      dgvFuncionarios.Columns[10].Visible = false;
      dgvFuncionarios.Columns[11].Visible = false;
      dgvFuncionarios.Columns[12].Visible = false;
      dgvFuncionarios.Columns[13].Visible = false;
      dgvFuncionarios.Columns[14].Visible = false;
      dgvFuncionarios.Columns[15].Visible = false;
      dgvFuncionarios.Columns[16].Visible = false;
      dgvFuncionarios.Columns[17].Visible = false;
      dgvFuncionarios.Columns[18].Visible = false;
      dgvFuncionarios.Columns[19].Visible = false;


      #endregion

    }

    #endregion

    private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

      #region declaração
      int linha = 0;
      string idCidade = string.Empty;
      string ativo = string.Empty;

      #endregion

      #region Implementação

      linha = e.RowIndex;

      tbMatricula.Text = dgvFuncionarios[0, linha].Value.ToString().Trim();
      tbNome.Text = dgvFuncionarios[1, linha].Value.ToString().Trim();
      tbDataNascimento.Text = dgvFuncionarios[2, linha].Value.ToString().Trim();
      tbEmail.Text = dgvFuncionarios[3, linha].Value.ToString().Trim();
      mtbCpf.Text = dgvFuncionarios[4, linha].Value.ToString().Trim();
      tbRG.Text = dgvFuncionarios[5, linha].Value.ToString().Trim();
      tbCartProf.Text = dgvFuncionarios[6, linha].Value.ToString().Trim();
      tbSerieCart.Text = dgvFuncionarios[7, linha].Value.ToString().Trim();
      mtbFone.Text = dgvFuncionarios[8, linha].Value.ToString().Trim();
      mtbCelular.Text = dgvFuncionarios[9, linha].Value.ToString().Trim();
      tbCargo.Text = dgvFuncionarios[10, linha].Value.ToString().Trim();
      tbRua.Text = dgvFuncionarios[11, linha].Value.ToString().Trim();
      tbNumero.Text = dgvFuncionarios[12, linha].Value.ToString().Trim();
      tbReferencia.Text = dgvFuncionarios[13, linha].Value.ToString().Trim();
      idCidade = dgvFuncionarios[14, linha].Value.ToString().Trim();
      idEstado = dgvFuncionarios[15, linha].Value.ToString().Trim();
      lblAlteradoEm.Text = dgvFuncionarios[16, linha].Value.ToString().Trim();
      lblCadastradoEm.Text = dgvFuncionarios[17, linha].Value.ToString().Trim();
      ativo = dgvFuncionarios[18, linha].Value.ToString().Trim();
      cbCidade.Text = dgvFuncionarios[19, linha].Value.ToString().Trim();

      if (ativo.Equals("1"))
      {
        lblAtivo.Text = "Ex-funcionário";
      }
      else
        lblAtivo.Text = "É funcionário";

      #endregion
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {

      #region Declaração

      funcionarioControler funcio = null;
      List<Cidade> cidades = null;
      int estado = 0;
      int idCidade = 0;

      #endregion

      #region Implementação

      funcio = new funcionarioControler();
      cidades = new List<Cidade>();

      estado = int.Parse(idEstado);
      cidades = funcio.lstCidades(strConn,estado);

      cbCidade.DataSource = cidades;

      cbCidade.SelectedIndex = idCidade;

      habilitaCampos();

      #endregion

    }

    private void habilitaCampos()
    {

      #region Implementação

      tbCargo.ReadOnly = false;
      tbEmail.ReadOnly = false;
      mtbFone.ReadOnly = false;
      mtbCelular.ReadOnly = false;
      cbCidade.Enabled = true;
      tbRua.ReadOnly = false;
      tbNumero.ReadOnly = false;
      tbReferencia.ReadOnly = false;


      #endregion
    }

    private void cbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
    {

      #region Implementação

      if (cbTipoPesquisa.Text.Equals("") || cbTipoPesquisa.Text.Equals("Ativos") || cbTipoPesquisa.Text.Equals("Inativos"))
      {
        tbPesquisa.Enabled = false;
      }

      #endregion

    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {

    }
  }
}
