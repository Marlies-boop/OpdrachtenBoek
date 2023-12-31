﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    internal class Console_Schrijven
    {
        public void Opdracht1()
        {
            //1.Gebruik drie keer Console.WriteLine om “Hello World!” naar het scherm te schrijven. 
            Console.WriteLine("hello World!");
            Console.WriteLine("hello World!");
            Console.WriteLine("hello World!");
        }

        public void Opdracht2()
        {
            // 2.Gebruik drie keer achter elkaar Console.Write om “Hello World!” naar het scherm te schrijven. 
            Console.Write("Hello World!");
            Console.Write("Hello World!");
            Console.Write("Hello World!");
        }

        public void Opdracht3()
        {
            // 3.Wat is het verschil? Zet je antwoord in een regel commentaar. 
            //Bij opdracht 1 wordt op elke nieuwe regel een "Hello World!" neergezet
            //en in opdracht 2 wordt alles achter elkaar gezet.
        }

        public void Opdracht4()
        {
            // 4.Gebruik Console.BackgroundColor om de achtergrondkleur van je console te veranderen. Gebruik hierna een Console.WriteLine om dit te laten zien. 
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Deze tekst heeft een groene achtergrond.");
        }

        public void Opdracht5()
        {
            // 5.Gebruik Console.ForegroundColor om de tekstkleur van je console te veranderen. Gebruik hierna een Console.WriteLine om dit te laten zien. 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Deze tekst is rood.");
        }

        public void Opdracht6()
        {
            // 6.Schrijf een stukje code dat “Hello World” naar het scherm schrijft met voor beide woorden een andere BackgroundColor en ForegroundColor. De tekst moet op één regel staan. 
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Hello");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" World!");
        }

        public void Opdracht7(ConsoleColor forColor, string tekst, ConsoleColor backColor)
        {
            // 7.** Schrijf een functie met als parameters twee kleuren en een string.
            // Deze functie schrijft de string tekst weg naar de console met de opgegeven kleuren
            // en reset daarna de kleuren. 
            Console.ForegroundColor = forColor;
            Console.BackgroundColor = backColor;
            Console.WriteLine(tekst);
            Console.ResetColor();
        }
    }
}
