using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeevalChallenges;

namespace ChallengesTests.TestFiles._26_FileSizeTest
{
    [TestClass]
    public class _26_FileSizeTest
    {
        [TestMethod]
        public void _26_FileSizeMainTest()
        {
            string path = @"../../../ChallengesTests/TestFiles/26_FileSize/testFile.txt";
            _26_FileSize challenge = new _26_FileSize(path);

            Assert.AreEqual(9, challenge.GetFileSize());
        }
    }
}
