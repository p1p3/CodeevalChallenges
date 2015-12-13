using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._93_CapitalizeWordsTest
{
    [TestClass]
    public class _93_CapitalizeWordsTest
    {
        [TestMethod]
        public void _93_CapitalizeWordsMainTest()
        {
            _93_CapitalizeWords challenge = new _93_CapitalizeWords("Hello world");
            Assert.AreEqual("Hello World", challenge.Capitalize());

            challenge = new _93_CapitalizeWords("javaScript language");
            Assert.AreEqual("JavaScript Language", challenge.Capitalize());

            challenge = new _93_CapitalizeWords("a letter");
            Assert.AreEqual("A Letter", challenge.Capitalize());

            challenge = new _93_CapitalizeWords("1st thing");
            Assert.AreEqual("1st Thing", challenge.Capitalize());

        }
    }
}
