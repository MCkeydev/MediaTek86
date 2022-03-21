using PROJET1.Connexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using PROJET1.Model;
/// <summary>
/// Package d'acces aux données
/// </summary>
namespace PROJET1.Dal
{
    /// <summary>
    /// Classe Outil nous permettant d'obtenir les informations 
    /// nécessaires dans la BDD.
    /// </summary>
    public static class AccesDonnees
    {
        /// <summary>
        /// chaine de connexion au SGBDR
        /// </summary>
        private static string chaineConnexion = "server=localhost;user id=personnel;password=motdepasse;persistsecurityinfo=True;database=personnel";
       
        /// <summary>
        /// Effectue une requête SELECT sur la table 'responsable'.
        /// </summary>
        /// <param name="login">identifiant à tester</param>
        /// <param name="pwd">mot de passe à tester</param>
        /// <returns>true si utilisateur existe dans la BDD</returns>
        public static bool Authentification(string login, string pwd)
        {
            string request = "SELECT * FROM responsable WHERE binary login=@login AND pwd=SHA2(@pwd, 256) ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.Select(request, parameters);
           
            if (connexion.Read())
            {
                connexion.Close();
                return true;
            }
            else
            {
                connexion.Close();
                return false;
            }
        }
        
        /// <summary>
        /// Retrouve la table 'personnel' de la BDD.
        /// </summary>
        /// <returns>Liste de tout le personnel.</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            string request = "SELECT p.*, s.nom FROM personnel p JOIN service s ON p.idservice = s.idservice ";
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Select(request, null);
            List<Personnel> lesPersonnels = new List<Personnel>();
            while (c.Read())
            {
                
                Personnel lePersonnel = new Personnel((int)c.Field("idpersonnel"),
                    (int)c.Field("idservice"),
                    (string)c.Field("nom"),
                    (string)c.Field("prenom"),
                    (string)c.Field("tel"),
                    (string)c.Field("mail"));
                lesPersonnels.Add(lePersonnel);
            }
            c.Close();

            return lesPersonnels;

        }
    }
}
