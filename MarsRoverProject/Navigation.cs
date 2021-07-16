using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class Navigation
    {
        public Navigation() { }

        public string Navigate(NavigationParam navigationParam)
        {
            Location currentLocation = navigationParam.CurrentLocation;

            foreach (var instruction in navigationParam.Instructions)
            {
                Perform(instruction, currentLocation);
            }

            string result = $"{currentLocation.Position.X} {currentLocation.Position.Y} {currentLocation.Heading}";

            return result;
        }

        private void Perform(char instruction, Location currentLocation)
        {
            switch (instruction)
            {
                case 'L':
                    Rotation.TurnLeft(currentLocation);
                    break;
                case 'R':
                    Rotation.TurnRight(currentLocation);
                    break;
                case 'M':
                    Movement.Move(currentLocation);
                    break;
            }
        }
    }
}
