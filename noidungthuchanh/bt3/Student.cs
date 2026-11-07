class Student:Person
{
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("I am also a student");
    }
}