using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;

namespace Quaack_data_interactie.dao
{
    public interface BerichtenDao
    {
        /// <summary>
        /// Ophalen van alle berichten van een gebruiker.
        /// </summary>
        /// <param name="userId">Userid van de gebruiker</param>
        /// <returns>lijst met berichten</returns>
        List<Bericht> find(string userId);

        /// <summary>
        /// Ophalen bericht op id.
        /// </summary>
        /// <param name="bericht_id">id bericht</param>
        /// <returns>Bericht</returns>
        Bericht find(int bericht_id);

        /// <summary>
        /// Opslaan bericht.
        /// </summary>
        /// <param name="bericht"></param>
        void save(Bericht bericht);

        /// <summary>
        /// Bijwerken bericht.
        /// </summary>
        /// <param name="bericht"></param>
         void update(Bericht bericht);

        /// <summary>
        /// Verwijderen bericht (markering removed op true zetten).
        /// </summary>
        /// <param name="bericht"></param>
         void delete(Bericht bericht);
    }
}
