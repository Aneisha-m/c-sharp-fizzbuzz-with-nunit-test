using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    public class Program
    {
        static void Main(string[] args)
        {
          for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine(Game.FinalOutput(i));
            }
            Console.ReadLine();
        }
    }

    public class Game
    {
        public static string FinalOutput(int number)
        {
            string output;
            if((number % 3 == 0) && (number % 5 == 0))
            {
                output = "FizzBuzz";
            }
            else if(number % 3 == 0)
            {
                output = "Fizz";
            }
            else if(number % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = number.ToString();
            }
            return output;
        }
    }
  
}
