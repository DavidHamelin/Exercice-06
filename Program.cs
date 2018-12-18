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
            Console.WriteLine("Entrez votre Prenom");
            firstName = Console.ReadLine();
            Console.WriteLine("Entrez votre Nom");
            lastName = Console.ReadLine();
            Console.WriteLine("Entrez votre Année de naissance");
            yearBirth = int.Parse(Console.ReadLine());

            
            
            int age = DateTime.Now.Year - yearBirth;

            Console.WriteLine($"Fiche de renseignement : \n Prenom : {firstName} \n Nom {lastName} \n Age {age}: ");

            Console.WriteLine($"Fiche de renseignement : " + Environment.NewLine + $"Prenom : {firstName} \n Nom : {lastName} \n Age {age}: ");
        }
    }
}
