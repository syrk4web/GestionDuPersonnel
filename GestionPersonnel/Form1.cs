using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace GestionPersonnelLogin
{
    class Model
    {
        public static MySqlConnection getDBConnection()
        {
            // Connection String.
            string connString = "Server=127.0.0.1;Database=bts;port=3306;User Id=root;password=*****";
            MySqlConnection dbConnect = new MySqlConnection(connString);

            return dbConnect;
        }

        //CHECK LOGIN INFO
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


        ///SHOW PERSONNEL WHEN APP INIT
        public static void dbGetListPersonnel(ListBox getListPersonnel)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            ///INSTRUCTIONS APRES DB CONNEXION
            ///création query
            string dbQuery = "SELECT * FROM bts.personnel";
            // Création objet de commande
            MySqlCommand cmd = new MySqlCommand();
            //Connexion de la commande.
            cmd.Connection = dbConnect;
            cmd.CommandText = dbQuery;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader[0].ToString();
                        string name = reader[1].ToString();
                        string firstName = reader[2].ToString();
                        string service = reader[5].ToString();
                        getListPersonnel.Items.Add(id + " : " + name + " " + firstName + " : " + service);

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

        public static void dbGetListServices(ListBox getListServices)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            string dbQuery = "SELECT * FROM bts.services";
            // Création objet de commande
            MySqlCommand cmd = new MySqlCommand();
            //Connexion de la commande.
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

        ///ADD PERSONNEL
        public static void dbAddListPersonnel(ListBox listPersonnel, string name, string firstName, string tel, string mail, string affectation)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "INSERT INTO bts.personnel VALUES (@id, @name, @firstname, @tel, @mail, @affectation)";
                // Création objet de commande
                MySqlCommand cmd = new MySqlCommand();
                //Connexion de la commande.
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                int getID = listPersonnel.Items.Count + 1;
                ///Add new employee
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = getID;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName.ToUpper();
                cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
                cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@affectation", MySqlDbType.VarChar).Value = affectation;
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
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

        public static void dbUpdateListPersonnel(string[] currPersoInfo, string name, string firstName, string tel, string mail, string affectation)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "UPDATE bts.personnel SET id =@id, name =@name, firstname =@firstname, tel =@tel, mail =@mail, affectation =@affectation WHERE id =@id";
                // Création objet de commande
                MySqlCommand cmd = new MySqlCommand();
                //Connexion de la commande.
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                ///Modify employee
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = currPersoInfo[0];
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName.ToUpper();
                cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
                cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@affectation", MySqlDbType.VarChar).Value = affectation;
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
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

        public static void dbModifMenuShowInfo(string[] currPersoInfo, TextBox name, TextBox firstname, TextBox tel, TextBox mail, ListBox listAffectation)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();

            string dbQuery = "SELECT * FROM bts.personnel";
            // Création objet de commande
            MySqlCommand cmd = new MySqlCommand();
            //Connexion de la commande.
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

                            name.Text = reader[1].ToString();
                            firstname.Text = reader[2].ToString();
                            tel.Text = reader[3].ToString();
                            mail.Text = reader[4].ToString();
                            int index = listAffectation.FindString(reader[5].ToString());
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

        public static void dbSupprPerso(string[] currPersoInfo)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {

                string dbQuery = "DELETE FROM bts.personnel WHERE id =@id";
                // Création objet de commande
                MySqlCommand cmd = new MySqlCommand();
                //Connexion de la commande.
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = currPersoInfo[0];
                int rowCount = cmd.ExecuteNonQuery();
                Console.WriteLine("Row Count affected = " + rowCount);
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

        public static void dbGetListAbs(string[] currPerso, ListBox listAbs)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            ///INSTRUCTIONS APRES DB CONNEXION
            ///création query
            string dbQuery = "SELECT * FROM bts.absence";
            // Création objet de commande
            MySqlCommand cmd = new MySqlCommand();
            //Connexion de la commande.
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

        public static void dbAbsAdd(string[] currPersoInfo, string dateDeb, string dateFin, string motif)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "INSERT INTO bts.absence VALUES (@name, @firstname, @dateDeb, @dateFin, @motif)";
                // Création objet de commande
                MySqlCommand cmd = new MySqlCommand();
                //Connexion de la commande.
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                ///Add new employee
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[2];
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@dateDeb", MySqlDbType.VarChar).Value = dateDeb;
                cmd.Parameters.Add("@dateFin", MySqlDbType.VarChar).Value = dateFin;
                cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = motif;

                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
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

        public static void dbUpdateAbs(string[] currPersoInfo, string initDateDeb, string initDateFin, string initMotif, string newDateDeb, string newDateFin, string newMotif)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "UPDATE bts.absence SET dateDeb =@newDateDeb, dateFin =@newDateFin, motif =@newMotif WHERE name =@name AND firstname =@firstname AND dateDeb = @dateDeb AND dateFin =@dateFin AND motif =@motif";
                // Création objet de commande
                MySqlCommand cmd = new MySqlCommand();
                //Connexion de la commande.
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                //WHERE params
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[2];
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@dateDeb", MySqlDbType.VarChar).Value = initDateDeb;
                cmd.Parameters.Add("@dateFin", MySqlDbType.VarChar).Value = initDateFin;
                cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = initMotif;
                //NEW PARAMS
                cmd.Parameters.Add("@newDateDeb", MySqlDbType.VarChar).Value = newDateDeb;
                cmd.Parameters.Add("@newDateFin", MySqlDbType.VarChar).Value = newDateFin;
                cmd.Parameters.Add("@newMotif", MySqlDbType.VarChar).Value = newMotif;

                //DB EXECUTION LOGIC
                int rowCount = cmd.ExecuteNonQuery();
                Console.WriteLine("Row Count affected = " + rowCount);
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

        public static void dbSupprAbs(string[] currPersoInfo, string currDateDeb, string currDateFin, string currMotif)
        {
            MySqlConnection dbConnect = Model.getDBConnection();
            dbConnect.Open();
            try
            {
                string dbQuery = "DELETE FROM bts.absence WHERE name =@name AND firstname =@firstname AND dateDeb =@dateDeb AND dateFin =@dateFin AND motif =@motif";
                // Création objet de commande
                MySqlCommand cmd = new MySqlCommand();
                //Connexion de la commande.
                cmd.Connection = dbConnect;
                cmd.CommandText = dbQuery;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = currPersoInfo[2];
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = currPersoInfo[1];
                cmd.Parameters.Add("@dateDeb", MySqlDbType.VarChar).Value = currDateDeb;
                cmd.Parameters.Add("@dateFin", MySqlDbType.VarChar).Value = currDateFin;
                cmd.Parameters.Add("@motif", MySqlDbType.VarChar).Value = currMotif;
                int rowCount = cmd.ExecuteNonQuery();
                Console.WriteLine("Row Count affected = " + rowCount);
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

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        /// MYSQL 

        /// LOADING APP
        private void Form1_Load(object sender, EventArgs e)
        {
            Model.dbGetListPersonnel(lstPersonnel);
            Model.dbGetListServices(lstAffectation);
        }

        ///LOGIN MENU

        /// vérifie si le formulaire est valide
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ///cas où un champ n'est pas rempli
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                loginError("Il existe un ou plusieurs champs du formulaire qui sont vides.", true);

            }
            ///cas où les informations ne sont pas valides avec la base de donnée
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                bool isAdmin = Model.dbCheckLogin(txtUsername.Text, txtPassword.Text);
                if (!isAdmin)
                {
                    loginError("L'username ou le password sont incorrects.", true);
                }

                if (isAdmin)
                {
                    loginMenuDisplay(false);
                    mainMenuDisplay(true);
                }

            }

        }

        private void loginError(string errMsg, bool isVisible)
        {
            lblLogError.ForeColor = Color.Red;
            lblLogError.Text = errMsg;
            lblLogError.Visible = isVisible;
        }

        ///MAIN MENU       
        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            mainMenuDisplay(false);
            titleAddorModif.Text = "AJOUTER UN EMPLOYE";
            clearAddModifTxtBox();
            addOrModifMenuDisplay(true);

        }

        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex >= 0)
            {
                mainMenuDisplay(false);
                titleAddorModif.Text = "MODIFIER UN EMPLOYE";
                ///REMPLIR LES CHAMPS AVEC LES DONNES DE LA DATABASE
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", "");
                string[] currPersoInfo = currPersoStr.Split(' ');
                Model.dbModifMenuShowInfo(currPersoInfo, txtName, txtFirstName, txtTel, txtMail, lstAffectation);
                addOrModifMenuDisplay(true);
            }
            else
            {
                lblPersonnelError.Text = "Il faut sélectionner un membre du personnel pour pouvoir le modifier.";
                lblPersonnelError.Visible = true;

            }
        }

        private void btnAbsPersonnel_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex >= 0)
            {
                mainMenuDisplay(false);
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", "");
                string[] currPersoInfo = currPersoStr.Split(' ');
                Model.dbGetListAbs(currPersoInfo, lstAbs);
                lblAbsInfo.Text = currPersoStr;
                mainAbsMenuDisplay(true);
            }
            else
            {
                personnelError("Il faut sélectionner un membre du personnel pour afficher ses absences.", true);

            }

        }

        private void personnelError(string errMsg, bool isVisible)
        {
            lblPersonnelError.Text = errMsg;
            lblPersonnelError.Visible = isVisible;
        }

        private void btnSupprPersonnel_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex >= 0)
            {
                mainMenuDisplay(false);
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", " ");
                lblSupprInfoPerso.Text = currPersoStr;
                supprMenuDisplay(true);
            }
            else
            {
                personnelError("Il faut sélectionner un membre du personnel pour le supprimer.", true);
            }
        }


        ///MENU ADD OR MODIFY
        private void btnBackAddModif_Click(object sender, EventArgs e)
        {
            addOrModifMenuDisplay(false);
            mainMenuDisplay(true);
        }

        private void btnValidAddModif_Click(object sender, EventArgs e)
        {
            ///envoie erreur s'il manque un champ ou pas d'affection
            if (txtName.Text == "" || txtFirstName.Text == "" || txtTel.Text == "" || txtMail.Text == "" || lstAffectation.SelectedIndex < 0)
            {
                lblAddOrModifError.Text = "Un champ est manquant pour pouvoir effectuer cette action.";
                lblAddOrModifError.Visible = true;
                return;
            }
            ///dans le cas contraire, on ajoute ou modifie selon le bouton qu'on avait appuyé
            ///et le titre indiqué
            if (titleAddorModif.Text.Contains("AJOUTER"))
            {
                Model.dbAddListPersonnel(lstPersonnel, txtName.Text, txtFirstName.Text, txtTel.Text, txtMail.Text, lstAffectation.SelectedItem.ToString());


            }

            if (titleAddorModif.Text.Contains("MODIFIER"))
            {
                ///get les infos de l'employé actuel que l'on veut modifier
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", "");
                string[] currPersoInfo = currPersoStr.Split(' ');
                ///on utilise les infos comme conditions pour la db
                Model.dbUpdateListPersonnel(currPersoInfo, txtName.Text, txtFirstName.Text, txtTel.Text, txtMail.Text, lstAffectation.SelectedItem.ToString());
            }

            lstPersonnel.Items.Clear();
            Model.dbGetListPersonnel(lstPersonnel);
            addOrModifMenuDisplay(false);
            mainMenuDisplay(true);
            return;

        }

        ///MENU SUPPR
        private void btnAnnuleSuppr_Click(object sender, EventArgs e)
        {
            supprMenuDisplay(false);
            mainMenuDisplay(true);
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            string[] currPersoInfo = lstPersonnel.SelectedItem.ToString().Replace(" :", "").Split(' ');
            Model.dbSupprPerso(currPersoInfo);
            lstPersonnel.Items.Clear();
            Model.dbGetListPersonnel(lstPersonnel);
            supprMenuDisplay(false);
            mainMenuDisplay(true);
        }

        ///MAIN ABSENCE MENU
        private void btnAbsBack_Click(object sender, EventArgs e)
        {
            mainAbsMenuDisplay(false);
            mainMenuDisplay(true);
        }

        private void btnAbsAdd_Click(object sender, EventArgs e)
        {
            mainAbsMenuDisplay(false);
            titleAddModifAbs.Text = "AJOUTER UNE ABSENCE";
            addModifAbsMenuDisplay(true);
        }


        private void btnAbsModif_Click(object sender, EventArgs e)
        {
            if (lstAbs.SelectedIndex >= 0)
            {
                mainAbsMenuDisplay(false);
                titleAddModifAbs.Text = "MODIFIER UNE ABSENCE";
                ///On enlève les éléments inutiles à la récupération de l'absence à modifier en leur donnant la valeur 1
                string[] getInit = getInitDateMotif();
                string initDateDeb = getInit[0];
                string initDateFin = getInit[1];
                string initMotif = getInit[2];
                ///On ajoute les données au menu modification d'absence
                dateDebAddModifAbs.Text = initDateDeb;
                dateFinAddModifAbs.Text = initDateFin;
                txtAddModifAbsMotif.Text = initMotif;
                addModifAbsMenuDisplay(true);
            }
            else
            {
                errAbs("Il faut sélectionner une absence pour pouvoir la modifier.", true);
            }

        }

        private void btnAbsSuppr_Click(object sender, EventArgs e)
        {
            if (lstAbs.SelectedIndex >= 0)
            {
                mainAbsMenuDisplay(false);
                supprAbsMenuDisplay(true);
            }
            else
            {
                errAbs("Il faut sélectionner une absence pour pouvoir la supprimer.", true);
            }

        }

        private void errAbs(string errMsg, bool isVisible)
        {
            lblAbsError.Text = errMsg;
            lblAbsError.Visible = isVisible;
        }

        ///SUPPR ABSENCE MENU


        private void btnAbsSupprConfirm_Click(object sender, EventArgs e)
        {
            string[] currPersoInfo = lblAbsInfo.Text.Split(' ');
            string[] getInit = getInitDateMotif();
            string initDateDeb = getInit[0];
            string initDateFin = getInit[1];
            string initMotif = getInit[2];

            Model.dbSupprAbs(currPersoInfo, initDateDeb, initDateFin, initMotif);
            supprAbsMenuDisplay(false);
            lstAbs.Items.Clear();
            Model.dbGetListAbs(currPersoInfo, lstAbs);
            mainAbsMenuDisplay(true);
        }

        private void btnAnnuleSupprAbs_Click(object sender, EventArgs e)
        {
            supprAbsMenuDisplay(false);
            mainAbsMenuDisplay(true);
        }
        ///ADD OR MODIF ABSENCE MENU
        private void btnAddModifAbs_Click(object sender, EventArgs e)
        {
            string[] currPersoInfo = lblAbsInfo.Text.Split(' ');

            if (titleAddModifAbs.Text.Contains("AJOUTER"))
            {
                Model.dbAbsAdd(currPersoInfo, dateDebAddModifAbs.Text, dateFinAddModifAbs.Text, txtAddModifAbsMotif.Text);
            }

            if (titleAddModifAbs.Text.Contains("MODIFIER") && lstAbs.SelectedIndex >= 0)
            {
                string[] getInit = getInitDateMotif();
                string initDateDeb = getInit[0];
                string initDateFin = getInit[1];
                string initMotif = getInit[2];

                Model.dbUpdateAbs(currPersoInfo, initDateDeb, initDateFin, initMotif, dateDebAddModifAbs.Text, dateFinAddModifAbs.Text, txtAddModifAbsMotif.Text);
            }

            lstAbs.Items.Clear();
            Model.dbGetListAbs(currPersoInfo, lstAbs);
            addModifAbsMenuDisplay(false);
            mainAbsMenuDisplay(true);



        }

        string[] getInitDateMotif()
        {
            string[] absInfo = lstAbs.SelectedItem.ToString().Replace("Absent du", "").Replace("au motif :", "").Replace("au", "").Trim().Split(' ');
            string initDateDeb = "";
            string initDateFin = "";
            string initMotif = "";
            for (int i = 0; i < absInfo.Length; i++)
            {
                if (i == 0) initDateDeb += absInfo[i].ToString();
                if (i == 2) initDateFin += absInfo[i].ToString();
                if (i >= 4) initMotif += absInfo[i].ToString();
            }
            string[] getValues = new string[3] { initDateDeb, initDateFin, initMotif };
            return getValues;
        }

        private void btnAnnuleAddModifAbs_Click(object sender, EventArgs e)
        {
            addModifAbsMenuDisplay(false);
            mainAbsMenuDisplay(true);
        }


        ///MODULES

        ///SHOW OR HIDE MENU MODULES
        private void loginMenuDisplay(bool isShow)
        {
            titlelogin.Visible = isShow;
            btnLogin.Visible = isShow;
            lblLogError.Visible = isShow;
            lblUsername.Visible = isShow;
            txtUsername.Visible = isShow;
            lblPassword.Visible = isShow;
            txtPassword.Visible = isShow;
        }

        private void mainMenuDisplay(bool isShow)
        {
            lblListePersonnel.Visible = isShow;
            titleDashboard.Visible = isShow;
            lstPersonnel.Visible = isShow;
            lblActions.Visible = isShow;
            btnAddPersonnel.Visible = isShow;
            btnModifPersonnel.Visible = isShow;
            btnAbsPersonnel.Visible = isShow;
            btnSupprPersonnel.Visible = isShow;
            lblPersonnelError.Visible = false;
        }

        private void mainAbsMenuDisplay(bool isShow)
        {
            titleAbs.Visible = isShow;
            lblAbsEmployeID.Visible = isShow;
            lblListeAbs.Visible = isShow;
            lstAbs.Visible = isShow;
            lblAbsActions.Visible = isShow;
            btnAbsAdd.Visible = isShow;
            btnAbsModif.Visible = isShow;
            btnAbsSuppr.Visible = isShow;
            btnAbsBack.Visible = isShow;
            lblAbsInfo.Visible = isShow;
            lblAbsError.Visible = false;
        }

        private void addOrModifMenuDisplay(bool isShow)
        {
            titleAddorModif.Visible = isShow;
            lblName.Visible = isShow;
            txtName.Visible = isShow;
            lblFirstName.Visible = isShow;
            txtFirstName.Visible = isShow;
            lblTel.Visible = isShow;
            txtTel.Visible = isShow;
            lblMail.Visible = isShow;
            txtMail.Visible = isShow;
            lblAffectation.Visible = isShow;
            lstAffectation.Visible = isShow;
            btnAnnuleAddOrModif.Visible = isShow;
            btnAddModif.Visible = isShow;
            lblAddOrModifError.Visible = false;

        }

        private void clearAddModifTxtBox()
        {
            txtName.Text = "";
            txtFirstName.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            lstAffectation.ClearSelected();
        }

        private void supprMenuDisplay(bool isShow)
        {
            titleSupprPersonnel.Visible = isShow;
            lblSupprInfoPerso.Visible = isShow;
            lblSupprPersonnel.Visible = isShow;
            btnSuppr.Visible = isShow;
            btnAnnuleSuppr.Visible = isShow;
        }

        private void addModifAbsMenuDisplay(bool isShow)
        {
            titleAddModifAbs.Visible = isShow;
            dateDebAddModifAbs.Visible = isShow;
            dateFinAddModifAbs.Visible = isShow;
            lblAddModifAbsDateDeb.Visible = isShow;
            lblAddModifAbsDateFin.Visible = isShow;
            lblAddModifAbsMotif.Visible = isShow;
            txtAddModifAbsMotif.Visible = isShow;
            btnAddModifAbs.Visible = isShow;
            btnAnnuleAddModifAbs.Visible = isShow;
        }

        private void supprAbsMenuDisplay(bool isShow)
        {
            titleAbsSuppr.Visible = isShow;
            lblAbsSuppr.Visible = isShow;
            lblAbsSupprInfo.Visible = isShow;
            btnAnnuleSupprAbs.Visible = isShow;
            btnAbsSupprConfirm.Visible = isShow;
        }

    }
}
