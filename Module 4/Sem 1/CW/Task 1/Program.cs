using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task_1
{
    [Serializable]
    class Student
    {
        public string surname { get; set; }
        public int course { get; set; }

        public Student (string surname, int course)
        {
            this.surname = surname;
            this.course = course;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("Петров", rnd.Next(5));
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("Students.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, students);
            }
            BinaryFormatter formatter1 = new BinaryFormatter();
            using (Stream stream = new FileStream("Students.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Student[] students1 = (Student[])formatter1.Deserialize(stream);
                foreach (Student student in students1)
                {
                    Console.WriteLine(student.surname);
                    Console.WriteLine(student.course);
                }
            }
        }
    }
}
