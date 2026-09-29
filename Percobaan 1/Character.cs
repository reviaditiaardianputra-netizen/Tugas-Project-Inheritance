using System;

namespace GameInheritanceDemo
{
    public class Character
    {
        private string CharacterId = "";
        private string Name = "";
        private int BasePower;
        private string Address = "";
        public Character()
        {
            Console.WriteLine("===> Konstruktor default character <===");
        }
        public Character(string id, string name, int basePower, string address)
        {
            Console.WriteLine("===> Konstruktor berparameter character <===");
            CharacterId = id;
            Name = name;
            BasePower = basePower;
            Address = address;
        }
        public void DisplayBaseData()
        {
            Console.WriteLine("Character ID:    =" + CharacterId);
            Console.WriteLine("Character Name:  =" + Name);
            Console.WriteLine("Base Power:      =" + BasePower);
            Console.WriteLine("Address:         =" + Address);
        }
        public int getBasePower()
        {
            return BasePower;
        }
    }
}
//Revi Aditia AP//