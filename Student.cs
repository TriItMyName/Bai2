using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public Student(int id, string name, string age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}
