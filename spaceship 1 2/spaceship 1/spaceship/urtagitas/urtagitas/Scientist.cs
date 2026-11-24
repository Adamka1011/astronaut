using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urtagitas
{
    internal class Scientist : Astronaut
    {
        public Scientist(string name, int health, int energy, int oxygen) : base(name, health, energy, oxygen)
        {
        }
    }
}
