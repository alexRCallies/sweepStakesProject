using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    interface ISweepStakeManager
    {

        void InsertSweepStakes(SweepStakes sweepStakes);
        SweepStakes GetSweepStakes();
        void WinSweepStakes();
        
    }
}
