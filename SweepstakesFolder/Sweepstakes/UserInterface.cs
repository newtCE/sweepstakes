using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string InputContestantFirstName()
        {
            while (true)
            {
                Console.WriteLine("Please input contestant first name:");
                string userInput = Console.ReadLine();
                if (userInput != "")
                {
                    return userInput;
                }

            }
        }
        public static string InputContestantLastName()
        {
            while (true)
            {
                Console.WriteLine("Please input contestant last name:");
                string userInput = Console.ReadLine();
                if (userInput != "")
                {
                    return userInput;
                }

            }
        }
        public static string InputContestantEmail()
        {
            while (true)
            {
                Console.WriteLine("Please input contestant email address:");
                string userInput = Console.ReadLine();
                if (userInput != "")
                {
                    return userInput;
                }

            }
        }
        public static string InputPrize()
        {
            while (true)
            {
                Console.WriteLine("Please input sweepstakes prize:");
                string userInput = Console.ReadLine();
                if (userInput != "")
                {
                    return userInput;
                }

            }
        }
    }
}
