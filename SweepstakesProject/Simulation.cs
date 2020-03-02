using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
   public class Simulation
    {
        //constructor
        public Simulation()
        {
            CreateMarketingFirmWithManager();
        }
        //member methods
        public MarketingFirm CreateMarketingFirmWithManager() ///factory design pattern; using user input to determine what type of manager object to use/create
        {
            string managerType = UserInterface.GetManagerType();
            switch(managerType.ToLower())
            {
                case "queue":
                case "queue manager":
                    SweepstakesQueueManager manager = new SweepstakesQueueManager();
                    return new MarketingFirm(manager);
                case "stack":
                case "stack manager":
                    SweepstakesStackManager _manager = new SweepstakesStackManager();
                    return new MarketingFirm(_manager);
                default:
                    Console.WriteLine("Not valid");
                    return CreateMarketingFirmWithManager();
            }
            
        }

    }
}
