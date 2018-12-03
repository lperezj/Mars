// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rotate.cs" company="MyComany :-)">
//   Ryanair Test
// </copyright>
// <summary>
//   Defines the Rotate type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Mars.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The rotate test.
    /// </summary>
    [TestClass]
    public class Rotate
    {
        [DataRow("L", RoverMove.Facing.North, RoverMove.Facing.West)]
        [DataRow("R", RoverMove.Facing.North, RoverMove.Facing.East)]
        [DataRow("l", RoverMove.Facing.North, RoverMove.Facing.West)]
        [DataRow("r", RoverMove.Facing.North, RoverMove.Facing.East)]
        [DataRow("L", RoverMove.Facing.South, RoverMove.Facing.East)]
        [DataRow("R", RoverMove.Facing.South, RoverMove.Facing.West)]
        [DataRow("L", RoverMove.Facing.East, RoverMove.Facing.North)]
        [DataRow("R", RoverMove.Facing.East, RoverMove.Facing.South)]
        [DataRow("L", RoverMove.Facing.West, RoverMove.Facing.South)]
        [DataRow("R", RoverMove.Facing.West, RoverMove.Facing.North)]
        [DataRow("G", RoverMove.Facing.West, RoverMove.Facing.West)]
        [DataTestMethod]
        [TestMethod]

        public void WhenTheControllerUpdatesTheFacing_ThenRoverRotates(string command, RoverMove.Facing initialFacing, RoverMove.Facing expectedFacing)
        {
            // Arrange
            Coordinates initialCoordinates = new Coordinates(0, 0);
            RoverConfiguration initialConfiguration = new RoverConfiguration(initialFacing, initialCoordinates);
            MarsRover rover = new MarsRover(initialConfiguration);

            initialConfiguration.CommandToExecute = command;

            // Act
            rover.Move();

            // Assert
            Assert.IsTrue(initialConfiguration.CurrentDirection == expectedFacing);
        }
    }
}
