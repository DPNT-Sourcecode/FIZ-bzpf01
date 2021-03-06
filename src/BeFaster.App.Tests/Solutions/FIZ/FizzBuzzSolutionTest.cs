﻿using BeFaster.App.Solutions.FIZ;
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
        [TestCase(3, ExpectedResult = "fizz fake deluxe")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "buzz fake deluxe")]
        [TestCase(6, ExpectedResult = "fizz")]
        [TestCase(11, ExpectedResult = "11")]
        [TestCase(13, ExpectedResult = "fizz")]
        [TestCase(14, ExpectedResult = "14")]
        [TestCase(15, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(16, ExpectedResult = "16")]
        [TestCase(22, ExpectedResult = "22")]
        [TestCase(30, ExpectedResult = "fizz buzz deluxe")]
        [TestCase(33, ExpectedResult = "fizz fake deluxe")]
        [TestCase(35, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(50, ExpectedResult = "buzz deluxe")]
        [TestCase(52, ExpectedResult = "buzz")]
        [TestCase(53, ExpectedResult = "fizz buzz")]
        [TestCase(55, ExpectedResult = "buzz fake deluxe")]
        [TestCase(150, ExpectedResult = "fizz buzz deluxe")]
        [TestCase(250, ExpectedResult = "buzz deluxe")]
        [TestCase(305, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(555, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(636, ExpectedResult = "fizz deluxe")]
        [TestCase(9996, ExpectedResult = "fizz")]
        [TestCase(9998, ExpectedResult = "9998")]
        [TestCase(9999, ExpectedResult = "fizz")]
        public string FizzBuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
    }
}


