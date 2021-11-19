using System;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace GestionPersonnelLogin
{
    /// <summary>
    ///IT IS DATABASE LOGIC WHEN LOADING OR RECEIVING A REQUEST FROM USER.
    ///EVERY TIME WE NEED TO CONNECT TO DB, CREATE A QUERY AND COMMAND TO EXECUTE LOGIC
    /// </summary>
    /// <returns> : database execution logic </returns>
    ///<exception> no database connected</exception>
    class Model
    {
        /// <summary>
        ///THIS MODULE CONNECTS APP AND DATABASE
        /// </summary>
        /// <returns> : the database connexion, usefull for some logic execution </returns>
        public static MySqlConnection getDBConnection()
        {
            // Connection String.
            string connString = "Server=127.0.0.1;Database=bts;port=3306;User Id=bts; Password=P@ssw0rd";
            MySqlConnection dbConnect = new MySqlConnection(connString);

            return dbConnect;
        }

        /// <summary>
        /// CHECK USERNAME AND PWD INFO TO GET ACCESS OR NOT TO APP, RETURN BOOL
        /// </summary>
        /// <param name="getAdmin"></param>
        /// <param name="getPwd"></param>
        /// <returns> true or false if match</returns>
        ///<exception> no data </exception>
        public static bool dbCheckLogin(string getAdmin, string getPwd)
        {
            //CONNECT TO DB
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            //CREATE QUERY
            string dbQuery = "SELECT * FROM bts.responsable";
            //CREATE CMD
            MySqlCommand cmd = new MySqlCommand();
            //CONNECT CMD
            cmd.Connection = dbConnect;
            cmd.CommandText = dbQuery;
            //BOOL TO CHECK
            bool isAdmin = false;
            //EXECUTION LOGIC
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[1].ToString() == getAdmin && reader[2].ToString() == getPwd)
                        {
                            isAdmin = true;
                        }
                    }
                }
                else
                {
                    reader.Close();
                }
            }
            dbConnect.Close();
            dbConnect.Dispose();
            dbConnect = null;
            return isAdmin;
        }

        /// <summary>
        /// GET ALL EMPLOYEE LIST WHEN LOG IN OR ANY CHANGE
        /// </summary>
        /// <param name="getListPersonnel"></param>
        public static void dbGetListPersonnel(ListBox getListPersonnel)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            string dbQuery = "SELECT * FROM bts.personnel";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbConnect;
            cmd.CommandText = dbQuery;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader[0].ToString();
                        string firstName = reader[1].ToString();
                        string service = reader[4].ToString();
                        getListPersonnel.Items.Add(name + " " + firstName + " : " + service);
                    }
                }
                else
                {
                    reader.Close();
                }
            }
            dbConnect.Close();
            dbConnect.Dispose();
            dbConnect = null;
        }

        /// <summary>
        /// GET SERVICES OF FIRM TO PUT EMPLOYEE ON ONE OF THEM
        /// </summary>
        /// <param name="getListServices"></param>
        public static void dbGetListServices(ListBox getListServices)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            string dbQuery = "SELECT * FROM bts.service";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbConnect;
            cmd.CommandText = dbQuery;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string serviceName = reader[1].ToString();
                        getListServices.Items.Add(serviceName);
                    }
                }
                else
                {
                    reader.Close();
                }
            }
            dbConnect.Close();
            dbConnect.Dispose();
            dbConnect = null;
        }

        /// <summary>
        /// GET REASON LIST ITEMS
        /// </summary>
        /// <param name="getListMotif"></param>
        public static void dbGetListMotif(ListBox getListMotif)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            string dbQuery = "SELECT * FROM bts.motif";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbConnect;
            cmd.CommandText = dbQuery;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string motifName = reader[1].ToString();
                        getListMotif.Items.Add(motifName);
                    }
                }
                else
                {
                    reader.Close();
                }
            }
            dbConnect.Close();
            dbConnect.Dispose();
            dbConnect = null;
        }

        /// <summary>
        /// ADD EMPLOYEE TO DATABASE
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="affectation"></param>
        public static void dbAddListPersonnel(string name, string firstName, string tel, string mail, string affectation)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "INSERT INTO bts.personnel VALUES (@name, @firstname, @tel, @mail, @affectation)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                //ADD NEW EMPLOYEE
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName.ToUpper();
                cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
                cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@affectation", MySqlDbType.VarChar).Value = affectation;
                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                dbConnect.Close();
                dbConnect.Dispose();
                dbConnect = null;
            }
        }

        /// <summary>
        ///UPDATE EMPLOYEE INFORMATION WHEN ADD OR MODIF EMPLOYEE MENU
        /// </summary>
        /// <param name="currPersoInfo"></param>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="affectation"></param>
        public static void dbUpdatePerso(string[] currPersoInfo, string name, string firstName, string tel, string mail, string affectation)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "UPDATE bts.personnel SET name =@name, firstname =@firstname, tel =@tel, mail =@mail, affectation =@affectation WHERE name =@initName AND firstname =@initFirstName";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                //UPDATE EMPLOYEE PARAMS
                cmd.Parameters.Add("@initName", MySqlDbType.VarChar).Value = currPersoInfo[0];
                cmd.Parameters.Add("@initFirstName", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName.ToUpper();
                cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
                cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@affectation", MySqlDbType.VarChar).Value = affectation;
                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                dbConnect.Close();
                dbConnect.Dispose();
                dbConnect = null;
            }
        }

        /// <summary>
        ///GET CURRENT INFOS OF EMPLOYEE AND RETRIEVE THEM ON APP WHEN OPENING EMPLOYEE MODIF MENU
        /// </summary>
        /// <param name="currPersoInfo"></param>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="listAffectation"></param>
        public static void dbModifMenuShowInfo(string[] currPersoInfo, TextBox name, TextBox firstName, TextBox tel, TextBox mail, ListBox listAffectation)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            string dbQuery = "SELECT * FROM bts.personnel";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbConnect;
            cmd.CommandText = dbQuery;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == currPersoInfo[0].ToString())
                        {
                            name.Text = reader[0].ToString();
                            firstName.Text = reader[1].ToString();
                            tel.Text = reader[2].ToString();
                            mail.Text = reader[3].ToString();
                            int index = listAffectation.FindString(reader[4].ToString());
                            listAffectation.SetSelected(index, true);
                        }
                    }
                }
                else
                {
                    reader.Close();
                }
            }
            dbConnect.Close();
            dbConnect.Dispose();
            dbConnect = null;
        }

        /// <summary>
        ///SUPPRESS SELECTED EMPLOYEE
        /// </summary>
        /// <param name="currPersoInfo"></param>
        public static void dbSupprPerso(string[] currPersoInfo)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "DELETE FROM bts.personnel WHERE name = @name AND firstname =@firstName AND affectation =@affectation";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[0];
                cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@affectation", MySqlDbType.VarChar).Value = currPersoInfo[2];

                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                dbConnect.Close();
                dbConnect.Dispose();
                dbConnect = null;
            }
        }

        /// <summary>
        ///RETRIEVE ABSENCE LIST OF SELECTED EMPLOYEE
        /// </summary>
        /// <param name="currPerso"></param>
        /// <param name="listAbs"></param>
        public static void dbGetListAbs(string[] currPerso, ListBox listAbs)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            string dbQuery = "SELECT * FROM bts.absence";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbConnect;
            cmd.CommandText = dbQuery;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == currPerso[0].ToString() && reader[1].ToString() == currPerso[1])
                        {
                            string dateDeb = reader[2].ToString();
                            string dateFin = reader[3].ToString();
                            string motif = reader[4].ToString();
                            listAbs.Items.Add("Absent du " + dateDeb + " au " + dateFin + " au motif : " + motif);
                        }
                    }
                }
                else
                {
                    reader.Close();
                }
            }
            dbConnect.Close();
            dbConnect.Dispose();
            dbConnect = null;
        }

        /// <summary>
        ///ADD ABSENCE TO SELECTED EMPLOYEE
        /// </summary>
        /// <param name="currPersoInfo"></param>
        /// <param name="dateDeb"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public static void dbAbsAdd(string[] currPersoInfo, string dateDeb, string dateFin, string motif)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "INSERT INTO bts.absence VALUES (@name, @firstname, @dateDeb, @dateFin, @motif)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                //ADD ABSENCE PARAMS
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[0];
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@dateDeb", MySqlDbType.VarChar).Value = dateDeb;
                cmd.Parameters.Add("@dateFin", MySqlDbType.VarChar).Value = dateFin;
                cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = motif;
                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                dbConnect.Close();
                dbConnect.Dispose();
                dbConnect = null;
            }
        }

        /// <summary>
        ///UPDATE ABSENCE INFO OF SELECTED EMPLOYEE
        /// </summary>
        /// <param name="currPersoInfo"></param>
        /// <param name="initDateDeb"></param>
        /// <param name="initDateFin"></param>
        /// <param name="initMotif"></param>
        /// <param name="newDateDeb"></param>
        /// <param name="newDateFin"></param>
        /// <param name="newMotif"></param>
        public static void dbUpdateAbs(string[] currPersoInfo, string initDateDeb, string initDateFin, string initMotif, string newDateDeb, string newDateFin, string newMotif)
        {
            Console.WriteLine(currPersoInfo[0] + " " + currPersoInfo[1] + "Date :" + initDateDeb + "au" + initDateFin + "motif" + initMotif + "nouveau : " + newDateDeb + " " + newDateFin + " " + newMotif);
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "UPDATE bts.absence SET dateDeb =@newDateDeb, dateFin =@newDateFin, motif =@newMotif WHERE name =@name AND firstname =@firstname AND dateDeb = @dateDeb AND dateFin =@dateFin AND motif =@motif";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                //CONDITIONS PARAMS
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[0];
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@dateDeb", MySqlDbType.VarChar).Value = initDateDeb;
                cmd.Parameters.Add("@dateFin", MySqlDbType.VarChar).Value = initDateFin;
                cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = initMotif;
                //UPDATE PARAMS
                cmd.Parameters.Add("@newDateDeb", MySqlDbType.VarChar).Value = newDateDeb;
                cmd.Parameters.Add("@newDateFin", MySqlDbType.VarChar).Value = newDateFin;
                cmd.Parameters.Add("@newMotif", MySqlDbType.VarChar).Value = newMotif;
                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                dbConnect.Close();
                dbConnect.Dispose();
                dbConnect = null;
            }
        }

        /// <summary>
        ///SUPPR SELECTED ABSENCE OF SELECTED EMPLOYEE
        /// </summary>
        /// <param name="currPersoInfo"></param>
        /// <param name="currDateDeb"></param>
        /// <param name="currDateFin"></param>
        /// <param name="currMotif"></param>
        public static void dbSupprAbs(string[] currPersoInfo, string currDateDeb, string currDateFin, string currMotif)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "DELETE FROM bts.absence WHERE name =@name AND firstname =@firstname AND dateDeb =@dateDeb AND dateFin =@dateFin AND motif =@motif";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                //DELETE ALL ABSENCE ROW PARAMS
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[0];
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@dateDeb", MySqlDbType.VarChar).Value = currDateDeb;
                cmd.Parameters.Add("@dateFin", MySqlDbType.VarChar).Value = currDateFin;
                cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = currMotif;
                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                dbConnect.Close();
                dbConnect.Dispose();
                dbConnect = null;
            }
        }
    }
}
