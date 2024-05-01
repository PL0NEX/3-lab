using lab3;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var armor1 = new Armor("Plate Armor");
            var armor2 = new Armor("Chainmail");
            var weapon1 = new Weapon("Sword");
            var weapon2 = new Weapon("Bow");

            var armors = new List<Armor> { armor1, armor2 };
            var weapons = new List<Weapon> { weapon1, weapon2 };

            var hero = new Hero<Armor,Weapon>(armors, weapons);

            hero.DisplayEquipment();           
        }  
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
