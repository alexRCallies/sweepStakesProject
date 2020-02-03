using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        MarketingFirm marketingFirm;
        public Simulation()
        {
            
        }
        public void RunSimulation()
        {
           ISweepStakeManager manager =  WhichManager();
            marketingFirm = new MarketingFirm(manager);
            marketingFirm.CreateSweepStakes();
            Console.ReadLine();
        }
        public ISweepStakeManager WhichManager()
        {
            switch (User_Interface.TypeOfManager())
            {
                case "stack":
                    return new SweepStakesStackManager();
                case "queue":
                    return new SweepStakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid manager"));

            }
        }
    }
}
