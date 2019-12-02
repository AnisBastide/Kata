using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata_2;
using NUnit.Framework;

namespace TestKata_2
{
    [TestFixture]
    public class TestKata2
    {
        [TestCase("", 0)]
        [TestCase("//,\n1", 1)]
        [TestCase("//,\n1,2", 3)]
        [TestCase("//,\n1,2,3,4,5", 15)]
        [TestCase("//,\n1\n2\n3\n4\n5", 15)]
        [TestCase("//;\n1;2", 3)]

        public void TestStringCalculator(string number, int expectedResult)
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act
            var actualResult = stringCalculator.Add(number);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void TestException()
        {
            //Arrange
            var stringCalculator = new StringCalculator();

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => stringCalculator.Add(("//;\n1;2;-5")));

        }
    }
}
