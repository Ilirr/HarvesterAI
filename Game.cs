using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvesterAI
{
    public class Game
    {
        Harvester me;
        public void Main()
        {
            me = new Harvester();
            me.m_currentState = new HarvestState();

            // me.SetState(new HarvestState());
            while (true)
            {
                System.Threading.Thread.Sleep(500);

                if (me.m_currentState != null)
                {
                    me.m_currentState.Execute(me);
                }

            }
        }

    }
}
