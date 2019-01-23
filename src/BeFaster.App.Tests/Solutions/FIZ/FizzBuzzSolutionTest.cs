using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    class FizzBuzzSolutionTest
    {
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(6, ExpectedResult = "fizz")]
        [TestCase(11, ExpectedResult = "fake deluxe")]
        [TestCase(13, ExpectedResult = "fizz")]
        [TestCase(14, ExpectedResult = "14")]
        [TestCase(15, ExpectedResult = "fizz buzz")]
        [TestCase(16, ExpectedResult = "16")]
        [TestCase(22, ExpectedResult = "deluxe")]
        [TestCase(33, ExpectedResult = "fizz fake deluxe")]
        [TestCase(35, ExpectedResult = "fizz buzz")]
        [TestCase(52, ExpectedResult = "buzz")]
        [TestCase(53, ExpectedResult = "fizz buzz")]
        [TestCase(55, ExpectedResult = "buzz fake deluxe")]
        [TestCase(150, ExpectedResult = "fizz buzz")]
        [TestCase(250, ExpectedResult = "buzz")]
        [TestCase(305, ExpectedResult = "fizz buzz")]
        [TestCase(555, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(636, ExpectedResult = "fizz")]
        [TestCase(9996, ExpectedResult = "fizz")]
        [TestCase(9998, ExpectedResult = "9998")]
        [TestCase(9999, ExpectedResult = "fizz fake deluxe")]
        public string FizzBuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
    }
}


