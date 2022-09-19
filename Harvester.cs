using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvesterAI
{
    internal class Harvester
    {
        public const string Name = "Mathias";
        public const int EXH_MAX = 7;
        public const int REST_EFF = 5;

        public int Exhaustion = 0;
        public int HarvestedBananas = 0;

        public State m_currentState;
        public bool IsExhausted()
        {
            if (Exhaustion >= EXH_MAX)
                return true;
            else
                return false;
        }
        public bool Rested()
        {
            if (Exhaustion <= 0)
                return true;
            else
                return false;
        }
        public void SetState(State aNewState)
        {

            m_currentState.Exit(this);
            m_currentState = aNewState;
            m_currentState.Enter(this);
        }
    }
}
