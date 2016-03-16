using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Game;

namespace NunitTests
{
    [TestFixture]
    public class FrameTests
    {
        [Test]
        public void TestScoreNoThrows()
        {
            Frame f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.Score);
             
        }
        
    }
}
