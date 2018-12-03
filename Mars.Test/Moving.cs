// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Moving.cs" company="MyComany :-)">
//   Ryanair Test
// </copyright>
// <summary>
//   Defines the Moving test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mars.Test
{
    [TestClass]
    public class Moving
    {
        [DataRow("F", 1, 1, 0, 1)]
        [DataRow("F", 0, 1, 0, 1)]
        [DataRow("F", 0, 0, 0, 0)]
        [DataRow("f", 1, 1, 0, 1)]
        [DataRow("f", 0, 1, 0, 1)]
        [DataRow("f", 0, 0, 0, 0)]
        [DataRow("G", 0, 0, 0, 0)]
        [DataRow("g", 0, 0, 0, 0)]
        [DataTestMethod]
        [TestMethod]
        public void WhenTheControllerUpdatesTheFacing_AndDirectionIsNorth_ThenRoverMoveAndUpdatesTheCoordenates(string command, int initialX, int initialY, int expectedX, int expectedY)
        {
            // Arrange
            Coordinates initialCoordinates = new Coordinates(initialX, initialY);
            RoverConfiguration initialConfiguration = new RoverConfiguration(RoverMove.Facing.North, initialCoordinates);
            MarsRover rover = new MarsRover(initialConfiguration);

            initialConfiguration.CommandToExecute = command;

            // Act
            rover.Move();

            // Assert
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.X == expectedX);
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.Y == expectedY);
        }

        [DataRow("F", 1, 1, 2, 1)]
        [DataRow("F", 0, 1, 1, 1)]
        [DataRow("F", 0, 0, 1, 0)]
        [DataRow("F", 4, 1, 4, 1)]
        [DataTestMethod]
        [TestMethod]
        public void WhenTheControllerUpdatesTheFacing_AndDirectionIsSouth_ThenRoverMoveAndUpdatesTheCoordenates(string command, int initialX, int initialY, int expectedX, int expectedY)
        {
            // Arrange
            Coordinates initialCoordinates = new Coordinates(initialX, initialY);
            RoverConfiguration initialConfiguration = new RoverConfiguration(RoverMove.Facing.South, initialCoordinates);
            MarsRover rover = new MarsRover(initialConfiguration);

            initialConfiguration.CommandToExecute = command;

            // Act
            rover.Move();

            // Assert
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.X == expectedX);
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.Y == expectedY);
        }

        [DataRow("F", 1, 1, 1, 2)]
        [DataRow("F", 0, 1, 0, 2)]
        [DataRow("F", 0, 0, 0, 1)]
        [DataRow("F", 0, 4, 0, 4)]
        [DataTestMethod]
        [TestMethod]
        public void WhenTheControllerUpdatesTheFacing_AndDirectionIsEast_ThenRoverMoveAndUpdatesTheCoordenates(string command, int initialX, int initialY, int expectedX, int expectedY)
        {
            // Arrange
            Coordinates initialCoordinates = new Coordinates(initialX, initialY);
            RoverConfiguration initialConfiguration = new RoverConfiguration(RoverMove.Facing.East, initialCoordinates);
            MarsRover rover = new MarsRover(initialConfiguration);

            initialConfiguration.CommandToExecute = command;

            // Act
            rover.Move();

            // Assert
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.X == expectedX);
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.Y == expectedY);
        }

        [DataRow("F", 1, 1, 1, 0)]
        [DataRow("F", 0, 1, 0, 0)]
        [DataRow("F", 0, 0, 0, 0)]
        [DataTestMethod]
        [TestMethod]
        public void WhenTheControllerUpdatesTheFacing_AndDirectionIsWest_ThenRoverMoveAndUpdatesTheCoordenates(string command, int initialX, int initialY, int expectedX, int expectedY)
        {

            // Arrange
            Coordinates initialCoordinates = new Coordinates(initialX, initialY);
            RoverConfiguration initialConfiguration = new RoverConfiguration(RoverMove.Facing.West, initialCoordinates);
            MarsRover rover = new MarsRover(initialConfiguration);

            initialConfiguration.CommandToExecute = command;

            // Act
            rover.Move();

            // Assert
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.X == expectedX);
            Assert.IsTrue(initialConfiguration.CurrentCoordinates.Y == expectedY);
        }
    }
}
