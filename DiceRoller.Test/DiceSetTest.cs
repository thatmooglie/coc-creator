using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Test
{
    [TestClass]
    public class DiceSetTest
    {
        private Mock<IRollable> dieMock;

        [TestInitialize]
        public void Setup() => dieMock = new Mock<IRollable>();

        [TestMethod]
        public void DiceSet_GivenInvalidNumberOfSides_ThrowsArgumentOutOfRangeException()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new DiceSet(0, dieMock.Object));
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(100)]
        public void DiceSet_GivenValidNumberOfDice_RollIsCalledNumberOfDiceTimesAndReturnsExpectedResults(int numberOfDice)
        {
            // Arrange
            dieMock.Setup(d => d.Roll()).Returns(2);
            var sut = new DiceSet(numberOfDice, dieMock.Object);

            // Act
            var result = sut.Roll();

            // Assert
            dieMock.Verify(d => d.Roll(), Times.Exactly(numberOfDice));
            Assert.AreEqual(numberOfDice * 2, result);
        }
    }
}
