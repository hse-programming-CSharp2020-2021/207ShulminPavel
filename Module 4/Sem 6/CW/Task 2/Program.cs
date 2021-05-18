using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    interface IVocal
    {
        void DoSound();
    }

    public abstract class Animal : IVocal
    {

        static int id = 1;
        public abstract void DoSound();
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTakenCare { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {IsTakenCare}";
        }

        public Animal (string name, bool isTakenCare)
        {
            Name = name;
            IsTakenCare = isTakenCare;
            Id = id;
            id++;
        }
    }

    class Mammal : Animal
    {
        public int Paws { get; set; }

        public Mammal(string name, bool isTakenCare, int paws) : base(name, isTakenCare)
        {
            Paws = paws;
        }

        public override void DoSound()
        {
            Console.WriteLine("я млекопитающие, би-би-би");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Paws.ToString();
        }
    }

    class Bird : Animal
    {
        public int Speed { get; set; }

        public Bird(string name, bool isTakenCare, int speed) : base(name, isTakenCare)
        {
            Speed = speed;
        }

        public override void DoSound()
        {
            Console.WriteLine("я птичка, пип-пип-пип");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Speed.ToString();
        }
    }

    class Zoo : IEnumerable
    {
        public Animal[] Animals { get; set; }

        public Zoo(Animal[] animals)
        {
            Animals = animals;
        }

        public IEnumerator GetEnumerator()
        {
            return Animals.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            Animal[] animals = new Animal[n];
            for (int i = 0; i < n; i++)
            {
                int type = rand.Next(2);
                bool isTakenCare = false;
                switch (rand.Next(2))
                {
                    case 0:
                        isTakenCare = false;
                        break;
                    case 1:
                        isTakenCare = true;
                        break;
                }
                switch (type)
                {
                    case 0:
                        animals[i] = new Mammal(rand.Next().ToString(), isTakenCare, rand.Next(1, 21));
                        break;
                    case 1:
                        animals[i] = new Bird(rand.Next().ToString(), isTakenCare, rand.Next(1, 101));
                        break;
                }
            }
            Zoo zoo = new Zoo(animals);

            Console.WriteLine("Перекличка");
            foreach (Animal a in zoo)
                a.DoSound();

            var birds = zoo.Animals.Where(a => a is Bird && a.IsTakenCare).ToList();

            Console.WriteLine("Птицы с опекуном");
            foreach (Bird a in birds)
                Console.WriteLine(a);

            var mammals = zoo.Animals.Where(a => a is Mammal && !a.IsTakenCare).ToList();

            Console.WriteLine("Млекопитающие без опекуна");
            foreach (Mammal a in mammals)
                Console.WriteLine(a);
        }
    }
}
