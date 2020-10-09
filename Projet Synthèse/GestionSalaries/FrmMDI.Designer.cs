namespace GestionSalaraies
{
    partial class FrmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.barreMenus = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionUtilisateurs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewFormulaireUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionSalaries = new System.Windows.Forms.ToolStripMenuItem();
            this.bntNewFormulaireSalarie = new System.Windows.Forms.ToolStripMenuItem();
            this.barreMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // barreMenus
            // 
            this.barreMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barreMenus.BackColor = System.Drawing.Color.Transparent;
            this.barreMenus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barreMenus.BackgroundImage")));
            this.barreMenus.Dock = System.Windows.Forms.DockStyle.None;
            this.barreMenus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.barreMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.menuGestionUtilisateurs,
            this.menuGestionSalaries});
            this.barreMenus.Location = new System.Drawing.Point(0, 0);
            this.barreMenus.Name = "barreMenus";
            this.barreMenus.Size = new System.Drawing.Size(323, 24);
            this.barreMenus.TabIndex = 1;
            this.barreMenus.Text = "menuStrip1";
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnQuitter});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(50, 20);
            this.menuFichier.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnQuitter.Size = new System.Drawing.Size(153, 22);
            this.btnQuitter.Text = "Quitter";
            // 
            // menuGestionUtilisateurs
            // 
            this.menuGestionUtilisateurs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFormulaireUtilisateur});
            this.menuGestionUtilisateurs.Name = "menuGestionUtilisateurs";
            this.menuGestionUtilisateurs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuGestionUtilisateurs.Size = new System.Drawing.Size(140, 20);
            this.menuGestionUtilisateurs.Text = "Gestion des utilisateurs";
            // 
            // btnNewFormulaireUtilisateur
            // 
            this.btnNewFormulaireUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("btnNewFormulaireUtilisateur.Image")));
            this.btnNewFormulaireUtilisateur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewFormulaireUtilisateur.Name = "btnNewFormulaireUtilisateur";
            this.btnNewFormulaireUtilisateur.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewFormulaireUtilisateur.Size = new System.Drawing.Size(278, 22);
            this.btnNewFormulaireUtilisateur.Text = "Nouveau formulaire utilisateur";
            this.btnNewFormulaireUtilisateur.Click += new System.EventHandler(this.BtnNewFormulaireUtilisateur_Click);
            // 
            // menuGestionSalaries
            // 
            this.menuGestionSalaries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntNewFormulaireSalarie});
            this.menuGestionSalaries.Name = "menuGestionSalaries";
            this.menuGestionSalaries.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuGestionSalaries.Size = new System.Drawing.Size(121, 20);
            this.menuGestionSalaries.Text = "Gestion des salariés";
            this.menuGestionSalaries.Click += new System.EventHandler(this.menuGestionSalaries_Click);
            // 
            // bntNewFormulaireSalarie
            // 
            this.bntNewFormulaireSalarie.Name = "bntNewFormulaireSalarie";
            this.bntNewFormulaireSalarie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.bntNewFormulaireSalarie.Size = new System.Drawing.Size(263, 22);
            this.bntNewFormulaireSalarie.Text = "Nouveau formulaire Salarie";
            this.bntNewFormulaireSalarie.Click += new System.EventHandler(this.bntNewFormulaireSalarie_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 489);
            this.Controls.Add(this.barreMenus);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.barreMenus;
            this.Name = "FrmMDI";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmMDI_ResizeEnd);
            this.barreMenus.ResumeLayout(false);
            this.barreMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip barreMenus;
        private System.Windows.Forms.ToolStripMenuItem menuGestionUtilisateurs;
        private System.Windows.Forms.ToolStripMenuItem btnNewFormulaireUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem menuGestionSalaries;
        private System.Windows.Forms.ToolStripMenuItem bntNewFormulaireSalarie;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem btnQuitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        //private System.Windows.Forms.ErrorProvider epUtilisateur;
    }
}

