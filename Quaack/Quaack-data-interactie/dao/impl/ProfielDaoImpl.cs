using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;

namespace Quaack_data_interactie.dao.impl
{
    public class ProfielDaoImpl : ProfielDao
    {
        private static volatile ProfielDaoImpl instance;

        private static object syncRoot = new Object();

        /// <summary>
        /// private, verkrijgen van instantie via static methode getInstance()
        /// </summary>
        private ProfielDaoImpl()
        {
            //empty
        }

        /// <summary>
        /// Propertie voor het verkrijgen van instantie van de class. Er is altijd maar 1 instantie (singleton)
        /// </summary>
        /// <returns>de instantie van ProfielDaoImpl</returns>
        public static ProfielDaoImpl Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ProfielDaoImpl();
                    }
                }

                return instance;
            }
        }

       // private System.Object lockThis = new System.Object();

        public List<string> findUsers(string searchPattern)
        {
            List<string> result = new List<string>();
            result.Add("user1");
            result.Add("user2");
            return result;
        }

        public Profiel find(string userId)
        {
            Profiel profiel = new Profiel();
            profiel.Naam = "ProfielVanuitDAO";
            profiel.Verwijderd = false;
            return profiel;
        }

        public void save(Profiel profiel)
        {
            throw new NotImplementedException();
        }

        public void update(Profiel profiel)
        {
            throw new NotImplementedException();
        }
    }
}
