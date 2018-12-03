// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoverMove.cs" company="MyComany :-)">
//   Ryanair Test
// </copyright>
// <summary>
//   Defines Rover move
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Mars
{
    using System;

    /// <summary>
    /// The rover move.
    /// </summary>
    public class RoverMove
    {
        /// <summary>
        /// The en.
        /// </summary>
        public enum Facing
        {
            /// <summary>
            /// The north.
            /// </summary>
            North,

            /// <summary>
            /// The east.
            /// </summary>
            East,

            /// <summary>
            /// The south.
            /// </summary>
            South,

            /// <summary>
            /// The west.
            /// </summary>
            West
        }

        /// <summary>
        /// The move.
        /// </summary>
        /// <param name="marsRover">
        /// The mars rover.
        /// </param>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        public static void Move(MarsRover marsRover, RoverConfiguration configuration)
        {
            if (string.IsNullOrEmpty(configuration.CommandToExecute))
            {
                Console.WriteLine("You need a Command to move the Rover");
                return;
            }

            if (configuration.CommandToExecute != "L" 
                && configuration.CommandToExecute != "R"
                && configuration.CommandToExecute != "F")
            {
                Console.WriteLine("Invalid Command, only you can 'L|R' and 'F'");
                return;
            }

            switch (configuration.CommandToExecute)
            {
                case "L":
                    configuration.CurrentDirection = configuration.CurrentDirection == RoverMove.Facing.North ? RoverMove.Facing.West : (RoverMove.Facing)((int)configuration.CurrentDirection - 1);
                    break;
                case "R":
                    configuration.CurrentDirection = configuration.CurrentDirection == RoverMove.Facing.West ? RoverMove.Facing.North : (RoverMove.Facing)((int)configuration.CurrentDirection + 1);
                    break;
                case "F":
                    switch (configuration.CurrentDirection)
                    {
                        case RoverMove.Facing.North:
                            configuration.CurrentCoordinates = MoveNorth(configuration.CurrentCoordinates);
                            break;
                        case RoverMove.Facing.East:
                            configuration.CurrentCoordinates = MoveEast(configuration.CurrentCoordinates);
                            break;
                        case RoverMove.Facing.South:
                            configuration.CurrentCoordinates = MoveSouth(configuration.CurrentCoordinates);
                            break;
                        case RoverMove.Facing.West:
                            configuration.CurrentCoordinates = MoveWest(configuration.CurrentCoordinates);
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// The move north.
        /// </summary>
        /// <param name="coordinates">
        /// The coordinates.
        /// </param>
        /// <returns>
        /// The <see cref="Coordinates"/>.
        /// </returns>
        private static Coordinates MoveNorth(Coordinates coordinates)
        {
            if (coordinates.X != 0)
            {
                return new Coordinates()
                           {
                               X = coordinates.X - 1,
                               Y = coordinates.Y
                           };
            }

            return coordinates;
        }

        /// <summary>
        /// The move south.
        /// </summary>
        /// <param name="coordinates">
        /// The coordinates.
        /// </param>
        /// <returns>
        /// The <see cref="Coordinates"/>.
        /// </returns>
        private static Coordinates MoveSouth(Coordinates coordinates)
        {
            if (coordinates.X != 4)
            {
                return new Coordinates() { X = coordinates.X + 1, Y = coordinates.Y };
            }

            return coordinates;
        }

        /// <summary>
        /// The move east.
        /// </summary>
        /// <param name="coordinates">
        /// The coordinates.
        /// </param>
        /// <returns>
        /// The <see cref="Coordinates"/>.
        /// </returns>
        private static Coordinates MoveEast(Coordinates coordinates)
        {
            if (coordinates.Y != 4)
            {
                return new Coordinates() { X = coordinates.X, Y = coordinates.Y + 1 };
            }

            return coordinates;
        }

        /// <summary>
        /// The move west.
        /// </summary>
        /// <param name="coordinates">
        /// The coordinates.
        /// </param>
        /// <returns>
        /// The <see cref="Coordinates"/>.
        /// </returns>
        private static Coordinates MoveWest(Coordinates coordinates)
        {
            if (coordinates.Y != 0)
            {
                return new Coordinates() { X = coordinates.X, Y = coordinates.Y - 1 };
            }

            return coordinates;
        }
    }
}
