using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests
{
    [TestClass]
    public class _37_PangramTest
    {
        [TestMethod]
        public void PangramMainTest()
        {

            string text = "A quick brown fox jumps over the lazy dog";
            _37_Pangrams pangram = new _37_Pangrams(text);

            Assert.AreEqual( 0, pangram.missingLetters().Length);

             text = "A slow yellow fox crawls under the proactive dog";
             pangram = new _37_Pangrams(text);

            Assert.AreEqual(6,pangram.missingLetters().Length);

        }
    }
}
