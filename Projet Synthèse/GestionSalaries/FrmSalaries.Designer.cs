namespace Formulaire_Salarie
{
    partial class frmSalariés
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalariés));
            this.label1 = new System.Windows.Forms.Label();
            this.cbChoixSalarie = new System.Windows.Forms.ComboBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.gbDetailsUtilisateur = new System.Windows.Forms.GroupBox();
            this.tbChiffreAffaire = new System.Windows.Forms.TextBox();
            this.tbCommission = new System.Windows.Forms.TextBox();
            this.lbChiffreAffaire = new System.Windows.Forms.Label();
            this.lbCommission = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbSalaireBrut = new System.Windows.Forms.TextBox();
            this.tbTaux = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbMatricule = new System.Windows.Forms.TextBox();
            this.lbSalaireBrut = new System.Windows.Forms.Label();
            this.lbTauxCS = new System.Windows.Forms.Label();
            this.lbDateNaissance = new System.Windows.Forms.Label();
            this.lbPrénom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbMatricule = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.chkBxOui = new System.Windows.Forms.CheckBox();
            this.chkBxNon = new System.Windows.Forms.CheckBox();
            this.gbDetailsUtilisateur.SuspendLayout();
            this.pnlBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un utilisateur :";
            // 
            // cbChoixSalarie
            // 
            this.cbChoixSalarie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChoixSalarie.FormattingEnabled = true;
            this.cbChoixSalarie.Location = new System.Drawing.Point(213, 24);
            this.cbChoixSalarie.Name = "cbChoixSalarie";
            this.cbChoixSalarie.Size = new System.Drawing.Size(170, 21);
            this.cbChoixSalarie.TabIndex = 1;
            this.cbChoixSalarie.SelectedIndexChanged += new System.EventHandler(this.cbChoixSalarie_SelectedIndexChanged);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNouveau.CausesValidation = false;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(389, 24);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(159, 83);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // gbDetailsUtilisateur
            // 
            this.gbDetailsUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetailsUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.gbDetailsUtilisateur.Controls.Add(this.tbChiffreAffaire);
            this.gbDetailsUtilisateur.Controls.Add(this.tbCommission);
            this.gbDetailsUtilisateur.Controls.Add(this.lbChiffreAffaire);
            this.gbDetailsUtilisateur.Controls.Add(this.lbCommission);
            this.gbDetailsUtilisateur.Controls.Add(this.dtpDateNaissance);
            this.gbDetailsUtilisateur.Controls.Add(this.pnlBoutons);
            this.gbDetailsUtilisateur.Controls.Add(this.tbSalaireBrut);
            this.gbDetailsUtilisateur.Controls.Add(this.tbTaux);
            this.gbDetailsUtilisateur.Controls.Add(this.tbNom);
            this.gbDetailsUtilisateur.Controls.Add(this.tbPrenom);
            this.gbDetailsUtilisateur.Controls.Add(this.tbMatricule);
            this.gbDetailsUtilisateur.Controls.Add(this.lbSalaireBrut);
            this.gbDetailsUtilisateur.Controls.Add(this.lbTauxCS);
            this.gbDetailsUtilisateur.Controls.Add(this.lbDateNaissance);
            this.gbDetailsUtilisateur.Controls.Add(this.lbPrénom);
            this.gbDetailsUtilisateur.Controls.Add(this.lbNom);
            this.gbDetailsUtilisateur.Controls.Add(this.lbMatricule);
            this.gbDetailsUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailsUtilisateur.ForeColor = System.Drawing.Color.White;
            this.gbDetailsUtilisateur.Location = new System.Drawing.Point(44, 134);
            this.gbDetailsUtilisateur.Name = "gbDetailsUtilisateur";
            this.gbDetailsUtilisateur.Size = new System.Drawing.Size(504, 427);
            this.gbDetailsUtilisateur.TabIndex = 6;
            this.gbDetailsUtilisateur.TabStop = false;
            this.gbDetailsUtilisateur.Text = "Détails Utilisateur";
            this.gbDetailsUtilisateur.Visible = false;
            // 
            // tbChiffreAffaire
            // 
            this.tbChiffreAffaire.Location = new System.Drawing.Point(181, 277);
            this.tbChiffreAffaire.Name = "tbChiffreAffaire";
            this.tbChiffreAffaire.Size = new System.Drawing.Size(241, 22);
            this.tbChiffreAffaire.TabIndex = 15;
            this.tbChiffreAffaire.Validating += new System.ComponentModel.CancelEventHandler(this.tbChiffreAffaire_Validating);
            // 
            // tbCommission
            // 
            this.tbCommission.Location = new System.Drawing.Point(181, 238);
            this.tbCommission.Name = "tbCommission";
            this.tbCommission.Size = new System.Drawing.Size(241, 22);
            this.tbCommission.TabIndex = 13;
            this.tbCommission.Validating += new System.ComponentModel.CancelEventHandler(this.tbCommission_Validating);
            // 
            // lbChiffreAffaire
            // 
            this.lbChiffreAffaire.AutoSize = true;
            this.lbChiffreAffaire.Location = new System.Drawing.Point(18, 277);
            this.lbChiffreAffaire.Name = "lbChiffreAffaire";
            this.lbChiffreAffaire.Size = new System.Drawing.Size(113, 16);
            this.lbChiffreAffaire.TabIndex = 14;
            this.lbChiffreAffaire.Text = "Chiffre d\'affaire";
            // 
            // lbCommission
            // 
            this.lbCommission.AutoSize = true;
            this.lbCommission.Location = new System.Drawing.Point(18, 238);
            this.lbCommission.Name = "lbCommission";
            this.lbCommission.Size = new System.Drawing.Size(92, 16);
            this.lbCommission.TabIndex = 12;
            this.lbCommission.Text = "Commission";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(181, 126);
            this.dtpDateNaissance.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateNaissance.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(241, 22);
            this.dtpDateNaissance.TabIndex = 7;
            this.dtpDateNaissance.Value = new System.DateTime(2020, 10, 6, 17, 21, 0, 0);
            // 
            // pnlBoutons
            // 
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Controls.Add(this.btnModifier);
            this.pnlBoutons.Location = new System.Drawing.Point(77, 368);
            this.pnlBoutons.Name = "pnlBoutons";
            this.pnlBoutons.Size = new System.Drawing.Size(329, 40);
            this.pnlBoutons.TabIndex = 16;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.OrangeRed;
            this.btnValider.Location = new System.Drawing.Point(237, 1);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(89, 40);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(112, 0);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 40);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.OrangeRed;
            this.btnModifier.Location = new System.Drawing.Point(0, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 38);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // tbSalaireBrut
            // 
            this.tbSalaireBrut.Location = new System.Drawing.Point(181, 164);
            this.tbSalaireBrut.Name = "tbSalaireBrut";
            this.tbSalaireBrut.Size = new System.Drawing.Size(241, 22);
            this.tbSalaireBrut.TabIndex = 9;
            // 
            // tbTaux
            // 
            this.tbTaux.Location = new System.Drawing.Point(181, 203);
            this.tbTaux.Name = "tbTaux";
            this.tbTaux.Size = new System.Drawing.Size(241, 22);
            this.tbTaux.TabIndex = 11;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(181, 57);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(241, 22);
            this.tbNom.TabIndex = 3;
            this.tbNom.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(181, 95);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(241, 22);
            this.tbPrenom.TabIndex = 5;
            this.tbPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            // 
            // tbMatricule
            // 
            this.tbMatricule.Location = new System.Drawing.Point(181, 25);
            this.tbMatricule.Name = "tbMatricule";
            this.tbMatricule.Size = new System.Drawing.Size(241, 22);
            this.tbMatricule.TabIndex = 1;
            this.tbMatricule.Validating += new System.ComponentModel.CancelEventHandler(this.tbMatricule_Validating);
            // 
            // lbSalaireBrut
            // 
            this.lbSalaireBrut.AutoSize = true;
            this.lbSalaireBrut.Location = new System.Drawing.Point(18, 164);
            this.lbSalaireBrut.Name = "lbSalaireBrut";
            this.lbSalaireBrut.Size = new System.Drawing.Size(97, 16);
            this.lbSalaireBrut.TabIndex = 8;
            this.lbSalaireBrut.Text = "Salaire Brut :";
            // 
            // lbTauxCS
            // 
            this.lbTauxCS.AutoSize = true;
            this.lbTauxCS.Location = new System.Drawing.Point(18, 203);
            this.lbTauxCS.Name = "lbTauxCS";
            this.lbTauxCS.Size = new System.Drawing.Size(70, 16);
            this.lbTauxCS.TabIndex = 10;
            this.lbTauxCS.Text = "TauxCS :";
            // 
            // lbDateNaissance
            // 
            this.lbDateNaissance.AutoSize = true;
            this.lbDateNaissance.Location = new System.Drawing.Point(16, 131);
            this.lbDateNaissance.Name = "lbDateNaissance";
            this.lbDateNaissance.Size = new System.Drawing.Size(146, 16);
            this.lbDateNaissance.TabIndex = 6;
            this.lbDateNaissance.Text = "Date de naissance :";
            // 
            // lbPrénom
            // 
            this.lbPrénom.AutoSize = true;
            this.lbPrénom.Location = new System.Drawing.Point(18, 95);
            this.lbPrénom.Name = "lbPrénom";
            this.lbPrénom.Size = new System.Drawing.Size(69, 16);
            this.lbPrénom.TabIndex = 4;
            this.lbPrénom.Text = "Prénom :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(18, 60);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(48, 16);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nom :";
            // 
            // lbMatricule
            // 
            this.lbMatricule.AutoSize = true;
            this.lbMatricule.Location = new System.Drawing.Point(18, 28);
            this.lbMatricule.Name = "lbMatricule";
            this.lbMatricule.Size = new System.Drawing.Size(79, 16);
            this.lbMatricule.TabIndex = 0;
            this.lbMatricule.Text = "Matricule :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Êtes-vous commercial?";
            // 
            // chkBxOui
            // 
            this.chkBxOui.AutoSize = true;
            this.chkBxOui.BackColor = System.Drawing.Color.Transparent;
            this.chkBxOui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxOui.ForeColor = System.Drawing.Color.White;
            this.chkBxOui.Location = new System.Drawing.Point(216, 88);
            this.chkBxOui.Name = "chkBxOui";
            this.chkBxOui.Size = new System.Drawing.Size(48, 19);
            this.chkBxOui.TabIndex = 4;
            this.chkBxOui.Text = "Oui";
            this.chkBxOui.UseVisualStyleBackColor = false;
            this.chkBxOui.CheckedChanged += new System.EventHandler(this.chkBxOui_CheckedChanged);
            // 
            // chkBxNon
            // 
            this.chkBxNon.AutoSize = true;
            this.chkBxNon.BackColor = System.Drawing.Color.Transparent;
            this.chkBxNon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxNon.ForeColor = System.Drawing.Color.White;
            this.chkBxNon.Location = new System.Drawing.Point(275, 88);
            this.chkBxNon.Name = "chkBxNon";
            this.chkBxNon.Size = new System.Drawing.Size(52, 19);
            this.chkBxNon.TabIndex = 5;
            this.chkBxNon.Text = "Non";
            this.chkBxNon.UseVisualStyleBackColor = false;
            this.chkBxNon.CheckedChanged += new System.EventHandler(this.chkBxNon_CheckedChanged);
            // 
            // frmSalariés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 573);
            this.Controls.Add(this.chkBxNon);
            this.Controls.Add(this.chkBxOui);
            this.Controls.Add(this.gbDetailsUtilisateur);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.cbChoixSalarie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalariés";
            this.Text = "4";
            this.gbDetailsUtilisateur.ResumeLayout(false);
            this.gbDetailsUtilisateur.PerformLayout();
            this.pnlBoutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChoixSalarie;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.GroupBox gbDetailsUtilisateur;
        private System.Windows.Forms.Label lbPrénom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbMatricule;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbMatricule;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbTaux;
        private System.Windows.Forms.TextBox tbSalaireBrut;
        private System.Windows.Forms.Label lbSalaireBrut;
        private System.Windows.Forms.Label lbTauxCS;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbDateNaissance;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBxNon;
        private System.Windows.Forms.CheckBox chkBxOui;
        private System.Windows.Forms.Label lbChiffreAffaire;
        private System.Windows.Forms.Label lbCommission;
        private System.Windows.Forms.TextBox tbChiffreAffaire;
        private System.Windows.Forms.TextBox tbCommission;
    }
}

