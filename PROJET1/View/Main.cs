using MaterialSkin.Controls;
using PROJET1.Controller;
using PROJET1.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
namespace PROJET1.View
{
    public partial class Main : MaterialForm
    {
        private BindingSource bdsPersonnel = new BindingSource();
        private BindingSource bdsService = new BindingSource();
        private BindingSource bdsAbsence = new BindingSource();
        private BindingSource bdsMotif = new BindingSource();
        private bool enModif = false;

        private Controle controle;
        public Main(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            InitLesPersonnels();
            InitLesServices();
            InitMotif();
        }

      

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grpAjout.Enabled = true;
            dataPersonnel.Enabled = false;
            grpMain.Enabled = false;
        }

        private void btnAjoutConfirmer_Click(object sender, EventArgs e)
        {
            if (VerifChampsAjout())
            {
                int idpersonnel = 0;
                if (enModif)
                {
                    idpersonnel = int.Parse(dataPersonnel.SelectedRows[0].Cells["idpersonnel"].Value.ToString());
                }
              
                Service leService = (Service)bdsService.List[bdsService.Position];
                Personnel newPersonnel = new Personnel(idpersonnel, leService.Nom1, leService.IdService1, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text);

                if (enModif)
                {
                    MaterialDialog materialDialog = new MaterialDialog(this, "Modifier", "Voulez vous vraiment modifier ce personnel ? ", "Confirmer", true, "Annuler");
                    DialogResult result = materialDialog.ShowDialog(this);
                    if (((int)result) != 1) return;
                    controle.ModifPersonnel(newPersonnel);
                    
                        
                }
                else
                {
                    controle.AjoutPersonnel(newPersonnel);
                }
                
                InitLesPersonnels();
                ResetChampsAjout();
                
                grpMain.Enabled = true;
                dataPersonnel.Enabled = true;
                enModif = false;
            }
            else
            {
                MaterialSnackBar message = new MaterialSnackBar("Veuillez renseigner tous les champs", "OK", true);
                message.Show(this);
                
            }
        }

        private void btnAjoutAnnuler_Click(object sender, EventArgs e)
        {
            ResetChampsAjout();
            grpMain.Enabled = true;
            dataPersonnel.Enabled = true;

        }
        /// <summary>
        /// Réinitialise les champs de la fonction d'ajout de personnel.
        /// </summary>
        private void ResetChampsAjout()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            lblAjoutInfo.Text = "";
            cbService.SelectedIndex = 0;
            grpAjout.Enabled = false;
        }
        /// <summary>
        /// Vérifie si tous les champs sont remplis avant de soliciter la BDD pour ajouter un personnel.
        /// </summary>
        /// <returns>retourne vrai si aucun champ n'est vide</returns>
        private bool VerifChampsAjout()
        {
            if(txtNom.Text == "" || txtPrenom.Text == "" || txtTel.Text == "" || txtMail.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            if (VerifSelection(dataPersonnel))
            {
                MaterialSnackBar message = new MaterialSnackBar("Veuillez selectionner un personnel", "OK", true);
                message.Show(this);
            }
            else if (dataPersonnel.SelectedRows.Count > 1)
            {
                MaterialSnackBar message = new MaterialSnackBar("Veuillez ne selectionner qu'un personnel", "OK", true);
                message.Show(this);
            }
            else
            {
                Personnel lePersonnel = (Personnel)bdsPersonnel[bdsPersonnel.Position];
                lblAbsenceNom.Text = lePersonnel.Nom.ToUpper() + " " + lePersonnel.Prenom;
                InitAbsences(lePersonnel);
                tabControl.SelectedTab = tabAb;
                dataAbsence.Columns["idpersonnel"].Visible = false;
                dataAbsence.Columns["idmotif"].Visible = false;
                dataAbsence.Columns["datedebut"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataAbsence.Columns["datefin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataAbsence.Columns["motif"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
        }
        /// <summary>
        /// récupère tous les personnels,
        /// et rempli la DataGridView
        /// </summary>
        private void InitLesPersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
           ;
            bdsPersonnel.DataSource = lesPersonnels;
            dataPersonnel.DataSource = bdsPersonnel;
            dataPersonnel.Columns["idpersonnel"].Visible = false;
            dataPersonnel.Columns["idservice"].Visible = false;
            dataPersonnel.Columns["nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataPersonnel.Columns["prenom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataPersonnel.Columns["mail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Récupère tous les services
        /// et peuple la ComboBox
        /// </summary>
        private void InitLesServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdsService.DataSource = lesServices;
            cbService.DataSource = bdsService;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(VerifSelection(dataPersonnel))
            {
                MaterialSnackBar message = new MaterialSnackBar("Veuillez selectionner un personnel", "OK", true);
                message.Show(this);
            }
            else
            {

                MaterialDialog materialDialog = new MaterialDialog(this, "Supprimer", "Voulez vous vraiment supprimer ce(s) personnel(s) ? Toute suppression est irréversible.", "Confirmer", true, "Annuler");
                DialogResult result = materialDialog.ShowDialog(this);
                if(((int)result) == 1)
                {
                    foreach (DataGridViewRow row in dataPersonnel.SelectedRows)
                    {
                        int idpersonnel = int.Parse(row.Cells["idpersonnel"].Value.ToString());
                        controle.SupprPersonnel(idpersonnel);
                    }
                    InitLesPersonnels();

                }
               
               
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(dataPersonnel.SelectedRows.Count ==0)
            {
                MaterialSnackBar message = new MaterialSnackBar("Veuillez selectionner un personnel", "OK", true);
                message.Show(this);

            }else if(dataPersonnel.SelectedRows.Count > 1) {
                MaterialSnackBar message = new MaterialSnackBar("Veuillez ne selectionner qu'un personnel", "OK", true);
                message.Show(this);
            }
            else
            {
                enModif = true;
                grpAjout.Enabled = true;
                grpMain.Enabled = false;
                dataPersonnel.Enabled = false;
                Personnel lePersonnel = (Personnel)bdsPersonnel[bdsPersonnel.Position];
                txtNom.Text = lePersonnel.Nom;
                txtPrenom.Text = lePersonnel.Prenom;
                txtMail.Text = lePersonnel.Mail;
                txtTel.Text = lePersonnel.Tel;
                cbService.SelectedIndex = cbService.FindStringExact(lePersonnel.Service);
            }
                
               
        }
        /// <summary>
        /// Permet de vérifier qu'une ligne est sélectionnée 
        /// dans un DataGridView.
        /// </summary>
        /// <param name="data">la DataGridView cible</param>
        /// <returns>faux si une ligne est sélectionnée</returns>
        private bool VerifSelection(DataGridView data)
        {
            return data.SelectedRows.Count == 0;
        }
        /// <summary>
        /// Remplit la DataGridView des Absences.
        /// </summary>
        /// <param name="lePersonnel">Personnel dont il faut charger les absences.</param>
        private void InitAbsences(Personnel lePersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            lesAbsences = controle.GetAbsences(lePersonnel);
            bdsAbsence.DataSource = lesAbsences;
            dataAbsence.DataSource = bdsAbsence;
            dataAbsence.Columns["datedebut"].HeaderText = "Date Début";
            dataAbsence.Columns["datefin"].HeaderText = "Date Fin";

        }
        /// <summary>
        /// Initialise la ComboBox des Motifs.
        /// </summary>
        private void InitMotif()
        {
            bdsMotif.DataSource = controle.GetMotifs();
            cboMotif.DataSource = bdsMotif;
        }
    }
}
