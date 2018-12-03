// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Moving.cs" company="MyComany :-)">
//   Ryanair Test
// </copyright>
// <summary>
//   Defines the Moving test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Mars.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CoordinatesTest
    {
        [DataRow(0, 0, 0, 0)]
        [DataRow(-1, 0, 0, 0)]
        [DataRow(0, -1, 0, 0)]
        [DataRow(-1, -1, 0, 0)]
        [DataTestMethod]
        [TestMethod]
        public void WhenTheControllerUpdatesTheFacing_AndDirectionIsNorth_ThenRoverMoveAndUpdatesTheCoordenates(int initialX, int initialY, int expectedX, int expectedY)
        {
            // Arrange
            int initX = initialX;
            int initY = initialY;

            // Act
            Coordinates initialCoordinates = new Coordinates(initX, initY);

            // Assert
            Assert.IsTrue(initialCoordinates.X == expectedX);
            Assert.IsTrue(initialCoordinates.Y == expectedY);
        }
    }
}
