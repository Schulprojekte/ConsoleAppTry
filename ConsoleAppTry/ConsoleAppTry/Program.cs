using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTry
{
    class Program
    {
        private static int x;
        private static char rechenBefehl;
        private static int y;
        private static double z;

        static void Main(string[] args)
        {
            Rechnen1();
        }

        private static void Rechnen1()
        {

            try
            {
                Console.WriteLine("Geben Sie eine Zahl ein");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben Sie einen Rechenoperator ein: +, -, *, /");
                rechenBefehl = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Geben Sie eine Zahl ein");
                y = Convert.ToInt32(Console.ReadLine());

                switch(rechenBefehl)
                {
                    case '+':
                        z = x + y;
                        Console.WriteLine(z);
                        Console.ReadKey();
                        break; //ohne break geht die Ausführung automatisch in den nächsten case Block

                    case '-':
                        z = x - y;
                        Console.WriteLine(z);
                        Console.ReadKey();
                        break;

                    case '*':
                        z = x * y;
                        Console.WriteLine(z);
                        Console.ReadKey();
                        break;

                    case '/':
                        z = x / y;
                        Console.WriteLine(z);
                        Console.ReadKey();
                        break;

                    default: //Besondere Sprungmarke für unbekannte Sprungmarken
                        Console.WriteLine("Unbekannter Operator " + rechenBefehl);
                        break;
                } //Klammer für switch
            } //Klammer für try

            //catch(InputMismatchException e) //Reagiert bei nicht int: double, String...
            //{
            //    Console.WriteLine("Falsche Eingabe, geben Sie eine ganze Zahl ein");
            //}

            catch(ArithmeticException e)
            {
                Console.WriteLine("Sie machen einen Rechenfehler!");
                Console.ReadKey();
            }
            
            catch(Exception e) //reagiert auf alle Fehler
            {
                Console.WriteLine("Fehler ");
                Console.ReadKey();
            }

            finally
            {
                Console.WriteLine("Alles wird gut");
                Console.ReadKey();
            }
        }
    }
}
