
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
            this.SuspendLayout();
            // 
            // titlelogin
            // 
            this.titlelogin.AccessibleName = "titleLogin";
            this.titlelogin.AutoSize = true;
            this.titlelogin.Enabled = false;
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
            this.lblUsername.Enabled = false;
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
            this.lblPassword.Enabled = false;
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
            this.btnLogin.Location = new System.Drawing.Point(319, 225);
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
            this.lblLogError.Enabled = false;
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
            this.lblListePersonnel.Location = new System.Drawing.Point(112, 49);
            this.lblListePersonnel.Name = "lblListePersonnel";
            this.lblListePersonnel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblListePersonnel.Size = new System.Drawing.Size(171, 25);
            this.lblListePersonnel.TabIndex = 0;
            this.lblListePersonnel.Text = "Liste du personnel";
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
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.Location = new System.Drawing.Point(48, 86);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.Size = new System.Drawing.Size(300, 342);
            this.lstPersonnel.TabIndex = 2;
            this.lstPersonnel.Visible = false;
            // 
            // lblActions
            // 
            this.lblActions.AccessibleName = "lblActions";
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblActions.Location = new System.Drawing.Point(521, 49);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(77, 25);
            this.lblActions.TabIndex = 3;
            this.lblActions.Text = "Actions";
            this.lblActions.Visible = false;
            // 
            // btnAddPersonnel
            // 
            this.btnAddPersonnel.AccessibleName = "btnAddPersonnel";
            this.btnAddPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddPersonnel.Location = new System.Drawing.Point(456, 86);
            this.btnAddPersonnel.Name = "btnAddPersonnel";
            this.btnAddPersonnel.Size = new System.Drawing.Size(212, 60);
            this.btnAddPersonnel.TabIndex = 4;
            this.btnAddPersonnel.Text = "Ajout d\'un employé";
            this.btnAddPersonnel.UseVisualStyleBackColor = false;
            this.btnAddPersonnel.Visible = false;
            this.btnAddPersonnel.Click += new System.EventHandler(this.btnAddPersonnel_Click);
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.AccessibleName = "btnModifPersonnel";
            this.btnModifPersonnel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModifPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifPersonnel.Location = new System.Drawing.Point(456, 152);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(212, 60);
            this.btnModifPersonnel.TabIndex = 5;
            this.btnModifPersonnel.Text = "Modifier un employé";
            this.btnModifPersonnel.UseVisualStyleBackColor = false;
            this.btnModifPersonnel.Visible = false;
            this.btnModifPersonnel.Click += new System.EventHandler(this.btnModifPersonnel_Click);
            // 
            // btnAbsPersonnel
            // 
            this.btnAbsPersonnel.AccessibleName = "btnAbsPersonnel";
            this.btnAbsPersonnel.BackColor = System.Drawing.SystemColors.Info;
            this.btnAbsPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAbsPersonnel.Location = new System.Drawing.Point(455, 221);
            this.btnAbsPersonnel.Name = "btnAbsPersonnel";
            this.btnAbsPersonnel.Size = new System.Drawing.Size(212, 60);
            this.btnAbsPersonnel.TabIndex = 6;
            this.btnAbsPersonnel.Text = "Gérer les absences d\'un l\'employé";
            this.btnAbsPersonnel.UseVisualStyleBackColor = false;
            this.btnAbsPersonnel.Visible = false;
            this.btnAbsPersonnel.Click += new System.EventHandler(this.btnAbsPersonnel_Click);
            // 
            // btnSupprPersonnel
            // 
            this.btnSupprPersonnel.AccessibleName = "btnSupprPersonnel";
            this.btnSupprPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupprPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSupprPersonnel.Location = new System.Drawing.Point(455, 287);
            this.btnSupprPersonnel.Name = "btnSupprPersonnel";
            this.btnSupprPersonnel.Size = new System.Drawing.Size(212, 60);
            this.btnSupprPersonnel.TabIndex = 7;
            this.btnSupprPersonnel.Text = "Supprimer un employé";
            this.btnSupprPersonnel.UseVisualStyleBackColor = false;
            this.btnSupprPersonnel.Visible = false;
            this.btnSupprPersonnel.Click += new System.EventHandler(this.btnSupprPersonnel_Click);
            // 
            // titleAddOrModifyPersonnel
            // 
            this.titleAddorModif.AccessibleName = "titleAddOrModifyPersonnel";
            this.titleAddorModif.AutoSize = true;
            this.titleAddorModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleAddorModif.Location = new System.Drawing.Point(229, 22);
            this.titleAddorModif.Name = "titleAddOrModifyPersonnel";
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
            this.btnAddModif.Text = "Confirm";
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
            this.titleAbs.Location = new System.Drawing.Point(216, 21);
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
            this.lblAbsEmployeID.Location = new System.Drawing.Point(451, 70);
            this.lblAbsEmployeID.Name = "lblAbsEmployeID";
            this.lblAbsEmployeID.Size = new System.Drawing.Size(225, 22);
            this.lblAbsEmployeID.TabIndex = 1;
            this.lblAbsEmployeID.Text = "INFORMATION EMPLOYE";
            this.lblAbsEmployeID.Visible = false;
            // 
            // lblListeAbs
            // 
            this.lblListeAbs.AccessibleName = "lblListeAbs";
            this.lblListeAbs.AutoSize = true;
            this.lblListeAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblListeAbs.Location = new System.Drawing.Point(97, 70);
            this.lblListeAbs.Name = "lblListeAbs";
            this.lblListeAbs.Size = new System.Drawing.Size(205, 22);
            this.lblListeAbs.TabIndex = 2;
            this.lblListeAbs.Text = "LISTE DES ABSENCES";
            this.lblListeAbs.Visible = false;
            // 
            // lstAbs
            // 
            this.lstAbs.AccessibleName = "lstAbs";
            this.lstAbs.FormattingEnabled = true;
            this.lstAbs.Location = new System.Drawing.Point(39, 95);
            this.lstAbs.Name = "lstAbs";
            this.lstAbs.Size = new System.Drawing.Size(318, 316);
            this.lstAbs.TabIndex = 3;
            this.lstAbs.Visible = false;
            // 
            // lblAbsActions
            // 
            this.lblAbsActions.AccessibleName = "lblAbsActions";
            this.lblAbsActions.AutoSize = true;
            this.lblAbsActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAbsActions.Location = new System.Drawing.Point(518, 168);
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
            this.btnAbsAdd.Location = new System.Drawing.Point(378, 208);
            this.btnAbsAdd.Name = "btnAbsAdd";
            this.btnAbsAdd.Size = new System.Drawing.Size(168, 77);
            this.btnAbsAdd.TabIndex = 5;
            this.btnAbsAdd.Text = "Ajouter une absence";
            this.btnAbsAdd.UseVisualStyleBackColor = false;
            this.btnAbsAdd.Visible = false;
            // 
            // btnAbsModif
            // 
            this.btnAbsModif.AccessibleName = "BtnAbsModif";
            this.btnAbsModif.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbsModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsModif.Location = new System.Drawing.Point(378, 291);
            this.btnAbsModif.Name = "btnAbsModif";
            this.btnAbsModif.Size = new System.Drawing.Size(168, 77);
            this.btnAbsModif.TabIndex = 6;
            this.btnAbsModif.Text = "Modifier une absence";
            this.btnAbsModif.UseVisualStyleBackColor = false;
            this.btnAbsModif.Visible = false;
            // 
            // btnAbsSuppr
            // 
            this.btnAbsSuppr.AccessibleName = "btnAbsSuppr";
            this.btnAbsSuppr.BackColor = System.Drawing.Color.DarkRed;
            this.btnAbsSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsSuppr.Location = new System.Drawing.Point(567, 208);
            this.btnAbsSuppr.Name = "btnAbsSuppr";
            this.btnAbsSuppr.Size = new System.Drawing.Size(168, 77);
            this.btnAbsSuppr.TabIndex = 7;
            this.btnAbsSuppr.Text = "Supprimer une absence";
            this.btnAbsSuppr.UseVisualStyleBackColor = false;
            this.btnAbsSuppr.Visible = false;
            // 
            // btnAbsBack
            // 
            this.btnAbsBack.AccessibleName = "btnAbsBack";
            this.btnAbsBack.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAbsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbsBack.Location = new System.Drawing.Point(567, 291);
            this.btnAbsBack.Name = "btnAbsBack";
            this.btnAbsBack.Size = new System.Drawing.Size(168, 77);
            this.btnAbsBack.TabIndex = 8;
            this.btnAbsBack.Text = "Retour au menu principal";
            this.btnAbsBack.UseVisualStyleBackColor = false;
            this.btnAbsBack.Visible = false;
            this.btnAbsBack.Click += new System.EventHandler(this.btnAbsBack_Click);
            // 
            // lblAbsInfo
            // 
            this.lblAbsInfo.AccessibleName = "lblAbsInfo";
            this.lblAbsInfo.AutoSize = true;
            this.lblAbsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAbsInfo.Location = new System.Drawing.Point(403, 102);
            this.lblAbsInfo.MinimumSize = new System.Drawing.Size(300, 50);
            this.lblAbsInfo.Name = "lblAbsInfo";
            this.lblAbsInfo.Size = new System.Drawing.Size(300, 50);
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
            this.lblAbsError.Location = new System.Drawing.Point(375, 382);
            this.lblAbsError.MaximumSize = new System.Drawing.Size(365, 0);
            this.lblAbsError.MinimumSize = new System.Drawing.Size(360, 50);
            this.lblAbsError.Name = "lblAbsError";
            this.lblAbsError.Size = new System.Drawing.Size(360, 50);
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
            this.lblPersonnelError.Location = new System.Drawing.Point(375, 368);
            this.lblPersonnelError.MaximumSize = new System.Drawing.Size(360, 0);
            this.lblPersonnelError.MinimumSize = new System.Drawing.Size(350, 60);
            this.lblPersonnelError.Name = "lblPersonnelError";
            this.lblPersonnelError.Size = new System.Drawing.Size(350, 60);
            this.lblPersonnelError.TabIndex = 14;
            this.lblPersonnelError.Text = "personnel error";
            this.lblPersonnelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonnelError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPersonnelError);
            this.Controls.Add(this.lblAddOrModifError);
            this.Controls.Add(this.lblLogError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.titlelogin);
            this.Controls.Add(this.btnSupprPersonnel);
            this.Controls.Add(this.btnAbsPersonnel);
            this.Controls.Add(this.btnModifPersonnel);
            this.Controls.Add(this.btnAddPersonnel);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.lstPersonnel);
            this.Controls.Add(this.titleDashboard);
            this.Controls.Add(this.lblListePersonnel);
            this.Controls.Add(this.btnAddModif);
            this.Controls.Add(this.btnAnnuleAddOrModif);
            this.Controls.Add(this.lstAffectation);
            this.Controls.Add(this.lblAffectation);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.titleAddorModif);
            this.Controls.Add(this.lblAbsError);
            this.Controls.Add(this.lblAbsInfo);
            this.Controls.Add(this.btnAbsBack);
            this.Controls.Add(this.btnAbsSuppr);
            this.Controls.Add(this.btnAbsModif);
            this.Controls.Add(this.btnAbsAdd);
            this.Controls.Add(this.lblAbsActions);
            this.Controls.Add(this.lstAbs);
            this.Controls.Add(this.lblListeAbs);
            this.Controls.Add(this.lblAbsEmployeID);
            this.Controls.Add(this.titleAbs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

