using System;

namespace Palindrome
{
  public class Palindrome
  {
    public bool IsPalindrome(string wordInput)
    {
      char[] wordArray = wordInput.ToCharArray();
      Array.Reverse(wordArray);
      string reversedInput = String.Join("", wordArray);
      if (reversedInput == wordInput)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}