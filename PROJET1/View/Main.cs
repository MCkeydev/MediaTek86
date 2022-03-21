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
        private BindingSource bdsService;

        private Controle controle;
        public Main(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            InitLesPersonnels();
        }

      

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grpAjout.Enabled = true;
        }

        private void btnAjoutConfirmer_Click(object sender, EventArgs e)
        {
            if (VerifChampsAjout())
            {
                

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

        private void InitLesPersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
           ;
            bdsPersonnel.DataSource = lesPersonnels;
            dataPersonnel.DataSource = bdsPersonnel;
            dataPersonnel.Columns["idpersonnel"].Visible = false;
            dataPersonnel.Columns["idservice"].Visible = false;
            dataPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

      
    }
}
