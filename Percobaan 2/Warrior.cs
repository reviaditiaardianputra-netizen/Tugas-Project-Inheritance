namespace GameInheritanceDemo
{
    public class Warrior : Character
    {
        public int BONUS;
        public Warrior()
        {
            Console.WriteLine("===> Konstruktor default warrior <===");
        }
        public Warrior(string id, string name, int basePower, string address, int bonusPower) 
                : base(id, name, basePower, address)
        {
            Console.WriteLine("===> Konstruktor berparameter warrior <===");
            this.BONUS = bonusPower;
        }
        public void DisplayData()
        {
            DisplayBaseData();
            Console.WriteLine("Bonus Power:     =" + BONUS);
            Console.WriteLine("Total Power:     =" + (getBasePower() + BONUS));
            Console.WriteLine("===================================");
        }
    }
}
//Revi Aditia AP//