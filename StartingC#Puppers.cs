using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppers
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lindsey";
            string dogType;
            const int limit = 10;
            

            
            Console.WriteLine("Hi! My name is {0}, and this is my 1st day learning C#!", name);
            Console.WriteLine("What is your favorite type of dog?");
            
            dogType = Console.ReadLine();
            Console.WriteLine("I love {0} too!", dogType);

            Console.WriteLine("How many {0} do you want?", dogType);
            int litter1 = Convert.ToInt32(Console.ReadLine());/* ReadLine only reads in strings to the program,
            so we have to change it to int, so the program can read in a number.*/
            while (litter1 > limit)
            {
                Console.WriteLine("That's over the {0} pet limit, how many {1} do you want?", limit, dogType);
                litter1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("OMG {0} is a lot of {1}!", litter1, dogType);

            Console.WriteLine("What other type of dog do you like?");
            string dogType2 = Console.ReadLine();
            Console.WriteLine("How many {0} do you want?", dogType2);
            int litter2 = Convert.ToInt32(Console.ReadLine());

            while (litter2 > limit)
            {
                Console.WriteLine("That's over the {0} pet limit, how many {1} do you want?", limit, dogType2);
                litter2 = Convert.ToInt32(Console.ReadLine());
            }
            int sum = (litter1 + litter2);
            if( sum > limit)
            {
                Console.WriteLine(" But that will put you over the {0} pet limit per household limit!", limit);
            }
            else {
                Console.WriteLine(" Dude thats like {0} puppers, lets go get them!", sum);
            }
            



        }
    }
}
