using System;
using System.Collections.Generic;

namespace Task_2
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }

        public Human() { }

        public Human(string name)
        {

            this.Name = name;

        }

    }

    [Serializable]
    public class Professor : Human
    {

        public Professor(string name) : base(name) { }

    }

    [Serializable]
    public class Dept
    {

        public string DeptName { get; set; }

        List<Human> staff;

        public List<Human> Staff { get { return staff; } }

        public Dept() { }

        public Dept(string name, Human[] staffList)
        {

            this.DeptName = name;

            staff = new List<Human>(staffList);

        }

    }


    [Serializable]
    public class University
    {

        public string UniversityName { get; set; }

        public List<Dept> Departments { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
