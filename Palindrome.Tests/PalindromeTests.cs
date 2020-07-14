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
  }
}