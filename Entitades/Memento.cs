using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class Memento
    {
        public int Health { get; }

        public Memento(int health)
        {
            Health = health;
        }
    }
}
