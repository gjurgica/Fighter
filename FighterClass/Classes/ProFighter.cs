using FighterClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterClass.Classes
{
    public class ProFighter : Fighter, IStreet, IBox
    {
        private double Experience { get; set; }
        public ProFighter(double health, double powerPunch, double speed,double experience) : base(health, powerPunch, speed)
        {
            Experience = experience;
        }
        public void DoBoxing(Fighter opponent)
        {
            Console.WriteLine("Bam,bam,smash");
            TakeDamage(Experience);
        }

        public void DoStreet(Fighter opponent)
        {
            Console.WriteLine("Puf,paf,bong");
            TakeDamage();
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("Victory will be mine");
        }
    }
}
