using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class Fighter
    {
        public int Health { get; set; }
        public int Speed { get; set; }

        private int ConsecutiveHits;

        public Fighter(int speed)
        {
            Speed = speed;
            Health = 100;
            ConsecutiveHits = 0;
        }

        public void ReceiveHit(string hitType)
        {
            switch (hitType)
            {
                case "weak":
                    Health -= 5;
                    break;
                case "medium":
                    Health -= 10;
                    break;
                case "strong":
                    Health -= 20;
                    break;

            }
        }

        public Memento SaveHealth()
        {
            return new Memento(Health);
        }

        public void RestoreHealth(Memento memento)
        {
            Health = memento.Health;
        }

        public bool IsDefeated()
        {
             return Health <= 0;
        }
    }
}
