using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");//

        Animal someAnimal = new Dog();
        Animal anotherAnimal = new Cat();

        List<Animal> animals = new List<Animal>();
        animals.Add(someAnimal);
        animals.Add(anotherAnimal);

        foreach (Animal a in animals)
        {
            Console.WriteLine(a.GetSound);
        }
    }
}