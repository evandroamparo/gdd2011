namespace GoogleDevQuiz2011
{
  partial class FrmGooglon
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGooglon));
      this.lblTexto = new System.Windows.Forms.Label();
      this.txtTexto = new System.Windows.Forms.TextBox();
      this.lblPreposicoes = new System.Windows.Forms.Label();
      this.txtPreposicoes = new System.Windows.Forms.TextBox();
      this.lblRespostas = new System.Windows.Forms.Label();
      this.txtVerbos = new System.Windows.Forms.TextBox();
      this.lblVerbos = new System.Windows.Forms.Label();
      this.txtVerbosPrimeiraPessoa = new System.Windows.Forms.TextBox();
      this.lblVerbosPrimeiraPessoa = new System.Windows.Forms.Label();
      this.txtVocabulario = new System.Windows.Forms.TextBox();
      this.lblVocabulario = new System.Windows.Forms.Label();
      this.txtNumerosBonitos = new System.Windows.Forms.TextBox();
      this.lblNumerosBonitos = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTexto
      // 
      this.lblTexto.AutoSize = true;
      this.lblTexto.Location = new System.Drawing.Point(12, 9);
      this.lblTexto.Name = "lblTexto";
      this.lblTexto.Size = new System.Drawing.Size(37, 13);
      this.lblTexto.TabIndex = 0;
      this.lblTexto.Text = "Texto:";
      // 
      // txtTexto
      // 
      this.txtTexto.Location = new System.Drawing.Point(12, 25);
      this.txtTexto.Multiline = true;
      this.txtTexto.Name = "txtTexto";
      this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtTexto.Size = new System.Drawing.Size(397, 319);
      this.txtTexto.TabIndex = 2;
      this.txtTexto.Text = resources.GetString("txtTexto.Text");
      this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
      // 
      // lblPreposicoes
      // 
      this.lblPreposicoes.AutoSize = true;
      this.lblPreposicoes.Location = new System.Drawing.Point(415, 28);
      this.lblPreposicoes.Name = "lblPreposicoes";
      this.lblPreposicoes.Size = new System.Drawing.Size(68, 13);
      this.lblPreposicoes.TabIndex = 3;
      this.lblPreposicoes.Text = "Preposições:";
      // 
      // txtPreposicoes
      // 
      this.txtPreposicoes.Location = new System.Drawing.Point(567, 25);
      this.txtPreposicoes.Name = "txtPreposicoes";
      this.txtPreposicoes.ReadOnly = true;
      this.txtPreposicoes.Size = new System.Drawing.Size(84, 20);
      this.txtPreposicoes.TabIndex = 4;
      // 
      // lblRespostas
      // 
      this.lblRespostas.AutoSize = true;
      this.lblRespostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRespostas.Location = new System.Drawing.Point(415, 9);
      this.lblRespostas.Name = "lblRespostas";
      this.lblRespostas.Size = new System.Drawing.Size(70, 13);
      this.lblRespostas.TabIndex = 5;
      this.lblRespostas.Text = "Respostas:";
      // 
      // txtVerbos
      // 
      this.txtVerbos.Location = new System.Drawing.Point(567, 51);
      this.txtVerbos.Name = "txtVerbos";
      this.txtVerbos.ReadOnly = true;
      this.txtVerbos.Size = new System.Drawing.Size(84, 20);
      this.txtVerbos.TabIndex = 7;
      // 
      // lblVerbos
      // 
      this.lblVerbos.AutoSize = true;
      this.lblVerbos.Location = new System.Drawing.Point(415, 54);
      this.lblVerbos.Name = "lblVerbos";
      this.lblVerbos.Size = new System.Drawing.Size(43, 13);
      this.lblVerbos.TabIndex = 6;
      this.lblVerbos.Text = "Verbos:";
      // 
      // txtVerbosPrimeiraPessoa
      // 
      this.txtVerbosPrimeiraPessoa.Location = new System.Drawing.Point(567, 77);
      this.txtVerbosPrimeiraPessoa.Name = "txtVerbosPrimeiraPessoa";
      this.txtVerbosPrimeiraPessoa.ReadOnly = true;
      this.txtVerbosPrimeiraPessoa.Size = new System.Drawing.Size(84, 20);
      this.txtVerbosPrimeiraPessoa.TabIndex = 9;
      // 
      // lblVerbosPrimeiraPessoa
      // 
      this.lblVerbosPrimeiraPessoa.AutoSize = true;
      this.lblVerbosPrimeiraPessoa.Location = new System.Drawing.Point(415, 80);
      this.lblVerbosPrimeiraPessoa.Name = "lblVerbosPrimeiraPessoa";
      this.lblVerbosPrimeiraPessoa.Size = new System.Drawing.Size(136, 13);
      this.lblVerbosPrimeiraPessoa.TabIndex = 8;
      this.lblVerbosPrimeiraPessoa.Text = "Verbos em primeira pessoa:";
      // 
      // txtVocabulario
      // 
      this.txtVocabulario.Location = new System.Drawing.Point(418, 122);
      this.txtVocabulario.Multiline = true;
      this.txtVocabulario.Name = "txtVocabulario";
      this.txtVocabulario.ReadOnly = true;
      this.txtVocabulario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtVocabulario.Size = new System.Drawing.Size(354, 193);
      this.txtVocabulario.TabIndex = 11;
      // 
      // lblVocabulario
      // 
      this.lblVocabulario.AutoSize = true;
      this.lblVocabulario.Location = new System.Drawing.Point(415, 106);
      this.lblVocabulario.Name = "lblVocabulario";
      this.lblVocabulario.Size = new System.Drawing.Size(105, 13);
      this.lblVocabulario.TabIndex = 10;
      this.lblVocabulario.Text = "Lista de vocabulário:";
      // 
      // txtNumerosBonitos
      // 
      this.txtNumerosBonitos.Location = new System.Drawing.Point(567, 324);
      this.txtNumerosBonitos.Name = "txtNumerosBonitos";
      this.txtNumerosBonitos.ReadOnly = true;
      this.txtNumerosBonitos.Size = new System.Drawing.Size(84, 20);
      this.txtNumerosBonitos.TabIndex = 13;
      // 
      // lblNumerosBonitos
      // 
      this.lblNumerosBonitos.AutoSize = true;
      this.lblNumerosBonitos.Location = new System.Drawing.Point(417, 327);
      this.lblNumerosBonitos.Name = "lblNumerosBonitos";
      this.lblNumerosBonitos.Size = new System.Drawing.Size(68, 13);
      this.lblNumerosBonitos.TabIndex = 12;
      this.lblNumerosBonitos.Text = "Preposições:";
      // 
      // frmGooglon
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 356);
      this.Controls.Add(this.txtNumerosBonitos);
      this.Controls.Add(this.lblNumerosBonitos);
      this.Controls.Add(this.txtVocabulario);
      this.Controls.Add(this.lblVocabulario);
      this.Controls.Add(this.txtVerbosPrimeiraPessoa);
      this.Controls.Add(this.lblVerbosPrimeiraPessoa);
      this.Controls.Add(this.txtVerbos);
      this.Controls.Add(this.lblVerbos);
      this.Controls.Add(this.lblRespostas);
      this.Controls.Add(this.txtPreposicoes);
      this.Controls.Add(this.lblPreposicoes);
      this.Controls.Add(this.txtTexto);
      this.Controls.Add(this.lblTexto);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "FrmGooglon";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Provinha de Programação - Google Developer Day Brasil 2011";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTexto;
    private System.Windows.Forms.TextBox txtTexto;
    private System.Windows.Forms.Label lblPreposicoes;
    private System.Windows.Forms.TextBox txtPreposicoes;
    private System.Windows.Forms.Label lblRespostas;
    private System.Windows.Forms.TextBox txtVerbos;
    private System.Windows.Forms.Label lblVerbos;
    private System.Windows.Forms.TextBox txtVerbosPrimeiraPessoa;
    private System.Windows.Forms.Label lblVerbosPrimeiraPessoa;
    private System.Windows.Forms.TextBox txtVocabulario;
    private System.Windows.Forms.Label lblVocabulario;
    private System.Windows.Forms.TextBox txtNumerosBonitos;
    private System.Windows.Forms.Label lblNumerosBonitos;
  }
}

