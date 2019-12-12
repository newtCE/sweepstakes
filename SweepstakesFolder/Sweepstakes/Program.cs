using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes testCase=new Sweepstakes("Bike");
            Contestant testContestant = new Contestant();
            testCase.RegisterContestant(testContestant);
            testContestant = new Contestant();
            testCase.RegisterContestant(testContestant);
            testContestant = new Contestant();
            testCase.RegisterContestant(testContestant);
            testContestant = new Contestant();
            testCase.RegisterContestant(testContestant);
            for (int i = 1; i < testCase.currentRegistrationNumber+1; i++)
            {
                testCase.PrintContestantInfo(i);
            }
            testCase.PickWinner();
            Console.WriteLine("Winner is " + testCase.contestData[testCase.winnerNumber].firstName);
        }
    }
}
