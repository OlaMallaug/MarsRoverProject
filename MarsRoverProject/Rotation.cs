using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class Rotation
    {
        static readonly LinkedList<string> directions =
                new LinkedList<string>(new[] { "N", "W", "S", "E" });

        public static void TurnRight(Location currentLocation)
        {
            LinkedListNode<string> currentIndex = directions.Find(currentLocation.Heading);
            currentLocation.Heading = currentIndex.PreviousOrLast().Value;
        }

        public static void TurnLeft(Location currentLocation)
        {
            LinkedListNode<string> currentIndex = directions.Find(currentLocation.Heading);
            currentLocation.Heading = currentIndex.NextOrFirst().Value;
        }
    }

    public static class CircularLinkedList
    {
        public static LinkedListNode<T> NextOrFirst<T>(this LinkedListNode<T> current)
        {
            return current.Next ?? current.List.First;
        }

        public static LinkedListNode<T> PreviousOrLast<T>(this LinkedListNode<T> current)
        {
            return current.Previous ?? current.List.Last;
        }
    }
}
