using System;

namespace Mars
{
    public class Rover
    {
       
        public static void Main()
        {
            RoverConfiguration config = new RoverConfiguration(RoverMove.Facing.North, new Coordinates());
            MarsRover rover = new MarsRover(config);
            
            while (true)
            {
                config.CommandToExecute = Console.ReadLine();
                rover.Move();

                Console.WriteLine($"Rover is now at {config.CurrentCoordinates.X}, {config.CurrentCoordinates.Y} - facing {config.CurrentDirection}");
            }
        }
    }
}
