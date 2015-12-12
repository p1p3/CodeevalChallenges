using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._20_LowerCaseTest
{
    [TestClass]
    public class _20LowercaseTest
    {
        [TestMethod]
        public void _20LowercaseMainTest()
        {
            _20_Lowercase challenge = new _20_Lowercase("HELLO CODEEVAL");
            Assert.AreEqual("hello codeeval", challenge.GetLowerText());

            challenge = new _20_Lowercase("This is some text");
            Assert.AreEqual("this is some text", challenge.GetLowerText());
        }
    }
}
