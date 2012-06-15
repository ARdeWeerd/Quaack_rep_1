using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Quaack_domein.model;

namespace Quaack_data_interactie.dao.impl
{
    public sealed class BerichtenDaoImpl : BerichtenDao
    {
        private static volatile BerichtenDaoImpl instance;

        private static object syncRoot = new Object();

        /// <summary>
        /// private, verkrijgen van instantie via static methode getInstance()
        /// </summary>
        private BerichtenDaoImpl()
        {
            //empty
        }

        /// <summary>
        /// Propertie voor het verkrijgen van instantie van de class. Er is altijd maar 1 instantie (singleton)
        /// </summary>
        /// <returns>de instantie van BerichtenDaoImpl</returns>
        public static BerichtenDaoImpl Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new BerichtenDaoImpl();
                    }
                }

                return instance;
            }
        }

        private System.Object lockThis = new System.Object();

        public List<Bericht> find(string userId)
        {
            List<Bericht> result = new List<Bericht>();
            string strConnString =  @"Data Source='(local)\sqlexpress';Integrated Security=True;Pooling=False;Initial Catalog='NOHSchaatsen'";


            //aanmaken SqlCommand
           // String SQL = "SELECT b.bericht_kop, b.bericht_inhoud b.bericht_auteur FROM Berichten b WHERE bericht_kop LIKE @SEARCH OR bericht_inhoud LIKE @SEARCH OR bericht_auteur LIKE @SEARCH";
            String SQL = "SELECT b.bericht_kop, b.bericht_inhoud, b.bericht_auteur FROM Berichten b WHERE bericht_kop LIKE @SEARCH OR bericht_inhoud LIKE @SEARCH OR bericht_auteur LIKE @SEARCH";
            
           
            SqlCommand cmd = new SqlCommand(SQL, new SqlConnection(strConnString));
            cmd.Parameters.AddWithValue("@SEARCH", "%" + userId + "%");
            //aanamken adapter en dataset
            SqlDataAdapter berichtenAdpt = new SqlDataAdapter();
            berichtenAdpt.SelectCommand = cmd;
            DataSet berichtenDataSet = new DataSet();
            //opalen data 
            try
            {
                berichtenAdpt.Fill(berichtenDataSet, "Berichten");
                //vullen data in result
                foreach (DataRow row in berichtenDataSet.Tables["Berichten"].Rows)
                {
                    Bericht bericht = new Bericht();
                    string tekst = (string)row[0];
                    bericht.Tekst = tekst;
                    bericht.Tekst = (string)row[0];
                   // bericht. = (string)row[1];
                   // bericht.Auteur = (string)row[2];
                    result.Add(bericht);
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                throw new DaoException("Er is iets misgegaan met het ophalen van data, check de connectionString in BerichtenDaoImpl en zorg voor de juist SchaatsDatabase!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", e);
            }
            finally
            {
                cmd.Connection.Close();
            
            }

            return result;


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