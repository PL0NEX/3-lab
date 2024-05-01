using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Hero<TArmor, TWeapon>
        where TArmor : Armor
        where TWeapon : Weapon
    {
        public List<TArmor> Armors { get; } 

        public List<TWeapon> Weapons { get; }
        public Hero(List<TArmor> armors, List<TWeapon> weapons)
        {
            Armors = armors;
            Weapons = weapons;
        }

        public void DisplayEquipment()
        {
            Console.WriteLine("Hero's Equipment:");
            Console.WriteLine("Armors: " + string.Join(", ", Armors.Select(a => a.Name)));
            Console.WriteLine("Weapons: " + string.Join(", ", Weapons.Select(a => a.Name)));
        }
    }
}

