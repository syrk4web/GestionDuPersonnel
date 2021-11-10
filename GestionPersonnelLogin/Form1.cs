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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        /// MYSQL 
        class DBMySQLUtils
        {
            public static MySqlConnection getDBConnection()
            {
                // Connection String.
                string connString = "Server=127.0.0.1;Database=bts;port=3306;User Id=root;password=******";
                MySqlConnection dbConnect = new MySqlConnection(connString);

                return dbConnect;
            }

            ///SHOW PERSONNEL WHEN APP INIT
            public static void dbGetListPersonnel(ListBox getListPersonnel)
            {
                MySqlConnection dbConnect = DBMySQLUtils.getDBConnection();
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
                MySqlConnection dbConnect = DBMySQLUtils.getDBConnection();
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
                MySqlConnection dbConnect = DBMySQLUtils.getDBConnection();
                dbConnect.Open();
                try
                {
                    string dbQuery = "INSERT INTO bts.personnel VALUES (@personnel_id, @personnel_name, @personnel_firstname, @personnel_tel, @personnel_mail, @personnel_affectation)";
                    // Création objet de commande
                    MySqlCommand cmd = new MySqlCommand();
                    //Connexion de la commande.
                    cmd.Connection = dbConnect;
                    cmd.CommandText = dbQuery;
                    int getID = listPersonnel.Items.Count + 1;
                    ///Add new employee
                    cmd.Parameters.Add("@personnel_id", MySqlDbType.Int32).Value = getID;
                    cmd.Parameters.Add("@personnel_name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@personnel_firstname", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@personnel_tel", MySqlDbType.VarChar).Value = tel;
                    cmd.Parameters.Add("@personnel_mail", MySqlDbType.VarChar).Value = mail;
                    cmd.Parameters.Add("@personnel_affectation", MySqlDbType.VarChar).Value = affectation;
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
                MySqlConnection dbConnect = DBMySQLUtils.getDBConnection();
                dbConnect.Open();
                try
                {
                    string dbQuery = "UPDATE bts.personnel SET personnel_id =@id, personnel_name =@name, personnel_firstname =@firstname, personnel_tel =@tel, personnel_mail =@mail, personnel_affectation =@affectation WHERE personnel_id =@id";
                    // Création objet de commande
                    MySqlCommand cmd = new MySqlCommand();
                    //Connexion de la commande.
                    cmd.Connection = dbConnect;
                    cmd.CommandText = dbQuery;
                    ///Modify employee
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = currPersoInfo[0];
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName;
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
                MySqlConnection dbConnect = DBMySQLUtils.getDBConnection();
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
                            if(reader[0].ToString() == currPersoInfo[0].ToString())
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
        }

        /// LOADING APP
        private void Form1_Load(object sender, EventArgs e)
        {
            DBMySQLUtils.dbGetListPersonnel(lstPersonnel);
            DBMySQLUtils.dbGetListServices(lstAffectation);
        }

        ///LOGIN MENU

        /// vérifie si le formulaire est valide
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ///cas où un champ n'est pas rempli
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblLogError.ForeColor = Color.Red;
                lblLogError.Text = "Il existe un ou plusieurs champs du formulaire qui sont vides.";
                lblLogError.Visible = true;
            }
            ///cas où les informations ne sont pas valides avec la base de donnée
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                loginMenuDisplay(false);
                mainMenuDisplay(true);

            }
            
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
           if(lstPersonnel.SelectedIndex >= 0) {
             mainMenuDisplay(false);
                titleAddorModif.Text = "MODIFIER UN EMPLOYE";
                ///REMPLIR LES CHAMPS AVEC LES DONNES DE LA DATABASE
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", "");
                string[] currPersoInfo = currPersoStr.Split(' ');
                DBMySQLUtils.dbModifMenuShowInfo(currPersoInfo, txtName, txtFirstName, txtTel, txtMail, lstAffectation);
                addOrModifMenuDisplay(true);
           } else
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
                mainAbsMenuDisplay(true);
            }
            else
            {
                lblPersonnelError.Text = "Il faut sélectionner un membre du personnel pour afficher ses absences.";
                lblPersonnelError.Visible = true;

            }

        }

        private void btnSupprPersonnel_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex >= 0)
            {
                ///CREER LE MENU SUPPRESSION DU PERSONNEL
            }
            else
            {
                lblPersonnelError.Text = "Il faut sélectionner un membre du personnel pour le supprimer.";
                lblPersonnelError.Visible = true;
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
            if(txtName.Text == "" || txtFirstName.Text == "" || txtTel.Text == "" || txtMail.Text == "" || lstAffectation.SelectedIndex < 0)
             {
                lblAddOrModifError.Text = "Un champ est manquant pour pouvoir effectuer cette action.";
                lblAddOrModifError.Visible = true;
                return ;
            }
            ///dans le cas contraire, on ajoute ou modifie selon le bouton qu'on avait appuyé
            ///et le titre indiqué
            if (titleAddorModif.Text.Contains("AJOUTER"))
            {
                
                DBMySQLUtils.dbAddListPersonnel(lstPersonnel, txtName.Text, txtFirstName.Text, txtTel.Text, txtMail.Text, lstAffectation.SelectedItem.ToString());
            }

            if (titleAddorModif.Text.Contains("MODIFIER"))
            {
                ///get les infos de l'employé actuel que l'on veut modifier
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", "");
                string[] currPersoInfo = currPersoStr.Split(' ');
                ///on utilise les infos comme conditions pour la db
                DBMySQLUtils.dbUpdateListPersonnel(currPersoInfo, txtName.Text, txtFirstName.Text, txtTel.Text, txtMail.Text, lstAffectation.SelectedItem.ToString());
            }

            lstPersonnel.Items.Clear();
            DBMySQLUtils.dbGetListPersonnel(lstPersonnel);
            addOrModifMenuDisplay(false);
            mainMenuDisplay(true);
            return;

        }  
      
        ///MAIN ABSENCE MENU
        private void btnAbsBack_Click(object sender, EventArgs e)
        {
            mainAbsMenuDisplay(false);
            mainMenuDisplay(true);
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
    }
}
