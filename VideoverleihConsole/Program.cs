using System;
using VideoverleihConsole.Model;
using VideoverleihConsole.Controller;

namespace VideoverleihConsole
{
    class Program
    {
        new KundenController Kundenliste = new KundenController();

        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello testung World!");

            Kundenliste.kundeHinzufuegen("Müller","Lieschen", 30.04.89, "lieschenMueller@mueller.de");

           foreach(Kunde i in Kundenliste)
            {

            }

        }
    }
}
