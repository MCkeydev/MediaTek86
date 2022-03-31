using Gestion.Connexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Gestion.Model;

namespace Gestion.Dal
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
            string request = "SELECT p.*, s.nom as service FROM personnel p JOIN service s ON p.idservice = s.idservice ";
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Select(request, null);
            List<Personnel> lesPersonnels = new List<Personnel>();
            while (c.Read())
            {

                Personnel lePersonnel = new Personnel((int)c.Field("idpersonnel"),
                    (string)c.Field("service"),
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

        /// <summary>
        /// Retrouvela table 'Service' de la BDD
        /// </summary>
        /// <returns>Liste de Tous les services</returns>
        public static List<Service> GetLesServices()
        {
            string request = "SELECT * FROM service";
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Select(request, null);
            List<Service> lesServices = new List<Service>();
            while (c.Read())
            {

                Service leService = new Service((int)c.Field("idservice"), (string)c.Field("nom")
                    );
                lesServices.Add(leService);
            }
            c.Close();

            return lesServices;
        }
        /// <summary>
        /// Permet d'ajouter un personnel à la base de données.
        /// </summary>
        /// <param name="lePersonnel">Personnel à ajouter</param>
        public static void AjoutPersonnel(Personnel lePersonnel)
        {
            string request = "INSERT INTO personnel(idservice,nom, prenom, tel, mail) VALUES(@idservice, @nom, @prenom, @tel, @mail)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idservice", lePersonnel.IdService);
            parameters.Add("@nom", lePersonnel.Nom);
            parameters.Add("@prenom", lePersonnel.Prenom);
            parameters.Add("@tel", lePersonnel.Tel);
            parameters.Add("@mail", lePersonnel.Mail);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.Update(request, parameters);


        }
        /// <summary>
        /// Supprime une personnel de la base de Données,
        /// supprime aussi les absences correspondantes
        /// </summary>
        /// <param name="idpersonnel"></param>

        public static void SupprPersonnel(int idpersonnel)
        {
            string request = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";
            string requestAbsence = "DELETE FROM absence WHERE idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Update(requestAbsence, parameters);
            c.Update(request, parameters);


        }
        /// <summary>
        /// Modifie un personnel dans la base de données
        /// </summary>
        /// <param name="lePersonnel">Personnel avec les nouvelles informations</param>
        public static void ModifPersonnel(Personnel lePersonnel)
        {
            string request = "UPDATE personnel SET idservice = @idservice, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail WHERE idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", lePersonnel.IdPersonnel);
            parameters.Add("@idservice", lePersonnel.IdService);
            parameters.Add("@nom", lePersonnel.Nom);
            parameters.Add("@prenom", lePersonnel.Prenom);
            parameters.Add("@tel", lePersonnel.Tel);
            parameters.Add("@mail", lePersonnel.Mail);
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Update(request, parameters);
        }
        /// <summary>
        /// Recupère la liste des absences d'un personnel dans la BDD.
        /// </summary>
        /// <param name="lePersonnel">Personnel identifiant les absences</param>
        /// <returns>Liste des absences.</returns>
        public static List<Absence> GetAbsences(Personnel lePersonnel)
        {
            string request = "SELECT a.*, m.libelle as motif FROM absence a JOIN motif m ON a.idmotif = m.idmotif WHERE idpersonnel = @idpersonnel ORDER BY datedebut DESC";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", lePersonnel.IdPersonnel);
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Select(request, parameters);
            List<Absence> lesAbsences = new List<Absence>();
            while (c.Read())
            {
                Absence absence = new Absence((int)c.Field("idpersonnel"), (DateTime)c.Field("datedebut"), (int)c.Field("idmotif"), (DateTime)c.Field("datefin"), (string)c.Field("motif"));
                lesAbsences.Add(absence);

            }
            c.Close();
            return lesAbsences;
        }
        /// <summary>
        /// Récupère la liste des motifs dans la base de données
        /// </summary>
        /// <returns>liste des motifs</returns>
        public static List<Motif> GetMotifs()
        {
            string request = "SELECT * FROM motif";
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Select(request, null);
            List<Motif> lesMotifs = new List<Motif>();
            while (c.Read())
            {
                Motif motif = new Motif((int)c.Field("idmotif"), (string)c.Field("libelle"));
                lesMotifs.Add(motif);
            }
            c.Close();
            return lesMotifs;
        }
        /// <summary>
        /// Ajoute une absence.
        /// </summary>
        /// <param name="absence">Object correspondant à l'absence à insérer</param>
        public static void AjoutAbsence(Absence absence)
        {
            string request = "INSERT INTO absence(idpersonnel, datedebut, idmotif, datefin) VALUES(@idpersonnel, @datedebut, @idmotif, @datefin)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datefin", DateTime.Parse(absence.DateFin));
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Update(request, parameters);

        }
        /// <summary>
        /// Supprime une absence
        /// </summary>
        /// <param name="absence">Object correspondant à l'absence à supprimer.</param>
        public static void SupprAbsence(Absence absence)
        {

            string request = "DELETE FROM absence WHERE DATE(datedebut) = DATE(@datedebut) AND idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.DateDebut);

            parameters.Add("@idpersonnel", absence.IdPersonnel);

            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Update(request, parameters);
        }

        /// <summary>
        /// Modifie une absence
        /// </summary>
        /// <param name="oldAbsence">Ancienne absence à modifier</param>
        /// <param name="newAbsence">Nouvelle absence modifiée</param>
        public static void ModifAbsence(Absence oldAbsence, Absence newAbsence)
        {
            string request = "UPDATE absence SET datedebut = @datedebut, idmotif = @idmotif, datefin = @datefin WHERE idpersonnel = @idpersonnel AND datedebut = @olddatedebut";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", newAbsence.DateDebut);
            parameters.Add("@idmotif", newAbsence.IdMotif);
            parameters.Add("@datefin", DateTime.Parse(newAbsence.DateFin));
            parameters.Add("@idpersonnel", newAbsence.IdPersonnel);
            parameters.Add("@olddatedebut", oldAbsence.DateDebut);
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
            c.Update(request, parameters);
        }

    }
}
