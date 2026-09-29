using System;
namespace GameInheritanceDemo
{
    public class ArchMage : Mage
    {
        public int AncientKnowledge;
        public ArchMage()
        {
            Console.WriteLine("===> Konstruktor default archmage <===");
        }
        public ArchMage(int ancientKnowledge, int spellPower, string id, string name, int basePower, string address) 
                : base(spellPower, id, name, basePower, address)
        {
            Console.WriteLine("===> Konstruktor berparameter archmage <===");
            this.AncientKnowledge = ancientKnowledge;
        }
        public new void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("Ancient Knowledge:     =" + AncientKnowledge);
            Console.WriteLine("Grand Total Power:     =" + (getBasePower() + SpellPower + AncientKnowledge));
            Console.WriteLine("===================================");
        }
    }
}