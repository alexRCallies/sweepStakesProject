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
        public MarketingFirm(ISweepStakeManager manager)
        {
            this._manager = manager;
        }
       
    public void CreateSweepStakes()
        {
            
            _manager.InsertSweepStakes(sweepStakes);
            _manager.WinSweepStakes();
           
        }
    }
}
