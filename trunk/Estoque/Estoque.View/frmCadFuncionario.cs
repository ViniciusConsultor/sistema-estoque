using System.Windows.Forms;
using Estoque.Controller;
using Estoque.Module;
using System;
using System.Collections.Generic;

namespace Estoque.View
{
  public partial class frmCadFuncionario : Form
  {

    #region Declaração

    //String de conexão
    string strConn = string.Empty;

    #endregion

    #region Construtor

    /// <summary>
    /// Instancia da classe frmCadFuncionario
    /// </summary>
    /// <param name="strConn">String de conexão com o Banco de dados</param>
    public frmCadFuncionario(string strConn)
    {
      this.strConn = strConn;
      InitializeComponent();
    }

    #endregion

    #region Metodos

    private void btnNovo_Click(object sender, System.EventArgs e)
    {

      #region Implementação
     
      btnNovo.Enabled = false;
      habilitaCampos();
      limpaCampos();

      #endregion

    }

    private void btnSalvar_Click(object sender, System.EventArgs e)
    {

      #region Declaração

      funcionarioControler funcionControl = null;
      Funcionario funcionario = null;
      string CPF = string.Empty;
      string Fone = string.Empty;
      string Celular = string.Empty;
      int ID = 0;
      int comparaString = 0;
      #endregion

      #region Implementação

      funcionControl = new funcionarioControler();
      funcionario = new Funcionario();

      CPF = mtbCpf.Text;
      Fone = mtbFone.Text;
      Celular = mtbCelular.Text;

      if (tbNome.Text != "" && CPF != "" && tbRG.Text != "")
      {
        CPF = CPF.Replace(".", "").Replace("/", "").Replace("-", "");
        Fone = Fone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
        Celular = Celular.Replace("(", "").Replace(")", "").Replace(" ", "");

        //funcionario.Id = int.Parse(tbMatricula.Text);
        funcionario.Nome = tbNome.Text;
        funcionario.DataNascimento = dtpNascimento.Text;
        funcionario.Email = tbEmail.Text;
        funcionario.Cpf = CPF;
        funcionario.Rg = tbRG.Text;
        funcionario.Ctps = tbCartProf.Text;
        funcionario.CtpsSerie = tbSerieCart.Text;
        funcionario.Telefone = Fone;
        funcionario.Celular = Celular;
        funcionario.Rua = tbRua.Text;
        if (tbNumero.Text != "")
          funcionario.CasaNumero = int.Parse(tbNumero.Text);
        else
          funcionario.CasaNumero = 0;
        funcionario.Referencia = tbReferencia.Text;
        funcionario.IdCidade = int.Parse(cbCidade.SelectedValue.ToString());
        funcionario.Cidade = cbCidade.Text;
        funcionario.IdEstado = Convert.ToInt32(cbUF.SelectedIndex);
        funcionario.Estado = cbUF.Text;
        funcionario.Cargo = tbCargo.Text;
        funcionario.Ativo = cbxAtivo.Checked;

        if (cbxAtivaUsuario.Checked == true)
        {
          comparaString = tbSenha.Text.CompareTo(tbSenha2.Text);

          if (comparaString == 0) // senhas iguais
          {
            if (cbNivel.Text != "")
            {
              Usuario usuario = new Usuario();

              usuario.User = tbUsuario.Text;
              usuario.Senha = tbSenha.Text;
              usuario.Perfil = cbNivel.Text;
              usuario.Acesso = cbxAtivaUsuario.Checked;
              usuario.Ativo = cbxAtivo.Checked;

              ID = funcionControl.cadastrar(strConn, funcionario, usuario);
              if (ID > 0)
              {
                MessageBox.Show("Cadastrado com secesso! \n A Matricula do funcionário é: " + ID, "Sucesso");
                btnNovo.Enabled = true;
                desabilitaCampos();
                this.Size = new System.Drawing.Size(459, 546);
                tbMatricula.Text = ID.ToString();
              }
            }
            else
              MessageBox.Show("Selecione o Nivel de acesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
          else
            MessageBox.Show("As senhas digitadas são diferentes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      else
        MessageBox.Show("Alguns campos são Obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      #endregion

    }

    private void cbxAtivaUsuario_CheckedChanged(object sender, System.EventArgs e)
    {

      #region Implementação

      if (cbxAtivaUsuario.Checked == true)
      {
        this.Size = new System.Drawing.Size(459, 720);
      }
      else
      {
        this.Size = new System.Drawing.Size(459, 546);
      }

      #endregion

    }

    /// <summary>
    /// Dasbilita todos os Campos
    /// </summary>
    private void desabilitaCampos()
    {

      #region Implementação

      btnSalvar.Enabled = false;
      tbMatricula.Enabled = false;
      tbNome.Enabled = false;
      dtpNascimento.Enabled = false;
      tbRG.Enabled = false;
      mtbCpf.Enabled = false;
      tbCartProf.Enabled = false;
      tbSerieCart.Enabled = false;
      tbCargo.Enabled = false;
      tbEmail.Enabled = false;
      mtbFone.Enabled = false;
      mtbCelular.Enabled = false;
      cbUF.Enabled = false;
      cbCidade.Enabled = false;
      tbRua.Enabled = false;
      tbNumero.Enabled = false;
      tbReferencia.Enabled = false;
      cbxAtivaUsuario.Enabled = false;
      cbxAtivaUsuario.Checked = false;

      #endregion

    }

    private void frmCadFuncionario_Load(object sender, System.EventArgs e)
    {

      #region Implementação

      this.Size = new System.Drawing.Size(459, 546);
      limpaCampos();
      desabilitaCampos();

      #endregion

    }

    /// <summary>
    /// Habilita todos os Campos
    /// </summary>
    private void habilitaCampos()
    {

      #region Implementação

      btnSalvar.Enabled = true;
      tbMatricula.Enabled = true;
      tbNome.Enabled = true;
      dtpNascimento.Enabled = true;
      tbRG.Enabled = true;
      mtbCpf.Enabled = true;
      tbCartProf.Enabled = true;
      tbSerieCart.Enabled = true;
      tbCargo.Enabled = true;
      tbEmail.Enabled = true;
      mtbFone.Enabled = true;
      mtbCelular.Enabled = true;
      cbUF.Enabled = true;
      cbCidade.Enabled = true;
      tbRua.Enabled = true;
      tbNumero.Enabled = true;
      tbReferencia.Enabled = true;
      cbxAtivaUsuario.Enabled = true;

      #endregion

    }

    private void limpaCampos()
    {

      #region Implementação

      tbNome.Text = "";
      tbRG.Text = "";
      mtbCpf.Text = "";
      tbCartProf.Text = "";
      tbSerieCart.Text = "";
      tbCargo.Text = "";
      tbEmail.Text = "";
      mtbFone.Text = "";
      mtbCelular.Text = "";
      cbUF.Text = "";
      cbCidade.Text = "";
      tbRua.Text = "";
      tbNumero.Text = "";
      tbReferencia.Text = "";
      cbxAtivaUsuario.Checked = false;
      tbUsuario.Text = "";
      tbSenha.Text = "";
      tbSenha2.Text = "";
      cbxAtivo.Checked = false;

      #endregion

    }

    private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
    {

      #region Declaração

      funcionarioControler func = null;
      List<Cidade> cidades = null;
      int idEstado = 0;

      #endregion

      #region Implementação

      func = new funcionarioControler();
      cidades = new List<Cidade>();

      idEstado = cbUF.SelectedIndex;

      cidades = func.lstCidades(strConn, idEstado);

      cbCidade.DataSource = cidades;


      #endregion
    }

    #endregion

  }
}
