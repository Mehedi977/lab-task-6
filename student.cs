using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_3
{
    class Student
    {
        private String name;

        private String id;

        private String department;

        private float cgpa;

        public Student(String Name, String ID, String Department, float cgpa)
        {
            name = Name;
            id = ID;
            department = Department;
            this.cgpa = cgpa;
        }

        public void showinfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(department);
            Console.WriteLine(cgpa);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mr.mehedi", "18-36328-1", "Cs", 3.7f);
            s1.showinfo();
           
        }
    }
}
