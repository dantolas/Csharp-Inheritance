namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            Politician p = new Politician();
            Saint s = new Saint();


            Console.WriteLine(h.lie());
            Console.WriteLine(p.lie());
            Console.WriteLine(s.lie());


            Account a1 = new Account(100);
            Card card1 = new Card(13345, 400, a1);
            InterestAccount a2 = new InterestAccount(100, (float)1.3);
            InterestAccountWithTax a3 = new InterestAccountWithTax(100, (float)1.3, 20);

            Console.WriteLine(a1.getMoney() +"\n" + a2.getMoney() + "\n" + a3.getMoney() + "\n");
            card1.payWithCard(40);
            a2.addInterest();
            a3.addInterest();
            Console.WriteLine(a1.getMoney() + "\n" + a2.getMoney() + "\n" + a3.getMoney() + "\n");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}