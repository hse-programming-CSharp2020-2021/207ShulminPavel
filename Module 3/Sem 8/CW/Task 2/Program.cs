using System;
using System.Collections.Generic;

namespace Task_2
{
    class ElectronicQueue<T>
    {
        public Queue<T> queue = new Queue<T>();
        public void Enqueue(T element)
        {
            queue.Enqueue(element);
        }
    }

    struct Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ElectronicQueue<Person> eq = new ElectronicQueue<Person>();
            eq.Enqueue(new Person() { Name = "Pasha", Surname = "Shulmin", Age = 18 });
            eq.Enqueue(new Person() { Name = "Maria", Surname = "Gordenko", Age = 20 });
            foreach (Person p in eq.queue)
            {
                Console.WriteLine(p);
            }
        }
    }
}
