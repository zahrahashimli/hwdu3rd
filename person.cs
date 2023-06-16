using System;

namespace task1
{
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public double Height { get; private set; }

        public Person(string name, string surname, int age, double weight, double height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Weight: {Weight}, Height: {Height}";
        }
    }
}
