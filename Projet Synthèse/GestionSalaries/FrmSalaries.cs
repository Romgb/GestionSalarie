using GestionSalaraies;
using SalariesDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionSalaraies.Properties;
using System.Windows.Forms;
using Utilitaires;
using System.Globalization;

namespace Formulaire_Salarie
{
    public partial class frmSalariés : Form
    {
        Salarie salarie;
        Salaries salaries;
        Roles roles;
        Commercial commercial;
        ErrorProvider epSalarie = new ErrorProvider();
        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            Nouveau = 3,
            ModificationAnnuler = 4,
            Modifier = 5,
            FermetureDialogueResultYes = 6,
            FermetureDialogueResultNo = 7,
            CheckBxOui = 8,
            CheckBxNon = 9,
            ErreurChampsVidesCommercial = 10,
            AjoutValider = 11
        }
        public frmSalariés()
        {
            InitializeComponent();
            chargerUtilisateurs();
            GestionnaireContextes(Contextes.Initial);
        }

        #region Gestionnaire des contextes
        void GestionnaireContextes(Contextes contexte)

        {
            switch (contexte)
            {
                case Contextes.Initial:
                    cbChoixSalarie.Enabled = (cbChoixSalarie.Items.Count > 0);
                    btnNouveau.Enabled = true;
                    gbDetailsUtilisateur.Visible = false;
                    chkBxOui.Enabled = false;
                    chkBxNon.Enabled = false;
                    break;
                case Contextes.Consultation:
                    cbChoixSalarie.Enabled = (cbChoixSalarie.Items.Count > 0);
                    cbChoixSalarie.Enabled = true;
                    btnNouveau.Enabled = true;
                    chkBxOui.Enabled = false;
                    chkBxNon.Enabled = false;
                    gbDetailsUtilisateur.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = false;
                    tbMatricule.Enabled = false;
                    tbNom.Enabled = false;
                    tbPrenom.Enabled = false;
                    tbSalaireBrut.Enabled = false;
                    tbTaux.Enabled = false;
                    lbChiffreAffaire.Enabled = true;                   
                    lbCommission.Enabled = true;
                    tbChiffreAffaire.Enabled = false;
                    tbCommission.Enabled = false;
                    break;
                case Contextes.ModificationInitiale:
                    btnNouveau.Enabled = true;
                    gbDetailsUtilisateur.Visible = true;
                    cbChoixSalarie.Enabled = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbMatricule.ReadOnly = true;
                    tbNom.ReadOnly = true;
                    tbPrenom.ReadOnly = true;
                    dtpDateNaissance.Enabled = false;
                    tbSalaireBrut.ReadOnly = true;
                    tbTaux.ReadOnly = true;
                    break;
                case Contextes.Nouveau:
                    btnNouveau.Enabled = false;
                    gbDetailsUtilisateur.Visible = false;
                    cbChoixSalarie.Enabled = false;
                    chkBxOui.Enabled = true;
                    chkBxNon.Enabled = true;
                    tbMatricule.ReadOnly = false;
                    tbNom.ReadOnly = false;
                    tbPrenom.ReadOnly = false;
                    dtpDateNaissance.Enabled = true;
                    tbSalaireBrut.ReadOnly = false;
                    tbTaux.ReadOnly = false;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnModifier.Enabled = true;
                    break;
                case Contextes.ModificationAnnuler:
                    clearChamps();
                    btnNouveau.Enabled = true;
                    cbChoixSalarie.Enabled = true;
                    chkBxOui.Enabled = false;
                    chkBxNon.Enabled = false;
                    gbDetailsUtilisateur.Visible = false;
                    tbMatricule.ReadOnly = true;
                    tbNom.ReadOnly = true;
                    tbPrenom.ReadOnly = true;
                    dtpDateNaissance.Enabled = false;
                    tbSalaireBrut.ReadOnly = true;
                    tbTaux.ReadOnly = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnModifier.Enabled = false;
                    lbChiffreAffaire.Visible = true;
                    lbCommission.Visible = true;
                    
                    break;
                case Contextes.Modifier:
                    btnNouveau.Enabled = false;
                    cbChoixSalarie.Enabled = false;                  
                    gbDetailsUtilisateur.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbMatricule.ReadOnly = true;
                    tbNom.ReadOnly = false;
                    tbPrenom.ReadOnly = false;
                    dtpDateNaissance.Enabled = true;
                    tbSalaireBrut.ReadOnly = false;
                    tbTaux.ReadOnly = false;
                    tbChiffreAffaire.Enabled = true;
                    tbCommission.Enabled = true;
                    //cbRole.ReadOnly = false;
                    break;
                case Contextes.FermetureDialogueResultYes:
                    btnNouveau.Enabled = true;
                    cbChoixSalarie.Enabled = true;
                    gbDetailsUtilisateur.Visible = false;
                    btnModifier.Enabled = false;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    break;
                case Contextes.FermetureDialogueResultNo:
                    btnNouveau.Enabled = true;
                    cbChoixSalarie.Enabled = true;
                    gbDetailsUtilisateur.Visible = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;

                    break;
                case Contextes.CheckBxOui:
                    btnNouveau.Enabled = false;
                    cbChoixSalarie.Enabled = false;
                    gbDetailsUtilisateur.Visible = true;                    
                    chkBxOui.Enabled = false;
                    chkBxNon.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbMatricule.ReadOnly = false;
                    tbNom.ReadOnly = false;
                    tbPrenom.ReadOnly = false;
                    dtpDateNaissance.Enabled = true;
                    tbSalaireBrut.ReadOnly = false;
                    tbTaux.ReadOnly = false;
                    lbChiffreAffaire.Visible = true;
                    tbChiffreAffaire.Enabled = true;
                    lbCommission.Visible = true;
                    tbCommission.Enabled = true;
                    //cbChoixSalarie.Visible = true;
                    break;
                case Contextes.CheckBxNon:
                    btnNouveau.Enabled = true;
                    gbDetailsUtilisateur.Visible = true;
                    cbChoixSalarie.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbMatricule.ReadOnly = false;
                    tbNom.ReadOnly = false;
                    tbPrenom.ReadOnly = false;
                    dtpDateNaissance.Enabled = true;
                    tbSalaireBrut.Enabled = true;
                    tbTaux.ReadOnly = false;
                    lbChiffreAffaire.Visible = true;
                    tbChiffreAffaire.Enabled = false;
                    tbCommission.Enabled = false;
                    lbCommission.Visible = true;
                    break;
                case Contextes.ErreurChampsVidesCommercial:
                    btnNouveau.Enabled = false;
                    cbChoixSalarie.Enabled = false;
                    gbDetailsUtilisateur.Visible = true;
                    chkBxOui.Enabled = false;
                    chkBxNon.Enabled = false;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbMatricule.ReadOnly = false;
                    tbNom.ReadOnly = false;
                    tbPrenom.ReadOnly = false;
                    dtpDateNaissance.Enabled = true;
                    tbSalaireBrut.ReadOnly = false;
                    tbTaux.ReadOnly = false;
                    tbChiffreAffaire.Enabled = chkBxOui.Checked;
                    tbCommission.Enabled = chkBxOui.Checked;
                       
                   
                        break;
                   
                   
                //case Contextes.AjoutValider:
                  

                default:
                    break;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationAnnuler);

        }
        #endregion

