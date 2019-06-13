using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Question2
{
    class Employee
    {
        private string name;
        private double salary;   //Employee Properties
        private double tax;

        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } } //Employee Getters and Setters
        public double Tax { get { return tax; } set { tax = value; } }

        public Employee()
        {
            Console.WriteLine("Employee Record Created");
        }
        public Employee(string _name, double _salary, double _tax) //Employee Constructor
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\t***Employee Record Created Using Inputted Data***"); //Employee Method
            Name = _name;
            Salary = _salary;
            Tax = _tax;
        }
        public string Record()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return " \nEmployee Name: " + Name + "\nEmployee's Gross Salary: $" + salary + "\nEmployee's Tax Rate: " + (Tax) + "%";
        }
    }


    public class Program
    {
        public static void Main(string[] args) //Object created using Employee Constructor
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t****PAYROLL SYSTEM****\n\t----------------------");
            Console.Write("Welcome to the Payroll System. \nPlease enter the Employee's first and last name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the employee's annual gross salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Please enter the employee's tax rate: ");
            double tax = double.Parse(Console.ReadLine());

            Employee employee1 = new Employee(name, salary, tax);
            Console.WriteLine(employee1.Record());

            Console.WriteLine($"\nNet Salary of {name} is: ${salary - salary * (tax / 100)}");
            Console.ReadLine();

        }

    }
}
