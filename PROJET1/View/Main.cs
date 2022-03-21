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

        private Controle controle;
        public Main(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            InitLesPersonnels();
            InitLesServices();
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
                Service leService = (Service)bdsService.List[bdsService.Position];
                Personnel newPersonnel = new Personnel(idpersonnel, leService.Nom1, leService.IdService1, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text);
                controle.AjoutPersonnel(newPersonnel);
                InitLesPersonnels();
                ResetChampsAjout();
                
                grpMain.Enabled = true;
                dataPersonnel.Enabled = true;

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
            tabControl.SelectedTab = tabAb;
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
        private void InitLesServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdsService.DataSource = lesServices;
            cbService.DataSource = bdsService;
        }

    }
}
