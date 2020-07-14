using System;

namespace Palindrome
{
  class Palindrome
  {
    public bool IsPalindrome(string wordInput)
    {
      wordInput.ToLower();
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