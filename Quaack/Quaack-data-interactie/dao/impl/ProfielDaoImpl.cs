using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;
using System.Data.SqlClient;
using System.Data;

namespace Quaack_data_interactie.dao.impl
{
    public class ProfielDaoImpl : ProfielDao
    {
        private static volatile ProfielDaoImpl instance;

        private static object syncRoot = new Object();

        private static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\test\Quaack.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        //private SqlConnection conn = new SqlConnection(ConnectionString);

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
            string idQuery = "select username from profile where username like @ZOEK";
            SqlConnection conn = null;
            List<String> result = new List<string>();

            try
            {
                conn = new SqlConnection(connectionString);
                
                conn.Open();
                SqlCommand cmd = new SqlCommand(idQuery, conn);
                cmd.Parameters.AddWithValue("@ZOEK", "%" + searchPattern + "%");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable table = ds.Tables[0];
                foreach (DataRow row in table.Rows)
                {
                    result.Add((string) row[0]);
                }
                return result;               
            }
            catch (Exception de)
            {
                throw new DaoException("Eris iets misgegaan met zoeken naar users", de);
            }
            finally
            {
                conn.Close();
            }
        }

        public Profiel find(string userId)
        {
            Profiel result = findUserWithoutChildren(userId);

            //vullen van de lijst met geblokkeerde gebruikers
            result.GeblokkeerdeGebruikers = new List<Profiel>();
            List<string> blockedUsers = getBlockedUsers(userId);
            foreach (string blockedUser in blockedUsers)
            {
                Profiel p = findUserWithoutChildren(blockedUser);
                result.GeblokkeerdeGebruikers.Add(p);
            }
            //TODO doe hetzelfde voor geblokkeerdDoor indien noodzakelijk

            //TODO ophalen van berichten en koppelen aan profiel indien noodzakelijk
            
            return result;
        }

        private List<string> getBlockedUsers(string userId)
        {
            //TODO lezen van de gegevens uit de nog niet bestaande koppeltabel voor geblokkeerde gebruikers.
            return new List<string>();
        }


        private Profiel findUserWithoutChildren(string userid)
        {
            Profiel profiel = new Profiel();
            string selQuery = @"select profileid, username, password, profile, email, avatarlocation, mobilenumber, 
                                verficationpendingdatetime from profile where username = @USERNAME";
            SqlConnection conn = null;
            //Profiel result = new Profiel();
            try
            {
                conn = new SqlConnection(connectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand(selQuery, conn);
                cmd.Parameters.AddWithValue("@USERNAME", userid);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable table = ds.Tables[0];
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    profiel.Id = (int)row[0];
                    profiel.Naam = (string)row[1];
                    profiel.Wachtwoord = (string)row[2];
                    if (!(row[3] is DBNull)) profiel.Profielschets = (string)row[3];
                    profiel.Emailadres = (string)row[4];
                    if (!(row[5] is DBNull)) profiel.AvatarLokatie = (string)row[5];
                    if (!(row[6] is DBNull)) profiel.MobielNummer = (string)row[6];
                    if (!(row[7] is DBNull)) profiel.VerificationPendingDate = (DateTime)row[7];
                }
                return profiel;
            }
            catch (Exception de)
            {
                //return null;
                throw new DaoException("Eris iets misgegaan met zoeken naar users", de);
            }
            finally
            {
                conn.Close();
            }


        }


        public void save(Profiel profiel)
        {
            string insQuery = "";
            insQuery = @"insert into profile (username, password, profile, email, avatarlocation, mobilenumber, verificationpending, tempblocked, permblocked, removed) 
                                     values (@username, @password, @profile, @email, @avatarlocation, @mobilenumber, @verificationpending, @tempblocked, @permblocked, @removed);";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(insQuery, conn);
                cmd.Parameters.AddWithValue("@profileid", getNextId());
                cmd.Parameters.AddWithValue("@username", profiel.Naam);
                cmd.Parameters.AddWithValue("@password", "wwpUser");
                cmd.Parameters.AddWithValue("@email", profiel.Emailadres);
                cmd.Parameters.AddWithValue("@profile", profiel.Profielschets);
                cmd.Parameters.AddWithValue("@avatarlocation", profiel.AvatarLokatie);
                cmd.Parameters.AddWithValue("@mobilenumber", profiel.MobielNummer);
                cmd.Parameters.AddWithValue("@verificationpending", false);
                cmd.Parameters.AddWithValue("@tempblocked", false);
                cmd.Parameters.AddWithValue("@permblocked", false);
                cmd.Parameters.AddWithValue("@removed", false);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new DaoException("Er is iets misgegaan met opslaan van het profiel", e);
            }
            finally
            {
                conn.Close();
            }
        }



        public void update(Profiel profiel)
        {
            string updQuery = @"update profile set password = @password, profile = @profile, email = @email, avatarlocation = @avatarlocation,
                                mobilenumber = @mobilenumber, verificationpending = @verificationpending, tempblocked = @tempblocked, permblocked = @permblocked, removed = @removed
                               where profileid = @ID";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(updQuery, conn);
                cmd.Parameters.AddWithValue("@ID", profiel.Id);
                cmd.Parameters.AddWithValue("@password", profiel.Wachtwoord);
                cmd.Parameters.AddWithValue("@email", profiel.Emailadres);
                cmd.Parameters.AddWithValue("@profile", profiel.Profielschets);
                cmd.Parameters.AddWithValue("@avatarlocation", profiel.AvatarLokatie);
                cmd.Parameters.AddWithValue("@mobilenumber", profiel.MobielNummer);
                cmd.Parameters.AddWithValue("@verificationpending", false);
                cmd.Parameters.AddWithValue("@tempblocked", false);
                cmd.Parameters.AddWithValue("@permblocked", false);
                cmd.Parameters.AddWithValue("@removed", false);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new DaoException("Er is iets misgegaan met updaten van het profiel", e);
            }
            finally
            {
                conn.Close();
            }

                
        }

        private int getNextId()
        {
            string idQuery = "select MAX(profileid) from profile";
            SqlConnection conn = null;
           
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(idQuery, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow row = ds.Tables[0].Rows[0];
                if (row[0] is DBNull) //bij lege database
                {
                    return 1;
                }
                     

                int maxid = (int)row[0];
                return ++maxid;
            }
            catch (Exception de)
            {
                throw new DaoException("Eris iets misgegaan met bepalen van met volgende ident");
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