        #region Chargement utilisateur existant

        private void chargerUtilisateurs()
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
            salaries = new Salaries();
            ISauvegarde sauvegarde = MonApplication.DispositifSauvegarde;
            salaries.Load(sauvegarde, Settings.Default.AppData);
            foreach (Salarie item in salaries)
            {
                cbChoixSalarie.Items.Add(item.Matricule);
            }
        }
        private void chargerValeursSalarie()
        {
            tbMatricule.Text = salarie.Matricule;
            tbNom.Text = salarie.Nom;
            tbPrenom.Text = salarie.Prenom;
            dtpDateNaissance.Text = salarie.DateNaissance.ToString();
            tbSalaireBrut.Text = salarie.SalaireBrut.ToString();
            tbTaux.Text = salarie.TauxCS.ToString();
            //cbRole.Text = salarie.Role;
        }

        #endregion

        #region Modification d'un salarié
        private void modificationSalarie()
        {
            ErrorProvider ep = new ErrorProvider();

            try
            {
                salaries.Remove(salarie);
                if (IsValidChamps())
                {
                    ajouteNewSalarie();
                    salaries.Add(salarie);
                }
                
            }
            catch (Exception ex)
            {

                ep.SetError(btnValider, ex.Message);
            }

        }
        #endregion

        #region Méthode globale de vérification des champs 
        private bool IsValidChamps()
        {
            bool valid = true;

            
            if (!Salarie.IsMatriculeValide(tbMatricule.Text))
            {
                epSalarie.SetError(tbMatricule, "Le matricule est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbMatricule, "");
            }
            if (!Salarie.IsNomPrenomValide(tbNom.Text))
            {
                epSalarie.SetError(tbNom, "Le nom est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbNom, "");
            }
            if (!Salarie.IsNomPrenomValide(tbNom.Text))
            {
                epSalarie.SetError(tbPrenom, "Le prénom est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbPrenom, "");
            }
            if (!Salarie.IsDateNaissanceValide(DateTime.Parse(dtpDateNaissance.Text)))
            {
                epSalarie.SetError(dtpDateNaissance, "La date de naissance est incorrecte");
                return false;
            }
            else
            {
                epSalarie.SetError(dtpDateNaissance, "");
            }
            decimal salaireConverti;
            bool conv = decimal.TryParse(tbSalaireBrut.Text, out salaireConverti);
            if (!conv)
            {
                epSalarie.SetError(tbSalaireBrut, "La valeur doit être un décimal");
                return false;
            }
            if (!Salarie.IsSalaireValide(salaireConverti))
            {
                epSalarie.SetError(tbSalaireBrut, "Le salaire brut est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbSalaireBrut, "");
            }
            decimal tauxConverti;
            bool convers = decimal.TryParse(tbTaux.Text, out tauxConverti);
            if (!convers)
            {
                epSalarie.SetError(tbSalaireBrut, "La valeur doit être un décimal");
                return false;
            }
            if (!Salarie.IsTauxCSValide(tauxConverti))
            {
                epSalarie.SetError(tbTaux, "Le tauxCS est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbTaux, "");
            }

            return valid;
        }
        #endregion

        #region Méthodes validating

        private void tbMatricule_Validating(object sender, CancelEventArgs e)
        {
           
            if (Salarie.IsMatriculeValide(tbMatricule.Text))
            {
                epSalarie.SetError(tbMatricule, string.Empty);
                
            }
            else
            {

                epSalarie.SetError(tbMatricule, "Le matricule est incorrect");
            }
        }
        private void tbNom_Validating(object sender, CancelEventArgs e)
        {
            
            if (!Salarie.IsNomPrenomValide(tbNom.Text))
            {
                epSalarie.SetError(tbNom, "Le nom est incorrect");
            }
            else
            {
                epSalarie.SetError(tbNom, "");
                
            }
        }
        private void tbPrenom_Validating(object sender, CancelEventArgs e)
        {
           
            if (!Salarie.IsNomPrenomValide(tbNom.Text))
            {
                epSalarie.SetError(tbPrenom, "Le prénom est incorrect");
            }
            else
            {
                epSalarie.SetError(tbPrenom, "");
                
            }
        }
        private void tbDateNaissance_Validating(object sender, CancelEventArgs e)
        {
            
            if (!Salarie.IsDateNaissanceValide(DateTime.Parse(dtpDateNaissance.Text)))
            {
                epSalarie.SetError(dtpDateNaissance, "La date de naissance est incorrecte");
            }
            else
            {
                epSalarie.SetError(dtpDateNaissance, "");
            }
        }
        private void tbSalaireBrut_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();
            decimal salaireConverti;
            bool conv = decimal.TryParse(tbSalaireBrut.Text, out salaireConverti);
            if (!conv)
            {
                ep.SetError(tbSalaireBrut, "La valeur doit être un décimal");
            }
            else if (!Salarie.IsSalaireValide(salaireConverti))
            {
                ep.SetError(tbSalaireBrut, "Le salaire brut est incorrect");
            }
            else
            {
                ep.SetError(tbSalaireBrut, "");
            }
        }
        private void tbTaux_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();
            decimal tauxConverti;
            bool conv = decimal.TryParse(tbTaux.Text, out tauxConverti);
            if (!conv)
            {
                ep.SetError(tbSalaireBrut, "La valeur doit être un décimal");
            }
            else if (!Salarie.IsTauxCSValide(tauxConverti))
            {
                ep.SetError(tbTaux, "Le tauxCS est incorrect");
            }
            else
            {
                ep.SetError(tbTaux, "");
            }
        }
        private void tbCommission_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();
            decimal commission;
            bool comconv = decimal.TryParse(tbTaux.Text, out commission);
            if (!comconv)
            {
                ep.SetError(tbSalaireBrut, "La valeur doit être un décimal");
            }
            else if (!Salarie.IsTauxCSValide(commission))
            {
                ep.SetError(tbTaux, "La commission est incorrect");
            }
            else
            {
                ep.SetError(tbTaux, "");
            }
        }
        private void tbChiffreAffaire_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();
            decimal chiffreAffaire;
            bool chiffreAffconv = decimal.TryParse(tbTaux.Text, out chiffreAffaire);
            if (!chiffreAffconv)
                if (!chiffreAffconv)
                {
                    ep.SetError(tbSalaireBrut, "La valeur doit être un décimal");
                }
                else if (!Salarie.IsTauxCSValide(chiffreAffaire))
                {
                    ep.SetError(tbTaux, "Le chiffre d'affaire est incorrect");
                }
                else
                {
                    ep.SetError(tbTaux, "");
                }
        }
        #endregion

        #region Ajout du nouveau salarié


        private void ajoutCommercial()
        {
            Commercial commercial = new Commercial();
            //Salarie salarie = (commercial)Salarie;

            //commercial.ChiffreAffaire = tbChiffreAffaire.Text.

            try
            {
                salarie = new Salarie();
                salarie.Matricule = tbMatricule.Text;
                salarie.Nom = tbNom.Text;
                salarie.Prenom = tbPrenom.Text;
                salarie.DateNaissance = DateTime.Parse(dtpDateNaissance.Text);
                salarie.SalaireBrut = decimal.Parse(String.Format(CultureInfo.CurrentCulture, tbSalaireBrut.Text));
                salarie.TauxCS = decimal.Parse(String.Format(CultureInfo.CurrentUICulture, tbTaux.Text));
                commercial.Commission = decimal.Parse(String.Format(CultureInfo.CurrentCulture, tbCommission.Text));
                commercial.ChiffreAffaire = decimal.Parse(String.Format(CultureInfo.CurrentCulture, tbChiffreAffaire.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidChampsCommercial()
        {
            bool valid = true;

            if (IsValidChamps() != true)
            {
                epSalarie.SetError(tbMatricule, "Le matricule est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbMatricule, "");
            }
            if (!Salarie.IsNomPrenomValide(tbNom.Text))
            {
                epSalarie.SetError(tbNom, "Le nom est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbNom, "");
            }
            if (!Salarie.IsNomPrenomValide(tbNom.Text))
            {
                epSalarie.SetError(tbPrenom, "Le prénom est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbPrenom, "");
            }
            if (!Salarie.IsDateNaissanceValide(DateTime.Parse(dtpDateNaissance.Text)))
            {
                epSalarie.SetError(dtpDateNaissance, "La date de naissance est incorrecte");
                return false;
            }
            else
            {
                epSalarie.SetError(dtpDateNaissance, "");
            }
            decimal salaireConverti;
            bool conv = decimal.TryParse(tbSalaireBrut.Text, out salaireConverti);
            if (!conv)
            {
                epSalarie.SetError(tbSalaireBrut, "La valeur doit être un décimal");
                return false;
            }
            if (!Salarie.IsSalaireValide(salaireConverti))
            {
                epSalarie.SetError(tbSalaireBrut, "Le salaire brut est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbSalaireBrut, "");
            }
            decimal tauxConverti;
            bool convers = decimal.TryParse(tbTaux.Text, out tauxConverti);
            if (!convers)
            {
                epSalarie.SetError(tbSalaireBrut, "La valeur doit être un décimal");
                return false;
            }
            if (!Salarie.IsTauxCSValide(tauxConverti))
            {
                epSalarie.SetError(tbTaux, "Le tauxCS est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbTaux, "");
            }
            decimal commissionConvertie;
            bool converse = decimal.TryParse(tbCommission.Text, out commissionConvertie);
            if (!converse)
            {
                epSalarie.SetError(tbSalaireBrut, "La valeur doit être un décimal");
                return false;
            }
            if (!Salarie.IsTauxCSValide(tauxConverti))
            {
                epSalarie.SetError(tbTaux, "Le tauxCS est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbTaux, "");
            }
            decimal chiffreAffaire;
            bool conversion = decimal.TryParse(tbCommission.Text, out commissionConvertie);
            if (!conversion)
            {
                epSalarie.SetError(tbSalaireBrut, "La valeur doit être un décimal");
                return false;
            }
            if (!Salarie.IsTauxCSValide(tauxConverti))
            {
                epSalarie.SetError(tbTaux, "Le tauxCS est incorrect");
                return false;
            }
            else
            {
                epSalarie.SetError(tbTaux, "");


            }
            return valid;
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
      //      GestionnaireContextes(Contextes.Nouveau);

            if (salaries.Contains(salarie))
            {              
                modificationSalarie();
            }
            if (chkBxOui.Checked)
            {
                ajoutCommercial();
                ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
                salaries.Save(serialiseur, Settings.Default.AppData);
                cbChoixSalarie.Items.Add(salarie.Matricule);
                clearChamps();
                DialogResult result = MessageBox.Show("Vous venez d'ajouter un commercial.\n" +
                    "Souhaitez-vous faire une nouvelle opération?",
                    "Fin de l'opération",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    GestionnaireContextes(Contextes.FermetureDialogueResultYes);
                }
                else
                {
                    this.Close();
                }
            }

            if (IsValidChamps() == true)
            {
                ajouteNewSalarie();
                salaries.Add(salarie);
                ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
                salaries.Save(serialiseur, Settings.Default.AppData);
                cbChoixSalarie.Items.Add(salarie.Matricule);
                clearChamps();
                DialogResult result = MessageBox.Show("Vous d'ajouter un nouveau salarié\n" +
                    "Souhaitez-vous faire une nouvelle opération",
                    "Salarié ajouté",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    GestionnaireContextes(Contextes.FermetureDialogueResultYes);
                    
                }
                else
                {
                    this.Close(); 
                }
            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs n'ont pas été remplis", "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
               // GestionnaireContextes(Contextes.ErreurChampsVidesCommercial);
            }
        }
        private void ajouteNewSalarie()
        {
            try
            {
                salarie = new Salarie();
                salarie.Matricule = tbMatricule.Text;
                salarie.Nom = tbNom.Text;
                salarie.Prenom = tbPrenom.Text;
                salarie.DateNaissance = DateTime.Parse(dtpDateNaissance.Text);
                salarie.SalaireBrut = decimal.Parse(String.Format(CultureInfo.CurrentCulture, tbSalaireBrut.Text));
                salarie.TauxCS = decimal.Parse(String.Format(CultureInfo.CurrentUICulture, tbTaux.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Petite méthode "Clear"
        //Petite méthode permettant de "Clear" tous les champs après avoir ajouté le nouveau salarié
        private void clearChamps()
        {
            cbChoixSalarie.ResetText();
            tbMatricule.Clear();
            tbNom.Clear();
            tbPrenom.Clear();
            dtpDateNaissance.ResetText();
            tbSalaireBrut.Clear();
            tbTaux.Clear();
            chkBxOui.Checked = false;
            chkBxNon.Checked = false;
        }
        #endregion

        #region Modification d'un salarié
        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.Modifier);

        }
        #endregion

        #region Rôles
        private void ChargerRoles()
        {
            roles = new Roles();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            roles.Load(serialiseur, Settings.Default.AppData);
        }


        #endregion

        #region Brouillon
        //private void chkbSalarié_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkbSalarié.Checked == true)
        //    {
        //        chkbCommercial.Checked = false;
        //        cbChoixSalarie.Enabled = true;
        //        btnNouveau.Enabled = true;

        //    }
        //    else
        //    {
        //        cbChoixSalarie.Enabled = false;
        //        btnNouveau.Enabled = false;
        //    }

        //}
        //private void chkbCommercial_CheckedChanged(object sender, EventArgs e)
        //{
        ////    Méthode GetType pour faire marcher les boutons checks
        //    Salarie salarie = salarie.GetType();



        //    if (chkbCommercial.Checked == true)
        //    {
        //        chkbSalarié.Checked = false;
        //        cbChoixSalarie.Enabled = true;
        //        btnNouveau.Enabled = true;

        //    }
        //    else
        //    {
        //        chkbCommercial.Enabled = false;
        //        btnNouveau.Enabled = false;
        //    }
        //}

        //private void ModifierUtilisateur()
        //{

        //    if (IsValidChamps())
        //    {
        //        try
        //        {
        //            salarie.Matricule = tbIdentifiant.Text;
        //            salarie.MotDePasse = tbMotDePasse.Text;
        //            tbNom.Text = salarie.Nom;
        //            //chkCompteBloque.Checked = salarie.CompteBloque;
        //            salarie.Matricule = tbIdentifiant.Text;
        //            salarie.MotDePasse = tbMotDePasse.Text;
        //            tbNom.Text = salarie.Nom;
        //            //chkCompteBloque.Checked = salarie.CompteBloque;
        //        }
        //        catch (Exception)
        //        {
        //            // a programmer
        //        }


        //    }
        //}
        //private bool IsValidChamps()
        //{
        //    bool valid = true;

        //    if (!Utilisateur.IsIdentifiantValide(tbIdentifiant.Text))
        //    {
        //        valid = false;
        //        epUtilisateur.SetError(tbIdentifiant, "L'identifiant n'est pas valide");

        //    }
        //    else
        //    {
        //        epUtilisateur.SetError(tbIdentifiant, string.Empty);
        //    }
        //    return valid;
        //}
        #endregion

        #region Evenements

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.Nouveau);
            clearChamps();

        }
        private void cbChoixSalarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = salaries.ExtraireSalarie(cbChoixSalarie.Items[cbChoixSalarie.SelectedIndex].ToString());
            chargerValeursSalarie();
            GestionnaireContextes(Contextes.Consultation);
        }
        private void chkBxOui_CheckedChanged(object sender, EventArgs e)
        
        {
            GestionnaireContextes(Contextes.CheckBxOui);
        }

        private void chkBxNon_CheckedChanged(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.CheckBxNon);
        }


        #endregion
    }
}
