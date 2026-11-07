class Program
{
    static void Main()
    {
        Animal[] animals = {new Dog(), new Cat(), new Animal()};
        foreach(Animal a in animals)
        {
            a.Speak();
        }
    }
}