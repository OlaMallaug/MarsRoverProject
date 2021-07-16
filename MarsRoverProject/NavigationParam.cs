using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class NavigationParam
    {
        public Coordinates GridSize { get; }
        public Location CurrentLocation { get; private set; }
        public List<char> Instructions { get; }

        public NavigationParam(Coordinates gridSize, Location currentLocation, List<char> instructions)
        {
            GridSize = gridSize;
            CurrentLocation = currentLocation;
            Instructions = instructions;
        }

        public void UpdateCurrentHeading(string newHeading)
        {
            CurrentLocation.Heading = newHeading;
        }

        internal void UpdateCurrentCoordinates(Coordinates newPosition)
        {
            CurrentLocation.Position = newPosition;
        }
    }
}
