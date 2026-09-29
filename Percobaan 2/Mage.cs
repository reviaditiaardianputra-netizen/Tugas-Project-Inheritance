using System;
namespace GameInheritanceDemo
{
    public class Mage : Character
    {
        public int SpellPower;
        public Mage()
        {
            Console.WriteLine("===> Konstruktor default mage <===");
        }
        public Mage(int spellPower, string id, string name, int basePower, string address) 
                : base(id, name, basePower, address)
        {
            Console.WriteLine("===> Konstruktor berparameter mage <===");
            this.SpellPower = spellPower;
        }
        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("Spell Power:     =" + SpellPower);
            Console.WriteLine("Total Power:     =" + (getBasePower() + SpellPower));
            Console.WriteLine("===================================");
        }
    }
}