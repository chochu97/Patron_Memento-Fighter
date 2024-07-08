using Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter1 = new Fighter(7);
            Fighter fighter2 = new Fighter(5);

            CareTaker careTaker1 = new CareTaker(fighter1);
            CareTaker careTaker2 = new CareTaker(fighter2);

            // un jugador es golpeado 5 veces seguidas

            careTaker1.HitFighter("weak");
            careTaker1.HitFighter("weak");
            careTaker1.HitFighter("weak");
            careTaker1.HitFighter("medium");
            careTaker1.HitFighter("weak");
            Console.WriteLine("La Salud del jugador 1 despues de 5 golpes consecutivos: " + fighter1.Health);
            Console.WriteLine("La Salud del jugador 2 despues de 5 golpes consecutivos: " + fighter2.Health);

            careTaker1.ResetHits();

            // un jugador es golpeado de forma interrumpida

            careTaker1.HitFighter("weak");
            careTaker1.HitFighter("weak");

            careTaker2.HitFighter("strong");

            careTaker1.HitFighter("weak");
            careTaker1.HitFighter("strong");

            Console.WriteLine("La Salud del jugador 1 : " + fighter1.Health);
            Console.WriteLine("La Salud del jugador 2 : " + fighter2.Health);

            Console.ReadKey();
        }
    }
}
