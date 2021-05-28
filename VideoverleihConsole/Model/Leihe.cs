using System;
using System.Collections.Generic;
using System.Text;

namespace VideoverleihConsole.Model
{
    public class Leihe
    {
        public Guid ID { get; }
        public DateTime leihdatum { get; }
        public int leihdauerInTagen { get; set; }

        public string omdbID { get; }



        public Leihe(DateTime Leihdatum, string OmdbID, int LeihdauerInTagen)
        {
            leihdatum = Leihdatum;
            omdbID = OmdbID;
            leihdauerInTagen = LeihdauerInTagen;

        }

        public Leihe(string OmdbID, int LeihdauerInTagen)
        {
            leihdatum = DateTime.Now;
            omdbID = OmdbID;
            leihdauerInTagen = LeihdauerInTagen;

        }
    }
}
