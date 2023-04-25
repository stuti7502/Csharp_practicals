class Bird
{
    public virtual void Voice()
    {
        Console.WriteLine("Turr Turr");
    }
}

class Duck : Bird
{
    public override void Voice()
    {
        Console.WriteLine("Quack Quack");
    }
}

class Program
{
    static void Main()
    {
        Bird myBird = new Bird();

        Bird myDuck = new Duck();

        myBird.Voice();

        myDuck.Voice();
    }
}
