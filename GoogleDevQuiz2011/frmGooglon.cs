using System;
using System.Windows.Forms;

namespace GoogleDevQuiz2011
{
  public partial class FrmGooglon : Form
  {
    public FrmGooglon()
    {
      InitializeComponent();
      txtTexto_TextChanged(null, null);
    }

    private void txtTexto_TextChanged(object sender, EventArgs e)
    {
      var parser = new Googlon.GooglonParser(txtTexto.Text);

      txtPreposicoes.Text = parser.NumeroPreposicoes.ToString();
      txtVerbos.Text = parser.NumeroVerbos.ToString();
      txtVerbosPrimeiraPessoa.Text = parser.NumeroVerbosPrimeiraPessoa.ToString();
      txtVocabulario.Text = parser.ListaVocabulario;
      txtNumerosBonitos.Text = parser.NumerosBonitosDistintos.ToString();
    }
  }
}
