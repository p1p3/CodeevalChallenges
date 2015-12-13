using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._12_FirstNotRepeatedCharacterTest
{
    [TestClass]
    public class _12_FirstNotRepeatedCharacterTest
    {
        [TestMethod]
        public void _12_FirstNotRepeatedCharacterMainTest()
        {
            _12_FirstNotRepeatedCharacter challenge = new _12_FirstNotRepeatedCharacter("yellow");
            Assert.AreEqual("y", challenge.FirstNotRepeatedCharacter());

            challenge = new _12_FirstNotRepeatedCharacter("tooth");
            Assert.AreEqual("h", challenge.FirstNotRepeatedCharacter());
        }
    }
}
