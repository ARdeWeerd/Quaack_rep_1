using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein;
using Quaack_domein.model;
using Quaack_data_interactie;
using Quaack_data_interactie.dao;
using Quaack_data_interactie.dao.impl;

namespace Quaack_service.Service.impl
{
    /// <summary>
    /// author: Edwin Denekamp
    /// </summary>
    public sealed class ProfielServiceImpl : ProfielService
    {
        private ProfielDao profielDao;

        private static volatile ProfielServiceImpl instance;

        private static object syncRoot = new Object();

        private ProfielServiceImpl()
        {
            if (this.profielDao == null)
            {
                //instantie verkrijgen via singleton instance
                this.profielDao = ProfielDaoImpl.Instance;
            }

        }

        /// <summary>
        /// Property voor het verkrijgen van instantie van de class. Er is altijd maar 1 instantie (singleton)
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
            try
            {
                return this.profielDao.find(userId);

            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }

        public Result save(Profiel profiel)
        {
            try
            {
                if (this.profielDao.findUsers(profiel.Naam).Count > 0)
                {
                    return new Result(ResultCode.USERID_NOT_UNIQUE);
                }
                this.profielDao.save(profiel);
                return Result.newResultSucces();
            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }

        public Result update(Profiel profiel)
        {
            try
            {
                Profiel p = this.profielDao.find(profiel.Naam);
                if (p == null)
                {
                    return new Result(ResultCode.USERID_NOT_FOUND);
                }
                //TODO alle velden die gewijzigd kunnen worden doorlopen
                p.Profielschets = profiel.Profielschets;
                p.AvatarLokatie = profiel.AvatarLokatie;
                this.profielDao.update(p);
                return Result.newResultSucces();
            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }

        public Result delete(string userId)
        {
            try
            {
                Profiel p = this.profielDao.find(userId);
                if (p == null)
                {
                    return new Result(ResultCode.USERID_NOT_FOUND);
                }
                p.Verwijderd = true;
                this.profielDao.update(p);
                return Result.newResultSucces();
            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }

        public Result blockReacties(string userId, Profiel userIdToBlock, bool blocked)
        {
            try
            {
                //ophalen van de te bewerken data
                Profiel user = this.profielDao.find(userId);
                Profiel blockedUser = this.profielDao.find(userId);

                if (user == null || blockedUser == null)
                {
                    return new Result(ResultCode.USERID_NOT_FOUND);
                }
                //bijwerken van de domeinobjecten
                if (blocked)
                {
                    //gebruiker toevoegen aan de lijst met geblokkeere gebruikers
                    // eerst checken of die bestaat
                    if (!user.GeblokkeerdeGebruikers.Contains(blockedUser))
                    {
                        user.GeblokkeerdeGebruikers.Add(blockedUser);
                    }
                }
                else
                {
                    if (user.GeblokkeerdeGebruikers.Contains(blockedUser))
                    {
                        user.GeblokkeerdeGebruikers.Remove(blockedUser);
                    }
                }
                //save het resultaat
                this.profielDao.update(user);
                return Result.newResultSucces();
            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }

        public Result blockAccount(string userId, bool block)
        {
            try
            {
                Profiel p = this.profielDao.find(userId);
                if (p == null)
                {
                    return new Result(ResultCode.USERID_NOT_FOUND);
                }
                p.TijdelijkGeblokkeerd = block;
                this.profielDao.update(p);
                return Result.newResultSucces();
            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }

        public List<string> findUsers(string searchPattern)
        {
            try
            {
                List<string> users = this.profielDao.findUsers(searchPattern);
                //alleen degene tonen die niet removed zijn
                List<string> nietVerwijderdeGebruikers = new List<string>();
                foreach (string username in users)
                {
                    Profiel profiel = this.profielDao.find(username);
                    if (!profiel.Verwijderd)
                    {
                        nietVerwijderdeGebruikers.Add(username);
                    }
                }
                return nietVerwijderdeGebruikers;
            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }
    }
}
