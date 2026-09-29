using System;
namespace GameInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Demo Inheritance===");
            Console.WriteLine("1. membuat objek warrior (dengan konstruktor berparameter)");
            Warrior Warrior = new Warrior("W001", "Revi Aditia AP", 100, "SendenSari", 50);
            Warrior.DisplayData();

            Console.WriteLine("2. membuat objek mage (dengan konstruktor berparameter)");
            Mage mage = new Mage(999, "M001", "Damara", 100, "Semagung");
            mage.DisplayData();

            Console.WriteLine("3. membuat objek archmage (dengan konstruktor berparameter)");
            ArchMage archmage = new ArchMage(1000, 999, "AM001", "Super Pul", 100, "Dunia Lain");
            archmage.DisplayData();

            Console.ReadKey();
        }
    }
}