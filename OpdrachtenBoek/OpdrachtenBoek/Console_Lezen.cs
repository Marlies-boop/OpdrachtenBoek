using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    internal class Console_Lezen
    {
        // 8.Doormiddel van Console.ReadLine kun je gebruikersinvoer lezen. Maak een string variabele ‘userName’ aan.  
        public string userName;

        public void Opdracht8Tot11()
        {
            // 9.Schrijf een stukje code dat de gebruiker om zijn naam vraagt.  
            Console.WriteLine("wat is je naam?");
            // 10.Sla de invoer van de gebruiker op in de variabele ‘userName’. 
            userName = Console.ReadLine();
            // 11.Geef ter controle de inhoud van de variabele ‘userName’ weer in de console. 
            Console.WriteLine(userName);
        }

        // 12.Doormiddel van Int32.Parse() kun je ‘proberen’ bepaalde inhoud om te zetten in een int. Maak een int variabele userAge aan. 
        public int userAge;
        public void Opdracht12Tot14()
        {
            // 13.Schrijf een stukje code dat de gebruiker om zijn leeftijd vraagt. 
            Console.WriteLine("Hoe oud ben je?");
            // 14.Sla de invoer van de gebruiker op in de variabele ‘userAge’ (let op het type) 
            userAge = Convert.ToInt32(Console.ReadLine());
        }

        public int opgeslagenGetal = 5;
        public int gegoktGetal;
        public void Opdracht15()
        {
            // 15.** Schrijf een functie die de gebruiker om een getal vraagt.
            // Vergelijk dit getal met een opgeslagen getal.
            // Als het hier gelijk aan is, geef dan de gebruiker terug dat hij het goed heeft geraden. 
            Console.WriteLine("geef een getal.");
            gegoktGetal = Convert.ToInt32(Console.ReadLine());
            if (gegoktGetal == opgeslagenGetal)
            {
                Console.WriteLine("Je hebt het goed geraden.");
            }
            else
            {
                Console.WriteLine("Je hebt niet  goed geraden.");
            }
        }

    }
}
