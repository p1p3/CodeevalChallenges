using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._10_MthLastElementTest
{
    [TestClass]
    public class _10_MthLastElementTest
    {
        [TestMethod]
        public void _10_MthLastElementMainTest()
        {
            _10_MthLastElement challenge = new _10_MthLastElement("a b c d 4");
            Assert.AreEqual("a", challenge.getMthElement());

             challenge = new _10_MthLastElement("e f g h 2");
            Assert.AreEqual("g", challenge.getMthElement());

            
            try
            {
                challenge = new _10_MthLastElement("e f g h 5");
            }
            catch (IndiceIncorrectoExecption)
            {
                Assert.IsTrue(true);
            }
           


        }
    }
}
