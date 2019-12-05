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
    public class TestKata
    {
        [TestCase("",0)]
        [TestCase("1",1)]
        [TestCase("1,2",3)]
        public void VerifyAddOutput(string number,int expectedResult)
        {
            //Arrange
            var stringCalculator = new StringCalculator();
            //Act
            var actualResult = stringCalculator.Add(number);
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
