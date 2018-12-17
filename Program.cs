using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int yearBirth;
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            yearBirth = int.Parse(Console.ReadLine());

            DateTime now = DateTime.Today;
            int age = now.Year - yearBirth;
            int.Parse(age);
            string[] identity = new string[] { firstName, lastName, age };

            Console.WriteLine(identity);
        }
    }
}
