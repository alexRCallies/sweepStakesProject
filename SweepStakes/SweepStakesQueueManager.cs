using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes 
{
    class SweepStakesQueueManager : ISweepStakeManager
    {
        Queue<SweepStakes> sweepStakes = new Queue<SweepStakes>();

        public void InsertSweepStakes(SweepStakes sweepStakes)
        {

        }
        public SweepStakes GetSweepStakes()
        {
            return
        }
    }
}
