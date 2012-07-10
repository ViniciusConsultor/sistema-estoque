namespace Estoque.View
{
  partial class frmAltFuncionario
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.tbPesquisa = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cbTipoPesquisa = new System.Windows.Forms.ComboBox();
      this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
      this.gbInformacoes = new System.Windows.Forms.GroupBox();
      this.lblAtivo = new System.Windows.Forms.Label();
      this.lblAlteradoEm = new System.Windows.Forms.Label();
      this.lblCadastradoEm = new System.Windows.Forms.Label();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.label21 = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.tbUF = new System.Windows.Forms.TextBox();
      this.tbReferencia = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.tbNumero = new System.Windows.Forms.TextBox();
      this.label16 = new System.Windows.Forms.Label();
      this.tbRua = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.cbCidade = new System.Windows.Forms.ComboBox();
      this.label18 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.mtbFone = new System.Windows.Forms.MaskedTextBox();
      this.tbEmail = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.tbDataNascimento = new System.Windows.Forms.TextBox();
      this.tbCargo = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbSerieCart = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.tbCartProf = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tbRG = new System.Windows.Forms.TextBox();
      this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbNome = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbMatricula = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btnEditar = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
      this.gbInformacoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnPesquisar);
      this.groupBox1.Controls.Add(this.tbPesquisa);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.cbTipoPesquisa);
      this.groupBox1.Location = new System.Drawing.Point(16, 14);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(322, 114);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tipo Pesquisa";
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Location = new System.Drawing.Point(184, 78);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(75, 25);
      this.btnPesquisar.TabIndex = 4;
      this.btnPesquisar.Text = "Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // tbPesquisa
      // 
      this.tbPesquisa.Location = new System.Drawing.Point(6, 80);
      this.tbPesquisa.Name = "tbPesquisa";
      this.tbPesquisa.Size = new System.Drawing.Size(172, 21);
      this.tbPesquisa.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Pesquisar Por";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tipo";
      // 
      // cbTipoPesquisa
      // 
      this.cbTipoPesquisa.FormattingEnabled = true;
      this.cbTipoPesquisa.Items.AddRange(new object[] {
            "",
            "Nome",
            "CPF",
            "RG",
            "Ativos",
            "Inativos"});
      this.cbTipoPesquisa.Location = new System.Drawing.Point(9, 36);
      this.cbTipoPesquisa.Name = "cbTipoPesquisa";
      this.cbTipoPesquisa.Size = new System.Drawing.Size(150, 23);
      this.cbTipoPesquisa.TabIndex = 0;
      this.cbTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPesquisa_SelectedIndexChanged);
      // 
      // dgvFuncionarios
      // 
      this.dgvFuncionarios.AllowUserToAddRows = false;
      this.dgvFuncionarios.AllowUserToDeleteRows = false;
      this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFuncionarios.Location = new System.Drawing.Point(12, 144);
      this.dgvFuncionarios.Name = "dgvFuncionarios";
      this.dgvFuncionarios.ReadOnly = true;
      this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvFuncionarios.Size = new System.Drawing.Size(326, 300);
      this.dgvFuncionarios.TabIndex = 1;
      this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
      // 
      // gbInformacoes
      // 
      this.gbInformacoes.Controls.Add(this.lblAtivo);
      this.gbInformacoes.Controls.Add(this.lblAlteradoEm);
      this.gbInformacoes.Controls.Add(this.lblCadastradoEm);
      this.gbInformacoes.Controls.Add(this.btnSalvar);
      this.gbInformacoes.Controls.Add(this.label21);
      this.gbInformacoes.Controls.Add(this.label23);
      this.gbInformacoes.Controls.Add(this.tbUF);
      this.gbInformacoes.Controls.Add(this.tbReferencia);
      this.gbInformacoes.Controls.Add(this.label17);
      this.gbInformacoes.Controls.Add(this.tbNumero);
      this.gbInformacoes.Controls.Add(this.label16);
      this.gbInformacoes.Controls.Add(this.tbRua);
      this.gbInformacoes.Controls.Add(this.label15);
      this.gbInformacoes.Controls.Add(this.cbCidade);
      this.gbInformacoes.Controls.Add(this.label18);
      this.gbInformacoes.Controls.Add(this.label19);
      this.gbInformacoes.Controls.Add(this.label11);
      this.gbInformacoes.Controls.Add(this.mtbCelular);
      this.gbInformacoes.Controls.Add(this.label10);
      this.gbInformacoes.Controls.Add(this.mtbFone);
      this.gbInformacoes.Controls.Add(this.tbEmail);
      this.gbInformacoes.Controls.Add(this.label13);
      this.gbInformacoes.Controls.Add(this.label14);
      this.gbInformacoes.Controls.Add(this.tbDataNascimento);
      this.gbInformacoes.Controls.Add(this.tbCargo);
      this.gbInformacoes.Controls.Add(this.label12);
      this.gbInformacoes.Controls.Add(this.label6);
      this.gbInformacoes.Controls.Add(this.tbSerieCart);
      this.gbInformacoes.Controls.Add(this.label8);
      this.gbInformacoes.Controls.Add(this.tbCartProf);
      this.gbInformacoes.Controls.Add(this.label7);
      this.gbInformacoes.Controls.Add(this.tbRG);
      this.gbInformacoes.Controls.Add(this.mtbCpf);
      this.gbInformacoes.Controls.Add(this.label5);
      this.gbInformacoes.Controls.Add(this.label3);
      this.gbInformacoes.Controls.Add(this.tbNome);
      this.gbInformacoes.Controls.Add(this.label4);
      this.gbInformacoes.Controls.Add(this.tbMatricula);
      this.gbInformacoes.Controls.Add(this.label9);
      this.gbInformacoes.Location = new System.Drawing.Point(344, 14);
      this.gbInformacoes.Name = "gbInformacoes";
      this.gbInformacoes.Size = new System.Drawing.Size(384, 500);
      this.gbInformacoes.TabIndex = 2;
      this.gbInformacoes.TabStop = false;
      this.gbInformacoes.Text = "Informações";
      // 
      // lblAtivo
      // 
      this.lblAtivo.AutoSize = true;
      this.lblAtivo.Location = new System.Drawing.Point(145, 476);
      this.lblAtivo.Name = "lblAtivo";
      this.lblAtivo.Size = new System.Drawing.Size(0, 15);
      this.lblAtivo.TabIndex = 69;
      // 
      // lblAlteradoEm
      // 
      this.lblAlteradoEm.AutoSize = true;
      this.lblAlteradoEm.Location = new System.Drawing.Point(157, 448);
      this.lblAlteradoEm.Name = "lblAlteradoEm";
      this.lblAlteradoEm.Size = new System.Drawing.Size(0, 15);
      this.lblAlteradoEm.TabIndex = 68;
      // 
      // lblCadastradoEm
      // 
      this.lblCadastradoEm.AutoSize = true;
      this.lblCadastradoEm.Location = new System.Drawing.Point(126, 415);
      this.lblCadastradoEm.Name = "lblCadastradoEm";
      this.lblCadastradoEm.Size = new System.Drawing.Size(0, 15);
      this.lblCadastradoEm.TabIndex = 67;
      // 
      // btnSalvar
      // 
      this.btnSalvar.Location = new System.Drawing.Point(174, 36);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(75, 23);
      this.btnSalvar.TabIndex = 66;
      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(6, 448);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(145, 15);
      this.label21.TabIndex = 63;
      this.label21.Text = "Ultima alteração em: ";
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(7, 415);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(112, 15);
      this.label23.TabIndex = 57;
      this.label23.Text = "Cadastrado em: ";
      // 
      // tbUF
      // 
      this.tbUF.Location = new System.Drawing.Point(6, 297);
      this.tbUF.Name = "tbUF";
      this.tbUF.ReadOnly = true;
      this.tbUF.Size = new System.Drawing.Size(44, 21);
      this.tbUF.TabIndex = 56;
      // 
      // tbReferencia
      // 
      this.tbReferencia.Location = new System.Drawing.Point(6, 381);
      this.tbReferencia.MaxLength = 50;
      this.tbReferencia.Name = "tbReferencia";
      this.tbReferencia.ReadOnly = true;
      this.tbReferencia.Size = new System.Drawing.Size(231, 21);
      this.tbReferencia.TabIndex = 54;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(6, 363);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(77, 15);
      this.label17.TabIndex = 53;
      this.label17.Text = "Referencia";
      // 
      // tbNumero
      // 
      this.tbNumero.Location = new System.Drawing.Point(264, 339);
      this.tbNumero.MaxLength = 5;
      this.tbNumero.Name = "tbNumero";
      this.tbNumero.ReadOnly = true;
      this.tbNumero.Size = new System.Drawing.Size(58, 21);
      this.tbNumero.TabIndex = 52;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(261, 319);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(58, 15);
      this.label16.TabIndex = 51;
      this.label16.Text = "Numero";
      // 
      // tbRua
      // 
      this.tbRua.Location = new System.Drawing.Point(6, 339);
      this.tbRua.MaxLength = 50;
      this.tbRua.Name = "tbRua";
      this.tbRua.ReadOnly = true;
      this.tbRua.Size = new System.Drawing.Size(243, 21);
      this.tbRua.TabIndex = 50;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(7, 321);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(33, 15);
      this.label15.TabIndex = 49;
      this.label15.Text = "Rua";
      // 
      // cbCidade
      // 
      this.cbCidade.DisplayMember = "Nome";
      this.cbCidade.Enabled = false;
      this.cbCidade.FormattingEnabled = true;
      this.cbCidade.Location = new System.Drawing.Point(74, 294);
      this.cbCidade.Name = "cbCidade";
      this.cbCidade.Size = new System.Drawing.Size(181, 23);
      this.cbCidade.TabIndex = 48;
      this.cbCidade.ValueMember = "Id";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(71, 274);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(52, 15);
      this.label18.TabIndex = 47;
      this.label18.Text = "Cidade";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(7, 275);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(25, 15);
      this.label19.TabIndex = 45;
      this.label19.Text = "UF";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(143, 233);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(53, 15);
      this.label11.TabIndex = 43;
      this.label11.Text = "Celular";
      // 
      // mtbCelular
      // 
      this.mtbCelular.Location = new System.Drawing.Point(142, 252);
      this.mtbCelular.Mask = "(99) 00000000";
      this.mtbCelular.Name = "mtbCelular";
      this.mtbCelular.ReadOnly = true;
      this.mtbCelular.Size = new System.Drawing.Size(113, 21);
      this.mtbCelular.TabIndex = 42;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(139, 233);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(53, 15);
      this.label10.TabIndex = 44;
      this.label10.Text = "Celular";
      // 
      // mtbFone
      // 
      this.mtbFone.Location = new System.Drawing.Point(6, 251);
      this.mtbFone.Mask = "(99) 0000-0000";
      this.mtbFone.Name = "mtbFone";
      this.mtbFone.ReadOnly = true;
      this.mtbFone.Size = new System.Drawing.Size(113, 21);
      this.mtbFone.TabIndex = 41;
      // 
      // tbEmail
      // 
      this.tbEmail.Location = new System.Drawing.Point(6, 209);
      this.tbEmail.MaxLength = 50;
      this.tbEmail.Name = "tbEmail";
      this.tbEmail.ReadOnly = true;
      this.tbEmail.Size = new System.Drawing.Size(264, 21);
      this.tbEmail.TabIndex = 39;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(7, 233);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(63, 15);
      this.label13.TabIndex = 40;
      this.label13.Text = "Telefone";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(6, 191);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(44, 15);
      this.label14.TabIndex = 38;
      this.label14.Text = "Email";
      // 
      // tbDataNascimento
      // 
      this.tbDataNascimento.Location = new System.Drawing.Point(6, 124);
      this.tbDataNascimento.Name = "tbDataNascimento";
      this.tbDataNascimento.ReadOnly = true;
      this.tbDataNascimento.Size = new System.Drawing.Size(115, 21);
      this.tbDataNascimento.TabIndex = 37;
      // 
      // tbCargo
      // 
      this.tbCargo.Location = new System.Drawing.Point(195, 167);
      this.tbCargo.MaxLength = 20;
      this.tbCargo.Name = "tbCargo";
      this.tbCargo.ReadOnly = true;
      this.tbCargo.Size = new System.Drawing.Size(183, 21);
      this.tbCargo.TabIndex = 36;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(192, 147);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(45, 15);
      this.label12.TabIndex = 35;
      this.label12.Text = "Cargo";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(132, 104);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(27, 15);
      this.label6.TabIndex = 29;
      this.label6.Text = "RG";
      // 
      // tbSerieCart
      // 
      this.tbSerieCart.Location = new System.Drawing.Point(133, 167);
      this.tbSerieCart.MaxLength = 4;
      this.tbSerieCart.Name = "tbSerieCart";
      this.tbSerieCart.ReadOnly = true;
      this.tbSerieCart.Size = new System.Drawing.Size(52, 21);
      this.tbSerieCart.TabIndex = 34;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(133, 148);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(41, 15);
      this.label8.TabIndex = 33;
      this.label8.Text = "Série";
      // 
      // tbCartProf
      // 
      this.tbCartProf.Location = new System.Drawing.Point(6, 167);
      this.tbCartProf.MaxLength = 7;
      this.tbCartProf.Name = "tbCartProf";
      this.tbCartProf.ReadOnly = true;
      this.tbCartProf.Size = new System.Drawing.Size(111, 21);
      this.tbCartProf.TabIndex = 32;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 148);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(111, 15);
      this.label7.TabIndex = 31;
      this.label7.Text = "Nº Carteira Prof.";
      // 
      // tbRG
      // 
      this.tbRG.Location = new System.Drawing.Point(132, 123);
      this.tbRG.MaxLength = 10;
      this.tbRG.Name = "tbRG";
      this.tbRG.ReadOnly = true;
      this.tbRG.Size = new System.Drawing.Size(100, 21);
      this.tbRG.TabIndex = 30;
      // 
      // mtbCpf
      // 
      this.mtbCpf.Location = new System.Drawing.Point(244, 123);
      this.mtbCpf.Mask = "000,000,000-00";
      this.mtbCpf.Name = "mtbCpf";
      this.mtbCpf.ReadOnly = true;
      this.mtbCpf.Size = new System.Drawing.Size(114, 21);
      this.mtbCpf.TabIndex = 28;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(241, 104);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 15);
      this.label5.TabIndex = 27;
      this.label5.Text = "CPF";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 104);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(117, 15);
      this.label3.TabIndex = 25;
      this.label3.Text = "Data Nascimento";
      // 
      // tbNome
      // 
      this.tbNome.Location = new System.Drawing.Point(6, 80);
      this.tbNome.MaxLength = 50;
      this.tbNome.Name = "tbNome";
      this.tbNome.ReadOnly = true;
      this.tbNome.Size = new System.Drawing.Size(372, 21);
      this.tbNome.TabIndex = 24;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 62);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(110, 15);
      this.label4.TabIndex = 23;
      this.label4.Text = "Nome Completo";
      // 
      // tbMatricula
      // 
      this.tbMatricula.Location = new System.Drawing.Point(6, 38);
      this.tbMatricula.Name = "tbMatricula";
      this.tbMatricula.ReadOnly = true;
      this.tbMatricula.Size = new System.Drawing.Size(97, 21);
      this.tbMatricula.TabIndex = 22;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(7, 20);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(67, 15);
      this.label9.TabIndex = 21;
      this.label9.Text = "Matricula";
      // 
      // btnEditar
      // 
      this.btnEditar.Location = new System.Drawing.Point(134, 462);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(75, 23);
      this.btnEditar.TabIndex = 3;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // frmAltFuncionario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(740, 525);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.gbInformacoes);
      this.Controls.Add(this.dgvFuncionarios);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.Name = "frmAltFuncionario";
      this.Text = "Alterar Funcionário";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
      this.gbInformacoes.ResumeLayout(false);
      this.gbInformacoes.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.TextBox tbPesquisa;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbTipoPesquisa;
    private System.Windows.Forms.DataGridView dgvFuncionarios;
    private System.Windows.Forms.GroupBox gbInformacoes;
    private System.Windows.Forms.TextBox tbDataNascimento;
    private System.Windows.Forms.TextBox tbCargo;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbSerieCart;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbCartProf;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox tbRG;
    private System.Windows.Forms.MaskedTextBox mtbCpf;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbNome;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbMatricula;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.MaskedTextBox mtbCelular;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.MaskedTextBox mtbFone;
    private System.Windows.Forms.TextBox tbEmail;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox tbUF;
    private System.Windows.Forms.TextBox tbReferencia;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.TextBox tbNumero;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox tbRua;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.ComboBox cbCidade;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Label lblAlteradoEm;
    private System.Windows.Forms.Label lblCadastradoEm;
    private System.Windows.Forms.Label lblAtivo;
  }
}