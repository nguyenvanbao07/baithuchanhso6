class Dog:Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog is barking");
    }
}
class Cat:Animal
{
    public new void Speak()
    {
        Console.WriteLine("Cat is meowing");
    }
}