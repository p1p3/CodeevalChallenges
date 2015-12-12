using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;
using System.Linq;
using System;

namespace ChallengesTests
{
    [TestClass]
    public class BigPositionsTest
    {
        [TestMethod]
        public void BigPositionsMainTest()
        {
            string path = @"../../../ChallengesTests/TestFiles/19_BigPositions/Files.txt";
            _19_BigPositions challenge = new _19_BigPositions(path);
            bool[] result = (from i in challenge.nlines select i.bitsEqual()).ToArray();

            foreach (_19_BigPositions.nline line in challenge.nlines)
            {
                Console.WriteLine(line.bitsEqual().ToString().ToLower());
            }

            Assert.IsTrue(result[0]);
            Assert.IsFalse(result[1]);
        }
    }
}
