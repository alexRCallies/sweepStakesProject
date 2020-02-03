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
            marketingFirm = new MarketingFirm();
        }
        public void RunSimulation()
        {
            marketingFirm.CreateSweepStakes();
        }
    }
}
