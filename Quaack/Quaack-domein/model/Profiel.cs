using System;
using System.Collections.Generic;

namespace Quaack_domein.model
{
    public class Profiel
    {
        private Guid id;
        private string naam;
        private string wachtwoord;
        private string profielschets;
        private string emailadres;
        private string avatarLokatie;
        private string mobielNummer;
        private DateTime geblokkeerd;
        private DateTime wijzigingEmail;
        private DateTime verificationPendingDate;
        private List<Profiel> geblokkeerdeGebruikers;
        private List<Profiel> geblokkeerdDoor;
        private List<Bericht> berichten;
        private bool tijdelijkGeblokkeerd = false;
        private bool permanentGeblokkeerd = false;
        private bool verwijderd = false;

        public bool TijdelijkGeblokkeerd
        {
            get { return tijdelijkGeblokkeerd; }
            set { tijdelijkGeblokkeerd = value; }
        }
       
        public bool PermanentGeblokkeerd
        {
            get { return permanentGeblokkeerd; }
            set { permanentGeblokkeerd = value; }
        }
       

        public bool Verwijderd
        {
            get { return verwijderd; }
            set { verwijderd = value; }
        }

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
 
        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        public string Profielschets
        {
            get { return profielschets; }
            set { profielschets = value; }
        }

        public string Emailadres
        {
            get { return emailadres; }
            set { emailadres = value; }
        }

        public string AvatarLokatie
        {
            get { return avatarLokatie; }
            set { avatarLokatie = value; }
        }

        public string MobielNummer
        {
            get { return mobielNummer; }
            set { mobielNummer = value; }
        }
 
        public DateTime Geblokkeerd
        {
            get { return geblokkeerd; }
            set { geblokkeerd = value; }
        }

        public DateTime WijzigingEmail
        {
            get { return wijzigingEmail; }
            set { wijzigingEmail = value; }
        }

        public DateTime VerificationPendingDate
        {
            get { return verificationPendingDate; }
            set { verificationPendingDate = value; }
        }
 

        public List<Profiel> GeblokkeerdeGebruikers
        {
            get { return geblokkeerdeGebruikers; }
            set { geblokkeerdeGebruikers = value; }
        }

        public List<Profiel> GeblokkeerdDoor
        {
            get { return geblokkeerdDoor; }
            set { geblokkeerdDoor = value; }
        }
 
        public List<Bericht> Berichten
        {
            get { return berichten; }
            set { berichten = value; }
        }

    }
}
