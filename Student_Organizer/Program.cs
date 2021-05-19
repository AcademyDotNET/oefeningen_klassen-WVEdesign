using System;

namespace Student_Organizer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nWelkom op de StudentOrganizer. \n\nEnter choice: Invoer Nieuwe Student[1]\nToon alle Studenten[2]\nExit[3]");
            Console.ForegroundColor = ConsoleColor.Gray;




            int stap = 1;
            bool answerFound = false;

            while (answerFound != true)
            {
                switch (stap)
                {
                    case 1: // Menukeuze1
                        if (year % 4 == 0)
                        {
                            stap = 2;
                        }
                        else
                        {
                            stap = 5;
                        }
                        break;
                    case 2: // Menukeuze2
                        if (year % 100 == 0)
                        {
                            stap = 3;
                        }
                        else
                        {
                            stap = 4;
                        }
                        break;
                    case 3: // go back
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nexiting");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        answerFound = true;
                        break;
                    case 4: // 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nexiting");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        answerFound = true;
                        break;
                    default:
                        stap = 1;
                        break;
                }
            }
        }
    }
}
