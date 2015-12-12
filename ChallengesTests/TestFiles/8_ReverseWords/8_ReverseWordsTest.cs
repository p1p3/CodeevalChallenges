using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._8_ReverseWordsTest
{
    [TestClass]
    public class _8_ReverseWordsTest
    {
        [TestMethod]
        public void _8_ReverseWordsMainTest()
        {
            _8_ReverseWords challenge = new _8_ReverseWords("Hello World");
            Assert.AreEqual("World Hello", challenge.ReverseWords());

            challenge = new _8_ReverseWords("Hello CodeEval");
            Assert.AreEqual("CodeEval Hello", challenge.ReverseWords());
        }
    }
}
