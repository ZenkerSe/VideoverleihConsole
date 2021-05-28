using System;
using System.Collections.Generic;
using System.Text;
using VideoverleihConsole.Model;

namespace VideoverleihConsole.Controller
{
    class KundenController
    {
        List<Kunde> Kundenliste { get; }

        public void kundeHinzufuegen()
        {
            string Nachname = "Müller";
            string Vorname = "Lieschen";
            DateTime Geburtstag = Convert.ToDateTime("30.04.1989");
            string Email = "MickeyMouse@hotmail.org";

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
