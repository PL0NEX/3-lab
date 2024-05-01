using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Weapon
    {
        public string Name { get; }

        public Weapon(string name)
        {
            Name = name;
        }
        public override string ToString() { return Name; }
    }
}
