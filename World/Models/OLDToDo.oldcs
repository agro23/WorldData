using System.Collections.Generic;
using System.Text;
using System;

namespace WordCounter.Models
{

  public class RepeatCounter
  {
    private string _keyword;
    private string _sentence;

    public RepeatCounter(string keyword, string sentence)
    {
    _keyword = keyword;
    _sentence = sentence;
    }

    public string GetKeyword()
    {
      return _keyword;
    }
    public void SetKeyword(string keyword)
    {
      _keyword = keyword;
    }

    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    public static string ValidateSentence(string sentence)
    {
      StringBuilder newString = new StringBuilder();
      for (var i = 0; i < sentence.Length; i++)
      {
        if(! char.IsPunctuation(sentence[i]))
        {
        newString.Append(sentence[i]);
        }
      }
      return newString.ToString();
    }

    public static int Counter(string keyword, string sentence)
    {
      sentence = ValidateSentence(sentence);
      string [] words = sentence.Split(' ');
      int repeatCount = 0;
      for (var i=0; i < words.Length; i++)
      {
        if (words[i].ToUpper().Equals(keyword.ToUpper()))
        {
          repeatCount++;
        }
      }
      return repeatCount;
    }
  }
}
