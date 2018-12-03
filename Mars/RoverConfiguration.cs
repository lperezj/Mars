// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoverConfiguration.cs" company="MyComany :-)">
//   Ryanair Test
// </copyright>
// <summary>
//   Defines the Rover Configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Mars
{
    /// <summary>
    /// The rover configuration.
    /// </summary>
    public class RoverConfiguration
    {
        /// <summary>
        /// The command to execute.
        /// </summary>
        private string commandToExecute;

        /// <summary>
        /// Gets or sets the current direction.
        /// </summary>
        public RoverMove.Facing CurrentDirection { get; set; }

        /// <summary>
        /// Gets or sets the current coordinates.
        /// </summary>
        public Coordinates CurrentCoordinates { get; set; }

        /// <summary>
        /// Gets or sets the command to execute.
        /// </summary>
        public string CommandToExecute
        {
            get => this.commandToExecute.ToUpper();

            set => this.commandToExecute = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoverConfiguration"/> class.
        /// </summary>
        /// <param name="direction">
        /// The direction.
        /// </param>
        /// <param name="coordinates">
        /// The coordinates.
        /// </param>
        public RoverConfiguration(RoverMove.Facing direction, Coordinates coordinates)
        {
            this.CurrentCoordinates = coordinates;
            this.CurrentDirection = direction;
        }
    }
}
