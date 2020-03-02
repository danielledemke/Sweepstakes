using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables
        private Queue<Sweepstakes> queue;

        //constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }


        //member methods
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = queue.Dequeue();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
