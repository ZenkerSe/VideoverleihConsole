using System;
using System.Collections.Generic;
using System.Text;
using VideoverleihConsole.Model;

namespace VideoverleihConsole
{
    public class Controller
    {
        public List<Kunde> Kunden { get; set; }
      
        public Controller(List<Kunde> kunden)
        {
            Kunden = kunden;
        }
            //Console.WriteLine("\n 4: Kunden anzeigen");
            //Console.WriteLine("\n 5: Kunden anlegen");
            //Console.WriteLine("\n 6: Kunden bearbeiten");
            //Console.WriteLine("\n 7: Kunden löschen");
            
        public void KundenAnzeigen()
        {
            foreach(Kunde i in Kunden)
            {
                Console.WriteLine(i);
            }
        }
    }
}
