using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesStackManager : ISweepStakeManager
    {
        Stack<SweepStakes> stack = new Stack<SweepStakes>();

        
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            sweepStakes.RegisterContestant();
            stack.Push(sweepStakes);
        }
        public SweepStakes GetSweepStakes()
        {
            return stack.Pop();
        }
        public void WinSweepStakes()
        {
            GetSweepStakes().PickWinner();
        }
    }
}
