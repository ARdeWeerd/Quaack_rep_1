using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;

namespace Quaack_service.Service
{
    /// <summary>
    /// author: Edwin Denekamp
    /// </summary>
    public interface BerichtenService
    {
        /// <summary>
        /// Ophalen van alle berichten van een gebruiker.
        /// </summary>
        /// <param name="userId">Userid van de gebruiker</param>
        /// <returns>Resultaat van de actie</returns>
        List<Bericht> find(string userId);

        /// <summary>
        /// Ophalen bericht op id.
        /// </summary>
        /// <param name="bericht_id">id bericht</param>
        /// <returns>Resultaat van de actie</returns>
        Bericht find(int bericht_id);

        /// <summary>
        /// Opslaan bericht.
        /// </summary>
        /// <param name="bericht"></param>
        /// <returns>Resultaat van de actie</returns>
        Result save(Bericht bericht);

        /// <summary>
        /// Bijwerken bericht.
        /// </summary>
        /// <param name="bericht"></param>
        /// <returns>Resultaat van de actie</returns>
        Result update(Bericht bericht);

        /// <summary>
        /// Verwijderen bericht (markering removed op true zetten).
        /// </summary>
        /// <param name="bericht"></param>
        /// <returns>Resultaat van de actie</returns>
        Result delete(Bericht bericht);
    }
}
