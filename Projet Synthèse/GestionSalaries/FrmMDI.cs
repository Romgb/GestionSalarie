using Formulaire_Salarie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitaires;

namespace GestionSalaraies
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent(); 
            //ToolStripMenuItem tSMI = new ToolStripMenuItem();
            //tSMI.Text = " Quitter l'application ";
            //tSMI.Click += new System.EventHandler(this.btnQuitter_Click);
            //this.menuGestionUtilisateurs.DropDownItems.Add(tSMI);
            btnQuitter.Click += btnQuitter_Click;
           
        }

        private void chargementSalarie(object sender, EventArgs e)
        {
            FrmUtilisateurs frmUtilisateurs = new FrmUtilisateurs();
        }

        private void BtnNewFormulaireUtilisateur_Click(object sender, EventArgs e)
        {
            FrmUtilisateurs frmUtilisateurs = new FrmUtilisateurs();
            frmUtilisateurs.MdiParent = this;
            frmUtilisateurs.Show();
        }

        private void bntNewFormulaireSalarie_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bntNewFormulaireSalarie = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmSalariés")
                {
                    frm.Focus();
                    bntNewFormulaireSalarie = true;
                }
            }

            if (!bntNewFormulaireSalarie)
            {
                frmSalariés frmSalarie = new frmSalariés();
                frmSalarie.MdiParent = this;
                frmSalarie.Show();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMDI_ResizeEnd(object sender, EventArgs e)
        {
            Refresh();
        }

        private void menuGestionSalaries_Click(object sender, EventArgs e)
        {

        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
