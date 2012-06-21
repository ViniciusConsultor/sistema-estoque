﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            frmConfiguracao config = new frmConfiguracao();

            config.MdiParent = this;

            config.Show();
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
    }
}
