using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager:ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes()
        {
            string prize=UserInterface.InputPrize();
            Sweepstakes newSweepstakes = new Sweepstakes(prize);
            sweepstakesStack.Push(newSweepstakes);
            //put sweepstakes on top of stack
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();
        }
    }
}
