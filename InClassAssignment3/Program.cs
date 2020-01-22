using System;
using System.Collections.Generic;

namespace InClassAssignment3
{
    class Program
    {


        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { FirstName = "Bill", LastName = "Gates",     DateOfBirth = new DateTime(1955, 10, 28), Previous = null, Next = null};
            Customer customer2 = new Customer() { FirstName = "Satya", LastName = "Nadella ", DateOfBirth = new DateTime(1967, 10, 19), Previous = customer1, Next = null};
            Customer customer3 = new Customer() { FirstName = "Sundar", LastName = "Pichai",  DateOfBirth = new DateTime(1972, 06, 10), Previous = customer2, Next = null};

            customer1.Next = customer2;
            customer2.Next = customer3;

            Customer header = customer1;
            while (header != null)
            {
                Console.WriteLine($"{header.FirstName} {header.LastName} {header.CalculateAge()}");
                header = header.Next;
            }
            Customer last = customer3;
            while (last != null)
            {
                Console.WriteLine($"{last.FirstName} {last.LastName} {last.CalculateAge()}");
                last = last.Previous;
            }
            Console.ReadLine();
        }
    }
}

public class Customer
{
    public Customer Previous;
    public Customer Next;
    public string FirstName;
    public string LastName;
    public DateTime DateOfBirth;


    public int CalculateAge()
    {
        int age = 0;
        DateTime todaysDate = DateTime.Now;
        int currentYear = todaysDate.Year;
        age = currentYear - DateOfBirth.Year;

        return age;
    }
}

