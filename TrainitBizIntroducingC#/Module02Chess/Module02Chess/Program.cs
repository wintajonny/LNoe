using System;

namespace Module02Chess
{
    class Program
    {
        static void Main(string[] args)
        {


            string previousChar = "O";
            string firstLineChar = "X";
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (x == 0 && firstLineChar == "O")
                    {
                        previousChar = "X";
                    }
                    else if (x == 0 && firstLineChar == "X")
                    {
                        previousChar = "O";
                    }

                    
                    if (previousChar == "O")
                    {
                        Console.Write("X");
                        previousChar = "X";
                    }
                    else
                    {
                        Console.Write("O");
                        previousChar = "O";
                    }


                    if (x == 7)
                    {
                        firstLineChar = previousChar;
                    }


                }

                Console.WriteLine();


            }




        }
    }
}
