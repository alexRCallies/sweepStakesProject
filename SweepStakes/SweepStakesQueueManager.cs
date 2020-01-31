using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes 
{
    class SweepStakesQueueManager : ISweepStakeManager
    {

        Queue<SweepStakes> queue = new Queue<SweepStakes>();
        
        
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            sweepStakes.RegisterContestant();
            queue.Enqueue(sweepStakes);
        }
        public SweepStakes GetSweepStakes()
        {
           return queue.Dequeue();
        }
        public void WinSweepStakes()
        {
            GetSweepStakes().PickWinner();
        }
    }
}
