using System;
using System.Collections.Generic;
using System.Text;
using VideoverleihConsole.Model;

namespace VideoverleihConsole.Controller
{
    class KundenController
    {
        List<Kunde> Kundenliste { get; }

        public void kundeHinzufuegen(string nachname, string vorname, DateTime geburtstag, string email)
        {
            string Nachname = nachname;
            string Vorname = vorname;
            DateTime Geburtstag = geburtstag;
            string Email = email;

            Kunde NeuerKunde = new Kunde(Nachname, Vorname, Geburtstag, Email);
            Kundenliste.Add(NeuerKunde);
        }

        public void kundeLoeschen(Guid id)
        {
            Kunde ZuLoeschenderKunde = Kundenliste.Find(x => x.ID == id);
    
            Kundenliste.Remove(ZuLoeschenderKunde);
        }
        
    }
}
