using System;
using DevOpsDemo.ConsoleApp;
using NUnit.Framework;

namespace DevOpsDemo.UnitTests
{
    [TestFixture]
    public class when_using_worker_for_adding
    {
        [Test]
        public void given_valid_ints_then_return_sum()
        {
            //Arrange
            int a = 1, b = 2, expected = 3; 
             
            //Act  
            var result = Worker.SimpleAdd(a, b);

            //Assert
            Assert.IsInstanceOf<int>(result, "Result is not an int");
            Assert.AreEqual(expected, result, "Result does not match expected sum");
        }

        [Test]
        public void given_valid_negatives_then_return_sum()
        {
            //Arrange
            int a = -1, b = -2, expected = -3;

            //Act
            var result = Worker.SimpleAdd(a, b);

            //Assert
            Assert.IsInstanceOf<int>(result, "Result is not an int");
            Assert.AreEqual(expected, result, "Result does not match expected sum");
        }        

    }


}
