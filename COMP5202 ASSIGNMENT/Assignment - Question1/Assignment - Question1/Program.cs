using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Question1
{
    public class Program
    { //Liam Sullivan ID:30022060 COMP.5202 Assignment
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t****ROTORUA THERMAL HOLIDAY PARK****\n\t------------------------------------");
            Console.WriteLine("\tWelcome to Rotorua Thermal Holiday Park login system.");
            Console.Write("\nPlease type in a username: ");
            ValidateUsername(); //Method to check if the username is valid

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("USERNAME ACCEPTED!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nPlease enter a password for your account: ");
            ValidatePassword(); //Method to check if the password is valid
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PASSWORD ACCEPTED!");
            Console.WriteLine("\nUsername and password have been accepted and set.");
            Console.ReadLine();
        }
        static void ValidateUsername() //Method to check if username meets criterias
        {
            string user = Console.ReadLine();
            while (user.Length < 8) //Minimum of 8 characters for username in order to proceed
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR. USERNAME TOO SHORT. PLEASE TRY AGAIN.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nPlease type in a username: ");
                user = Console.ReadLine();
            }
            Console.Write("Username has been registered.\nPlease re-enter your username: ");
            string input = Console.ReadLine();
            while (input != user)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR. USERNAME DOES NOT MATCH.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nPlease re-enter your username: ");
                input = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;

        }
        static void ValidatePassword()
        {
            string pass = Console.ReadLine();
            while (pass.Length < 8) //Minimum of 8 characters for password in order to proceed
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR. PASSWORD TOO SHORT. PLEASE TRY AGAIN.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nPlease enter a password for your account: ");
                pass = Console.ReadLine();
            }

            Console.Write("Password has been registered.\nPlease re-enter your password: ");
            string check = Console.ReadLine();
            while (check != pass)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR. PASSWORD DOES NOT MATCH.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nPlease re-enter your password: ");
                check = Console.ReadLine();
            }

        }

    }
}
