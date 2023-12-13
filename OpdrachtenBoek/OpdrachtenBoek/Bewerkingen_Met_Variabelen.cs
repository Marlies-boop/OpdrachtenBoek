using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    internal class Bewerkingen_Met_Variabelen
    {
        //22. Declareer twee char variabelen en initialiseer deze met een cijfer als waarde.
        public char charVariabel1 = '1';
        public char charVariabel2 = '2';

        //23. Declareer een int variabele.
        public int intVariabel = 1;

        public void Opdracht24En25()
        {
            //24. Tel de twee char variabelen bij elkaar op en sla het resultaat op in de int variabele.
            int result = charVariabel1 + charVariabel2;

            //25. Schrijf dit resultaat weg naar de console.
            Console.WriteLine(result);
        }
        //26. Wat is het resultaat? Is dit wat je verwachtte? Waarom wel/niet? Zet je antwoord in een regel commentaar.
        //Het antwoord is 99. dit is niet wat ik verwachtte maar het klopt wel want char gebruikt de ASCII waardoor elke char een andere waarde heeft.

        public void Opdracht27Tot30()
        {
            //27. Declareer twee string variabelen en geef deze een tekst waarde.
            string stringVariabel1 = "hallo";
            string stringVariabel2 = " gebruiker";

            //28. Declareer een derde string variabele.
            string stringVariabel3;

            //29. Tel de twee string variabelen bij elkaar op en sla het resultaat op in de derde.
            stringVariabel3 = stringVariabel1 + stringVariabel2;

            //30. Schrijf dit resultaat weg naar de console.
            Console.WriteLine(stringVariabel3);

        }

        public void Opdracht31Tot33()
        {
            //31. Declareer drie int variabelen en initialiseer er twee.
            int intVariabel1 = 2;
            int intVariabel2 = 5;
            int intVariabel3;

            //32. Sla de deling van de twee waarden op in de derde.
            intVariabel3 = intVariabel2 / intVariabel1;

            //33. Schrijf het resultaat weg naar de console.
            Console.WriteLine(intVariabel3);
        }
        //34. Is dit wat je verwacht? Waarom wel/niet? Zet je antwoord in een regel commentaar.
        //dit is wat ik had verwacht want je kan hele getallen wel delen door elkaar maar als je een oneven getal deelt wordt hij afgerond omdat integers altijd 1 geheel nummer zijn.

        public void Opdracht35Tot38()
        {
            //35. Declareer twee string variabelen en een int.
            //36. Initialiseer een string en de int met een waarde.
            string stringVariabel1 = "Hallo";
            string stringVariabel2;
            int intvariabel = 5;

            //37. Tel de int bij de string op en sla het resultaat op in de niet geinitialiseerde string.
            stringVariabel2 = stringVariabel1 + intvariabel;

            //38. Schrijf het resultaat weg naar de console.
            Console.WriteLine(stringVariabel2);

        }
        //39. Is dit wat je verwacht? Waarom wel/niet? Zet je antwoord in een regel commentaar.
        //ja want een string gebruikt chars en dat houdt in dat getallen ook gebruikt kunnen worden.
    }
}
