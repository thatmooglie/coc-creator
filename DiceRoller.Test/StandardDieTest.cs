using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Test
{
    [TestClass]
    public class StandardDieTests
    {

        [TestMethod]
        public void D6_Roll_ReturnsValueBetween1And6()
        {
            // Arrange
            var sut = new D6();

            // Act
            var result = sut.Roll();

            // Assert
            Assert.IsTrue(result >= 1 && result <= 6);
        }

        [TestMethod]
        public void D20_Roll_ReturnsValueBetween1And20()
        {
            // Arrange
            var sut = new D20();

            // Act
            var result = sut.Roll();

            // Assert
            Assert.IsTrue(result >= 1 && result <= 20);
        }
    }
}
