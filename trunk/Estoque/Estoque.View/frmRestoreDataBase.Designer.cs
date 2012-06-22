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
      this.button1 = new System.Windows.Forms.Button();
      this.ltbArquivos = new System.Windows.Forms.ListBox();
      this.gbRestore.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbRestore
      // 
      this.gbRestore.Controls.Add(this.ltbArquivos);
      this.gbRestore.Location = new System.Drawing.Point(12, 12);
      this.gbRestore.Name = "gbRestore";
      this.gbRestore.Size = new System.Drawing.Size(391, 395);
      this.gbRestore.TabIndex = 0;
      this.gbRestore.TabStop = false;
      this.gbRestore.Text = "Arquivos para Backup";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(162, 425);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(83, 30);
      this.button1.TabIndex = 1;
      this.button1.Text = "Restaurar";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // ltbArquivos
      // 
      this.ltbArquivos.FormattingEnabled = true;
      this.ltbArquivos.Location = new System.Drawing.Point(6, 19);
      this.ltbArquivos.Name = "ltbArquivos";
      this.ltbArquivos.Size = new System.Drawing.Size(379, 368);
      this.ltbArquivos.TabIndex = 0;
      // 
      // frmRestoreDataBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(423, 471);
      this.Controls.Add(this.button1);
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
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox ltbArquivos;
  }
}