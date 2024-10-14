namespace Abstract
{
    abstract class Animal  //Abstract class
    {
        //Abstract method (does have a body)
        public abstract void animalSound();

        //Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal  //Derived class (inherit from Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This pig says: wee wee");
        }
    }

    class Program
    {
        static void Main()
        {
            Pig myPig = new Pig();  //create a pig object
            myPig.animalSound();    //call the abstract method
            myPig.sleep();          //call the regular method
        }
    }
}
