using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse__
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;
            if (!TryParse(Console.ReadLine(), out resultat))
                Console.WriteLine("Skriv in en siffra");
        }
        public static bool TryParse(string s, out int resultat)
        {
            try
            {
                resultat = int.Parse(s);
                return true;
            }
            catch
            {
                resultat = 0;
                return false;
            }
        }
    }
}
