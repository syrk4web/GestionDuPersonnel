
namespace GestionPersonnelLogin
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlelogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogError = new System.Windows.Forms.Label();
            this.lblListePersonnel = new System.Windows.Forms.Label();
            this.titleDashboard = new System.Windows.Forms.Label();
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.lblActions = new System.Windows.Forms.Label();
            this.btnAddPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnAbsPersonnel = new System.Windows.Forms.Button();
            this.btnSupprPersonnel = new System.Windows.Forms.Button();
            this.titleAddorModif = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lstAffectation = new System.Windows.Forms.ListBox();
            this.btnAnnuleAddOrModif = new System.Windows.Forms.Button();
            this.btnAddModif = new System.Windows.Forms.Button();
            this.lblAddOrModifError = new System.Windows.Forms.Label();
            this.titleAbs = new System.Windows.Forms.Label();
            this.lblAbsEmployeID = new System.Windows.Forms.Label();
            this.lblListeAbs = new System.Windows.Forms.Label();
            this.lstAbs = new System.Windows.Forms.ListBox();
            this.lblAbsActions = new System.Windows.Forms.Label();
            this.btnAbsAdd = new System.Windows.Forms.Button();
            this.btnAbsModif = new System.Windows.Forms.Button();
            this.btnAbsSuppr = new System.Windows.Forms.Button();
            this.btnAbsBack = new System.Windows.Forms.Button();
            this.lblAbsInfo = new System.Windows.Forms.Label();
            this.lblAbsError = new System.Windows.Forms.Label();
            this.lblPersonnelError = new System.Windows.Forms.Label();
            this.btnAnnuleSuppr = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.titleSupprPersonnel = new System.Windows.Forms.Label();
            this.lblSupprPersonnel = new System.Windows.Forms.Label();
            this.lblSupprInfoPerso = new System.Windows.Forms.Label();
            this.titleAddModifAbs = new System.Windows.Forms.Label();
            this.lblAddModifAbsDateDeb = new System.Windows.Forms.Label();
            this.dateDebAddModifAbs = new System.Windows.Forms.DateTimePicker();
            this.lblAddModifAbsDateFin = new System.Windows.Forms.Label();
            this.dateFinAddModifAbs = new System.Windows.Forms.DateTimePicker();
            this.lblAddModifAbsMotif = new System.Windows.Forms.Label();
            this.btnAnnuleAddModifAbs = new System.Windows.Forms.Button();
            this.btnAddModifAbs = new System.Windows.Forms.Button();
            this.titleAbsSuppr = new System.Windows.Forms.Label();
            this.lblAbsSuppr = new System.Windows.Forms.Label();
            this.lblAbsSupprInfo = new System.Windows.Forms.Label();
            this.btnAnnuleSupprAbs = new System.Windows.Forms.Button();
            this.btnAbsSupprConfirm = new System.Windows.Forms.Button();
            this.lstMotif = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titlelogin
            // 
            this.titlelogin.AccessibleName = "titleLogin";
            this.titlelogin.AutoSize = true;
            this.titlelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.titlelogin.Location = new System.Drawing.Point(176, 44);
            this.titlelogin.Name = "titlelogin";
            this.titlelogin.Size = new System.Drawing.Size(451, 39);
            this.titlelogin.TabIndex = 0;
            this.titlelogin.Text = "GESTION DU PERSONNEL";
            // 
            // lblUsername
            // 
            this.lblUsername.AccessibleName = "lblUsername";
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(241, 126);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleName = "txtUsername";
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(352, 126);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "txtPassword";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(352, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AccessibleName = "lblPassword";
            this.lblPassword.AutoSize = true;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(241, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleName = "btnLogin";
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(336, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogError
            // 
            this.lblLogError.AccessibleName = "lblLogError";
            this.lblLogError.AutoSize = true;
            this.lblLogError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLogError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogError.Location = new System.Drawing.Point(210, 284);
            this.lblLogError.MinimumSize = new System.Drawing.Size(350, 100);
            this.lblLogError.Name = "lblLogError";
            this.lblLogError.Size = new System.Drawing.Size(350, 100);
            this.lblLogError.TabIndex = 6;
            this.lblLogError.Text = "error info";
            this.lblLogError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogError.Visible = false;
            // 
            // lblListePersonnel
            // 
            this.lblListePersonnel.AccessibleName = "lblListePersonnel";
            this.lblListePersonnel.AutoSize = true;
            this.lblListePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblListePersonnel.Location = new System.Drawing.Point(139, 55);
            this.lblListePersonnel.Name = "lblListePersonnel";
            this.lblListePersonnel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblListePersonnel.Size = new System.Drawing.Size(227, 25);
            this.lblListePersonnel.TabIndex = 0;
            this.lblListePersonnel.Text = "LISTE DU PERSONNEL";
            this.lblListePersonnel.Visible = false;
            // 
            // titleDashboard
            // 
            this.titleDashboard.AccessibleName = "titleDashboard";
            this.titleDashboard.AutoSize = true;
            this.titleDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleDashboard.Location = new System.Drawing.Point(249, 9);
            this.titleDashboard.Name = "titleDashboard";
            this.titleDashboard.Size = new System.Drawing.Size(269, 31);
            this.titleDashboard.TabIndex = 1;
            this.titleDashboard.Text = "TABLEAU DE BORD";
            this.titleDashboard.Visible = false;
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.AccessibleName = "lstPersonnel";
            this.lstPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.ItemHeight = 16;
            this.lstPersonnel.Location = new System.Drawing.Point(12, 83);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.Size = new System.Drawing.Size(456, 340);
            this.lstPersonnel.TabIndex = 2;
            this.lstPersonnel.Visible = false;
            // 
            // lblActions
            // 
            this.lblActions.AccessibleName = "lblActions";
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblActions.Location = new System.Drawing.Point(585, 58);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(103, 25);
            this.lblActions.TabIndex = 3;
            this.lblActions.Text = "ACTIONS";
            this.lblActions.Visible = false;
            // 
            // btnAddPersonnel
            // 
            this.btnAddPersonnel.AccessibleName = "btnAddPersonnel";
            this.btnAddPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddPersonnel.Location = new System.Drawing.Point(476, 104);
            this.btnAddPersonnel.Name = "btnAddPersonnel";
            this.btnAddPersonnel.Size = new System.Drawing.Size(153, 79);
            this.btnAddPersonnel.TabIndex = 4;
            this.btnAddPersonnel.Text = "Ajouter employé";
            this.btnAddPersonnel.UseVisualStyleBackColor = false;
            this.btnAddPersonnel.Visible = false;
            this.btnAddPersonnel.Click += new System.EventHandler(this.btnAddPersonnel_Click);
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.AccessibleName = "btnModifPersonnel";
            this.btnModifPersonnel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModifPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModifPersonnel.Location = new System.Drawing.Point(635, 104);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(153, 79);
            this.btnModifPersonnel.TabIndex = 5;
            this.btnModifPersonnel.Text = "Modifier employé";
            this.btnModifPersonnel.UseVisualStyleBackColor = false;
            this.btnModifPersonnel.Visible = false;
            this.btnModifPersonnel.Click += new System.EventHandler(this.btnModifPersonnel_Click);
            // 
            // btnAbsPersonnel
            // 
            this.btnAbsPersonnel.AccessibleName = "btnAbsPersonnel";
            this.btnAbsPersonnel.BackColor = System.Drawing.SystemColors.Info;
            this.btnAbsPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsPersonnel.Location = new System.Drawing.Point(635, 199);
            this.btnAbsPersonnel.Name = "btnAbsPersonnel";
            this.btnAbsPersonnel.Size = new System.Drawing.Size(155, 79);
            this.btnAbsPersonnel.TabIndex = 6;
            this.btnAbsPersonnel.Text = "Absences d\'un employé";
            this.btnAbsPersonnel.UseVisualStyleBackColor = false;
            this.btnAbsPersonnel.Visible = false;
            this.btnAbsPersonnel.Click += new System.EventHandler(this.btnAbsPersonnel_Click);
            // 
            // btnSupprPersonnel
            // 
            this.btnSupprPersonnel.AccessibleName = "btnSupprPersonnel";
            this.btnSupprPersonnel.BackColor = System.Drawing.Color.DarkRed;
            this.btnSupprPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSupprPersonnel.Location = new System.Drawing.Point(474, 196);
            this.btnSupprPersonnel.Name = "btnSupprPersonnel";
            this.btnSupprPersonnel.Size = new System.Drawing.Size(153, 79);
            this.btnSupprPersonnel.TabIndex = 7;
            this.btnSupprPersonnel.Text = "Supprimer employé";
            this.btnSupprPersonnel.UseVisualStyleBackColor = false;
            this.btnSupprPersonnel.Visible = false;
            this.btnSupprPersonnel.Click += new System.EventHandler(this.btnSupprPersonnel_Click);
            // 
            // titleAddorModif
            // 
            this.titleAddorModif.AccessibleName = "titleAddOrModifyPersonnel";
            this.titleAddorModif.AutoSize = true;
            this.titleAddorModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleAddorModif.Location = new System.Drawing.Point(229, 22);
            this.titleAddorModif.Name = "titleAddorModif";
            this.titleAddorModif.Size = new System.Drawing.Size(344, 31);
            this.titleAddorModif.TabIndex = 0;
            this.titleAddorModif.Text = "Ajouter/Modifer un employé";
            this.titleAddorModif.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(218, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nom";
            this.lblName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "txtName";
            this.txtName.Location = new System.Drawing.Point(221, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AccessibleName = "lblFirstName";
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(218, 138);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Prénom";
            this.lblFirstName.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AccessibleName = "txtFirstName";
            this.txtFirstName.Location = new System.Drawing.Point(221, 158);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Visible = false;
            // 
            // lblTel
            // 
            this.lblTel.AccessibleName = "lblTel";
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTel.Location = new System.Drawing.Point(218, 192);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(32, 17);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Tél.";
            this.lblTel.Visible = false;
            // 
            // txtTel
            // 
            this.txtTel.AccessibleName = "txtTel";
            this.txtTel.Location = new System.Drawing.Point(221, 212);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(140, 20);
            this.txtTel.TabIndex = 6;
            this.txtTel.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AccessibleName = "lblMail";
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMail.Location = new System.Drawing.Point(222, 246);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            this.lblMail.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.AccessibleName = "txtMail";
            this.txtMail.Location = new System.Drawing.Point(221, 266);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(140, 20);
            this.txtMail.TabIndex = 8;
            this.txtMail.Visible = false;
            // 
            // lblAffectation
            // 
            this.lblAffectation.AccessibleName = "lblAffectation";
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAffectation.Location = new System.Drawing.Point(399, 83);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(75, 17);
            this.lblAffectation.TabIndex = 9;
            this.lblAffectation.Text = "Affectation";
            this.lblAffectation.Visible = false;
            // 
            // lstAffectation
            // 
            this.lstAffectation.FormattingEnabled = true;
            this.lstAffectation.Location = new System.Drawing.Point(402, 103);
            this.lstAffectation.Name = "lstAffectation";
            this.lstAffectation.Size = new System.Drawing.Size(171, 186);
            this.lstAffectation.TabIndex = 10;
            this.lstAffectation.Visible = false;
            // 
            // btnAnnuleAddOrModif
            // 
            this.btnAnnuleAddOrModif.AccessibleName = "btnAnnuleAddOrModif";
            this.btnAnnuleAddOrModif.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAnnuleAddOrModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAnnuleAddOrModif.Location = new System.Drawing.Point(272, 350);
            this.btnAnnuleAddOrModif.Name = "btnAnnuleAddOrModif";
            this.btnAnnuleAddOrModif.Size = new System.Drawing.Size(112, 42);
            this.btnAnnuleAddOrModif.TabIndex = 11;
            this.btnAnnuleAddOrModif.Text = "Annuler";
            this.btnAnnuleAddOrModif.UseVisualStyleBackColor = false;
            this.btnAnnuleAddOrModif.Visible = false;
            this.btnAnnuleAddOrModif.Click += new System.EventHandler(this.btnBackAddModif_Click);
            // 
            // btnAddModif
            // 
            this.btnAddModif.AccessibleName = "btnAddModif";
            this.btnAddModif.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddModif.Location = new System.Drawing.Point(390, 350);
            this.btnAddModif.Name = "btnAddModif";
            this.btnAddModif.Size = new System.Drawing.Size(112, 42);
            this.btnAddModif.TabIndex = 12;
            this.btnAddModif.Text = "Confirmer";
            this.btnAddModif.UseVisualStyleBackColor = false;
            this.btnAddModif.Visible = false;
            this.btnAddModif.Click += new System.EventHandler(this.btnValidAddModif_Click);
            // 
            // lblAddOrModifError
            // 
            this.lblAddOrModifError.AccessibleName = "lblAddOrModifError";
            this.lblAddOrModifError.AutoSize = true;
            this.lblAddOrModifError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddOrModifError.ForeColor = System.Drawing.Color.Red;
            this.lblAddOrModifError.Location = new System.Drawing.Point(198, 401);
            this.lblAddOrModifError.MaximumSize = new System.Drawing.Size(405, 0);
            this.lblAddOrModifError.MinimumSize = new System.Drawing.Size(400, 40);
            this.lblAddOrModifError.Name = "lblAddOrModifError";
            this.lblAddOrModifError.Size = new System.Drawing.Size(400, 40);
            this.lblAddOrModifError.TabIndex = 13;
            this.lblAddOrModifError.Text = "error";
            this.lblAddOrModifError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddOrModifError.Visible = false;
            // 
            // titleAbs
            // 
            this.titleAbs.AccessibleName = "titleAbs";
            this.titleAbs.AutoSize = true;
            this.titleAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleAbs.Location = new System.Drawing.Point(219, 9);
            this.titleAbs.Name = "titleAbs";
            this.titleAbs.Size = new System.Drawing.Size(355, 31);
            this.titleAbs.TabIndex = 0;
            this.titleAbs.Text = "GESTION DES ABSENCES";
            this.titleAbs.Visible = false;
            // 
            // lblAbsEmployeID
            // 
            this.lblAbsEmployeID.AccessibleName = "lblAbsEmployeID";
            this.lblAbsEmployeID.AutoSize = true;
            this.lblAbsEmployeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAbsEmployeID.Location = new System.Drawing.Point(522, 306);
            this.lblAbsEmployeID.Name = "lblAbsEmployeID";
            this.lblAbsEmployeID.Size = new System.Drawing.Size(238, 22);
            this.lblAbsEmployeID.TabIndex = 1;
            this.lblAbsEmployeID.Text = "EMPLOYE SELECTIONNE :";
            this.lblAbsEmployeID.Visible = false;
            // 
            // lblListeAbs
            // 
            this.lblListeAbs.AccessibleName = "lblListeAbs";
            this.lblListeAbs.AutoSize = true;
            this.lblListeAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblListeAbs.Location = new System.Drawing.Point(143, 61);
            this.lblListeAbs.Name = "lblListeAbs";
            this.lblListeAbs.Size = new System.Drawing.Size(205, 22);
            this.lblListeAbs.TabIndex = 2;
            this.lblListeAbs.Text = "LISTE DES ABSENCES";
            this.lblListeAbs.Visible = false;
            // 
            // lstAbs
            // 
            this.lstAbs.AccessibleName = "lstAbs";
            this.lstAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstAbs.FormattingEnabled = true;
            this.lstAbs.ItemHeight = 16;
            this.lstAbs.Location = new System.Drawing.Point(12, 101);
            this.lstAbs.Name = "lstAbs";
            this.lstAbs.Size = new System.Drawing.Size(456, 324);
            this.lstAbs.TabIndex = 3;
            this.lstAbs.Visible = false;
            // 
            // lblAbsActions
            // 
            this.lblAbsActions.AccessibleName = "lblAbsActions";
            this.lblAbsActions.AutoSize = true;
            this.lblAbsActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAbsActions.Location = new System.Drawing.Point(586, 64);
            this.lblAbsActions.Name = "lblAbsActions";
            this.lblAbsActions.Size = new System.Drawing.Size(90, 22);
            this.lblAbsActions.TabIndex = 4;
            this.lblAbsActions.Text = "ACTIONS";
            this.lblAbsActions.Visible = false;
            // 
            // btnAbsAdd
            // 
            this.btnAbsAdd.AccessibleName = "btnAbsAdd";
            this.btnAbsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAbsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsAdd.Location = new System.Drawing.Point(476, 104);
            this.btnAbsAdd.Name = "btnAbsAdd";
            this.btnAbsAdd.Size = new System.Drawing.Size(153, 79);
            this.btnAbsAdd.TabIndex = 5;
            this.btnAbsAdd.Text = "Ajouter absence";
            this.btnAbsAdd.UseVisualStyleBackColor = false;
            this.btnAbsAdd.Visible = false;
            this.btnAbsAdd.Click += new System.EventHandler(this.btnAbsAdd_Click);
            // 
            // btnAbsModif
            // 
            this.btnAbsModif.AccessibleName = "BtnAbsModif";
            this.btnAbsModif.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbsModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsModif.Location = new System.Drawing.Point(635, 104);
            this.btnAbsModif.Name = "btnAbsModif";
            this.btnAbsModif.Size = new System.Drawing.Size(153, 79);
            this.btnAbsModif.TabIndex = 6;
            this.btnAbsModif.Text = "Modifier absence";
            this.btnAbsModif.UseVisualStyleBackColor = false;
            this.btnAbsModif.Visible = false;
            this.btnAbsModif.Click += new System.EventHandler(this.btnAbsModif_Click);
            // 
            // btnAbsSuppr
            // 
            this.btnAbsSuppr.AccessibleName = "btnAbsSuppr";
            this.btnAbsSuppr.BackColor = System.Drawing.Color.DarkRed;
            this.btnAbsSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsSuppr.Location = new System.Drawing.Point(474, 202);
            this.btnAbsSuppr.Name = "btnAbsSuppr";
            this.btnAbsSuppr.Size = new System.Drawing.Size(153, 79);
            this.btnAbsSuppr.TabIndex = 7;
            this.btnAbsSuppr.Text = "Supprimer absence";
            this.btnAbsSuppr.UseVisualStyleBackColor = false;
            this.btnAbsSuppr.Visible = false;
            this.btnAbsSuppr.Click += new System.EventHandler(this.btnAbsSuppr_Click);
            // 
            // btnAbsBack
            // 
            this.btnAbsBack.AccessibleName = "btnAbsBack";
            this.btnAbsBack.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAbsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsBack.Location = new System.Drawing.Point(635, 200);
            this.btnAbsBack.Name = "btnAbsBack";
            this.btnAbsBack.Size = new System.Drawing.Size(153, 80);
            this.btnAbsBack.TabIndex = 8;
            this.btnAbsBack.Text = "Retour";
            this.btnAbsBack.UseVisualStyleBackColor = false;
            this.btnAbsBack.Visible = false;
            this.btnAbsBack.Click += new System.EventHandler(this.btnAbsBack_Click);
            // 
            // lblAbsInfo
            // 
            this.lblAbsInfo.AccessibleName = "lblAbsInfo";
            this.lblAbsInfo.AutoSize = true;
            this.lblAbsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAbsInfo.Location = new System.Drawing.Point(523, 328);
            this.lblAbsInfo.MaximumSize = new System.Drawing.Size(240, 0);
            this.lblAbsInfo.MinimumSize = new System.Drawing.Size(220, 50);
            this.lblAbsInfo.Name = "lblAbsInfo";
            this.lblAbsInfo.Size = new System.Drawing.Size(220, 50);
            this.lblAbsInfo.TabIndex = 9;
            this.lblAbsInfo.Text = "informations du personnel";
            this.lblAbsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbsInfo.Visible = false;
            // 
            // lblAbsError
            // 
            this.lblAbsError.AccessibleName = "lblAbsError";
            this.lblAbsError.AutoSize = true;
            this.lblAbsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAbsError.ForeColor = System.Drawing.Color.Red;
            this.lblAbsError.Location = new System.Drawing.Point(488, 378);
            this.lblAbsError.MaximumSize = new System.Drawing.Size(305, 0);
            this.lblAbsError.MinimumSize = new System.Drawing.Size(300, 50);
            this.lblAbsError.Name = "lblAbsError";
            this.lblAbsError.Size = new System.Drawing.Size(300, 50);
            this.lblAbsError.TabIndex = 10;
            this.lblAbsError.Text = "error";
            this.lblAbsError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbsError.Visible = false;
            // 
            // lblPersonnelError
            // 
            this.lblPersonnelError.AccessibleName = "lblPersonnelError";
            this.lblPersonnelError.AutoSize = true;
            this.lblPersonnelError.BackColor = System.Drawing.SystemColors.Control;
            this.lblPersonnelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPersonnelError.ForeColor = System.Drawing.Color.Red;
            this.lblPersonnelError.Location = new System.Drawing.Point(488, 365);
            this.lblPersonnelError.MaximumSize = new System.Drawing.Size(305, 0);
            this.lblPersonnelError.MinimumSize = new System.Drawing.Size(300, 60);
            this.lblPersonnelError.Name = "lblPersonnelError";
            this.lblPersonnelError.Size = new System.Drawing.Size(300, 60);
            this.lblPersonnelError.TabIndex = 14;
            this.lblPersonnelError.Text = "personnel error";
            this.lblPersonnelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonnelError.Visible = false;
            // 
            // btnAnnuleSuppr
            // 
            this.btnAnnuleSuppr.AccessibleName = "btnAnnuleSuppr";
            this.btnAnnuleSuppr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAnnuleSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAnnuleSuppr.Location = new System.Drawing.Point(272, 350);
            this.btnAnnuleSuppr.Name = "btnAnnuleSuppr";
            this.btnAnnuleSuppr.Size = new System.Drawing.Size(112, 42);
            this.btnAnnuleSuppr.TabIndex = 15;
            this.btnAnnuleSuppr.Text = "Annuler";
            this.btnAnnuleSuppr.UseVisualStyleBackColor = false;
            this.btnAnnuleSuppr.Visible = false;
            this.btnAnnuleSuppr.Click += new System.EventHandler(this.btnAnnuleSuppr_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.AccessibleName = "btnSuppr";
            this.btnSuppr.BackColor = System.Drawing.Color.DarkRed;
            this.btnSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSuppr.Location = new System.Drawing.Point(390, 350);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(112, 42);
            this.btnSuppr.TabIndex = 16;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = false;
            this.btnSuppr.Visible = false;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // titleSupprPersonnel
            // 
            this.titleSupprPersonnel.AccessibleName = "titleSupprPersonnel";
            this.titleSupprPersonnel.AutoSize = true;
            this.titleSupprPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleSupprPersonnel.Location = new System.Drawing.Point(219, 22);
            this.titleSupprPersonnel.Name = "titleSupprPersonnel";
            this.titleSupprPersonnel.Size = new System.Drawing.Size(360, 31);
            this.titleSupprPersonnel.TabIndex = 17;
            this.titleSupprPersonnel.Text = "SUPPRIMER UN EMPLOYE";
            this.titleSupprPersonnel.Visible = false;
            // 
            // lblSupprPersonnel
            // 
            this.lblSupprPersonnel.AccessibleName = "lblSupprPersonnel";
            this.lblSupprPersonnel.AutoSize = true;
            this.lblSupprPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSupprPersonnel.Location = new System.Drawing.Point(89, 92);
            this.lblSupprPersonnel.Name = "lblSupprPersonnel";
            this.lblSupprPersonnel.Size = new System.Drawing.Size(587, 20);
            this.lblSupprPersonnel.TabIndex = 18;
            this.lblSupprPersonnel.Text = "Vous êtes sur le point de supprimer de la liste des employés la personne suivante" +
    " :";
            this.lblSupprPersonnel.Visible = false;
            // 
            // lblSupprInfoPerso
            // 
            this.lblSupprInfoPerso.AccessibleName = "lblSupprInfoPerso";
            this.lblSupprInfoPerso.AutoSize = true;
            this.lblSupprInfoPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupprInfoPerso.Location = new System.Drawing.Point(198, 168);
            this.lblSupprInfoPerso.MaximumSize = new System.Drawing.Size(410, 0);
            this.lblSupprInfoPerso.MinimumSize = new System.Drawing.Size(400, 100);
            this.lblSupprInfoPerso.Name = "lblSupprInfoPerso";
            this.lblSupprInfoPerso.Size = new System.Drawing.Size(400, 100);
            this.lblSupprInfoPerso.TabIndex = 19;
            this.lblSupprInfoPerso.Text = "personnel info";
            this.lblSupprInfoPerso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSupprInfoPerso.Visible = false;
            // 
            // titleAddModifAbs
            // 
            this.titleAddModifAbs.AccessibleName = "titleAddModifAbs";
            this.titleAddModifAbs.AutoSize = true;
            this.titleAddModifAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleAddModifAbs.Location = new System.Drawing.Point(216, 22);
            this.titleAddModifAbs.Name = "titleAddModifAbs";
            this.titleAddModifAbs.Size = new System.Drawing.Size(344, 31);
            this.titleAddModifAbs.TabIndex = 20;
            this.titleAddModifAbs.Text = "AJOUTER UNE ABSENCE";
            this.titleAddModifAbs.Visible = false;
            // 
            // lblAddModifAbsDateDeb
            // 
            this.lblAddModifAbsDateDeb.AccessibleName = "lblAddModifAbsDateDeb";
            this.lblAddModifAbsDateDeb.AutoSize = true;
            this.lblAddModifAbsDateDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddModifAbsDateDeb.Location = new System.Drawing.Point(261, 155);
            this.lblAddModifAbsDateDeb.Name = "lblAddModifAbsDateDeb";
            this.lblAddModifAbsDateDeb.Size = new System.Drawing.Size(78, 17);
            this.lblAddModifAbsDateDeb.TabIndex = 21;
            this.lblAddModifAbsDateDeb.Text = "Date début";
            this.lblAddModifAbsDateDeb.Visible = false;
            // 
            // dateDebAddModifAbs
            // 
            this.dateDebAddModifAbs.AccessibleName = "dateDebAddModifAbs";
            this.dateDebAddModifAbs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebAddModifAbs.Location = new System.Drawing.Point(350, 152);
            this.dateDebAddModifAbs.Name = "dateDebAddModifAbs";
            this.dateDebAddModifAbs.Size = new System.Drawing.Size(200, 20);
            this.dateDebAddModifAbs.TabIndex = 22;
            this.dateDebAddModifAbs.Visible = false;
            // 
            // lblAddModifAbsDateFin
            // 
            this.lblAddModifAbsDateFin.AccessibleName = "lblAddModifAbsDateFin";
            this.lblAddModifAbsDateFin.AutoSize = true;
            this.lblAddModifAbsDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddModifAbsDateFin.Location = new System.Drawing.Point(261, 198);
            this.lblAddModifAbsDateFin.Name = "lblAddModifAbsDateFin";
            this.lblAddModifAbsDateFin.Size = new System.Drawing.Size(57, 17);
            this.lblAddModifAbsDateFin.TabIndex = 23;
            this.lblAddModifAbsDateFin.Text = "Date fin";
            this.lblAddModifAbsDateFin.Visible = false;
            // 
            // dateFinAddModifAbs
            // 
            this.dateFinAddModifAbs.AccessibleName = "dateFinAddModifAbs";
            this.dateFinAddModifAbs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinAddModifAbs.Location = new System.Drawing.Point(350, 199);
            this.dateFinAddModifAbs.Name = "dateFinAddModifAbs";
            this.dateFinAddModifAbs.Size = new System.Drawing.Size(200, 20);
            this.dateFinAddModifAbs.TabIndex = 24;
            this.dateFinAddModifAbs.Visible = false;
            // 
            // lblAddModifAbsMotif
            // 
            this.lblAddModifAbsMotif.AccessibleName = "lblAddModifAbsMotif";
            this.lblAddModifAbsMotif.AutoSize = true;
            this.lblAddModifAbsMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddModifAbsMotif.Location = new System.Drawing.Point(261, 235);
            this.lblAddModifAbsMotif.Name = "lblAddModifAbsMotif";
            this.lblAddModifAbsMotif.Size = new System.Drawing.Size(38, 17);
            this.lblAddModifAbsMotif.TabIndex = 26;
            this.lblAddModifAbsMotif.Text = "Motif";
            this.lblAddModifAbsMotif.Visible = false;
            // 
            // btnAnnuleAddModifAbs
            // 
            this.btnAnnuleAddModifAbs.AccessibleName = "btnAnnuleAddModifAbs";
            this.btnAnnuleAddModifAbs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAnnuleAddModifAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAnnuleAddModifAbs.Location = new System.Drawing.Point(271, 350);
            this.btnAnnuleAddModifAbs.Name = "btnAnnuleAddModifAbs";
            this.btnAnnuleAddModifAbs.Size = new System.Drawing.Size(112, 42);
            this.btnAnnuleAddModifAbs.TabIndex = 27;
            this.btnAnnuleAddModifAbs.Text = "Annuler";
            this.btnAnnuleAddModifAbs.UseVisualStyleBackColor = false;
            this.btnAnnuleAddModifAbs.Visible = false;
            this.btnAnnuleAddModifAbs.Click += new System.EventHandler(this.btnAnnuleAddModifAbs_Click);
            // 
            // btnAddModifAbs
            // 
            this.btnAddModifAbs.AccessibleName = "btnAddModifAbs";
            this.btnAddModifAbs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddModifAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddModifAbs.Location = new System.Drawing.Point(390, 350);
            this.btnAddModifAbs.Name = "btnAddModifAbs";
            this.btnAddModifAbs.Size = new System.Drawing.Size(112, 42);
            this.btnAddModifAbs.TabIndex = 28;
            this.btnAddModifAbs.Text = "Confirmer";
            this.btnAddModifAbs.UseVisualStyleBackColor = false;
            this.btnAddModifAbs.Visible = false;
            this.btnAddModifAbs.Click += new System.EventHandler(this.btnAddModifAbs_Click);
            // 
            // titleAbsSuppr
            // 
            this.titleAbsSuppr.AccessibleName = "titleAbsSuppr";
            this.titleAbsSuppr.AutoSize = true;
            this.titleAbsSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleAbsSuppr.Location = new System.Drawing.Point(219, 22);
            this.titleAbsSuppr.Name = "titleAbsSuppr";
            this.titleAbsSuppr.Size = new System.Drawing.Size(378, 31);
            this.titleAbsSuppr.TabIndex = 29;
            this.titleAbsSuppr.Text = "SUPPRIMER UNE ABSENCE";
            this.titleAbsSuppr.Visible = false;
            // 
            // lblAbsSuppr
            // 
            this.lblAbsSuppr.AccessibleName = "lblAbsSuppr";
            this.lblAbsSuppr.AutoSize = true;
            this.lblAbsSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAbsSuppr.Location = new System.Drawing.Point(208, 95);
            this.lblAbsSuppr.Name = "lblAbsSuppr";
            this.lblAbsSuppr.Size = new System.Drawing.Size(400, 20);
            this.lblAbsSuppr.TabIndex = 30;
            this.lblAbsSuppr.Text = "Vous êtes sur le point de supprimer l\'absence suivante :";
            this.lblAbsSuppr.Visible = false;
            // 
            // lblAbsSupprInfo
            // 
            this.lblAbsSupprInfo.AccessibleName = "lblAbsSupprInfo";
            this.lblAbsSupprInfo.AutoSize = true;
            this.lblAbsSupprInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAbsSupprInfo.Location = new System.Drawing.Point(251, 174);
            this.lblAbsSupprInfo.MaximumSize = new System.Drawing.Size(330, 0);
            this.lblAbsSupprInfo.MinimumSize = new System.Drawing.Size(320, 50);
            this.lblAbsSupprInfo.Name = "lblAbsSupprInfo";
            this.lblAbsSupprInfo.Size = new System.Drawing.Size(320, 50);
            this.lblAbsSupprInfo.TabIndex = 31;
            this.lblAbsSupprInfo.Text = "info absence";
            this.lblAbsSupprInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbsSupprInfo.Visible = false;
            // 
            // btnAnnuleSupprAbs
            // 
            this.btnAnnuleSupprAbs.AccessibleName = "btnAnnuleSupprAbs";
            this.btnAnnuleSupprAbs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAnnuleSupprAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAnnuleSupprAbs.Location = new System.Drawing.Point(272, 350);
            this.btnAnnuleSupprAbs.Name = "btnAnnuleSupprAbs";
            this.btnAnnuleSupprAbs.Size = new System.Drawing.Size(112, 42);
            this.btnAnnuleSupprAbs.TabIndex = 32;
            this.btnAnnuleSupprAbs.Text = "Annuler";
            this.btnAnnuleSupprAbs.UseVisualStyleBackColor = false;
            this.btnAnnuleSupprAbs.Visible = false;
            this.btnAnnuleSupprAbs.Click += new System.EventHandler(this.btnAnnuleSupprAbs_Click);
            // 
            // btnAbsSupprConfirm
            // 
            this.btnAbsSupprConfirm.AccessibleName = "btnAbsSuppr";
            this.btnAbsSupprConfirm.BackColor = System.Drawing.Color.DarkRed;
            this.btnAbsSupprConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsSupprConfirm.Location = new System.Drawing.Point(389, 350);
            this.btnAbsSupprConfirm.Name = "btnAbsSupprConfirm";
            this.btnAbsSupprConfirm.Size = new System.Drawing.Size(112, 42);
            this.btnAbsSupprConfirm.TabIndex = 33;
            this.btnAbsSupprConfirm.Text = "Supprimer";
            this.btnAbsSupprConfirm.UseVisualStyleBackColor = false;
            this.btnAbsSupprConfirm.Visible = false;
            this.btnAbsSupprConfirm.Click += new System.EventHandler(this.btnAbsSupprConfirm_Click);
            // 
            // lstMotif
            // 
            this.lstMotif.AccessibleName = "lstMotif";
            this.lstMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstMotif.FormattingEnabled = true;
            this.lstMotif.ItemHeight = 16;
            this.lstMotif.Location = new System.Drawing.Point(350, 235);
            this.lstMotif.Name = "lstMotif";
            this.lstMotif.Size = new System.Drawing.Size(202, 100);
            this.lstMotif.TabIndex = 34;
            this.lstMotif.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbsBack);
            this.Controls.Add(this.btnAbsSuppr);
            this.Controls.Add(this.btnAbsAdd);
            this.Controls.Add(this.lblAbsActions);
            this.Controls.Add(this.lblAbsSuppr);
            this.Controls.Add(this.btnAnnuleAddModifAbs);
            this.Controls.Add(this.lblAddModifAbsMotif);
            this.Controls.Add(this.dateFinAddModifAbs);
            this.Controls.Add(this.lblAddModifAbsDateFin);
            this.Controls.Add(this.dateDebAddModifAbs);
            this.Controls.Add(this.lblAddModifAbsDateDeb);
            this.Controls.Add(this.btnAnnuleSuppr);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.lblListePersonnel);
            this.Controls.Add(this.btnAnnuleAddOrModif);
            this.Controls.Add(this.lblAffectation);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAbsInfo);
            this.Controls.Add(this.lblListeAbs);
            this.Controls.Add(this.lblAbsEmployeID);
            this.Controls.Add(this.titleAbs);
            this.Controls.Add(this.lblSupprInfoPerso);
            this.Controls.Add(this.lstAffectation);
            this.Controls.Add(this.lstPersonnel);
            this.Controls.Add(this.lblSupprPersonnel);
            this.Controls.Add(this.lblAbsSupprInfo);
            this.Controls.Add(this.titleAbsSuppr);
            this.Controls.Add(this.titlelogin);
            this.Controls.Add(this.lstAbs);
            this.Controls.Add(this.btnAbsSupprConfirm);
            this.Controls.Add(this.btnAnnuleSupprAbs);
            this.Controls.Add(this.lblPersonnelError);
            this.Controls.Add(this.lblAddOrModifError);
            this.Controls.Add(this.titleAddModifAbs);
            this.Controls.Add(this.titleSupprPersonnel);
            this.Controls.Add(this.titleDashboard);
            this.Controls.Add(this.titleAddorModif);
            this.Controls.Add(this.btnAbsModif);
            this.Controls.Add(this.lblAbsError);
            this.Controls.Add(this.btnSupprPersonnel);
            this.Controls.Add(this.btnAddPersonnel);
            this.Controls.Add(this.btnModifPersonnel);
            this.Controls.Add(this.btnAbsPersonnel);
            this.Controls.Add(this.btnAddModif);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.lblLogError);
            this.Controls.Add(this.btnAddModifAbs);
            this.Controls.Add(this.lstMotif);
            this.Name = "Form1";
            this.Text = "Gestion Du Personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// login components
        private System.Windows.Forms.Label titlelogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogError;
        ///main menu components
        private System.Windows.Forms.Label lblListePersonnel;
        private System.Windows.Forms.Label titleDashboard;
        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Button btnAddPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Button btnAbsPersonnel;
        private System.Windows.Forms.Button btnSupprPersonnel;
        ///add or modify view
        private System.Windows.Forms.Label titleAddorModif;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.ListBox lstAffectation;
        private System.Windows.Forms.Button btnAnnuleAddOrModif;
        private System.Windows.Forms.Button btnAddModif;
        private System.Windows.Forms.Label lblAddOrModifError;
        ///absence main menu view
        private System.Windows.Forms.Label titleAbs;
        private System.Windows.Forms.Label lblAbsEmployeID;
        private System.Windows.Forms.Label lblListeAbs;
        private System.Windows.Forms.ListBox lstAbs;
        private System.Windows.Forms.Label lblAbsActions;
        private System.Windows.Forms.Button btnAbsAdd;
        private System.Windows.Forms.Button btnAbsModif;
        private System.Windows.Forms.Button btnAbsSuppr;
        private System.Windows.Forms.Button btnAbsBack;
        private System.Windows.Forms.Label lblAbsInfo;
        private System.Windows.Forms.Label lblAbsError;
        private System.Windows.Forms.Label lblPersonnelError;
        private System.Windows.Forms.Button btnAnnuleSuppr;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Label titleSupprPersonnel;
        private System.Windows.Forms.Label lblSupprPersonnel;
        private System.Windows.Forms.Label lblSupprInfoPerso;
        private System.Windows.Forms.Label titleAddModifAbs;
        private System.Windows.Forms.Label lblAddModifAbsDateDeb;
        private System.Windows.Forms.DateTimePicker dateDebAddModifAbs;
        private System.Windows.Forms.Label lblAddModifAbsDateFin;
        private System.Windows.Forms.DateTimePicker dateFinAddModifAbs;
        private System.Windows.Forms.Label lblAddModifAbsMotif;
        private System.Windows.Forms.Button btnAnnuleAddModifAbs;
        private System.Windows.Forms.Button btnAddModifAbs;
        private System.Windows.Forms.Label titleAbsSuppr;
        private System.Windows.Forms.Label lblAbsSuppr;
        private System.Windows.Forms.Label lblAbsSupprInfo;
        private System.Windows.Forms.Button btnAnnuleSupprAbs;
        private System.Windows.Forms.Button btnAbsSupprConfirm;
        private System.Windows.Forms.ListBox lstMotif;
    }
}

