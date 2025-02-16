using System;

namespace enums
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunEnumsExample();
        }

        public static void RunEnumsExample()
        {
            Console.WriteLine("\nEnums Example");

            BorderSide topSide = BorderSide.Top;
            bool isTop = (topSide == BorderSide.Top);
            Console.WriteLine("topSide == BorderSide.Top : " + isTop);                  // True

            int i = (int)BorderSide.Left;
            BorderSide side = (BorderSide)i;
            bool isLeftOrRight = (int)side <= 2;
            Console.WriteLine("leftOrRight : " + isLeftOrRight);                        // True

            HorizontalAlignment h = (HorizontalAlignment)BorderSide.Right;
            // same as
            HorizontalAlignment g = (HorizontalAlignment)(int)BorderSide.Right;

            WorldSide westEast = WorldSide.West | WorldSide.East;
            if ((westEast & WorldSide.West) != 0)
            {
                Console.WriteLine("Includes West");                                     // Includes West
            }

            string formatted = westEast.ToString();
            Console.WriteLine("formatted : " + formatted);                              // West, East

            WorldSide worldSide = WorldSide.West;
            worldSide |= WorldSide.East;
            Console.WriteLine("worldSide == westEast : " + (worldSide == westEast));    // True

            worldSide ^= WorldSide.East;                                                // Toggles WorldSide.East
            Console.WriteLine("worldSide : " + worldSide);                              // West
        }

        public enum BorderSide : int
        {
            Left,
            Right,
            Top,
            Bottom
        }

        public enum HorizontalAlignment : int
        {
            Left = BorderSide.Left,
            Right = BorderSide.Right,
            Center
        }

        [Flags]
        public enum WorldSide : int
        {
            None = 0,
            West = 1,
            East = 2,
            North = 4,
            South = 8
        }

        // or

        // public enum WorldSide : int
        // {
        //     None = 0,
        //     West = 1,
        //     East = 1<<1,
        //     North = 1<<2,
        //     South = 1<<3
        // }

        // or
        // including combinations

        // public enum WorldSide : int
        // {
        //     None = 0,
        //     West = 1,
        //     East = 1<<1,
        //     North = 1<<2,
        //     South = 1<<3,
        //     WestEast = West | East,
        //     NorthSouth = North | South,
        //     All = WestEast | NorthSouth
        // }
    }
}