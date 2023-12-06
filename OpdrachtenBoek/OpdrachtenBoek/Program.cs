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
            BasisVariabelen();
        }

        public static void ConsoleSchrijven()
        {
            Console_Schrijven console_schrijven = new Console_Schrijven();
            console_schrijven.Opdracht7();
        }

        public static void ConsoleLezen()
        {
            Console_Lezen console_lezen = new Console_Lezen();
            console_lezen.Opdracht15();
        }

        public static void BasisVariabelen()
        {
            Basis_Variabelen basis_variabelen = new Basis_Variabelen();
            basis_variabelen.Opdracht20();
        }
    }
}


