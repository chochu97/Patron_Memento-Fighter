using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();
        
        private Fighter fighter;
        
        private int consecutiveHits = 0;

        public CareTaker(Fighter fighter)
        {
            this.fighter = fighter;
        }

        public void HitFighter(string hitType)
        {
            if(consecutiveHits == 0)
            {
                SaveState();
            }

            fighter.ReceiveHit(hitType);
            consecutiveHits++;

            if(consecutiveHits == 5)
            {
                RestoreState();
                consecutiveHits = 0;
            }

            if (fighter.IsDefeated())
            {
                Console.WriteLine("The Fighter has been defeated");
            }
        }

        private void SaveState()
        {
            mementos.Add(fighter.SaveHealth());
        }

        private void RestoreState()
        {
            if(mementos.Count > 0)
            {
                Memento memento = mementos[mementos.Count - 1];
                mementos.RemoveAt(mementos.Count - 1);
                fighter.RestoreHealth(memento);
            }
        }

        public void ResetHits()
        {
            consecutiveHits = 0;
        }

    }
}
