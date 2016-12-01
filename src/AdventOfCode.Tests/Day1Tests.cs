using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day1Tests
    {
        [TestMethod]
        public void Day1_Part1_Example1()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result = problem.SolvePart1("R2, L3");

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Day1_Part1_Example2()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result = problem.SolvePart1("R2, R2, R2");

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Day1_Part1_Example3()
        {
            // Arrange
            var problem = new day1();

            // Act
            int result = problem.SolvePart1("R5, L5, R5, R3");

            // Assert
            Assert.AreEqual(12, result);
        }
    }
}
