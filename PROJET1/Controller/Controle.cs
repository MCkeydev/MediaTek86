using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJET1.Dal;
using PROJET1.View;
using System.Diagnostics;
using PROJET1.Model;

namespace PROJET1.Controller
{
    /// <summary>
    /// Controlleur de l'application.
    /// </summary>
    public class Controle
    {
        private readonly FrmAuth FrmAuth;
        private readonly Main FrmMain;
        public Controle()
        {
            this.FrmMain = new Main(this);
            this.FrmMain.ShowDialog();
            //this.FrmAuth = new FrmAuth(this);
            //this.FrmAuth.ShowDialog();
        }
        /// <summary>
        /// Appelle la méthode Authentification d'Acces donnees,
        /// en fonction du resultat obtenu,
        /// donne acces au programme
        /// </summary>
        /// <param name="login">Identifiant renseigné sur le formulaire de Connexion</param>
        /// <param name="pwd">Mot de passe renseigné.</param>
        /// <returns>false si l'utilisateur n'existe pas dans la base de données.</returns>
        public bool Authentification(string login, string pwd)
        {
            if(AccesDonnees.Authentification(login, pwd))
            {
                FrmAuth.Hide();
                (new Main(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Appelle la méthode GetLesPersonnels d'AccesDonnees,
        /// et en retourne le resultat.
        /// </summary>
        /// <returns>Liste des personnels de la BDD</returns>
        public List<Personnel> GetLesPersonnels()
        {
            
            
            return AccesDonnees.GetLesPersonnels();
        }
        /// <summary>
        /// Appelle la méthode GetLesServices d'AccesDonnees,
        /// et en retourne le résultat.
        /// </summary>
        /// <returns>Liste des services de la BDD</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }
        /// <summary>
        /// Appelle la méthode AjoutPersonnel
        /// D'AccesDonnees
        /// </summary>
        /// <param name="lePersonnel">Nouveau Personnel à ajouter</param>
        public void AjoutPersonnel(Personnel lePersonnel)
        {
            AccesDonnees.AjoutPersonnel(lePersonnel);
        }


        /// <summary>
        /// Appelle la méthode SupprPersonnel D'AccesDonnees
        /// </summary>
        /// <param name="idpersonnel">ID du personnel à supprimer</param>
        public void SupprPersonnel(int idpersonnel)
        {
            AccesDonnees.SupprPersonnel(idpersonnel);
        }
        /// <summary>
        /// Appelle la fonction ModifPersonnel d'AccesDonnees
        /// </summary>
        /// <param name="lePersonnel"></param>
        public void ModifPersonnel(Personnel lePersonnel)
        {
            AccesDonnees.ModifPersonnel(lePersonnel);
        }
        /// <summary>
        /// Appelle la méthode GetAbsences d'AccesDonnees
        /// </summary>
        /// <param name="lePersonnel">Personnel dont il faut charger les absences.</param>
        /// <returns>Liste des absences</returns>
        public List<Absence> GetAbsences(Personnel lePersonnel)
        {
            return AccesDonnees.GetAbsences(lePersonnel);
        }
        /// <summary>
        /// Appelle la méthode GetMotifs d'AccesDonnees.
        /// </summary>
        /// <returns>List des Motifs</returns>
        public List<Motif> GetMotifs()
        {
            return AccesDonnees.GetMotifs();
        }
        /// <summary>
        /// Appelle la méthode AjoutAbsence d'AccesDonnees.
        /// </summary>
        /// <returns></returns>
        public void AjoutAbsence(Absence absence)
        {
            AccesDonnees.AjoutAbsence(absence);

        }
        /// <summary>
        /// Appelle la méthode SupprAbsence d'AccesDonnees
        /// </summary>
        /// <param name="absence"></param>
        public void SupprAbsence(Absence absence)
        {

            AccesDonnees.SupprAbsence(absence);
        }
        /// <summary>
        /// Appelle la méthode ModifAbsence d'AccesDonnees.
        /// </summary>
        /// <param name="oldAbsence"></param>
        /// <param name="newAbsence"></param>
        public void ModifAbsence(Absence oldAbsence, Absence newAbsence)
        {
            AccesDonnees.ModifAbsence(oldAbsence, newAbsence);
        }
    }
}
