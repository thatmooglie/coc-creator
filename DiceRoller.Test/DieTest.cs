namespace DiceRoller.Test
{
    [TestClass]
    public class DieTest
    {
        [TestMethod]
        [DataRow(-10)]
        [DataRow(0)]
        public void Die_WhenInitializedWithInvalidSides_ThrowsArgumentOutOfRangeException(int numberOfSides)
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { new Die(numberOfSides); });
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(100)]
        public void Die_WhenRollIsCalled_ReturnsResultBetweenOneAndNumberOfSides(int numberOfSides)
        {
            // Arrange
            var sut = new Die(numberOfSides);

            // Act
            var result = sut.Roll();

            // Arrange
            Assert.IsTrue(numberOfSides > result & result >= 1);
        }

        [TestMethod]
        public void Die_WhenRollIsCalledWithOneSide_ReturnsOne()
        {
            // Arrange
            var sut = new Die(1);

            // Act
            var result = sut.Roll();

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}