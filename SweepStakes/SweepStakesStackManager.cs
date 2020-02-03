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
        SweepStakes sweepStakes;
        
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            int numOfSweepStakes = User_Interface.HowManySweepStakesToAdd();
            while (numOfSweepStakes != 0)
            {
                sweepStakes = new SweepStakes();
                sweepStakes.RegisterContestant();
                SweepStakesReady(sweepStakes);
                stack.Push(sweepStakes);
                numOfSweepStakes--;
            }
        }
        public SweepStakes GetSweepStakes()
        {
            
            return stack.Pop();
        }
        public void WinSweepStakes()
        {
            while (stack.Count != 0)
            {
               sweepStakes = GetSweepStakes();
                sweepStakes.PickWinner();
            }
        }
        public void SweepStakesReady(SweepStakes sweepStakes)
        {
            Console.WriteLine(sweepStakes.Name + " is ready to go");
        }
    }
}
