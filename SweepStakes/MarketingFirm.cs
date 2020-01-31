using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm : ISweepStakeManager
    {
        List<ISweepStakeManager> manager = new List<ISweepStakeManager>();

        public MarketingFirm(ISweepStakeManager manager)
        {

        }
        public void CreateSweepStakes()
        {

        }
    }
}
