using System;
using System.Collections.Generic;

namespace A
{
    /// <summary>
    /// Пассажир
    /// </summary>
    public class Passenger
    {
        string name;
        string lastName;
        int age;
        public bool IsOld 
        {
            get
            {
                if (Age > 65)
                    return true;
                else
                    return false;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get { return age; }
        }
        public override string ToString()
        {
            return $"Passenger: {Name} {LastName}\nAge: {Age}";
        }
    }
    /// <summary>
    /// Пассажир с детьми
    /// </summary>
    public class PassengerWithChildren : Passenger
    {
        int numberOfChildren;
        public bool IsNewBorn { set; get; }
        public int NumberOfChildren
        {
            set
            { 
                if (value > 0)
                {
                    numberOfChildren = value;
                }
            }
            get { return numberOfChildren; }
        }
        public override string ToString()
        {
            return $"Passenger: {Name} {LastName}\nAge: {Age}\nChildren: {NumberOfChildren}";
        }
    }
    /// <summary>
    /// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
    /// Пассажиры приоритетной очереди обслуживаются вне очереди
    /// </summary>
    public class PassengerQueue
    {
        // if passenger is ordinary we use ordinaryQueue
        Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
        // if passenger is old or with newborns we use priorityQueue
        Queue<Passenger> priorityQueue = new Queue<Passenger>();

        public void AddToQueue(Passenger newPassenger)
        {
            if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn) priorityQueue.Enqueue(newPassenger);
            else ordinaryQueue.Enqueue(newPassenger);
        }
        public void StartServingQueue()
        {
            if (priorityQueue.Count <= 3)
            {
                foreach (Passenger p in priorityQueue)
                {
                    Console.WriteLine(priorityQueue.Dequeue());
                    Console.WriteLine("Leave the priority queue");
                }
                foreach (Passenger p in ordinaryQueue)
                {
                    Console.WriteLine(ordinaryQueue.Dequeue());
                    Console.WriteLine("Leave the ordinary queue");
                }
            }
            else
            {
                while (priorityQueue.Count > 0 || ordinaryQueue.Count > 0)
                {
                    if (priorityQueue.Count > 0)
                    {
                        Console.WriteLine(priorityQueue.Dequeue());
                        Console.WriteLine("Leave the priority queue");
                    }
                    if (ordinaryQueue.Count > 0)
                    {
                        Console.WriteLine(ordinaryQueue.Dequeue());
                        Console.WriteLine("Leave the ordinary queue");
                    }
                }
            }
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Random rnd = new Random();
            PassengerQueue pq = new PassengerQueue();
            for (int i = 0; i < 5; i++)
            {
                Passenger passenger = new Passenger();
                passenger.Name = rnd.Next(100, 1000).ToString();
                passenger.LastName = rnd.Next(1000, 10000).ToString();
                passenger.Age = rnd.Next(18, 100);
                pq.AddToQueue(passenger);
            }
            for (int i = 0; i < 5; i++)
            {
                PassengerWithChildren passenger = new PassengerWithChildren();
                passenger.Name = rnd.Next(100, 1000).ToString();
                passenger.LastName = rnd.Next(1000, 10000).ToString();
                passenger.Age = rnd.Next(18, 100);
                passenger.NumberOfChildren = rnd.Next(1, 11);
                if (rnd.Next(0, 2) == 0)
                {
                    passenger.IsNewBorn = false;
                }
                else
                {
                    passenger.IsNewBorn = true;
                }
                pq.AddToQueue(passenger);
            }
            pq.StartServingQueue();
        }
    }
}
