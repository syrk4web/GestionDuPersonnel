using System.Windows.Forms;


namespace GestionPersonnelLogin
{
    public partial class Form1 : Form
    {

        //LOGIN MENU VIEW COMPONENTS
        public void loginMenuDisplay(bool isShow)
        {
            titlelogin.Visible = isShow;
            btnLogin.Visible = isShow;
            lblLogError.Visible = isShow;
            lblUsername.Visible = isShow;
            txtUsername.Visible = isShow;
            lblPassword.Visible = isShow;
            txtPassword.Visible = isShow;
        }

        //MAIN MENU VIEW COMPONENTS
        public void mainMenuDisplay(bool isShow)
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

        //MAIN ABSENCE MENU VIEW COMPONENTS
        public void mainAbsMenuDisplay(bool isShow)
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

        //ADD OR MODIF EMPLOYEE MENU VIEW COMPONENTS
        public void addOrModifMenuDisplay(bool isShow)
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

        //CLEAR TXTBOX AND SELECTED ITEM OF ADD OR MODIF EMPLOYEE VIEW COMPONENTS
        public void clearAddModifTxtBox()
        {
            txtName.Text = "";
            txtFirstName.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            lstAffectation.ClearSelected();
        }


        //SUPRESS EMPLOYEE MENU VIEW COMPONENTS
        public void supprMenuDisplay(bool isShow)
        {
            titleSupprPersonnel.Visible = isShow;
            lblSupprInfoPerso.Visible = isShow;
            lblSupprPersonnel.Visible = isShow;
            btnSuppr.Visible = isShow;
            btnAnnuleSuppr.Visible = isShow;
        }

        //ADD OR MODIF ABSENCE OF EMPLOYEE MENU VIEW COMPONENTS
        public void addModifAbsMenuDisplay(bool isShow)
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

        //SUPPR ABSENCE OF EMPLOYEE MENU VIEW COMPONENTS
        public void supprAbsMenuDisplay(bool isShow)
        {
            titleAbsSuppr.Visible = isShow;
            lblAbsSuppr.Visible = isShow;
            lblAbsSupprInfo.Visible = isShow;
            btnAnnuleSupprAbs.Visible = isShow;
            btnAbsSupprConfirm.Visible = isShow;
        }
    }
}
