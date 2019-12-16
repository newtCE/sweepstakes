using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        void SelectManagerType(string selection)
        {
            if (selection == "queue")
            {
                SweepstakesQueueManager manager = new SweepstakesQueueManager();
            }
            else if(selection=="stack")
            {
                SweepstakesStackManager manager = new SweepstakesStackManager();
            }
        }
    }
}
