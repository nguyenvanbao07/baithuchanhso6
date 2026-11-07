class Program
{
    static void Main()
    {
    Console.WriteLine("-OVERRIDE");
    Animal a1= new Dog();
    Dog d1= new Dog();
    a1.Speak();
    d1.Speak();

    Console.WriteLine("-NEW-");
    Animal a2 = new Cat();
    Cat c1 = new Cat();
    a2.Speak();
    c1.Speak();
    }
}