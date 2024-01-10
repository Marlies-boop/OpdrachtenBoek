using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OpdrachtenBoek
{
    internal class Beslissingen
    {
        public void Opracht50Tot51()
        {
            //50. Declareer een int variabele en geef deze een waarde.
            int intVariabel = 4;
            //51. Schrijf een if-statement dat controleert of deze int een bepaalde waarde heeft.
            //Als dit waar is,schrijf dan “Waar” naar de console.
            //Als het niet waar is schrijf dan “Niet waar” naar de console.
            if (intVariabel == 5)
            {
                Console.WriteLine("Waar");
            }
            else
            {
                Console.WriteLine("Niet waar");
            }
        }

        public void Opdracht52Tot54()
        {
            //52. Declareer een string variabele en een char variabele.
            //Geef deze beide hetzelfde teken als waarde.
            string stringVariabel = "b";
            char charVariabel = 'a';
            //53. Schrijf een if-statement waarin je de string variabele met de char variabele vergelijkt.
            //Als dit zo is dan moet je programma “Ze zijn gelijk” naar de console schrijven.
            //Is dit niet zo, dan moet je programma “Ze zijn niet gelijk” naar de console schrijven.

            //54. Lukt dit? Zo niet, wat moet je doen om dit wel te laten werken?
            //Schrijf je if-statement zo dat dit goed werkt.

            //Je kan een string niet zomaar naar een char omzetten.
            //Je moet de char naar een string omzetten of andersom.
            string charStringVariabel = Convert.ToString(charVariabel);
            if (stringVariabel == charStringVariabel)
            {
                Console.WriteLine("Ze zijn gelijk.");
            }
            else
            {
                Console.WriteLine("Ze zijn niet gelijk.");
            }
        }

        public void Opdracht55()
        {
            //55. Vraag de gebruiker om een getal (van 1 t/m 12) in te voeren en sla deze op in een integer variabele
            //(gebruik Console.ReadLine en parsing).
            //Schrijf een switch-statement dat de gebruikersinvoer vergelijkt met alle opties van 1 t/m 12
            //en geef de gebruiker in de console terug welke maandnaam hierbij hoort.
            Console.WriteLine("geef een getal van 1 t/m 12.");
            string gebruikerInputString = Console.ReadLine();
            int gebruikerInput = int.Parse(gebruikerInputString);
            switch (gebruikerInput)
            {
                case 1:
                    Console.WriteLine("Januari");
                    break;
                case 2:
                    Console.WriteLine("Februari");
                    break;
                case 3:
                    Console.WriteLine("Maart");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Mei");
                    break;
                case 6:
                    Console.WriteLine("Juni");
                    break;
                case 7:
                    Console.WriteLine("Juli");
                    break;
                case 8:
                    Console.WriteLine("Augustus");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }
        }

        public void Opdracht56()
        {
            //56. * Schrijf een stukje code dat de gebruiker om invoer vraagt.
            //Schrijf een if-statement die controleert of dit stukje tekst overeenkomt
            //met een string variabele die je zelf hebt ingesteld.
            //Zorg ervoor dat je code de gebruiker een antwoord geeft afhankelijk van de invoer.
            string gebruikerInput;
            string mijnTekst = "Hallo";
            Console.WriteLine("Schrijf maar wat.");
            gebruikerInput = Console.ReadLine();
            if (gebruikerInput == mijnTekst)
            {
                Console.WriteLine("We hebben hetzelfde.");
            }
            else
            {
                Console.WriteLine("We hebben niet hetzelfde.");
            }
        }

        enum Moves {heal, attack, flee}
        public void Opdracht57()
        {
            //57. ** Declareer een enum Moves die minstens drie verschillende moves van het karakter van de
            //gebruiker bevat. (bv: heal, attack, flee).
            //Schrijf de keuzes voor de gebruiker naar de console en vraag de gebruiker om een van de opties.
            //Controleer eerst of de invoer overeenkomt met een van de opties,
            //geef anders aan dat dit geen correcte invoer is.
            //Als het correct is, gebruik dan een switch statement om een stukje ‘flavor-tekst’
            //naar de console te schrijven die bij die move past.
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("1: heal");
            Console.WriteLine("2: attack");
            Console.WriteLine("3: flee");

            string gebruikerInput;
            gebruikerInput = Console.ReadLine();
            bool tryParseBool = Int32.TryParse(gebruikerInput, out int intWaarde);
            if (tryParseBool)
            {
                switch (intWaarde)
                {
                    case 1:
                        Console.WriteLine("You healed.");
                        break;
                    case 2:
                        Console.WriteLine("You attacked.");
                        break;
                    case 3:
                        Console.WriteLine("You ran away.");
                        break;
                    default:
                        Console.WriteLine("You can't do that.");
                        break;
                }               
            }
            else
            {
                Console.WriteLine("You can't do that.");
            }
        }  
    }
}

