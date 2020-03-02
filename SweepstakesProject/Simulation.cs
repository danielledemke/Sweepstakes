using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
   public class Simulation
    {
        public MarketingFirm CreateMarketingFirmWithManager()
        {
            string managerChoice;
            UserInterface.GetUserInputFor(managerChoice);
            MarketingFirm marketingFirm = new MarketingFirm(ISweepstakesManager manager);
        }

    }
}
