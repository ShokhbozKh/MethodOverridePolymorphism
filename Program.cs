namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rasmda berilgan struktura asosida klasslarni yarating.
            //display() methodini overriding usulida amalga oshiring.
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Quack();
            mallardDuck.Swim();
            mallardDuck.display();

            Console.WriteLine("-----------------------------------");
            RedheadDuck redheadDuck = new RedheadDuck();
            redheadDuck.Quack();
            redheadDuck.Swim();
            redheadDuck.display();
        }
    }
    class Duck
    {
        public void Quack()
        {
            Console.WriteLine("quack.....");
        }
        public void Swim()
        {
            Console.WriteLine("swimming....");
        }
        public virtual void display()
        {
            Console.WriteLine("Other duck-like methods..");
        }

    }
    class MallardDuck : Duck
    {
        public override void display()
        {
            //base.display(); asosiy classdagi shu methodni ishlatadi
            Console.WriteLine("Looks like a mallard...");
        }
    }
    class RedheadDuck : Duck
    {
        public override void display()
        {
            //base.display();
            Console.WriteLine("Looks like a redhead");
        }
    }
}