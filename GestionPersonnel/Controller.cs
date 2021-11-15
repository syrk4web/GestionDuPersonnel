using System;
using System.Drawing;
using System.Windows.Forms;


namespace GestionPersonnelLogin
{
    public partial class Form1 : Form
    {
        
        //ON LOGIN MENU
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //If username or pwd is empty
            if (txtUsername.Text == "" || txtPassword.Text == "") loginError("Il existe un ou plusieurs champs du formulaire qui sont vides.", true);
            //if nothing empty, check if username and pwd exist in "responsable" table
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                //check from database and return bool if admin
                bool isAdmin = Model.dbCheckLogin(txtUsername.Text, txtPassword.Text);
                if (!isAdmin)loginError("L'username ou le password sont incorrects.", true);
                if (isAdmin)
                {
                    //load list and display menu
                    Model.dbGetListPersonnel(lstPersonnel);
                    Model.dbGetListServices(lstAffectation);
                    loginMenuDisplay(false);
                    mainMenuDisplay(true);
                }

            }

        }

        //LOGIN MODULES
        //display wanted error msg if something wrong when trying to log in
        private void loginError(string errMsg, bool isVisible)
        {
            lblLogError.ForeColor = Color.Red;
            lblLogError.Text = errMsg;
            lblLogError.Visible = isVisible;
        }

        //ON MAIN MENU

        //go to add employee menu
        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            titleAddorModif.Text = "AJOUTER UN EMPLOYE";
            clearAddModifTxtBox();
            mainMenuDisplay(false);
            addOrModifMenuDisplay(true);

        }

        //go to modif selected employee menu
        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            //can modif employee only if one exist or is selected
            if (lstPersonnel.SelectedIndex >= 0)
            {
                titleAddorModif.Text = "MODIFIER UN EMPLOYE";
                //get current employee info to be display on next menu
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", "");
                string[] currPersoInfo = currPersoStr.Split(' ');
                Model.dbModifMenuShowInfo(currPersoInfo, txtName, txtFirstName, txtTel, txtMail, lstAffectation);
                mainMenuDisplay(false);
                addOrModifMenuDisplay(true);
            }
            else
            {
                personnelError("Il faut sélectionner un membre du personnel pour pouvoir le modifier.", true);

            }
        }

        //go to absence menu of selected employee
        private void btnAbsPersonnel_Click(object sender, EventArgs e)
        {
            //can modif employee only if one exist or is selected
            if (lstPersonnel.SelectedIndex >= 0)
            {
                //get selected employee info
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", "");
                string[] currPersoInfo = lstPersonnel.SelectedItem.ToString().Replace(" :", "").Split(' ');
                //get absence list of selected employee
                Model.dbGetListAbs(currPersoInfo, lstAbs);
                //show name of current employee on absence menu
                lblAbsInfo.Text = currPersoStr;
                mainMenuDisplay(false);
                mainAbsMenuDisplay(true);
            }
            else
            {
                personnelError("Il faut sélectionner un membre du personnel pour afficher ses absences.", true);

            }

        }

        //go to suppress employee menu
        private void btnSupprPersonnel_Click(object sender, EventArgs e)
        {
            //check if employee is selected to go
            if (lstPersonnel.SelectedIndex >= 0)
            {
                //get and retrive employee info
                string currPersoStr = lstPersonnel.SelectedItem.ToString().Replace(" :", " ");
                lblSupprInfoPerso.Text = currPersoStr;
                mainMenuDisplay(false);
                supprMenuDisplay(true);
            }
            else
            {
                personnelError("Il faut sélectionner un membre du personnel pour le supprimer.", true);
            }
        }


        //MENU ADD OR MODIF EMPPLOYEE
        //some components are shared for add and modif employee features

        //go back to main menu without action
        private void btnBackAddModif_Click(object sender, EventArgs e)
        {
            addOrModifMenuDisplay(false);
            mainMenuDisplay(true);
        }

        //valid add or modif action and return to main menu
        private void btnValidAddModif_Click(object sender, EventArgs e)
        {
            //all txtbox and list item display have to be fill
            if (txtName.Text == "" || txtFirstName.Text == "" || txtTel.Text == "" || txtMail.Text == "" || lstAffectation.SelectedIndex < 0)
            {
                lblAddOrModifError.Text = "Un champ est manquant pour pouvoir effectuer cette action.";
                lblAddOrModifError.Visible = true;
                //stop execution
                return;
            }
            //if all is fill, check if we are adding or modifying employee with title display
            if (titleAddorModif.Text.Contains("AJOUTER")) Model.dbAddListPersonnel(txtName.Text, txtFirstName.Text, txtTel.Text, txtMail.Text, lstAffectation.SelectedItem.ToString());
            if (titleAddorModif.Text.Contains("MODIFIER"))
            {
                //get current employee info
                string[] currPersoInfo = lstPersonnel.SelectedItem.ToString().Split(' ');
                //use this with new info to update employee
                Model.dbUpdatePerso(currPersoInfo, txtName.Text, txtFirstName.Text, txtTel.Text, txtMail.Text, lstAffectation.SelectedItem.ToString());
            }

            //reload content and change menu
            reloadListPerso();
            addOrModifMenuDisplay(false);
            mainMenuDisplay(true);
        }

        //MENU SUPPR

        //go back to main menu without action
        private void btnAnnuleSuppr_Click(object sender, EventArgs e)
        {
            supprMenuDisplay(false);
            mainMenuDisplay(true);
        }

        //suppress selected employee
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            //get current employee and supress it on database
            string[] currPersoInfo = lstPersonnel.SelectedItem.ToString().Replace(" :", "").Split(' ');
            Model.dbSupprPerso(currPersoInfo);
            //reload content and change menu
            reloadListPerso();
            supprMenuDisplay(false);
            mainMenuDisplay(true);
        }

        //MAIN MENU AND EMPLOYEE MODULES

        //module that display error message on main personnel menu if needed
        private void personnelError(string errMsg, bool isVisible)
        {
            lblPersonnelError.Text = errMsg;
            lblPersonnelError.Visible = isVisible;
        }

        //module that reload list of employee after any change
        private void reloadListPerso()
        {
            lstPersonnel.Items.Clear();
            Model.dbGetListPersonnel(lstPersonnel);
        }

        //MAIN ABSENCE MENU

        //go back to main menu without action
        private void btnAbsBack_Click(object sender, EventArgs e)
        {
            mainAbsMenuDisplay(false);
            mainMenuDisplay(true);
        }

        //go to add absence menu
        private void btnAbsAdd_Click(object sender, EventArgs e)
        {
            titleAddModifAbs.Text = "AJOUTER UNE ABSENCE";
            mainAbsMenuDisplay(false);
            addModifAbsMenuDisplay(true);
        }

        //go to modif absence menu
        private void btnAbsModif_Click(object sender, EventArgs e)
        {
            //check if an absence item is selected
            if (lstAbs.SelectedIndex >= 0)
            {
                titleAddModifAbs.Text = "MODIFIER UNE ABSENCE";
                //get current data of selected employee
                string[] getInit = getInitDateMotif();
                string initDateDeb = getInit[0];
                string initDateFin = getInit[1];
                string initMotif = getInit[2];
                //display current data on fields
                dateDebAddModifAbs.Text = initDateDeb;
                dateFinAddModifAbs.Text = initDateFin;
                txtAddModifAbsMotif.Text = initMotif;
                mainAbsMenuDisplay(false);
                addModifAbsMenuDisplay(true);
            }
            else
            {
                errAbs("Il faut sélectionner une absence pour pouvoir la modifier.", true);
            }
        }

        //go to suppr absence menu
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

        //SUPPR ABSENCE MENU

        //suppress selected absence
        private void btnAbsSupprConfirm_Click(object sender, EventArgs e)
        {
            //get init absence info and selected employee
            string[] currPersoInfo = lblAbsInfo.Text.Split(' ');
            string[] getInit = getInitDateMotif();
            string initDateDeb = getInit[0];
            string initDateFin = getInit[1];
            string initMotif = getInit[2];
            //suppress on database
            Model.dbSupprAbs(currPersoInfo, initDateDeb, initDateFin, initMotif);
            //reload and change menu
            lstAbs.Items.Clear();
            Model.dbGetListAbs(currPersoInfo, lstAbs);
            supprAbsMenuDisplay(false);
            mainAbsMenuDisplay(true);
        }

        //go back to main absence menu without action
        private void btnAnnuleSupprAbs_Click(object sender, EventArgs e)
        {
            supprAbsMenuDisplay(false);
            mainAbsMenuDisplay(true);
        }

        //ADD OR MODIF ABSENCE MENU
        //add and modif absence share some components
      
        //add or modif absence action
        private void btnAddModifAbs_Click(object sender, EventArgs e)
        {
            //get curr employee info
            string[] currPersoInfo = lblAbsInfo.Text.Split(' ');
            //add case
            if (titleAddModifAbs.Text.Contains("AJOUTER")) Model.dbAbsAdd(currPersoInfo, dateDebAddModifAbs.Text, dateFinAddModifAbs.Text, txtAddModifAbsMotif.Text);
            //modif case
            if (titleAddModifAbs.Text.Contains("MODIFIER") && lstAbs.SelectedIndex >= 0)
            {
                //get initData
                string[] getInit = getInitDateMotif();
                string initDateDeb = getInit[0];
                string initDateFin = getInit[1];
                string initMotif = getInit[2];
                //put initData and newData with logic to change on database
                Model.dbUpdateAbs(currPersoInfo, initDateDeb, initDateFin, initMotif, dateDebAddModifAbs.Text, dateFinAddModifAbs.Text, txtAddModifAbsMotif.Text);
            }
            //in all cases, we want to reload and go back
            lstAbs.Items.Clear();
            Model.dbGetListAbs(currPersoInfo, lstAbs);
            addModifAbsMenuDisplay(false);
            mainAbsMenuDisplay(true);
        }



        private void btnAnnuleAddModifAbs_Click(object sender, EventArgs e)
        {
            addModifAbsMenuDisplay(false);
            mainAbsMenuDisplay(true);
        }

        //MODULES ABSENCE MENU

        //modules that allow to get dates and textInfo about absence as array to work with
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

        //module that display wanted error msg about absence menu
        private void errAbs(string errMsg, bool isVisible)
        {
            lblAbsError.Text = errMsg;
            lblAbsError.Visible = isVisible;
        }
    }
}
