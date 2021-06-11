using System;
using System.Globalization;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/


namespace TestProjejcCsharp
{
    class Program
    {
        static bool symbol_chek(string sana, char symbol, int len)
        {
            int merkki = 0;
            len -= 4;
            for(int i = 1; i<len; i++)
            {
                if (sana[i] == symbol)
                {
                    merkki++;
                }
                else
                    continue;
            }
            if (merkki == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            DateTime tanaan = DateTime.Now;
            string tervehdys;
            string nimi;
            int ika = 0;
            string postinum;
            string osoite;
            string toimipaikka;
            string ikaluokitus;
            string sukupuoli;
            string puh;
            string email;


            Console.WriteLine(tanaan.ToString("d", culture));



            while (true)
            {
                Console.Write("Kerro sukupuoli :");
                sukupuoli = Console.ReadLine();

                sukupuoli = sukupuoli.ToLower();

                if (sukupuoli == "mies" ||sukupuoli == "m")
                {
                    Console.WriteLine("Mitä jäbä duunaa?");
                    break;
                }
                else if (sukupuoli == "nainen" || sukupuoli == "n")
                {
                    Console.WriteLine("Mitä mimmi puuhaa?");
                    break;
                }
            }

            Console.Write("Anna nimesi :");
            nimi = Console.ReadLine();

            Console.Write("Anna ikäsi :");
            ika = int.Parse(Console.ReadLine());

            Console.Write("Anna osoite :");
            osoite = Console.ReadLine();

            Console.Write("Postinumero :");
            postinum = Console.ReadLine();

            Console.Write("Postitoimipaikka :");
            toimipaikka = Console.ReadLine();

            Console.Write("Anna puhelinnimero :");
            puh = Console.ReadLine();

            while (true)
            {
                Console.Write("Anna sähköposti osoite :");
                email = Console.ReadLine();
                int strLen = email.Length;
                if(symbol_chek(email, '@', strLen))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tarkista Sähköposti osoite! ");
                }
            }

            if (ika < 7)
            {
                ikaluokitus = " olet alle kouluikäinen";
            }
            else if (ika < 18)
            {
                ikaluokitus = " olet alaikäinen";
            }
            else
            {
                ikaluokitus = " olet täysikäinen";
            }


            tervehdys = "Päivä " + nimi + " ! olet " + ika.ToString() + " vuotias";

            Console.WriteLine(tervehdys + ikaluokitus);
            Console.WriteLine("Osoittetieddot ovat...........");
            Console.WriteLine(osoite);
            Console.WriteLine(postinum);
            Console.WriteLine(toimipaikka);
        }
    }
}
