using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein;
using Quaack_domein.model;

namespace Quaack_service.Service.impl
{
    /// <summary>
    /// author: Edwin Denekamp
    /// </summary>
    public sealed class ProfielServiceImpl : ProfielService
    {

        private static volatile ProfielServiceImpl instance;

        private static object syncRoot = new Object();

        private ProfielServiceImpl()
        {
           // if (this.berichtenDao == null)
            {
                //instantie verkrijgen via singleton instance
           //     this.berichtenDao = BerichtenDaoImpl.Instance;
            }
 
        }

        /// <summary>
        /// Propertie voor het verkrijgen van instantie van de class. Er is altijd maar 1 instantie (singleton)
        /// </summary>
        /// <returns>de instantie van ProfielServiceImpl</returns>
        public static ProfielServiceImpl Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ProfielServiceImpl();
                    }
                }

                return instance;
            }
        }

        public Profiel find(string userId)
        {
            Profiel profiel = new Profiel();
            profiel.Naam = "testUserVanuitService";
            return profiel;
        }

        public Result save(Profiel profiel)
        {
            return Result.newResultSucces();
        }

        public Result update(Profiel profiel)
        {
            return Result.newResultSucces();
        }

        public Result delete(string userId)
        {
            return Result.newResultSucces();
        }

        public Result blockReacties(string userId, Profiel userIdToBlock, bool blocked)
        {
            return Result.newResultSucces();
        }

        public Result blockAccount(string userId)
        {
            return Result.newResultSucces();
        }
    }
}
