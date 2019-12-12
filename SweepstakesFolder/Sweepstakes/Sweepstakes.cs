using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        int currentRegistrationNumber = 1;     //increments with each contestant
        int winnerNumber;
        string sweepStakesName;
        Dictionary<int, Contestant> contestData = new Dictionary<int, Contestant>();
        public Sweepstakes(string contestName)
        {
            sweepStakesName = contestName;
            Dictionary<int, Contestant> contestData = new Dictionary<int, Contestant>();
        }
        public string SweepstakesName
        {
            get
            {
                return sweepStakesName;
            }
        }
        public string Winner
        {
            get
            {
                if (winnerNumber != 0)
                {
                    return PickWinner();
                }
                else
                {
                    return "No winner yet chosen.";
                }
            }
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
            string winner = "The Winner of this sweepstakes is "+contestData[winnerNumber].firstName+" "+contestData[winnerNumber].lastName+".";
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant: " + contestant.firstName + " " + contestant.lastName + "\nEmail Address: " + contestant.emailAddress);
            Console.ReadLine();
        }
        public void PrintContestantInfo(int contestantRegistrationNumber)
        {
            Console.WriteLine("Contestant: " + contestData[contestantRegistrationNumber].firstName + " " + contestData[contestantRegistrationNumber].lastName + "\nEmail Address: " + contestData[contestantRegistrationNumber].emailAddress);
            Console.ReadLine();
        }
    }
}
