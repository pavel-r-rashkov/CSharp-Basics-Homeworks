using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FallingRocks
{
    struct Position
    {
        public int x;
        public int y;
        public char obstacle;

        public Position(int col, int row, char ch)
        {
            this.x = col;
            this.y = row;
            this.obstacle = ch;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 60;
            string obstaclesChar = "@#$%^&*";
            string dwarf = "<0>";
            int speed = 180;
            int maxSpeed = 80;
            int linesPassed = -(Console.WindowHeight - 1);
            int maxObstaclePerLineCount = 3;
            Random rnd = new Random();
            int dwarfPosition = Console.WindowWidth / 2;
            Queue<Position> obstacles = new Queue<Position>();

            while (true)
            {
                // increasing speed every 40 lines till maximum speed is reached

                if (speed >= maxSpeed)
                {
                    if (linesPassed % 40 == 0)
                    {
                        speed -= 5;
                    }
                }

                // moving obstacles 1 position down ... 

                for (int i = 0; i < obstacles.Count; i++)
                {
                    Position obstacle = obstacles.Dequeue();
                    if (obstacle.y != Console.WindowHeight - 1)
                    {
                        obstacle.y += 1;
                        obstacles.Enqueue(obstacle);
                    }
                }

                // generating random obstacles at line 0 ... 

                int numberOfObstacles = rnd.Next(maxObstaclePerLineCount) + 1;
                for (int obstacleCounter = 1; obstacleCounter <= numberOfObstacles; obstacleCounter++)
                {
                    obstacles.Enqueue(new Position(rnd.Next(Console.WindowWidth), 0, obstaclesChar[rnd.Next(obstaclesChar.Length)]));
                }

                // clearing old console state

                Console.Clear();

                // drawing obstacles

                foreach (Position obst in obstacles)
                {
                    Console.SetCursorPosition(obst.x, obst.y);
                    switch (obst.obstacle)
                    {
                        case '@':
                            Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                        case '$':
                            Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                        case '%':
                            Console.ForegroundColor = ConsoleColor.DarkGray; break;
                        case '^':
                            Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                        case '&':
                            Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                        case '*':
                            Console.ForegroundColor = ConsoleColor.DarkRed; break;
                    }
                    Console.Write(obst.obstacle);
                }

                // drawing the dwarf

                Console.SetCursorPosition(dwarfPosition - 1, Console.WindowHeight - 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(dwarf);

                // checking collision

                bool gameOver = false;
                foreach (Position pos in obstacles)
                {
                    if (pos.x == dwarfPosition - 1 && pos.y == Console.WindowHeight - 1)
                    {
                        gameOver = true;
                    }
                    if (pos.x == dwarfPosition && pos.y == Console.WindowHeight - 1)
                    {
                        gameOver = true;
                    }
                    if (pos.x == dwarfPosition + 1 && pos.y == Console.WindowHeight - 1)
                    {
                        gameOver = true;
                    }
                }

                // Printing result

                if (gameOver == true)
                {
                    PrintGameOver();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(23, 16);
                    Console.WriteLine("Your result is {0}", linesPassed);
                    break;
                }

                // dwarf moving user input

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddMilliseconds(speed);
                while (DateTime.Now <= endTime)
                {
                    if (Console.KeyAvailable == true)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow)
                        {
                            if (dwarfPosition != 1)
                            {
                                dwarfPosition--;
                            }
                        }
                        else if (key.Key == ConsoleKey.RightArrow)
                        {
                            if (dwarfPosition != Console.WindowWidth - 3)
                            {
                                dwarfPosition++;
                            }
                        }
                    }
                }
                linesPassed++;
            }
        }
        static void PrintGameOver()
        {
            char ch = (char)167;
            string interval = "   ";
            string firstLine = " " + ch + ch + "   " + ch + "     " + ch + "   " + ch + "    " + ch + ch + interval + " " + ch + "  " + ch + "   " + ch + "  " + ch + ch + " " + ch + ch + " ";
            string secondLine = ch + "    " + ch + " " + ch + "   " + ch + " " + ch + " " + ch + " " + ch + "  " + ch + " " + ch + interval + ch + " " + ch + " " + ch + "   " + ch + " " + ch + " " + ch + " " + ch + " " + ch;
            string thirdLine = ch + " " + ch + "  " + ch + ch + ch + "   " + ch + " " + ch + " " + ch + " " + ch + "  " + ch + ch + ch + interval + ch + " " + ch + "  " + ch + " " + ch + "  " + ch + ch + ch + " " + ch + ch + " ";
            string fourthLine = ch + " " + ch + " " + ch + "   " + ch + " " + ch + "   " + ch + "   " + ch + " " + ch + "  " + interval + ch + " " + ch + "  " + ch + " " + ch + "  " + ch + "   " + ch + " " + ch;
            string fifthLine = " " + ch + ch + " " + ch + "   " + ch + " " + ch + "       " + ch + "  " + ch + ch + interval + " " + ch + "    " + ch + "    " + ch + ch + " " + ch + " " + ch;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine(firstLine);
            Console.SetCursorPosition(10, 11);
            Console.WriteLine(secondLine);
            Console.SetCursorPosition(10, 12);
            Console.WriteLine(thirdLine);
            Console.SetCursorPosition(10, 13);
            Console.WriteLine(fourthLine);
            Console.SetCursorPosition(10, 14);
            Console.WriteLine(fifthLine);
        }
    }
}
