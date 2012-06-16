using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;

namespace Quaack_service.Service
{
    public interface ProfielService
    {
        /// <summary>
        /// Ophalen lijst met gebruikersnamen die voldoen aan de zoekopdracht
        /// </summary>
        /// <param name="searchPattern"></param>
        /// <returns>lijst met namen</returns>
        List<String> findUsers(string searchPattern);

        /// <summary>
        /// Ophalen profiel van gebruiker op userId
        /// </summary>
        /// <param name="userId">userId</param>
        /// <returns>Profiel van gebruiker</returns>
        Profiel find(string userId);

        /// <summary>
        /// Opslaan van profiel.
        /// </summary>
        /// <param name="profiel">Het op te slaan profiel</param>
        /// <returns>Resultaat van de actie</returns>
        Result save(Profiel profiel);

        /// <summary>
        /// Opslaan van profiel.
        /// </summary>
        /// <param name="profiel">Het op te slaan profiel</param>
        /// <returns>Resultaat van de actie</returns>
        Result update(Profiel profiel);

        /// <summary>
        /// Verwijderen van profiel (removed op true)
        /// </summary>
        /// <param name="userId">userId van de te verwijderen gebruiker</param>
        /// <returns>Resultaat van de actie</returns>
        Result delete(String userId);

        /// <summary>
        /// Blokkeren van een gebruiker voor plaatsen reacties op berichten.
        /// </summary>
        /// <param name="userId">userId van de gebruiker</param>
        /// <param name="userIdToBlock">userId van de te blokkeren gebruiker</param>
        /// <param name="blocked">true indien blokkeren, false indien deblokkeren</param>
        /// <returns>Resultaat van de actie</returns>
        Result blockReacties(String userId, Profiel userIdToBlock, bool blocked);

        /// <summary>
        /// Blokkeren van de gebruiker voor gebruik van systeem.
        /// </summary>
        /// <param name="userId">userId van de te blokkeren gebruiker</param>
        /// <returns>Resultaat van de actie</returns>
        Result blockAccount(String userId, bool block);
      
    }
}
