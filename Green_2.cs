using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lab_8
{
  public class Green_2 : Green
  {
    // Поля
    private char[]? _output;
    private (char, int)[] _midoutput;
    // private char[]? _output;

    private static readonly char[] _russianLetters;


    // Свойства
    // public char[]? Output => _output;
    public char[]? Output => _output?.ToArray();

    // Статический конструктор
    static Green_2()
    {
      _russianLetters = new char[]
      {
                'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о',
                'п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я', 'a','b','c','d','e','f','g','h','i','j','k','l','m',
    'n','o','p','q','r','s','t','u','v','w','x','y','z'
      };
    }
    // Конструктор
    public Green_2(string input) : base(input)
    {
      _output = null;
    }


    // Методы
    private bool IsRussianLetter(char ch)
    {
      return (ch >= 'а' && ch <= 'я') || ch == 'ё';
    }

    public override void Review()
    {
      if (Input == null) return;

      string text = Input.ToLowerInvariant();
      string[] words = text.Split(new char[] { ' ', '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' }, StringSplitOptions.RemoveEmptyEntries);

      (char, int)[] letterCount = new (char, int)[_russianLetters.Length];
      for (int i = 0; i < _russianLetters.Length; i++)
      {
        letterCount[i].Item1 = _russianLetters[i];
        letterCount[i].Item2 = 0;
      }

      foreach (string word in words)
      {
        for (int i = 0; i < letterCount.Length; i++)
        {
          if (word[0] == letterCount[i].Item1)
          {
            letterCount[i].Item2++;
          }
        }
      }
      for (int i = 0; i < letterCount.Length; i++)
      {
        Console.Write((letterCount[i].Item1).ToString() + " " + (letterCount[i].Item2).ToString() + ", ");
      }
      Console.WriteLine();

      var result = letterCount
          .Where(item => item.Item2 != 0)
          .OrderByDescending(item => item.Item2)
          .ThenBy(item => item.Item1)
          .ToArray();
      _output = new char[result.Length];
      for (int i = 0; i < result.Length; i++)
      {
        _output[i] = result[i].Item1;
      }
    }

    public override string ToString()
    {
      if (_output == null || _output.Length == 0) return string.Empty;

      return string.Join(
          ", ", _output
      );
    }
  }
}
