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
            Assert.Throws<System.ArgumentNullException>(() => HelloSolution.Hello(null));
        }

        [Test]
        public void HelloEmptyParameter()
        {
            Assert.Throws<System.ArgumentNullException>(() => HelloSolution.Hello(string.Empty));
        }

        [Test]
        public void HelloWhitespaceParameter()
        {
            Assert.Throws<System.ArgumentNullException>(() => HelloSolution.Hello(" "));
        }

        [Test]
        public void Hello()
        {
            string friendName = System.Guid.NewGuid().ToString();

            Assert.AreEqual(("Hello, " + friendName + "!"), HelloSolution.Hello(friendName));
        }
    }
}




