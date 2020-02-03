using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {

        public ISweepStakeManager _manager;
        SweepStakes sweepStakes;
        
        public ISweepStakeManager WhichManager()
        {
            switch (User_Interface.TypeOfManager())
            {
                case "stack":
                    return _manager = new SweepStakesStackManager();
                case "queue":
                    return _manager = new SweepStakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid manager"));
            }
        }
    public void CreateSweepStakes()
        {
            WhichManager();
            _manager.InsertSweepStakes(sweepStakes);
            _manager.WinSweepStakes();
           
        }
    }
}
