using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._41_ArrayAbsurdityTest
{
    [TestClass]
    public class _41_ArrayAbsurdityTest
    {
        [TestMethod]
        public void _41_ArrayAbsurdityMainTest()
        {
            _41_ArrayAbsurdity challenge = new _41_ArrayAbsurdity("5;0,1,2,3,0");
            Assert.AreEqual("0", challenge.GetDuplicate());

            challenge = new _41_ArrayAbsurdity("20;0,1,10,3,2,4,5,7,6,8,11,9,15,12,13,4,16,18,17,14");
            Assert.AreEqual("4", challenge.GetDuplicate());
;        }
    }
}
