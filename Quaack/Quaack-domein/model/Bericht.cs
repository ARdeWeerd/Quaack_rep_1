using System;
using System.Collections.Generic;

namespace Quaack_domein.model
{
    public class Bericht
    {
        private string tekst;
        private bool verwijderd;
        private DateTime datumGeplaatst;

        private List<Bericht> reacties;
        private Bericht reactieOp;

        private Profiel geplaatsDoor;
        private Profiel verwijderdDoor;

        public Profiel GeplaatsDoor
        {
            get { return geplaatsDoor; }
            set { geplaatsDoor = value; }
        }
       

        public Profiel VerwijderdDoor
        {
            get { return verwijderdDoor; }
            set { verwijderdDoor = value; }
        }

        public string Tekst
        {
            get { return this.tekst; }
            set { this.tekst = value; }
        }

        public bool Verwijderd
        {
            get { return this.verwijderd; }
            set { this.verwijderd = value; }

        }

        public DateTime DatumGeplaatst
        {
            get { return this.datumGeplaatst; }
            set { this.datumGeplaatst = value; }
        }

        public List<Bericht> Reacties
        {
            get { return this.reacties; }
            set { this.reacties = value; }
        }

        public Bericht ReactieOp
        {
            get { return this.reactieOp; }
            set { this.reactieOp = value; }
        }

    }
}
