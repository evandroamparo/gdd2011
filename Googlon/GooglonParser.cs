using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googlon
{
  public class GooglonParser
  {
    public string Texto { get; set; }

    private const string LetrasFoo = "cqlgz";

    public const string OrdemAlfabetica = "sjxchqlvpdnkfbmgzwrt";

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

    public string ListaVocabulario
    {
      get
      {
        var palavras = Texto.Split(' ');
        var palavrasSemRepeticao = new List<string>();

        foreach (var palavra in palavras)
        {
          if (palavrasSemRepeticao.IndexOf(palavra) == -1)
          {
            palavrasSemRepeticao.Add(palavra);
          }
        }

        var palavrasOrdenadas = palavrasSemRepeticao.OrderBy(current => current, new GooglonComparer());
        var sbVocabulario = new StringBuilder();
        foreach (var palavra in palavrasOrdenadas)
        {
          sbVocabulario.AppendFormat("{0} ", palavra);
        }
        return sbVocabulario.ToString();
      }
    }

    public int NumerosBonitosDistintos
    {
      get
      {
        var palavras = Texto.Split(' ');
        var numeros = new List<long>();

        foreach (var palavra in palavras)
        {
          numeros.Add(PalavraParaNumero(palavra));
        }

        var numerosBonitos = numeros.Where(numero => EhNumeroBonito(numero)).ToList();

        var numerosDistintos = new List<long>();

        foreach (var numeroBonito in numerosBonitos)
        {
          if (!numerosDistintos.Contains(numeroBonito))
          {
            numerosDistintos.Add(numeroBonito);
          }
        }
        return numerosDistintos.Count;
      }
    }

    private static bool EhNumeroBonito(long numero)
    {
      return (numero >= 946916) && (numero % 3 == 0);
    }

    private static long PalavraParaNumero(string palavra)
    {
      long numero = 0;

      for (int i = 0; i < palavra.Length; i++)
      {
        var digito = OrdemAlfabetica.IndexOf(palavra[i]);
        var valorLetra = (long) Math.Pow(20, i);
        numero += digito * valorLetra;
      }
      return numero;
    }
  }
}