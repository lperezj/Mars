// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coordinates.cs" company="MyComany :-)">
//   Ryanair Test
// </copyright>
// <summary>
//   Defines the Moving test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Mars
{
    /// <summary>
    /// The coordinates.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        public Coordinates()
        {
            this.X = 0;
            this.Y = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        public Coordinates(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                this.X = 0;
                this.Y = 0;
            }
            else
            {
                this.X = x;
                this.Y = y;
            }

        }

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        public int Y { get; set; }
    }
}
