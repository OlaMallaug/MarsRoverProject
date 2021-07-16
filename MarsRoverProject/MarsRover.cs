using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    public class MarsRover
    {
        public MarsRover() { }

        public string Execute(string input)
        {
            string output = "";

            input = input.Replace("\r", "");  //remove carriage return from string
            Navigation navigation = new Navigation();
            List<NavigationParam> NavigationParams = ParseInput.ParseNaviagtionParam(input);

            foreach (NavigationParam navigationParam in NavigationParams)
            {
                string result = navigation.Navigate(navigationParam);
                output += result + "\r\n";
            }

            return output;
        }
    }
}
