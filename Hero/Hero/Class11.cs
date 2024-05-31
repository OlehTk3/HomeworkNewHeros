using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class SniperRifle : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SniperRifle(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 0;
        }
    }
}
