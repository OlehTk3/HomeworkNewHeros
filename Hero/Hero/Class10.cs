using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class GrenadeLauncher : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public GrenadeLauncher(string name)
        {
            Name = name;
            AttackDamage = 50;
            BlockingPower = 0;
        }
    }
}
