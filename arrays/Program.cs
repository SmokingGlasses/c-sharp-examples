using System;

namespace arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunArraysExample();
        }

        public static void RunArraysExample()
        {
            char[] name = new char[5];

            name[0] = 'D';
            name[1] = 'a';
            name[2] = 'v';
            name[3] = 'i';
            name[4] = 'd';

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }

            Console.WriteLine("");

            char[] a = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] b = { 'a', 'e', 'i', 'o', 'u' };

            Point[] points = new Point[500];
            int firstPointX = points[0].X;
            Console.WriteLine("");
            Console.WriteLine("firstPointX : " + firstPointX);

            Position[] positions = new Position[500];
            //int firstPositionX = positions[0].X;    //  Runtime error, NullReferenceException

            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = new Position();
            }

            int firstPositionX = positions[0].X;
            Console.WriteLine("firstPositionX : " + firstPositionX);
            Console.WriteLine("");


            //  Rectangular arrays
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                    Console.WriteLine($"matrix[{i}, {j}] : {matrix[i, j]}");
                }
            }

            Console.WriteLine("");

            int[,] board = new int[,]
            {
                { 0, 1, 2 },
                { 3, 4, 5 },
                { 6, 7, 8 }
            };

            //  Jagged arrays
            int[][] jaggedArray = new int[3][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[3];

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * 3 + j;
                    Console.WriteLine($"jaggedArray[{i}][{j}] : {jaggedArray[i][j]}");
                }
            }

            int[][] jaggedBoard = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8, 9}
            };
        }

        public struct Point { public int X, Y; };
        public class Position { public int X, Y; };
    }
}
