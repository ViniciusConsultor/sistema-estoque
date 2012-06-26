namespace Estoque.View
{
    partial class frmConfiguracao
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
      this.btnCarregaBanco = new System.Windows.Forms.Button();
      this.cbDataBase = new System.Windows.Forms.ComboBox();
      this.btnRestore = new System.Windows.Forms.Button();
      this.cbListServer = new System.Windows.Forms.ComboBox();
      this.lbConString = new System.Windows.Forms.Label();
      this.lbTeste = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnTeste = new System.Windows.Forms.Button();
      this.tbSenha = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbUser = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnBackup = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.saveBackupDialog = new System.Windows.Forms.SaveFileDialog();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnCarregaBanco);
      this.groupBox1.Controls.Add(this.cbDataBase);
      this.groupBox1.Controls.Add(this.btnRestore);
      this.groupBox1.Controls.Add(this.cbListServer);
      this.groupBox1.Controls.Add(this.lbConString);
      this.groupBox1.Controls.Add(this.lbTeste);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.btnTeste);
      this.groupBox1.Controls.Add(this.tbSenha);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.tbUser);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.btnBackup);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(98, 58);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(598, 309);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Banco de Dados";
      // 
      // btnCarregaBanco
      // 
      this.btnCarregaBanco.Location = new System.Drawing.Point(246, 64);
      this.btnCarregaBanco.Name = "btnCarregaBanco";
      this.btnCarregaBanco.Size = new System.Drawing.Size(75, 23);
      this.btnCarregaBanco.TabIndex = 17;
      this.btnCarregaBanco.Text = "Carregar";
      this.btnCarregaBanco.UseVisualStyleBackColor = true;
      this.btnCarregaBanco.Click += new System.EventHandler(this.btnCarregaBanco_Click);
      // 
      // cbDataBase
      // 
      this.cbDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbDataBase.FormattingEnabled = true;
      this.cbDataBase.Location = new System.Drawing.Point(81, 65);
      this.cbDataBase.Name = "cbDataBase";
      this.cbDataBase.Size = new System.Drawing.Size(140, 23);
      this.cbDataBase.TabIndex = 16;
      // 
      // btnRestore
      // 
      this.btnRestore.Location = new System.Drawing.Point(388, 136);
      this.btnRestore.Name = "btnRestore";
      this.btnRestore.Size = new System.Drawing.Size(80, 29);
      this.btnRestore.TabIndex = 15;
      this.btnRestore.Text = "Restore";
      this.btnRestore.UseVisualStyleBackColor = true;
      this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
      // 
      // cbListServer
      // 
      this.cbListServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbListServer.FormattingEnabled = true;
      this.cbListServer.Location = new System.Drawing.Point(81, 35);
      this.cbListServer.Name = "cbListServer";
      this.cbListServer.Size = new System.Drawing.Size(253, 23);
      this.cbListServer.TabIndex = 14;
      // 
      // lbConString
      // 
      this.lbConString.AutoSize = true;
      this.lbConString.Location = new System.Drawing.Point(62, 212);
      this.lbConString.Name = "lbConString";
      this.lbConString.Size = new System.Drawing.Size(0, 15);
      this.lbConString.TabIndex = 13;
      // 
      // lbTeste
      // 
      this.lbTeste.AutoSize = true;
      this.lbTeste.Location = new System.Drawing.Point(206, 268);
      this.lbTeste.Name = "lbTeste";
      this.lbTeste.Size = new System.Drawing.Size(92, 15);
      this.lbTeste.TabIndex = 12;
      this.lbTeste.Text = "Não Conectado";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(11, 212);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(45, 15);
      this.label5.TabIndex = 11;
      this.label5.Text = "String: ";
      // 
      // btnTeste
      // 
      this.btnTeste.Enabled = false;
      this.btnTeste.Location = new System.Drawing.Point(35, 260);
      this.btnTeste.Name = "btnTeste";
      this.btnTeste.Size = new System.Drawing.Size(87, 30);
      this.btnTeste.TabIndex = 10;
      this.btnTeste.Text = "Testar";
      this.btnTeste.UseVisualStyleBackColor = true;
      this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
      // 
      // tbSenha
      // 
      this.tbSenha.Location = new System.Drawing.Point(81, 124);
      this.tbSenha.Name = "tbSenha";
      this.tbSenha.Size = new System.Drawing.Size(140, 21);
      this.tbSenha.TabIndex = 9;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(32, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(43, 15);
      this.label4.TabIndex = 8;
      this.label4.Text = "Senha";
      // 
      // tbUser
      // 
      this.tbUser.Location = new System.Drawing.Point(81, 97);
      this.tbUser.Name = "tbUser";
      this.tbUser.Size = new System.Drawing.Size(140, 21);
      this.tbUser.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(25, 100);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Usuário";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Data Base";
      // 
      // btnBackup
      // 
      this.btnBackup.Enabled = false;
      this.btnBackup.Location = new System.Drawing.Point(388, 100);
      this.btnBackup.Name = "btnBackup";
      this.btnBackup.Size = new System.Drawing.Size(80, 30);
      this.btnBackup.TabIndex = 2;
      this.btnBackup.Text = "Backup";
      this.btnBackup.UseVisualStyleBackColor = true;
      this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Servidor:";
      // 
      // frmConfiguracao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(792, 566);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MinimizeBox = false;
      this.Name = "frmConfiguracao";
      this.Text = "Configurações";
      this.Load += new System.EventHandler(this.frmConfiguracao_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label lbConString;
        private System.Windows.Forms.Label lbTeste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbListServer;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ComboBox cbDataBase;
        private System.Windows.Forms.Button btnCarregaBanco;
        private System.Windows.Forms.SaveFileDialog saveBackupDialog;
    }
}