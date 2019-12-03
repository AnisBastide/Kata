using System;
using Kata_2;
using NUnit.Framework;

namespace TestKata_2
{
    [TestFixture]
    public class TestStringCalculator
    {
        [TestCase("", 0)]
        [TestCase("1,0", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,4,5,6", 18)]
        [TestCase("1\n2\n4\n5\n6", 18)]
        [TestCase("//;\n1;2;4;5;6", 18)]
        public void TestAdd(string number, int expectedResult)
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var actualResult = stringCalculator.Add(number);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void TestAddThrowException()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
           
        //Assert
        //Assert.Throws(typeof(ArgumentException), stringCalculator.Add("//;\n1;2;4;5;-6"));
        Assert.Throws<ArgumentException>(() => stringCalculator.Add(("//;\n1;2;4;5;-6;-8")));
        }
    }
}
