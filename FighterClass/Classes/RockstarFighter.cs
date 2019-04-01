using FighterClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterClass.Classes
{
    public class RockstarFighter : Fighter, IStreet, IBox, IMuayThai
    {
        private double Reputation { get; set; }
        public RockstarFighter(double health, double powerPunch, double speed,double reputation) : base(health,powerPunch,speed)
        {
            Reputation = reputation;
        }
        public void DoBoxing(Fighter opponent)
        {
            Console.WriteLine("Poww");
            TakeDamage(Reputation);
        }

        public void DoMuayThai(Fighter opponent)
        {
            Console.WriteLine("Uauaaa");
            TakeDamage();
        }

        public void DoStreet(Fighter opponent)
        {
            Console.WriteLine("Splash,swashh");
            TakeDamage(Speed);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You are history");
        }
    }
}
