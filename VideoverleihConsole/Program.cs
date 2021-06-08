using System;
using System.Collections.Generic;
using VideoverleihConsole.Model;


namespace VideoverleihConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Kunde> kunden = new List<Kunde>();
            kunden.Add(new Kunde("Müller","Lieschen",Convert.ToDateTime("30.04.1989"),"liese@mueller.de"));
            Controller Kundenliste = new Controller(kunden);

            int decisionIdentifier = 0;
            //Menue
            while (decisionIdentifier != 8) { 

            Console.WriteLine("Videoverleih - Consoletool");
            Console.WriteLine("\n________________________");

            Console.WriteLine("\n 0: Leihen anzeigen");

            Console.WriteLine("\n 1: Leihe eintragen");
            Console.WriteLine("\n 2: Leihe bearbeiten");
            Console.WriteLine("\n 3: Leihe löschen");

            Console.WriteLine("\n 4: Kunden anzeigen");


            Console.WriteLine("\n 5: Kunden anlegen");
            Console.WriteLine("\n 6: Kunden bearbeiten");
            Console.WriteLine("\n 7: Kunden löschen");
            Console.WriteLine("\n 8: Beenden");

            decisionIdentifier = Convert.ToInt32(Console.ReadLine());

            switch (decisionIdentifier)
            {
                case 0:
                    Console.WriteLine("Leihen anzeigen");
                    break;
                case 1:
                    Console.WriteLine("Leihe eintragen");
                    break;
                case 2:
                    Console.WriteLine("Leihe bearbeiten");
                    break;
                case 3:
                    Console.WriteLine("Leihe löschen");
                    break;
                case 4:
                    Console.WriteLine("Kunden anzeigen");
                        Kundenliste.KundenAnzeigen();
                    break;
                case 5:
                    Console.WriteLine("Kunden anlegen");
                    break;
                case 6:
                    Console.WriteLine("Kunden bearbeiten");
                    break;
                case 7:
                    Console.WriteLine("Kunden löschen");
                    break;
                case 8:
                    Console.WriteLine("Beenden");
                    Environment.Exit(0);
                    break;
                default: 
                    Console.WriteLine("invalide Eingabe");
                    break;
            }
            }

        }
    }
}
