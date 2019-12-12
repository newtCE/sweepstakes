using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        int currentRegistrationNumber = 0;     //increments with each contestant
        Dictionary<int, Contestant> contestData = new Dictionary<int, Contestant>();
        public Sweepstakes(string contestName)
        {  
            Dictionary<int, Contestant> contestData = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = currentRegistrationNumber;
            currentRegistrationNumber += 10;
            contestant.firstName = UserInterface.InputContestantFirstName();
            contestant.lastName = UserInterface.InputContestantLastName();
            contestant.emailAddress = UserInterface.InputContestantEmail();
            contestData.Add(contestant.registrationNumber, contestant);

        }
        public string PickWinner()
        {
            string winner = "winner";
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
