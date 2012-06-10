using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;
using Quaack_data_interactie.dao;
using Quaack_data_interactie.dao.impl;

namespace Quaack_service.Service.impl
{
    public sealed class BerichtenServiceImpl : BerichtenService
    {
        /// <summary>
        /// Declaratie van interface, de implementatie kan makkelijk gewijzigd worden
        /// </summary>
        private BerichtenDao berichtenDao;

        private static volatile BerichtenServiceImpl instance;

        private static object syncRoot = new Object();

        private BerichtenServiceImpl()
        {
            if (this.berichtenDao == null)
            {
                //instantie verkrijgen via singleton instance
                this.berichtenDao = BerichtenDaoImpl.Instance;
            }
 
        }

        /// <summary>
        /// Propertie voor het verkrijgen van instantie van de class. Er is altijd maar 1 instantie (singleton)
        /// </summary>
        /// <returns>de instantie van BerichtenDaoImpl</returns>
        public static BerichtenServiceImpl Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new BerichtenServiceImpl();
                    }
                }

                return instance;
            }
        }


        public List<Bericht> find(string userId)
        {
            //TODO rules implementeren, bijvoorbeeld check of userid bestaat
            //eigen exception gooien bij fouten 
            try
            {
                return this.berichtenDao.find(userId);
            }
            catch (DaoException de)
            {
                throw new ServiceException(de.Message, de);
            }
        }

        public Bericht find(int bericht_id)
        {
            throw new NotImplementedException();
        }

        public void save(Bericht bericht)
        {
            throw new NotImplementedException();
        }
    }
}
