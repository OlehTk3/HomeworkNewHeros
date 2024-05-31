using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public interface IHero
    {
        double Attack();
        double Defend(double damage);
    }
}
