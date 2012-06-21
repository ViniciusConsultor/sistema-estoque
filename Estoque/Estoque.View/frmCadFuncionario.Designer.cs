namespace Estoque.View
{
  partial class frmCadFuncionario
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
      this.gbFuncionario = new System.Windows.Forms.GroupBox();
      this.gbUsuario = new System.Windows.Forms.GroupBox();
      this.SuspendLayout();
      // 
      // gbFuncionario
      // 
      this.gbFuncionario.Location = new System.Drawing.Point(31, 28);
      this.gbFuncionario.Name = "gbFuncionario";
      this.gbFuncionario.Size = new System.Drawing.Size(607, 198);
      this.gbFuncionario.TabIndex = 0;
      this.gbFuncionario.TabStop = false;
      this.gbFuncionario.Text = "Funcionario";
      // 
      // gbUsuario
      // 
      this.gbUsuario.Location = new System.Drawing.Point(40, 247);
      this.gbUsuario.Name = "gbUsuario";
      this.gbUsuario.Size = new System.Drawing.Size(569, 140);
      this.gbUsuario.TabIndex = 1;
      this.gbUsuario.TabStop = false;
      this.gbUsuario.Text = "Usuario";
      // 
      // frmCadFuncionario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(724, 498);
      this.Controls.Add(this.gbUsuario);
      this.Controls.Add(this.gbFuncionario);
      this.Name = "frmCadFuncionario";
      this.Text = "Cadastro de Funcionários";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbFuncionario;
    private System.Windows.Forms.GroupBox gbUsuario;
  }
}