using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._16_NumberOfOnesTest
{
    [TestClass]
    public class _16_NumberOfOnesTest
    {
        [TestMethod]
        public void _16_NumberOfOnesMainTest()
        {
            _16_NumberOfOnes challenge = new _16_NumberOfOnes(10);
            Assert.AreEqual(2, challenge.NumberOfOnes());

            challenge = new _16_NumberOfOnes(22);
            Assert.AreEqual(3, challenge.NumberOfOnes());

            challenge = new _16_NumberOfOnes(56);
            Assert.AreEqual(3, challenge.NumberOfOnes());

        }
    }
}
