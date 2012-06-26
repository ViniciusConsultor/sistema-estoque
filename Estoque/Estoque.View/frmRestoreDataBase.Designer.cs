namespace Estoque.View
{
  partial class frmRestoreDataBase
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
      this.gbRestore = new System.Windows.Forms.GroupBox();
      this.ltbArquivos = new System.Windows.Forms.ListBox();
      this.btnRestaurar = new System.Windows.Forms.Button();
      this.gbRestore.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbRestore
      // 
      this.gbRestore.Controls.Add(this.ltbArquivos);
      this.gbRestore.Location = new System.Drawing.Point(12, 12);
      this.gbRestore.Name = "gbRestore";
      this.gbRestore.Size = new System.Drawing.Size(399, 229);
      this.gbRestore.TabIndex = 0;
      this.gbRestore.TabStop = false;
      this.gbRestore.Text = "Arquivos para Backup";
      // 
      // ltbArquivos
      // 
      this.ltbArquivos.FormattingEnabled = true;
      this.ltbArquivos.Location = new System.Drawing.Point(6, 19);
      this.ltbArquivos.Name = "ltbArquivos";
      this.ltbArquivos.Size = new System.Drawing.Size(387, 199);
      this.ltbArquivos.TabIndex = 0;
      // 
      // btnRestaurar
      // 
      this.btnRestaurar.Location = new System.Drawing.Point(158, 262);
      this.btnRestaurar.Name = "btnRestaurar";
      this.btnRestaurar.Size = new System.Drawing.Size(83, 30);
      this.btnRestaurar.TabIndex = 1;
      this.btnRestaurar.Text = "Restaurar";
      this.btnRestaurar.UseVisualStyleBackColor = true;
      this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
      // 
      // frmRestoreDataBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(423, 305);
      this.Controls.Add(this.btnRestaurar);
      this.Controls.Add(this.gbRestore);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmRestoreDataBase";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Restauração do Banco";
      this.Load += new System.EventHandler(this.frmRestoreDataBase_Load);
      this.gbRestore.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbRestore;
    private System.Windows.Forms.Button btnRestaurar;
    private System.Windows.Forms.ListBox ltbArquivos;
  }
}