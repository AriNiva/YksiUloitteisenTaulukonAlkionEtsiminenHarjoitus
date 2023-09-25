using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksiuloitteisenTaulukonAlkionEtsiminenHarjoitus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[] { 2000, 1, 3, 5, 16, 77, 101, 44, 1324, 3234 };
            string luku; 
            int iLuku, laskuri = 0;
            Console.WriteLine("Anna luku niin etsin onko se taulukossa: ");
            luku = Console.ReadLine();
            bool menestys = int.TryParse(luku, out iLuku);
            bool löytyi;
            if (menestys == false) 
            {
                Console.WriteLine("Luku ei ollut numeerinen.");
            }
            löytyi = false;
            for (int i = 0; i < taulukko.Length; i++) 
            {
                if (iLuku == taulukko[i])
                {
                    Console.WriteLine("Onneksi olkoon luku {0} löytyi!", iLuku.ToString());
                    löytyi = true;
                }
                laskuri = i + 1;
            }
            if (löytyi == false) Console.WriteLine("Kävin läpi {0} lukua mutten löytänyt lukua {1}!", laskuri, iLuku);
            Console.WriteLine("Paina enter...");
            Console.ReadLine();

        }
    }
}
