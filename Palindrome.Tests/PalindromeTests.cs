using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_InputStringReveresedEqualToInputString_True()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(true, testPalindrome.IsPalindrome("racecar"));
    }

    [TestMethod]
    public void IsPalindrome_InputStringReveresedNotEqualToInputString_False()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(false, testPalindrome.IsPalindrome("spaceship"));
    }
  }
}