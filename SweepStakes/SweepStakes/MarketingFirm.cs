using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        //MEMBER VARIABLES
        public ISweepstakesManager manager;
        //CONSTRUCTOR

        //MEMBER METHODS
         
        public void ChooseManager()
        {
            manager = UserInterface.PickStackOrQueue;
        }

        public void CreatSweepstake()
        {
            Console.WriteLine("What would you like the sweepstakes to be called?");
            string sweepName = Console.ReadLine();
            Sweepstakes newSweepstake = new Sweepstakes(sweepName);
            manager.InsertSweepstakes(newSweepstake);
        }

        public void RunSweepstake(Sweepstakes newSweepstake)
        {
            
        }
    }
}
