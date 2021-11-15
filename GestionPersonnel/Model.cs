using System;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace GestionPersonnelLogin
{
    //IT IS DATABASE LOGIC WHEN LOADING OR RECEIVING A REQUEST FROM USER
    class Model
    {
        //UTILS ALLOWING CONNECTION TO DATABASE
        public static MySqlConnection getDBConnection()
        {
            // Connection String.
            string connString = "Server=127.0.0.1;Database=bts;port=3306;User Id=root;password=*****";
            MySqlConnection dbConnect = new MySqlConnection(connString);

            return dbConnect;
        }

        //CHECK USERNAME AND PWD INFO TO GET ACCESS OR NOT TO APP, RETURN BOOL
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


        //GET ALL EMPLOYEE LIST WHEN LOG IN OR ANY CHANGE
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

        //GET SERVICES OF FIRM TO PUT EMPLOYEE ON ONE OF THEM
        public static void dbGetListServices(ListBox getListServices)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            string dbQuery = "SELECT * FROM bts.services";
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

        //ADD EMPLOYEE
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

        //UPDATE EMPLOYEE INFORMATION WHEN ON ADD OR MODIF EMPLOYEE MENU
        public static void dbUpdatePerso(string[] currPersoInfo, string name, string firstName, string tel, string mail, string affectation)
        {
            Console.WriteLine(currPersoInfo[0], currPersoInfo[1], currPersoInfo[2], currPersoInfo[3]);
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

        //GET CURRENT INFOS OF EMPLOYEE AND RETRIEVE THEM ON APP WHEN OPENING EMPLOYEE MODIF MENU
        public static void dbModifMenuShowInfo(string[] currPersoInfo, TextBox name, TextBox firstname, TextBox tel, TextBox mail, ListBox listAffectation)
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
                            firstname.Text = reader[1].ToString();
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

        //SUPPRESS SELECTED EMPLOYEE
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

        //RETRIEVE ABSENCE LIST OF SELECTED EMPLOYEE
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
                        if (reader[0].ToString() == currPerso[2].ToString() && reader[1].ToString() == currPerso[1])
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

        //ADD ABSENCE TO SELECTED EMPLOYEE
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
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[2];
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

        //UPDATE ABSENCE INFO OF SELECTED EMPLOYEE
        public static void dbUpdateAbs(string[] currPersoInfo, string initDateDeb, string initDateFin, string initMotif, string newDateDeb, string newDateFin, string newMotif)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "UPDATE bts.absence SET dateDeb =@newDateDeb, dateFin =@newDateFin, motif =@newMotif WHERE name =@name AND firstname =@firstname AND dateDeb = @dateDeb AND dateFin =@dateFin AND motif =@motif";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                //CONDITIONS PARAMS
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[2];
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

        //SUPPR SELECTED ABSENCE OF SELECTED EMPLOYEE
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
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[2];
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
