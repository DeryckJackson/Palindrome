using System;

namespace Palindrome
{
  class Palindromes
  {
    static void Main()
    {
      Console.WriteLine("Enter your word to see if it is a Palindrome:");
      string userWord = Console.ReadLine();
      Palindrome newPal = new Palindrome();
      if(newPal.IsPalindrome(userWord))
      {
        Console.WriteLine("Your word is a Palindrome!");
      }
      else
      {
        Console.WriteLine("Your word is not a Palindrome.");
      }
    }
  }
}
