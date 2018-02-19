using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldData;
using WorldData.Models;
using System.Collections.Generic;
using System;
using System.Text;

namespace WorldData.Tests
{
  [TestClass]
  public class WorldDataTest
  {
    [TestMethod]
    public void UserInputsAWord_AWordEmptyString_Equals_False()
    {
      Console.WriteLine("Please give me a country name: ");
      string aString = Console.ReadLine();
      Assert.AreEqual(false, (aString=="")); // should pass
    }
    //
    // [TestMethod]
    // public void UserInputsASentence_ASentenceEmptyString_Equals_False()
    // {
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   Assert.AreEqual(false, (aString=="")); // should pass
    // }
    //
    // [TestMethod]
    // public void ProgramRemovesPunctuationFromInputSentence_ASentenceContainsAPeriod_Equals_False()
    // {
    //   // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   Assert.AreEqual(false, (aString.Contains("."))); // should fail
    // }
    //
    // [TestMethod]
    // public void ProgramChecksPunctuationInInputSentence_ASentenceContainsNoPunctuation_Equals_true()
    // {
    //   // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   string[] punct = {".", ",", "!", "?", ";", ":", "-", "'", "\""};
    //   int i = 0;
    //   bool retval = false;
    //   while (i < punct.Length)
    //   {
    //     if (aString.Contains(punct[i]))
    //     {
    //         retval = true;
    //         break;
    //     }
    //     i++;
    //   }
    //   Assert.AreEqual(false, retval);
    // }
    //
    // [TestMethod]
    // public void ProgramRemovesPunctuation_ASentenceContainsNoPunctuation_Equals_true()
    // {
    //   // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   StringBuilder newString = new StringBuilder();
    //   for (var i = 0; i < aString.Length-1; i++)
    //   {
    //     if(! char.IsPunctuation(aString[i])){
    //       newString.Append(aString[i]);
    //     }
    //   }
    //
    //   Console.WriteLine("New string is: " + newString.ToString());
    //   bool retval = false;
    //   int k = 0;
    //   string[] punct = {".", ",", "!", "?", ";", ":", "-", "'", "\""};
    //   while (k < punct.Length)
    //   {
    //     if (newString.ToString().Contains(punct[k]))
    //     {
    //         retval = true;
    //         break;
    //     }
    //     k++;
    //   }
    //   Assert.AreEqual(false, (retval==true));
    // }
    //
    // [TestMethod]
    // public void ProgramSplitsAtSpace_ASentenceIsAnArrayNow_Equals_true()
    // {
    //   // * Split the new word string at " " into an array of strings called "sentence" and output it to the Console. This is the array we will compare the key word to in order to count its occurrences. If the array is not empty and its words contain no spaces it will pass the test.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   StringBuilder newString = new StringBuilder();
    //   for (var i = 0; i < aString.Length-1; i++)
    //   {
    //     if(! char.IsPunctuation(aString[i])){
    //       newString.Append(aString[i]);
    //     }
    //   }
    //   string [] words = newString.ToString().Split(' ');
    //   for (var i=0; i < words.Length; i++)
    //   {
    //     Console.WriteLine(words[i]);
    //   }
    //   Assert.AreEqual(false, (words.Length <= 0 == true));
    // }
    //
    // [TestMethod]
    // public void ProgramComparesWords_NoMatchesCounterIs0_Equals_true()
    // {
    //   // * Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
    //   //   TESTING: The counter is 0 when a string with no matches to the keyword is entered. Output the counter.:
    //   Console.WriteLine("Please give me a keyword: ");
    //   string keyword = Console.ReadLine().ToUpper();
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine().ToUpper();
    //   StringBuilder newString = new StringBuilder();
    //   for (var i = 0; i < aString.Length-1; i++)
    //   {
    //     if(! char.IsPunctuation(aString[i])){
    //       newString.Append(aString[i]);
    //     }
    //   }
    //   string [] words = newString.ToString().Split(' ');
    //   int repeatCount = 0;
    //   for (var i=0; i < words.Length; i++)
    //   {
    //     if (words[i].Equals(keyword))
    //     {
    //         repeatCount++;
    //     }
    //   }
    //   Console.WriteLine(keyword + " occurred  " + repeatCount + " time(s)");
    //   Assert.AreEqual(false, (repeatCount <= 0 == true));
    // }
    //
    // [TestMethod]
    // public void UserInputsAWord_AWordEmptyString_Equals_False()
    // // * Create a RepeatCounter Object model with a name. Simply test the object comes into existence. IsNotNull(Object) = true.
    // //   - NO INPUT OR OUTPUT
    // {
    //   RepeatCounter Count = new RepeatCounter("Apples", "I hear apples are pretty nice.");
    //   Assert.IsNotNull(Count); // should pass
    // }
    //
    // [TestMethod]
    // public void ObjectStripsPunctuation_NoSpacesInString_Equals_True()
    // {
    // // string x = RepeatCounter.ValidateSentence("Apples, I say, are a tasty fruit.");
    // string x = RepeatCounter.ValidateSentence("Apples are a tasty fruit. I like apples.");
    // // * Add a method to strip punctuation from a given sentence and return it in UPPERCASE.
    // Console.WriteLine("The result is " + x);
    // Assert.AreEqual(true, (x.Contains(" ") == true));
    // }
    //
    // [TestMethod]
    // public void ObjectCountsKeyword_RepeatsCounted_Equals_True()
    // {
    // int x = RepeatCounter.Counter("Apples", "Apples, apples, ApPlEs, appLES, APPLES. apples.");
    // // int x = RepeatCounter.Counter("Apples", "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples.");
    // // * Add the Method that counts the occurrences of the key word in the sentence and returns the number of occurrences.
    // Console.WriteLine("The resulting count is " + x);
    // Assert.AreEqual(true, (x > 0 == true));
    // }

  }
}
