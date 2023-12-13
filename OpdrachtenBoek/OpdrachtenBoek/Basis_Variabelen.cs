using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    internal class Basis_Variabelen
    {
        //16.Declareer 5 variabelen, 1 int, 1 string, 1 char, 1 float en 1 bool. 
        //17.Initialiseer deze 5 variabelen met een waarde. 
        public int intVariabel = 10;
        public string stringVariabel = "vijf";
        public char charVariabel = 'a';
        public float floatVariabel = 5f;
        public bool boolVariabel = false;
        public void Opdracht18()
        {
            // 18.Geef 2 van deze 5 variabelen een nieuwe waarde. 
            boolVariabel = true;
            intVariabel = 5;
        }

        // 19.Declareer een nieuwe int variabele. 
        public int intVariabel2 = 5;
        public void Opdracht20()
        {
            // 20.Schrijf deze variabele naar de console. 
            Console.WriteLine(intVariabel2);
        }

        // 21.Wat gebeurt er? Waarom gebeurt dit? Zet je antwoord in een regel commentaar.  
        // hij schrijft 5 naar de console, dit kan omdat een string alle karakters kan gebruiken.
    }
}
