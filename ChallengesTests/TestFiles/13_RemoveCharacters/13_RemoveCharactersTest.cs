using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._13_RemoveCharactersTest
{
    [TestClass]
    public class _13_RemoveCharactersTest
    {
        [TestMethod]
        public void RemoveCharactersMainTest()
        {
            _13_RemoveCharacters challenge = new _13_RemoveCharacters("how are you", "abc");
            Assert.AreEqual("how re you", challenge.RemoveChars());

            challenge = new _13_RemoveCharacters("hello world", "def");
            Assert.AreEqual("hllo worl", challenge.RemoveChars());
        }
    }
}
