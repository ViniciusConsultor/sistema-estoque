namespace Estoque.View
{
    partial class frmCadProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutos));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cbxDisponivel = new System.Windows.Forms.CheckBox();
      this.tbCodBarras = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.tbQuantidade = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cbCategorias = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbNomePro = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbCodigoPro = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.mtbValor = new System.Windows.Forms.MaskedTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.gbPrecos = new System.Windows.Forms.GroupBox();
      this.mtbCrediario = new System.Windows.Forms.MaskedTextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.mtbValorBase = new System.Windows.Forms.MaskedTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.mtbValorPrazo = new System.Windows.Forms.MaskedTextBox();
      this.gbFornecedor = new System.Windows.Forms.GroupBox();
      this.tbNomeFor = new System.Windows.Forms.TextBox();
      this.btnPesForne = new System.Windows.Forms.Button();
      this.tbCodForne = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.gbPrecos.SuspendLayout();
      this.gbFornecedor.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cbxDisponivel);
      this.groupBox1.Controls.Add(this.tbCodBarras);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.btnNovo);
      this.groupBox1.Controls.Add(this.btnSalvar);
      this.groupBox1.Controls.Add(this.tbQuantidade);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.cbCategorias);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.tbNomePro);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.tbCodigoPro);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(14, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(602, 202);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Produto";
      // 
      // cbxDisponivel
      // 
      this.cbxDisponivel.AutoSize = true;
      this.cbxDisponivel.Enabled = false;
      this.cbxDisponivel.Location = new System.Drawing.Point(196, 171);
      this.cbxDisponivel.Name = "cbxDisponivel";
      this.cbxDisponivel.Size = new System.Drawing.Size(77, 17);
      this.cbxDisponivel.TabIndex = 14;
      this.cbxDisponivel.Text = "Disponível";
      this.cbxDisponivel.UseVisualStyleBackColor = true;
      // 
      // tbCodBarras
      // 
      this.tbCodBarras.Enabled = false;
      this.tbCodBarras.Location = new System.Drawing.Point(324, 125);
      this.tbCodBarras.Name = "tbCodBarras";
      this.tbCodBarras.Size = new System.Drawing.Size(205, 21);
      this.tbCodBarras.TabIndex = 3;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(321, 105);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(82, 15);
      this.label9.TabIndex = 12;
      this.label9.Text = "Cod. Barras";
      // 
      // btnNovo
      // 
      this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnNovo.Location = new System.Drawing.Point(165, 31);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(83, 28);
      this.btnNovo.TabIndex = 11;
      this.btnNovo.Text = "Novo";
      this.btnNovo.UseVisualStyleBackColor = true;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Enabled = false;
      this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnSalvar.Location = new System.Drawing.Point(267, 31);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(86, 28);
      this.btnSalvar.TabIndex = 10;
      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // tbQuantidade
      // 
      this.tbQuantidade.Enabled = false;
      this.tbQuantidade.Location = new System.Drawing.Point(53, 171);
      this.tbQuantidade.Name = "tbQuantidade";
      this.tbQuantidade.Size = new System.Drawing.Size(84, 21);
      this.tbQuantidade.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(49, 153);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(81, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "Quantidade";
      // 
      // cbCategorias
      // 
      this.cbCategorias.DisplayMember = "CategoriaP";
      this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCategorias.Enabled = false;
      this.cbCategorias.FormattingEnabled = true;
      this.cbCategorias.Location = new System.Drawing.Point(53, 123);
      this.cbCategorias.Name = "cbCategorias";
      this.cbCategorias.Size = new System.Drawing.Size(236, 23);
      this.cbCategorias.TabIndex = 2;
      this.cbCategorias.ValueMember = "IdCategoria";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(49, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 15);
      this.label3.TabIndex = 4;
      this.label3.Text = "Categoria";
      // 
      // tbNomePro
      // 
      this.tbNomePro.Enabled = false;
      this.tbNomePro.Location = new System.Drawing.Point(53, 77);
      this.tbNomePro.MaxLength = 100;
      this.tbNomePro.Name = "tbNomePro";
      this.tbNomePro.Size = new System.Drawing.Size(476, 21);
      this.tbNomePro.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(49, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Nome";
      // 
      // tbCodigoPro
      // 
      this.tbCodigoPro.Location = new System.Drawing.Point(53, 35);
      this.tbCodigoPro.MaxLength = 6;
      this.tbCodigoPro.Name = "tbCodigoPro";
      this.tbCodigoPro.ReadOnly = true;
      this.tbCodigoPro.Size = new System.Drawing.Size(84, 21);
      this.tbCodigoPro.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(49, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Código";
      // 
      // mtbValor
      // 
      this.mtbValor.Location = new System.Drawing.Point(17, 43);
      this.mtbValor.Mask = "$ 00,00";
      this.mtbValor.Name = "mtbValor";
      this.mtbValor.Size = new System.Drawing.Size(84, 21);
      this.mtbValor.TabIndex = 0;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 25);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(87, 15);
      this.label5.TabIndex = 8;
      this.label5.Text = "Valor a Vista";
      // 
      // gbPrecos
      // 
      this.gbPrecos.Controls.Add(this.mtbCrediario);
      this.gbPrecos.Controls.Add(this.label8);
      this.gbPrecos.Controls.Add(this.mtbValorBase);
      this.gbPrecos.Controls.Add(this.label7);
      this.gbPrecos.Controls.Add(this.label6);
      this.gbPrecos.Controls.Add(this.mtbValorPrazo);
      this.gbPrecos.Controls.Add(this.mtbValor);
      this.gbPrecos.Controls.Add(this.label5);
      this.gbPrecos.Enabled = false;
      this.gbPrecos.Location = new System.Drawing.Point(14, 301);
      this.gbPrecos.Name = "gbPrecos";
      this.gbPrecos.Size = new System.Drawing.Size(217, 139);
      this.gbPrecos.TabIndex = 10;
      this.gbPrecos.TabStop = false;
      this.gbPrecos.Text = "Preços";
      // 
      // mtbCrediario
      // 
      this.mtbCrediario.Location = new System.Drawing.Point(124, 93);
      this.mtbCrediario.Mask = "$ 00,00";
      this.mtbCrediario.Name = "mtbCrediario";
      this.mtbCrediario.Size = new System.Drawing.Size(83, 21);
      this.mtbCrediario.TabIndex = 3;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(121, 71);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(66, 15);
      this.label8.TabIndex = 14;
      this.label8.Text = "Crediário";
      // 
      // mtbValorBase
      // 
      this.mtbValorBase.Location = new System.Drawing.Point(124, 43);
      this.mtbValorBase.Mask = "$ 00,00";
      this.mtbValorBase.Name = "mtbValorBase";
      this.mtbValorBase.Size = new System.Drawing.Size(83, 21);
      this.mtbValorBase.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(121, 25);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(39, 15);
      this.label7.TabIndex = 12;
      this.label7.Text = "Base";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 71);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(93, 15);
      this.label6.TabIndex = 11;
      this.label6.Text = "Valor a Prazo";
      // 
      // mtbValorPrazo
      // 
      this.mtbValorPrazo.Location = new System.Drawing.Point(17, 93);
      this.mtbValorPrazo.Mask = "$ 00,00";
      this.mtbValorPrazo.Name = "mtbValorPrazo";
      this.mtbValorPrazo.Size = new System.Drawing.Size(84, 21);
      this.mtbValorPrazo.TabIndex = 2;
      // 
      // gbFornecedor
      // 
      this.gbFornecedor.Controls.Add(this.tbNomeFor);
      this.gbFornecedor.Controls.Add(this.btnPesForne);
      this.gbFornecedor.Controls.Add(this.tbCodForne);
      this.gbFornecedor.Controls.Add(this.label11);
      this.gbFornecedor.Controls.Add(this.label10);
      this.gbFornecedor.Enabled = false;
      this.gbFornecedor.Location = new System.Drawing.Point(14, 220);
      this.gbFornecedor.Name = "gbFornecedor";
      this.gbFornecedor.Size = new System.Drawing.Size(602, 75);
      this.gbFornecedor.TabIndex = 11;
      this.gbFornecedor.TabStop = false;
      this.gbFornecedor.Text = "Fornecedor";
      // 
      // tbNomeFor
      // 
      this.tbNomeFor.Location = new System.Drawing.Point(206, 39);
      this.tbNomeFor.Name = "tbNomeFor";
      this.tbNomeFor.ReadOnly = true;
      this.tbNomeFor.Size = new System.Drawing.Size(323, 21);
      this.tbNomeFor.TabIndex = 4;
      // 
      // btnPesForne
      // 
      this.btnPesForne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesForne.BackgroundImage")));
      this.btnPesForne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnPesForne.Location = new System.Drawing.Point(126, 33);
      this.btnPesForne.Name = "btnPesForne";
      this.btnPesForne.Size = new System.Drawing.Size(32, 32);
      this.btnPesForne.TabIndex = 3;
      this.btnPesForne.UseVisualStyleBackColor = true;
      this.btnPesForne.Click += new System.EventHandler(this.btnPesForne_Click);
      // 
      // tbCodForne
      // 
      this.tbCodForne.Location = new System.Drawing.Point(20, 39);
      this.tbCodForne.Name = "tbCodForne";
      this.tbCodForne.Size = new System.Drawing.Size(100, 21);
      this.tbCodForne.TabIndex = 0;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(203, 21);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(45, 15);
      this.label11.TabIndex = 1;
      this.label11.Text = "Nome";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(17, 21);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(52, 15);
      this.label10.TabIndex = 0;
      this.label10.Text = "Código";
      // 
      // frmCadProdutos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(626, 478);
      this.Controls.Add(this.gbFornecedor);
      this.Controls.Add(this.gbPrecos);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmCadProdutos";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Produtos";
      this.Load += new System.EventHandler(this.frmCadProdutos_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.gbPrecos.ResumeLayout(false);
      this.gbPrecos.PerformLayout();
      this.gbFornecedor.ResumeLayout(false);
      this.gbFornecedor.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCodigoPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomePro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbPrecos;
        private System.Windows.Forms.MaskedTextBox mtbCrediario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbValorBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbValorPrazo;
        private System.Windows.Forms.TextBox tbCodBarras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.TextBox tbNomeFor;
        private System.Windows.Forms.Button btnPesForne;
        private System.Windows.Forms.TextBox tbCodForne;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbxDisponivel;
    }
}