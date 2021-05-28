using System;
using System.Collections.Generic;
using System.Text;

namespace VideoverleihConsole.Model
{
    public class Kunde
    {
        public Guid ID { get; }
        public string nachname { get; }
        public string vorname { get; }
        public DateTime geburtstag { get; }
        public string eMail { get; private set; }

        public Kunde(string Nachname, string Vorname, DateTime Geburtstag, string EMail)
        {
            nachname = Nachname;
            vorname = Vorname;
            geburtstag = Geburtstag;
            eMail = EMail;
        }

        public void aendereMail (string NeueMail)
        {
            eMail = NeueMail;
        }
    }
}
