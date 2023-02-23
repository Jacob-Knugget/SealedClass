using System;
namespace Employees
{
    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    }
    class Program
    {
        class Employee : IEmployee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Employee()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Employee(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public virtual double Pay()
            {
                double salary;
                Console.WriteLine($"What is Employee {this.Fullname()}'s weekly salary?");
                salary = double.Parse(Console.ReadLine());
                return salary;
            }
        }

        sealed class Executive : Employee
        {
            public string Title { get; set; }
            public double Salary { get; set; }

            public Executive() : base()
            {
                Title = "";
                Salary = 0;
            }
            public Executive(int id, string firstName, string lastName, string title, double salary)
                : base(id, firstName, lastName)
            {
                Title = title;
                Salary = salary;
            }
            public override double Pay()
            {
                return Salary = Salary * 52.1429;
            }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee(4, "Jeff", "Bordim");
            Console.WriteLine($"Employee Name: {employee.Fullname()}\n Weekly Salary: {employee.Pay()}");

            Executive executive = new Executive(7, "Crystal", "Shabath", "Coach", 1500);
            Console.WriteLine($"Executive Name: {executive.Fullname()}\n Title: {executive.Title}\n Yearly Salary {executive.Pay()}");
        }
    }
}