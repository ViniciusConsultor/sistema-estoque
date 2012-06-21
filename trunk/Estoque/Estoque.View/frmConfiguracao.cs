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
            SqlConnection conn = null;
            

            #endregion

            #region Implementação

            data = new dataBase();

            

            config = data.iserirConexao();

            tbServidor.Text = config.Servidor;
            tbData.Text = config.Database;
            tbUser.Text = config.User;
            tbSenha.Text = config.Senha;

            

            
            #endregion
        }

        

        private void btnTeste_Click(object sender, EventArgs e)
        {
            #region Declaração

            Configuracoes config = null;

            dataBase data = null;
            SqlConnection conn = null;

            #endregion

            #region Implementação

            data = new dataBase();

            config = data.iserirConexao();

            conn = data.conectar(config);

            lbConString.Text = config.ConectionString;

            if (conn.State == ConnectionState.Open)
            {
                lbTeste.Text = "Conectado com Sucesso!";
                lbTeste.ForeColor = Color.Blue;

            }
            else
            {
                lbTeste.Text = "Não foi possível conectar ao Banco de Dados";
                lbTeste.ForeColor = Color.Red;

                config = mudaConfigurações();

                conn = data.conectar(config);

                if (conn.State == ConnectionState.Open)
                {
                    lbTeste.Text = "Conectado com Sucesso!";
                    lbTeste.ForeColor = Color.Blue;
                    if (data.salvaConfiguracoes(config))
                    {
                        MessageBox.Show("Salvo com Sucesso", "Sucesso", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    lbTeste.Text = "Não foi possível conectar ao Banco de Dados";
                    lbTeste.ForeColor = Color.Red;
                }
            }

            #endregion
        }

        public Configuracoes mudaConfigurações()
        {
            SqlConnectionStringBuilder myCSB = new SqlConnectionStringBuilder();
            ConnectionStringsSection csSection = new ConnectionStringsSection();

            #region Implementação

            config.Servidor = tbServidor.Text;
            config.Database = tbData.Text;
            config.User = tbData.Text;
            config.Senha = tbSenha.Text;

            myCSB.DataSource = config.Servidor;
            myCSB.InitialCatalog = config.Database;
            myCSB.UserID = config.User;
            myCSB.Password = config.Senha;

            config.ConectionString = myCSB.ConnectionString;

            return config;

            #endregion
        }
        
    }
}
