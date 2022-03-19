using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
namespace PROJET1.View
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
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
                lblAjoutInfo.Text = "Veuillez renseigner tous les champs";
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
    }
}
