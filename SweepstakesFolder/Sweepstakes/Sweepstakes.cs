using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public int currentRegistrationNumber = 1;     //increments with each contestant
        public int winnerNumber;
        public Dictionary<int, Contestant> contestData = new Dictionary<int, Contestant>();
        public Sweepstakes(string contestName)
        {  
            Dictionary<int, Contestant> contestData = new Dictionary<int, Contestant>();
        }
        
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = currentRegistrationNumber;
            currentRegistrationNumber += 1;
            contestant.firstName = UserInterface.InputContestantFirstName();
            contestant.lastName = UserInterface.InputContestantLastName();
            contestant.emailAddress = UserInterface.InputContestantEmail();
            contestData.Add(contestant.registrationNumber, contestant);

        }
        public string PickWinner()
        {
            Random rng = new Random();
            if (currentRegistrationNumber == 1)
            {
                winnerNumber = 1;
            }
            else
            {
                winnerNumber = rng.Next(1, (currentRegistrationNumber-1));
            }
            string winner = "winner";
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant: " + contestant.firstName + " " + contestant.lastName + "\nEmail Address: " + contestant.emailAddress);
            Console.ReadLine();
        }
        public void PrintContestantInfo(int contestant)
        {
            Console.WriteLine("Contestant: " + contestData[contestant].firstName + " " + contestData[contestant].lastName + "\nEmail Address: " + contestData[contestant].emailAddress);
            Console.ReadLine();
        }
    }
}
