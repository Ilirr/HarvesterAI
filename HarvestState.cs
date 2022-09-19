using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvesterAI
{
    class HarvestState : State
    {
        public override void Enter(Harvester worker)
        {
            Console.WriteLine("Harvest.Enter" + ": Going to harvest!");
        }

        public override void Execute(Harvester worker)
        {
            Console.WriteLine("Harvest.Execute" + ": Harvesting");
            worker.HarvestedBananas += 3;
            worker.Exhaustion += 1;

            if (worker.IsExhausted() == true)
            {
                worker.SetState(new RestState());
            }
        }

        public override void Exit(Harvester worker)
        {
            Console.WriteLine("Harvest.Exit" + ": Leaving from harvest.");
        }

    }
}
