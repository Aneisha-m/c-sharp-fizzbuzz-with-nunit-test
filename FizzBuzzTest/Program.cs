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
          int a;
          Console.WriteLine("\n Enter size of Index: \n");
          a = int.Parse(Console.ReadLine());
          int[] array = new int[a];
          for(int i = 1; i <= array.Length; i++)
            {
                Console.WriteLine($"\n {Game.FinalOutput(i)}");
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
