using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tp_jour_4_fizzbuzz;

namespace UnitTest.FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void GetOutput_WithNumberDivisibleBy3and5_ReturnRightResult()
        {
            string result = FizzBuzz.GetOutput(15);

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void GetOutput_WithNumberDivisibleBy3_ReturnRightResult()
        {
            string result = FizzBuzz.GetOutput(3);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GetOutput_WithNumberDivisibleBy5_ReturnRightResult()
        {
            string result = FizzBuzz.GetOutput(5);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GetOutput_WithNormalNumbers_ReturnRightResult()
        {
            string result = FizzBuzz.GetOutput(14);

            Assert.AreEqual("14", result);
        }
    }
}
