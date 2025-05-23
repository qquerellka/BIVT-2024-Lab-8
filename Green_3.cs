using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace Lab_8
{
  public class Green_3 : Green
  {
    // Поля 
    private string[]? _output;
    private string _sequence;
    private static char[] _punctuation;

    // Конструктор
    public Green_3(string input, string sequence) : base(input)
    {
      _output = null;
      _sequence = sequence is not null ? sequence.ToLowerInvariant() : string.Empty;
    }

    static Green_3()
    {
      _punctuation = ['.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/'];
    }

    // Свойства
    // public string[]? Output => _output;
    public char[]? Output => _output?.ToArray();


    // Методы
    public override void Review()
    {
      if (Input == null) return;

      string text = Input.ToLowerInvariant();
      string[] words = text.Split(new char[] { ' ', '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' }, StringSplitOptions.RemoveEmptyEntries);
      string[] testoutput = new string[words.Length];
      int count = 0;
      foreach (string s in words)
      {
        if (s.Contains(_sequence))
        {
          string clean = new string(s.Where(c => !_punctuation.Contains(c)).ToArray());

          // Проверка, нет ли уже такого слова
          if (!testoutput.Contains(clean))
          {
            testoutput[count] = clean;
            count++;
          }
        }
      }

      _output = new string[count];
      for (int i = 0; i < count; i++)
      {
        _output[i] = testoutput[i];
      }
    }

    public override string ToString()
    {
      if (_output == null || _output.Length == 0) return string.Empty;
      return string.Join(Environment.NewLine, _output);
    }
  }
}
