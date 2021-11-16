using System.Windows.Forms;

namespace GestionPersonnelLogin
{
    /// <summary>
    /// NECESSSARY COMPONENTS FOR APP
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        ///LOGIN MENU VIEW COMPONENTS
        /// </summary>
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
        /// <summary>
        ///MAIN MENU VIEW COMPONENTS
        /// </summary>
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
        /// <summary>
        ///MAIN ABSENCE MENU VIEW COMPONENTS
        /// </summary>
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
        /// <summary>
        ///ADD OR MODIF EMPLOYEE MENU VIEW COMPONENTS
        /// </summary>
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
        /// <summary>
        ///CLEAR TXTBOX AND SELECTED ITEM OF ADD OR MODIF EMPLOYEE VIEW COMPONENTS
        /// </summary>
        public void clearAddModifTxtBox()
        {
            txtName.Text = "";
            txtFirstName.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            lstAffectation.ClearSelected();
        }
        /// <summary>
        ///SUPRESS EMPLOYEE MENU VIEW COMPONENTS
        /// </summary>
        public void supprMenuDisplay(bool isShow)
        {
            titleSupprPersonnel.Visible = isShow;
            lblSupprInfoPerso.Visible = isShow;
            lblSupprPersonnel.Visible = isShow;
            btnSuppr.Visible = isShow;
            btnAnnuleSuppr.Visible = isShow;
        }
        /// <summary>
        ///ADD OR MODIF ABSENCE OF EMPLOYEE MENU VIEW COMPONENTS
        /// </summary>
        public void addModifAbsMenuDisplay(bool isShow)
        {
            titleAddModifAbs.Visible = isShow;
            dateDebAddModifAbs.Visible = isShow;
            dateFinAddModifAbs.Visible = isShow;
            lblAddModifAbsDateDeb.Visible = isShow;
            lblAddModifAbsDateFin.Visible = isShow;
            lblAddModifAbsMotif.Visible = isShow;
            lstMotif.Visible = isShow;
            btnAddModifAbs.Visible = isShow;
            btnAnnuleAddModifAbs.Visible = isShow;
        }
        /// <summary>
        ///SUPPR ABSENCE OF EMPLOYEE MENU VIEW COMPONENTS
        /// </summary>
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