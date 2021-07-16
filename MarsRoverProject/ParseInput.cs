using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class ParseInput
    {
        private static readonly List<string> listHeadings = new List<string> { "N", "W", "E", "S" };

        private const char linesDelimeter = '\n';
        private const char instructionsDelimeter = ' ';

        public static List<NavigationParam> ParseNaviagtionParam(string input)
        {
            string[] inputArray = SplitInput(input.TrimEnd('\n'));

            //Check if input has correct number of rows
            if((inputArray.Length - 1) % 2 > 0)
            {
                throw new ParseException("Input format is invalid");
            }

            Coordinates gridSize = GetGridDimensions(inputArray);

            List<NavigationParam> listNavigationParam = new List<NavigationParam>();

            //Get start location and instructions for each rower and add them to a list
            for (int currentRow = 1; currentRow < inputArray.Length; currentRow++)
            {
                Location location = getStartLocation(inputArray, currentRow, gridSize);
                currentRow++;
                List<char> instructions = getInstructions(inputArray, currentRow);
                listNavigationParam.Add(new NavigationParam(gridSize, location, instructions));
            }

            return listNavigationParam;
        }

        private static string[] SplitInput(string input)
        {
            var splitedString = input.Split(linesDelimeter);

            return splitedString;
        }

        private static Coordinates GetGridDimensions(string[] inputArray)
        {
            string[] strGridSize = inputArray[0].TrimEnd().Split(instructionsDelimeter);

            if (ValidateGridSize(strGridSize))
            {
                throw new ParseException("Wrong grid dimension format");
            }

            return new Coordinates
            {
                X = Int32.Parse(strGridSize[0]),
                Y = Int32.Parse(strGridSize[1])
            };
        }

        private static Location getStartLocation(string[] inputArray, int currentRow, Coordinates gridSize)
        {
            Location startLocation = new Location();

            string[] strStartLocation = inputArray[currentRow].TrimEnd().Split(instructionsDelimeter);

            if (!ValidateStartLocation(strStartLocation))
            {
                throw new ParseException("Invalid start location");
            }

            startLocation.Position.X = Int32.Parse(strStartLocation[0]);
            startLocation.Position.Y = Int32.Parse(strStartLocation[1]);

            startLocation.Heading = strStartLocation[2];

            if (!IsInsideGrid(gridSize, startLocation))
            {
                throw new ParseException("Start posistion outside grid");
            }
            
            return startLocation;
        }

        private static List<char> getInstructions(string[] inputArray, int currentRow)
        {
            List<char> listInstructions = new List<char>();
            listInstructions.AddRange(inputArray[currentRow]);
            
            return listInstructions;
        }

        private static bool ValidateGridSize(string[] strGridSize)
        {
            if (!(strGridSize.Length == 2) || !strGridSize[0].All(char.IsDigit) || !strGridSize[1].All(char.IsDigit))
            {
                return true;
            }
            
            return false;
        }

        private static bool ValidateStartLocation(string[] strStartPosition)
        {
            if (strStartPosition.Length == 3
               && strStartPosition[0].All(char.IsDigit)
               && strStartPosition[1].All(char.IsDigit)
               && listHeadings.Any(strStartPosition[2].Contains))
            {
                return true;
            }
            
            return false;
        }

        private static bool IsInsideGrid(Coordinates gridSize, Location location)
        {
            if (location.Position.X <= gridSize.X &&
              location.Position.Y <= gridSize.Y &&
              location.Position.X >= 0 &&
              location.Position.Y >= 0)
            {
                return true;
            }
            
            return false;
        }
    }

    class ParseException : Exception
    {
        public ParseException() { }

        public ParseException(string strErrorMessage)
            : base(String.Format("Error: {0}", strErrorMessage))
        {

        }

    }
}
