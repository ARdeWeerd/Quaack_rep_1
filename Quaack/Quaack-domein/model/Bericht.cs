using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quaack_domein.model
{
    public class Bericht
    {
        private string bericht_kop;
        private string bericht_inhoud;
        private string bericht_auteur;

        private List<Bericht> reacties;
        private Bericht reactieOp;

        public string Kop
        {
            get
            {
                return this.bericht_kop;
            }
            set
            {
                this.bericht_kop = value;
            }
        }


        public string Inhoud
        {
            get
            {
                return this.bericht_inhoud;
            }
            set
            {
                this.bericht_inhoud = value;
            }
        }

        public string Auteur
        {
            get
            {
                return this.bericht_auteur;
            }
            set
            {
                this.bericht_auteur = value;
            }
        }

    }
}
