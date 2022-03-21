using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJET1.Dal;
using PROJET1.View;
using System.Diagnostics;
using PROJET1.Model;
/// <summary>
/// Package du controlleur
/// </summary>
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

        public List<Personnel> GetLesPersonnels()
        {
            
            
            return AccesDonnees.GetLesPersonnels();
        }
    }
}
