using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
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
        private void frmConfiguracao_Load(object sender, EventArgs e)
        {

            #region Declaração

            configuracoesControler configControl = null;
            string conexao = string.Empty;
            SqlConnection conn = null;
            Configuracoes config = null;

            #endregion

            #region Implementação

            configControl = new configuracoesControler();

            tbServidor.Text = config.servidor;
            tbData.Text = config.database;
            tbUser.Text = config.user;
            tbSenha.Text = config.senha;

            lbConString.Text = config.conectionString;

            conn = configControl.carregaConfiguracao();

            if (conn.State == ConnectionState.Open)
            {
                lbTeste.Text = "Conectado com Sucesso!";
                lbTeste.ForeColor = Color.Blue;
            }
            else
            {
                lbTeste.Text = "Não foi possível conectar ao Banco de Dados";
                lbTeste.ForeColor = Color.Red;
            }
            #endregion
        }

        
    }
}
