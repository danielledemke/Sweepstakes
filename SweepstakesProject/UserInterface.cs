using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine("Please enter {0}" ,prompt);
            string input = Console.ReadLine();
            return input;
        }
        public static string GetManagerType()
        {
            Console.WriteLine("Which data structure would you like to use for storing the Sweepstakes: Queue or Stack? \n");
            string userEntry = Console.ReadLine();
            return userEntry;
        }
    }
}
