using System;
using System.Collections.Generic;

namespace Quaack_domein.model
{
    public class Profiel
    {
        private string naam;
        private string wachtwoord;
        private string profielschets;
        private string emailadres;
        private string avatarLokatie;
        private string mobielNummer;
        private DateTime geblokkerd;
        private DateTime wijzigingEmail;
        private DateTime verificationPendingDate;
        private List<Profiel> geblokkerdeGebruikers;
        private List<Profiel> geblokkeerdDoor;
        private List<Bericht> berichten;
        private bool verwijderd;


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
 
        public DateTime Geblokkerd
        {
            get { return geblokkerd; }
            set { geblokkerd = value; }
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
 

        public List<Profiel> GeblokkerdeGebruikers
        {
            get { return geblokkerdeGebruikers; }
            set { geblokkerdeGebruikers = value; }
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
