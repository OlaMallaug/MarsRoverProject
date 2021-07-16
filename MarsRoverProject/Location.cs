using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class Location
    {
        public Coordinates Position { set; get; }
        public string Heading { set; get; }

        public Location()
        {
            Position = new Coordinates();
        }
    }
}
