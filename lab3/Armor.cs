using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Armor
    {
        public string Name { get;}

        public Armor(string name)
        { 
            Name = name;
        }
        public override string ToString() { return Name; }
    }
}
