using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class Nunchucks : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Nunchucks(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 25;
        }
    }
}
