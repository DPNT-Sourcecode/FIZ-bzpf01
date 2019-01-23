using BeFaster.App.Solutions.HLO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    class HelloSolutionTest
    {
        [Test]
        public void HelloNullParameter()
        {
            Assert.Ignore();
        }

        [Test]
        public void HelloEmptyParameter()
        {
            Assert.Ignore();
        }

        [Test]
        public void Hello()
        {
            string friendName = System.Guid.NewGuid().ToString();

            Assert.AreEqual("Hello, World!", HelloSolution.Hello(friendName));
        }
    }
}



