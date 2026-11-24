using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urtagitas
{
    internal class Captain : Astronaut
    {
        public Captain() { }

        public Captain(string name, int health, int energy, int oxygen) : base(name, health, energy, oxygen)
        {
        }
    }
}
