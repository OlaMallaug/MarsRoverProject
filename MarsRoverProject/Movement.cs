using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class Movement
    {
        public static void Move(Location currentLocation)
        {
            switch (currentLocation.Heading)
            {
                case "N":
                    MoveNorth(currentLocation);
                    break;
                case "E":
                    MoveEast(currentLocation);
                    break;
                case "S":
                    MoveSouth(currentLocation);
                    break;
                case "W":
                    MoveWest(currentLocation);
                    break;
            }
        }

        private static void MoveNorth(Location currentLocation)
        {
            currentLocation.Position.Y += 1;
        }
        private static void MoveEast(Location currentLocation)
        {
            currentLocation.Position.X += 1;
        }

        private static void MoveSouth(Location currentLocation)
        {
            currentLocation.Position.Y -= 1;
        }

        private static void MoveWest(Location currentLocation)
        {
            currentLocation.Position.X -= 1;
        }
    }
}
