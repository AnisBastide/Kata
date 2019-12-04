using System;
using Kata_2;
using NUnit.Framework;

namespace TestKata_2
{
    [TestFixture]
    public class TestKata
    {
        [TestCase("",0)]
        [TestCase("1",1)]
        [TestCase("1,2",3)]
        [TestCase("1,2,1001",3)]
        [TestCase("1\n2",3)]
        [TestCase("//;\n1;2",3)]
        public void VerifyAddOutput(string number,int expectedResult)
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            //Act
            var actualResult = stringCalculator.Add(number);
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }
        [TestCase("1,-2,-3,6")]
        public void ThrowExceptionNegativeNumbers(string number)
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => stringCalculator.Add(number));
        }
    }
}
