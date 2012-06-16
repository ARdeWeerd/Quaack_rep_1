using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;

namespace Quaack_data_interactie.dao
{
    public interface ProfielDao
    {
        /// <summary>
        /// Ophalen lijst met gebruikersnamen die voldoen aan de zoekopdracht
        /// </summary>
        /// <param name="searchPattern"></param>
        /// <returns>lijst met namen</returns>
        List<String> findUsers(string searchPattern);

        /// <summary>
        /// Ophalen profiel van gebruiker.
        /// </summary>
        /// <param name="userId">id userId</param>
        /// <returns>profiel</returns>
        Profiel find(string userId);

        /// <summary>
        /// Opslaan profiel.
        /// </summary>
        /// <param name="profiel"></param>
        void save(Profiel profiel);

        /// <summary>
        /// Bijwerken profiel.
        /// </summary>
        /// <param name="profiel"></param>
         void update(Profiel profiel);
        
    }
}
