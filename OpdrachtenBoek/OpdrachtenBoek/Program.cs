using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Arrays();
        }

        public static void ConsoleSchrijven()
        {
            Console_Schrijven console_schrijven = new();
            console_schrijven.Opdracht6();
        }

        public static void ConsoleLezen()
        {
            Console_Lezen console_lezen = new();
            console_lezen.Opdracht15();
        }

        public static void BasisVariabelen()
        {
            Basis_Variabelen basis_variabelen = new();
            basis_variabelen.Opdracht20();
        }

        public static void Bewerkingen_Met_Variabelen()
        {
            Bewerkingen_Met_Variabelen bewerkingen_met_variabelen = new();
            bewerkingen_met_variabelen.Opdracht35Tot38();
        }

        public static void Casting_En_Conversie()
        {
            Casting_En_Conversie casting_en_conversie = new();
            casting_en_conversie.Opdracht49();
        }

        public static void Beslissingen()
        {
            Beslissingen beslissingen = new();
            beslissingen.Opdracht57();
        }

        public static void Arrays()
        {
            Arrays arrays = new();
            arrays.Opdracht61();
        }
    }
}


