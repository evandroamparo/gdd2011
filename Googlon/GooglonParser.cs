using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googlon
{
  public class GooglonParser
  {
    public GooglonParser(string texto)
    {
      this.Texto = texto;
    }

    private string[] _palavras;

    private string _texto;
    public string Texto
    {
      get { return _texto; }
      set
      {
        _texto = value;
        _palavras = Texto.Split(' ');
      }
    }

    private const string LetrasFoo = "cqlgz";

    private const string AlfabetoOrdenado = "sjxchqlvpdnkfbmgzwrt";

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
        return _palavras.Count(
            EhPreposicao);
      }
    }

    public int NumeroVerbos
    {
      get
      {
        return _palavras.Count(EhVerbo);
      }
    }

    public int NumeroVerbosPrimeiraPessoa
    {
      get
      {
        return _palavras.Count(EhVerboPrimeiraPessoa);
      }
    }

    public string ListaVocabulario
    {
      get
      {
        var palavrasSemRepeticao = new List<string>();

        foreach (var palavra in _palavras)
        {
          if (!palavrasSemRepeticao.Contains(palavra))
          {
            palavrasSemRepeticao.Add(palavra);
          }
        }

        var palavrasOrdenadas = palavrasSemRepeticao.OrderBy(current => current, new GooglonComparer(AlfabetoOrdenado));
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
        var numeros = new List<long>();

        foreach (var palavra in _palavras)
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
        var digito = AlfabetoOrdenado.IndexOf(palavra[i]);
        var valorLetra = (long) Math.Pow(20, i);
        numero += digito * valorLetra;
      }
      return numero;
    }
  }
}