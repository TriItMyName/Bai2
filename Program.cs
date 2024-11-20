using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai2;

namespace Bai1
{
    internal class Program
    {
        List<Student> students = new List<Student>();

        public void AddStudent(int id, string name, string age)
        {
            Student student = new Student(id, name, age);
            students.Add(student);
        }

        public void DisplayStudent()
        {
            students.ForEach(student => student.Display());
        }

        public void DisplayStudentByAge(int minAge, int maxAge)
        {
            var filteredStudents = students.Where(student => int.TryParse(student.Age, out int age) && age >= minAge && age <= maxAge).ToList();
            filteredStudents.ForEach(student => student.Display());
        }

        public void DisplayStudentByName(string name)
        {
            var filteredStudents = students.Where(student => student.Name.StartsWith(name)).ToList();
            filteredStudents.ForEach(student => student.Display());
        }

        public int CalculateSumAge()
        {
            int sum = 0;
            students.ForEach(student => sum += int.Parse(student.Age));
            return sum;
        }

        public void DisplayOldestStudent()
        {
            var oldestStudent = students
                .Where(student => int.TryParse(student.Age, out _))
                .OrderByDescending(student => int.Parse(student.Age))
                .FirstOrDefault();

            if (oldestStudent != null)
            {
                Console.WriteLine("Oldest student:");
                oldestStudent.Display();
            }
            else
            {
                Console.WriteLine("No valid students found.");
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = students
                .Where(student => int.TryParse(student.Age, out _))
                .OrderBy(student => int.Parse(student.Age))
                .ToList();

            Console.WriteLine("Students sorted by age:");
            sortedStudents.ForEach(student => student.Display());
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddStudent(2, "Jane Smith", "22");
            program.AddStudent(3, "Alice Johnson", "21");
            program.AddStudent(4, "Bob Brown", "23");
            program.AddStudent(5, "Charlie Davis", "24");
            program.AddStudent(6, "Tom Young", "15");
            program.AddStudent(7, "Jerry Mouse", "16");
            //Xuat toan bo danh sach
            Console.WriteLine("All students:");
            program.DisplayStudent();
            //In cac hoc sinh tu 15 toi 18 tuoi
            Console.WriteLine("Student with age between 15 and 18:");
            program.DisplayStudentByAge(15, 18);
            //In ten honc sinh bac dau bang chu cai A
            Console.WriteLine("Student with name start with A:");
            program.DisplayStudentByName("A");
            //Tinh tong tuoi cua tat ca hoc sinh
            Console.WriteLine("Sum of all students' age:");
            int sum = program.CalculateSumAge();
            Console.WriteLine(sum);
            //In hoc sinh lon tuoi nhat
            program.DisplayOldestStudent();
            //Sap xep hoc sinh theo tuoi
            program.SortStudentsByAge();
        }
    }
}
