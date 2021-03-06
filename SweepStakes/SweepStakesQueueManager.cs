﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes 
{
    class SweepStakesQueueManager : ISweepStakeManager
    {

        Queue<SweepStakes> queue = new Queue<SweepStakes>();
        SweepStakes sweepStakes;

        
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            int numOfSweepStakes = User_Interface.HowManySweepStakesToAdd();
            while (numOfSweepStakes != 0)
            {
                sweepStakes = new SweepStakes();
                sweepStakes.RegisterContestant();
                queue.Enqueue(sweepStakes);
                numOfSweepStakes--;
            }
        }
        public SweepStakes GetSweepStakes()
        {
            
            return queue.Dequeue();
           
        }
        public void WinSweepStakes()
        {
            while (queue.Count != 0)
            {
                sweepStakes = GetSweepStakes();
                sweepStakes.PickWinner();
            }
        }
    }
}
