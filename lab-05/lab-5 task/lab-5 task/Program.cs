using System;

namespace lab5
{

public class Person
    {
        private string name;

        public Person()
        {
            name = null;
        }

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { 
                  return name; }
            set {
                  name = value;}
        }
    }

    public class Student : Person
    {
        private string reg_No;
        private int std_age;
        private string std_program; 

        public Student() : base()
        {
            reg_No = null;
            std_age = 0;
            std_program = null; 
        }

        public Student(string name, string regNo, int age, string program) : base(name)
        {
            this.reg_No = regNo;
            this.std_age = age;
            this.std_program = program;
        }

        public string RegNo
        {
            get { return reg_No; }
            set { reg_No = value; }
        }

        public int Age
        {
            get { return std_age; }
            set { std_age = value; }
        }

        public string Program
        {
            get { return std_program; }
            set { std_program = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name:");
            string name = Console.ReadLine();

            Console.Write("Enter your Registration Number:");
            string regNo = Console.ReadLine();

            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your Program:");
            string program = Console.ReadLine();

            Student i_student = new Student(name, regNo, age, program);

            Console.WriteLine("\n");
            Console.WriteLine("***Student Information***\n");
            Console.WriteLine("Name: " + i_student.Name);
            Console.WriteLine("Registration Number: " + i_student.RegNo);
            Console.WriteLine("Age: " + i_student.Age);
            Console.WriteLine("Program: " + i_student.Program);
        }
    }

}

