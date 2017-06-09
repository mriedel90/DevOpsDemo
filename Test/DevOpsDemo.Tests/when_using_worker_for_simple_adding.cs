using System;
using System.ComponentModel;
using DevOpsDemo.ConsoleApp;
using NUnit.Framework;

namespace DevOpsDemo.Tests
{
    [TestFixture]
    public class when_using_worker_for_simple_adding
    {
        [Test]
        public void given_valid_ints_returns_sum()
        {
            //Arrange
            int a = 1, b = 2, expected = 3;


            //Act
            var actual = Worker.SimpleAdd(a, b);

            //Assert
            Assert.IsInstanceOf<int>(actual, "Result is not int");
            Assert.AreEqual(expected, actual, "Expected result is not as expected");
        }


        [Test]
        public void given_valid_negative_ints_returns_sum()
        {
            //Arrange
            int a = -1, b = -2, expected = -3;


            //Act
            var actual = Worker.SimpleAdd(a, b);

            //Assert
            Assert.IsInstanceOf<int>(actual, "Result is not int");
            Assert.AreEqual(expected, actual, "Expected result is not as expected");
        }
    }
}
