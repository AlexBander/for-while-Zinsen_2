/*######################################################################
#             Programm erstellt von AlexBander GitHub                  #
#                  https://github.com/AlexBander                       #
#                                                                      #
#                      for- und while-Schleifen                        #
#                                am                                    #
#                  Beispiel einer Zins Berechnung                      #
#                                                                      #
#                           C# - Projekt                               #
#                                                                      #
#                                                                      #
#                                                                      #
#                     Alle Rechte vorbehalten!                         #
#                GNU General Public License GNU GPLv3                  #
#           Copyright & Copyleft 2015 by XITS - AlexBander             #
######################################################################*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zinsen
{

    class Program
    {
        internal class Ask
        {
            internal static int i(string Frage)
            {
                Console.WriteLine(Frage);
                string tmp = Console.ReadLine();
                Int16 input;
                if (Int16.TryParse(tmp, out input))
                {
                        int result = Convert.ToInt16(input);
                        return result;
                    }
                else
                    {
                        Console.WriteLine("Fehlerhafte Eingabe (integer), ENTER zum wiederholen");
                        Console.ReadKey();
                        Ask.i(Frage);
                      return 0;
                    }
            }

            internal static double d(string Bitt_Frage_Eintragen)
            {

                Console.WriteLine(Bitt_Frage_Eintragen);
                string tmp = Console.ReadLine();
                double input;
                if (double.TryParse(tmp, out input))
                {
                    double result = Convert.ToDouble(input);
                    return result;
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe (double), ENTER zum wiederholen");
                    Console.ReadKey();
                    Ask.i(Bitt_Frage_Eintragen);
                    return 0;
                }
            }
            internal static string s(string Frage)
            {
                Console.WriteLine(Frage);
                string result = Convert.ToString(Console.ReadLine());
                return result;
            }

        }

    static void Main()
        {
            bool run;
            do
            {
                run = true;
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("### Zins Programm (Einfach) ### \n Wähle Programm: \n 1. - Watzlaw \n 2. - Alex2: for Header Bedingungen \n 3. - Alex3: for Zähler(i) only \n 4. Alex4: while Kopf-geführt \n 5. Alex5: while Fuß-geführt \n 6. ### Ende ###");

                int c = Convert.ToInt16(Console.ReadLine());
                if (c == 1) { Watzlaw(); }
                else if (c == 2) { Alex2(); }
                else if (c == 3) { Alex3(); }
                else if (c == 4) { Alex4(); }
                else if (c == 5) { Alex5(); }
                else { run = false; return; }
            }
            while (run == true);
        }

    static void Watzlaw()
        {

            double var1;                        // Betrag
            double var2;                        // Zinssatz
            double var3;                        // Zinsen
            double var4;                        // Betrag am Ende des Jahres, Betrag + Zinsen
            int var5;                           // Anfangsjahr der Berechnung
            int var6;                           // Endjahr der Berechnung

            int i;                              // Laufvariable, für die Schleife

            Console.WriteLine("Bitte den Betrag eingeben.......: ");
            var1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte den Zinssatz eingeben.....: ");
            var2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte das Anfangsjahr eingeben..: ");
            var5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte das Endjahr eingeben......: ");
            var6 = Convert.ToInt32(Console.ReadLine());

            for (i = var5; i <= var6; i++)
            {

                var3 = (var1 * var2) / 100;     // Zinsen
                var4 = var1 + var3;             // Endbetrag, Ende des Jahres

                Console.Write("Betrag : {0:c}", var1);
                Console.Write("  Zinsen : {0:c}", var3);
                Console.Write("  Endbetrag : {0:c}", var4);
                Console.Write("  Jahr : {0:0000}", i);
            /*
                Console.Write("Betrag : {0:000000000.00}", var1);
                Console.Write("  Zinsen : {0:000000000.00}", var3);
                Console.Write("  Endbetrag : {0:000000000.00}", var4);
                Console.Write("  Jahr : {0:0000}", i);
             */

                Console.WriteLine();            // Zeilenumbruch

                var1 = var4;                    // Betrag, Anfang des Jahres = Endbetrag des vorhergehenden Jahres 

            }

            Console.ReadKey();
            Console.Clear();    
        }
        // For-Schleife Alle Bedingungen im Header 
        static void Alex2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int startjahr = Ask.i("Wann ist das Anfangsjahr? ");
            int endjahr = Ask.i("Welches ist das Endjahr? ");
            double startkapital = Ask.d("Wie hoch ist das Startkapital? ");
            double prozentsatz = Ask.d("Wie hoch ist der Zinssatz");
            int j = endjahr - startjahr;
            double k;
            int i;

            for (k=startkapital, i = startjahr; i <= endjahr; i++)
                {
                    k = k + (k * (prozentsatz / 100));
                    startjahr++;
                Console.WriteLine("im Jahr: " + startjahr + " ein Wert von {0:c} \n"+" Endjahr: "+endjahr, k);
            }
            Console.ReadKey();
            Console.Clear();
            
        }
        // For-Schleife Count i only 
        static void Alex3()
        {

            Console.WriteLine("Startjahr: ");
            int startjahr = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Startkapital: ");
            double startkapital = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine("Prozentsatz: ");
            double prozentsatz = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine("Startjahr: ");
            int endjahr = Convert.ToInt16(Console.ReadLine());
            int j = endjahr - startjahr;
            double k;
            int i;

            for (i = 0; i <= j; i++)
            {
                int jahr = startjahr + i;
                k = startkapital + (startkapital * (prozentsatz / 100));
                startkapital = k;
                Console.WriteLine("im Jahr: " + jahr + " ein Wert von {0:c} \n", k);
            }
            Console.ReadKey();
            Console.Clear();
        }
        // while-Schleife Kopfgeführt bzw. einfache while Schleife
        static void Alex4()
        {

            Console.WriteLine("Startjahr: ");
            int startjahr = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Startkapital: ");
            double startkapital = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine("Prozentsatz: ");
            double prozentsatz = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine("Startjahr: ");
            int endjahr = Convert.ToInt16(Console.ReadLine());
            int j = endjahr - startjahr;
            double k;
            int i=0;

            while (i <= j)
            //                                                                     for (fkapital = 24, i = 0; i <= j; i++)
            {
                int jahr = startjahr + i;
                i++;
                k = startkapital + (startkapital * (prozentsatz / 100));
                startkapital = k;
                //                                                                     fkapital = fkapital + (fkapital * (Prozentsatz / 100));
                Console.WriteLine("im Jahr: " + jahr + " ein Wert von {0:c} \n", k);
                //                                                                     Console.WriteLine("im Jahr: " + Jahr + " ein Wert von {0:c} \n", fkapital);
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        // while-Schleife Fußgeführt bzw. do-while Schleife
        static void Alex5()
        {
            int startjahr = Ask.i("Wann ist das Anfangsjahr? ");
            int endjahr = Ask.i("Welches ist das Endjahr? ");
            double startkapital = Ask.d("Wie hoch ist das Startkapital? ");
            double prozentsatz = Ask.d("Wie hoch ist der Zinssatz");
            int j = endjahr - startjahr;
            double k;
            int x = 0;
            int jahr;

            do
            {
                jahr = startjahr + x;
                k = startkapital + (startkapital * (prozentsatz / 100));
                startkapital = k;
                Console.WriteLine("im Jahr: " + jahr + " ein Wert von {0:c} \n", k);
                x++;
                Console.ReadKey();
            }
            while (x <= j);
            Console.ReadKey();
            Console.Clear();
            Main();
        }

    }

}
