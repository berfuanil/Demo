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
            List<float> values = null;
            var result = a.Add(values);
            Assert.AreEqual(0, result);
        }
        */

        [TestMethod(), ExpectedException(typeof(ArgumentNullException))]
        public void EmptyListTest()
        {
            Addition a = new Addition();
            List<float> values = null;
            _ = a.Add(values);
        }

        /*
        [TestMethod]
        public void OutofBoundsTest()
        {
            // Arrange
            float lessThanMax = float32.MaxValue - 5;
            List<float> values = new List<float>() { lessThanMax, 3, 3 };

            // Act
            Addition a = new Addition();
            float sum = a.Add(values);

            // Assert
            Assert.IsTrue(sum > float32.MaxValue);
        }
        */
        [TestMethod]
        public void IsResultCorrect()
        {
            // Arrange
            List<float> values = new List<float>() { 2, 3 };

            // Act
            Addition a = new Addition();
            float sum = a.Add(values);

            // Assert
            Assert.IsTrue(sum == 5);
        }



    }
}