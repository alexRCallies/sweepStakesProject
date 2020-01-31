using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {

        ISweepStakeManager manager;
        SweepStakes sweepStakes;
        public MarketingFirm(ISweepStakeManager manager)
        {
            
        }
        public ISweepStakeManager WhichTypeOfManager()
        {
            switch (User_Interface.TypeOfManager())
            {
                case "stack":
                    return manager = new SweepStakesStackManager();
                case "queue":
                    return manager = new SweepStakesQueueManager();
            }
            return WhichTypeOfManager();
            
        }
       
        public void CreateSweepStakes()
        {
            WhichTypeOfManager();
            manager.InsertSweepStakes(sweepStakes);
            manager.WinSweepStakes();
           
        }
    }
}
