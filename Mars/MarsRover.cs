// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MarsRover.cs" company="MyComany :-)">
//   Ryanair Test
// </copyright>
// <summary>
//   Defines Rover
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Mars
{
    /// <summary>
    /// The mars rover.
    /// </summary>
    public class MarsRover
    {
        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        private RoverConfiguration Configuration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarsRover"/> class.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        public MarsRover(RoverConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Move method to do the Rover moved.
        /// </summary>
        public void Move()
        {
            RoverMove.Move(this,this.Configuration);
        }
    }
}
