using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    internal class Arrays
    {
        //58. Maak een array van 5 integers aan en vul deze met willekeurige waarden.
        //Print vervolgens de waarden van de array naar de console.
        public void Opdracht58()
        {
            int[] intArray = { 1,2,3,4,5};
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
        }

        //59. Maak een array van 10 strings aan en vraag de gebruiker om de waarden in te voeren.
        //Print vervolgens de waarden van de array naar de console.
        public void Opdracht59()
        {
            Console.WriteLine("Geef 10 waardes.");
            string[] stringArray = new string[10];
            for(int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
                Console.WriteLine(stringArray[i]);
            }
        }

        //60. Maak een array van 8 decimalen aan en vul deze met willekeurige waarden.
        //Bereken vervolgens het gemiddelde van de waarden in de array
        //en print deze waarde naar de console.
        public void Opdracht60()
        {
            double[] doubleArray = {1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5, 8.5};
            double som = doubleArray.Sum();
            double gemiddelde = som / doubleArray.Length;
            Console.WriteLine(gemiddelde);
        }

        //61. Maak een array van 7 doubles aan en vraag de gebruiker om de waarden in te voeren.
        //Bereken vervolgens de som van de waarden in de array en print deze waarde naar de console.
        public void Opdracht61()
        {
            double[] doubleArray = new double[7];
            Console.WriteLine("Voer 7 waardes met decimale in.");
            double som = 0.0;
            for(int i = 0;i < doubleArray.Length; i++)
            {
                doubleArray[i] = double.Parse(Console.ReadLine());
                som = doubleArray.Sum();
                //Console.WriteLine(doubleArray[i]);
            }
            Console.WriteLine(som.ToString("F1"));
        }

        //62. Maak een array van 6 strings aan en vraag de gebruiker om de waarden in te voeren.
        //Gebruik vervolgens de Array.Sort() methode om de array te sorteren
        //en print de gesorteerde array naar de console.
        public void Opdracht62()
        {
            string[] stringArray = new string[6];
            Console.WriteLine("Voer 6 woorden in.");
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            Array.Sort(stringArray);
            for(int i = 0;i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }

        //63. Maak een array van 9 integers aan en vul deze met willekeurige waarden.
        //Gebruik vervolgens de Array.Reverse() methode om de array om te keren
        //en print de omgekeerde array naar de console.
        public void Opdracht63()
        {
            int[] intArray = {1,2,3,4,5 };
            Array.Reverse(intArray);
            foreach(int i in intArray)
            {
                Console.WriteLine(i);
            }
        }

        //64. Maak een array van 10 doubles aan en vraag de gebruiker om de waarden in te voeren.
        //Gebruik vervolgens de Array.IndexOf() methode om te zoeken naar een specifieke waarde
        //in de array en print de index van de waarde naar de console.
        public void Opdracht64()
        {
            double[] doubleArray = new double[10];
            Console.WriteLine("Geef 10 getallen met decimalen.");
            for(int i = 0;i < doubleArray.Length; i++)
            {
                doubleArray[i] = double.Parse(Console.ReadLine());
            }
            int a = Array.IndexOf(doubleArray, 1.1);
            Console.WriteLine(a);
        }
        //65. Maak een array van 5 characters aan en vul deze met willekeurige waarden.
        //Gebruik vervolgens de Array.Clear() methode om de array leeg te maken
        //en print de lege array naar de console.
        //66. Maak een array van 8 booleans aan en vul deze met willekeurige waarden.
        //Gebruik vervolgens de Array.Find() methode om te zoeken naar een specifieke waarde in de array
        //en print de gevonden waarde naar de console.
        //67. * Maak een 2D array van 3 rijen en 4 kolommen aan en vul deze met willekeurige waarden.
        //Print vervolgens de waarden van de array naar de console.
        //68. ** Maak een 2D array van 5 rijen en 5 kolommen aan en vul deze met willekeurige waarden.
        //Schrijf vervolgens een functie die de som van de waarden in de bovenste rij van de array berekent
        //en de som van de waarden in de onderste rij van de array berekent.
        //Print vervolgens de som van de waarden in de bovenste rij
        //en de som van de waarden in de onderste rij naar de console.
        //Daarnaast moet de functie ook de grootste waarde in de bovenste rij
        //en de grootste waarde in de onderste rij retourneren, print deze waarden ook naar de console.
    }
}
