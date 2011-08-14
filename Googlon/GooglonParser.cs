using System.Linq;
using System.Collections;
using System.Text;

namespace Googlon
{
  public class GooglonParser
  {
    public string Texto { get; set; }

    private const string LetrasFoo = "cqlgz";

    private static bool EhPreposicao(string palavra)
    {
      return palavra.Length == 3 &&
             !LetrasFoo.Contains(palavra[palavra.Length - 1].ToString()) &&
             !palavra.Contains("k");
    }

    private static bool EhVerbo(string palavra)
    {
      return palavra.Length >= 6 &&
             LetrasFoo.Contains(palavra[palavra.Length - 1].ToString());
    }

    private static bool EhVerboPrimeiraPessoa(string palavra)
    {
      return EhVerbo(palavra) && 
             !LetrasFoo.Contains(palavra[0]);
    }

    public int NumeroPreposicoes
    {
      get
      {
        var palavras = Texto.Split(' ');
        return palavras.Count(
            EhPreposicao);
      }
    }

    public int NumeroVerbos
    {
      get
      {
        var palavras = Texto.Split(' ');
        return palavras.Count(EhVerbo);
      }
    }

    public int NumeroVerbosPrimeiraPessoa
    {
      get
      {
        var palavras = Texto.Split(' ');
        return palavras.Count(EhVerboPrimeiraPessoa);
      }
    }

    public string CriaListaVocabulario()
    {
      var palavras = Texto.Split(' ');
      var palavrasSemRepeticao = new SortedList();
      StringBuilder sbVocabulario = new StringBuilder();

      foreach (var palavra in palavras)
      {
        if (!palavrasSemRepeticao.ContainsKey(palavra))
        {
          palavrasSemRepeticao.Add(palavra, null);
        }
      }

      foreach (var palavra in palavrasSemRepeticao)
      {
        sbVocabulario.AppendFormat("{0} ", palavra.ToString());
      }

      return sbVocabulario.ToString();
    }
  }
}