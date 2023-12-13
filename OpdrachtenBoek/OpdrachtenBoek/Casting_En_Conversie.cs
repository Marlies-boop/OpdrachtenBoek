using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    internal class Casting_En_Conversie
    {
        public void Opdracht40En41()
        {
            //40. Declareer een int, een char en een string en initialiseer deze met een standaard waarde.
            int intWaarde = 1;
            char charWaarde = 'a';
            string stringWaarde = "hallo";
            //41. Gebruik de juiste vorm (casting, conversie of parsing) om deze waarden om te zetten op de 
            // volgende manier:
            // a. Maak een char variabele en zet de waarde van de int hierin.
            char charWaarde2 = (char)intWaarde;
            // b. Maak een int variabele en zet de waarde van de char hierin.
            int intWaarde2 = Convert.ToInt32(charWaarde);
            // c. Maak een int variabele en zet de waarde van de string hierin.
            int intWaarde3 = Convert.ToInt32(stringWaarde);
        }

        public void Opdracht42En43()
        {
            //42. Declareer een char variabele en geef deze een nummer als waarde.
            char charVariabel = '1';
            //43. Gebruik conversie om deze waarde in een int en double te zetten. Schrijf deze waarden naar de console.
            int intWaarde = Convert.ToInt32(charVariabel);
            Console.WriteLine(intWaarde);
            double doubleWaarde = char.GetNumericValue(charVariabel);
            Console.WriteLine(doubleWaarde);
        }

        //44. Declareer een string variabele en geef deze een decimaal getal als waarde.
        //45. Gebruik parsing om deze waarde in een int en double te zetten. Schrijf deze waarden naar de console. Wat valt je op?
        //46. Declareer een string variabele en geef deze een woord als waarde.
        //47. Gebruik TryParse om deze waarde in een int om te zetten. Wat gebeurt er?
        //48. * Binaire getallen bestaan alleen uit 0 en 1. Je kunt deze waarde opslaan in een string. Ga uit van 
        // een byte (8 bits) dit is dus bijvoorbeeld de string “01101010”.
        // Schrijf een functie die van een gegeven string met 8 nullen en enen de decimale waarde berekent
        // en naar de console schrijft. (De meest rechter bit heeft de waarde 1, die daar links van 2, daar links 
        // van 4, ect).
        //49. ** Laat de gebruiker een stuk tekst invoeren, sla dit op in een string variabele. Gebruik TryParse om 
        // dit om te zetten in een int. Als dit lukt dan moet je programma aan de gebruiker teruggeven dat hij 
        // het goed gedaan heeft, anders moet je programma aan de gebruiker teruggeven dat hij het niet 
        // goed gedaan heeft.
    }
}
