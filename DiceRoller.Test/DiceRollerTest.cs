using Moq;


namespace DiceRoller.Test
{
    [TestClass]
    public class DiceRollerTest
    {
        private Mock<IDieFactory>? dieFactoryMock;
        private Mock<IDiceSet> diceSetMock;
        private Mock<IDiceSetFactory>? diceSetFactoryMock;
        private DiceRoller sut;

        [TestInitialize]
        public void Setup()
        {
            dieFactoryMock = new Mock<IDieFactory>();
            diceSetMock = new Mock<IDiceSet>();
            diceSetFactoryMock = new Mock<IDiceSetFactory>();

            diceSetMock.Setup(ds => ds.Roll()).Returns(4);
            diceSetFactoryMock.Setup(dsf => dsf.Create(It.IsAny<int>(), It.IsAny<IRollable>())).Returns(diceSetMock.Object);

            sut = new DiceRoller(dieFactoryMock.Object, diceSetFactoryMock.Object);


        }
        [TestMethod]
        [DataRow(2, 6, 0, 4)]
        [DataRow(1, 20, 10, 14)]
        [DataRow(1, 100, -2, 2)]
        public void DiceRoller_WhenRollIsCalledWithValidInput_ReturnsCorrectResult(int numDice, int numSides, int modifier, int expectedResult)
        {
            // Arrange
            var input = FormatDiceInput(numDice, numSides, modifier);

            // Act
            var result = sut.Roll(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DiceRoller_WhenRollIsCalledWitInvalidInput_ThrowsArgumentException()
        {
            // Arrange
            var input = "invalid";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => sut.Roll(input));
            
        }


        private static string FormatDiceInput(int numberOfDice, int numberOfSides, int modifier)
        {
            return modifier switch
            {
                0 => $"{numberOfDice}d{numberOfSides}",
                > 0 => $"{numberOfDice}d{numberOfSides}+{modifier}",
                _ => $"{numberOfDice}d{numberOfSides}{modifier}"
            };
        }
    }
}
