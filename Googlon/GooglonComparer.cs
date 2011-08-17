using System;
using System.Collections.Generic;

namespace Googlon
{
  class GooglonComparer: IComparer<string>
  {
    private string _alfabeto;
    private string _ordemNormal;

    public GooglonComparer(string alfabeto)
    {
      _alfabeto = alfabeto;
      _ordemNormal = "";
      for (int i = 0; i < alfabeto.Length; i++)
      {
        _ordemNormal = _ordemNormal + char.ConvertFromUtf32(Convert.ToInt32('a') + i);
      }
    }

    public int Compare(string x, string y)
    {
      if (x != null && y != null)
      {
        string x2 = x,
               y2 = y;
        for (int i = 0; i < _ordemNormal.Length; i++)
        {
          if (_alfabeto != null)
          {
            x2 = x2.Replace(_alfabeto[i], char.ToUpper(_ordemNormal[i]));
            y2 = y2.Replace(_alfabeto[i], char.ToUpper(_ordemNormal[i]));
          }
        }
        return x2.CompareTo(y2);
      }
      return 0;
    }
  }
}
