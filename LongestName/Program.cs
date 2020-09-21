using System;

namespace LongestName
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter your first name:");
           string nameOne = Console.ReadLine();

           Console.WriteLine("Enter your second name:");
           string nameTwo = Console.ReadLine();
            int lengthOne = 0;
            int lengthTwo = 0;

            foreach(char letter in nameOne)
            {
                lengthOne = lengthOne + 1;
            }

            foreach (char letter in nameTwo)
            {
                lengthTwo = lengthTwo + 1;
            }

            if(lengthOne > lengthTwo)
            {
                Console.WriteLine(" Name one is the longest");
            }else if  (lengthOne < lengthTwo)
            {
                  Console.WriteLine(" Name two is the longest");
            }else
            {
                    Console.WriteLine("Both names are the same length");
            }




        }
    }
}
