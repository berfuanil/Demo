using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        

        [TestMethod()]
        public void ConstructorTest()
        {
            // Arrange

            // Act
            Addition a = new Addition();

            // Assert
            Assert.IsNotNull(a);
        }
        /*
        [TestMethod()]
        public void EmptyListTest()
        {
            Addition a = new Addition();
            List<int> values = null;
            var result = a.Add(values);
            Assert.AreEqual(0, result);
        }
        */

        [TestMethod(), ExpectedException(typeof(ArgumentNullException))]
        public void EmptyListTest()
        {
            Addition a = new Addition();
            List<int> values = null;
            _ = a.Add(values);
        }

        [TestMethod]
        public void OutofBoundsTest()
        {
            // Arrange
            int lessThanMax = Int32.MaxValue - 5;
            List<int> values = new List<int>() { lessThanMax, 3, 3 };

            // Act
            Addition a = new Addition();
            int sum = a.Add(values);

            // Assert
            Assert.IsTrue(sum > Int32.MaxValue);
        }

        [TestMethod]
        public void IsResultCorrect()
        {
            // Arrange
            List<int> values = new List<int>() { 2, 3 };

            // Act
            Addition a = new Addition();
            int sum = a.Add(values);

            // Assert
            Assert.IsTrue(sum == 5);
        }



    }
}