using System;
using System.Diagnostics;

namespace MatrixScreensaverApplication
{
    class Program
    {
        public static int windowHeight = Console.WindowHeight;
        public static int windowWidth = Console.WindowWidth;
        public static Random random = new Random();
        public static string[][] line = new string[windowWidth][];
        static void Main(string[] args)
        {
            Config();
            for (int i = 0; i < windowHeight; i++) // creates maximum lines
            {
                line[i] = new string[windowWidth];
                for (int j = 0; j < windowWidth; j++) // fills all line elements with an empty space
                {
                    line[i][j] = " ";
                }
            }

            while (true) // The actual rain part
            {
                Console.CursorVisible = false;
                int x = random.Next(windowWidth);
                int y = random.Next(windowHeight);
                line[y][x] = "1";
                for (int i = 0; i < windowHeight; i++)
                {
                    foreach (string element in line[i])
                    {
                        if (element == "1") // This doesn't work please fix it trahs thnx luv u bye
                        {
                            int yTemp = y - 1;
                            line[yTemp][x] = "2";
                        }
                        Console.Write(element);
                    }
                }
                Console.SetCursorPosition(0, 0);
            }
        }

        public static void Config()
        {
            while (true)
            {
                Console.WriteLine("MATRIX RAIN CONFIGURATION MENU\nWhat would you like to do?\n\nd: Debug information\nz: Start program");
                string answer = Console.ReadLine();
                if (answer == "z")
                    return;
                if (answer == "d")
                {
                    Console.WriteLine("\nWindow Width: {0}\nWindow Height: {1}\n",windowWidth ,windowHeight);
                }
            }

        }

    }
}