using System;
using System.Linq;
using Kata_2;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestKata_2
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4", 10)]
        [TestCase("1\n2", 3)]
        [TestCase("//;\n1;2", 3)]
        public void VerifyAddOutput(string numbers, int expectedResult)
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            //Act
            var actualResult = stringCalculator.Add(numbers);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void ThrowExceptionWhenAddNegativeNumber()
        {
            //Arrange
            var number = "1,-2,-5";
            var stringCalculator = new StringCalculator();
            //Act
            //Assert
            Assert.Throws<ArgumentException>((() => stringCalculator.Add(number)));
        }
    }
    [TestFixture]
    public class VerifyIfNumberArePositiveTest
    {
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4", 10)]
        public void VerifyAddOutput(string numbers, int expectedResult)
        {
            //Arrange
            var list = numbers.Split(',')
                .Select(int.Parse)
                .ToList();
            var verifyIfNumberArePositive = new VerifyIfNumberArePositive();
            //Act
            var actualResult = VerifyIfNumberArePositive.PublicCheckNegativeNumbers(list);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}