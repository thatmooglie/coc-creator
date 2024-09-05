using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Test
{
    [TestClass]
    public class DiceSetFactoryTest
    {
        [TestMethod]
        public void DiceSetFactory_CreateIsCalled_ReturnsExpectedDiceSet()
        {
            // Arrange
            var sut = new DiceSetFactory();
            var mockDie = new Mock<IRollable>().Object;

            // Act
            var diceSet = sut.Create(3, mockDie);

            // Assert
            Assert.IsNotNull(diceSet);
            Assert.AreEqual(3, diceSet.NumberOfDice);
            Assert.AreEqual(mockDie, diceSet.Die);
        }
    }
}
