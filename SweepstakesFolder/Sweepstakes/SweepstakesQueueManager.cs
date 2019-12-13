using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager:ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();
        public void InsertSweepstakes()
        {
            string prize = UserInterface.InputPrize();
            Sweepstakes newSweepstakes = new Sweepstakes(prize);
            sweepstakesQueue.Enqueue(newSweepstakes);
            //put sweepstakes on top of stack
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
        }
    }
}
