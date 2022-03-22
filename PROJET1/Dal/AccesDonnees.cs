﻿using PROJET1.Connexion;
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
        /// Supprime une personnel de la base de Données
        /// </summary>
        /// <param name="idpersonnel"></param>

        public static void SupprPersonnel(int idpersonnel)
        {
            string request = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);
            ConnexionBDD c = ConnexionBDD.GetInstance(chaineConnexion);
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
                Absence absence = new Absence((int)c.Field("idpersonnel"), (DateTime)c.Field("datedebut"),(int)c.Field("idmotif"), (DateTime)c.Field("datefin"), (string)c.Field("motif"));
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
   
    }
}
