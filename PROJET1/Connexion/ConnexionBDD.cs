﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
/// <summary>
/// Package de Connexion
/// </summary>
namespace PROJET1.Connexion
{
    /// <summary>
    /// Classe de connexion à la base de donnée
    /// en Singleton.
    /// </summary>
    public class ConnexionBDD
    {
        /// <summary>
        /// Instance unique de notre classe de Connexion.
        /// Initialisation à "null" pour la méthode "GetInstance"
        /// </summary>
        private static ConnexionBDD Instance = null;

        /// <summary>
        /// Object de connexion à la BDD.
        /// </summary>
        private MySqlConnection Connexion;

        /// <summary>
        /// Objet d'execution de requêtes SQL.
        /// Nécessite une requete SQL et une instance de MySqlConnection.
        /// </summary>
        private MySqlCommand Commande;

        /// <summary>
        /// Curseur permettant de récupérer et lire les resultats de la requête.
        /// </summary>
        private MySqlDataReader Curseur;

        /// <summary>
        /// Constructeur privé qui sera appellé dans GetInstance,
        /// afin de vérifier qu'il n'existe qu'une seule instance de la classe.
        /// </summary>
        /// <param name="chaineConnexion">Chaine de connexion à la BDD</param>
        private ConnexionBDD(string chaineConnexion)
        {
            try
            {
                this.Connexion = new MySqlConnection(chaineConnexion);
                Connexion.Open();

            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
           
        }

        public static ConnexionBDD GetInstance(string chaineConnexion)
        {
        
            if (Instance is null)
            {
                Instance = new ConnexionBDD(chaineConnexion);
            }
            return Instance;
        }

        /// <summary>
        /// Méthode effectuant requête SQL.
        /// Ne retourne rien car résultats disponibles par le Curseur.
        /// La requête est préparée en cas de paramètres afin d'éviter une injection SQL.
        /// </summary>
        /// <param name="requeteSQL">Chaîne de requête SQL</param>
        /// <param name="parameters">Dictionnaire de paramètres optionnel</param>
        public void Select(string requeteSQL, Dictionary<string, object> parameters)
        {
            try
            {
                Commande = new MySqlCommand(requeteSQL, Connexion);
                if(parameters is object)
                {
                    foreach(KeyValuePair<string, object> parameter in parameters)
                    {
                        Commande.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                Commande.Prepare();
                Curseur = Commande.ExecuteReader();
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Méthode qui exécute une requête non select.
        /// Ici donc pas de résultats dans le curseur.
        /// </summary>
        /// <param name="requeteSQL">Chaine de requete SQL</param>
        /// <param name="parameters">Dictionaire optionnel de paramètres</param>
        public void Update(string requeteSQL, Dictionary<string, object> parameters)
        {
            try{
                Commande = new MySqlCommand(requeteSQL, Connexion);
                if (parameters is object)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        Commande.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                Commande.Prepare();
                Commande.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Méthode qui indique si nous sommes à la fin du curseur
        /// </summary>
        /// <returns>false si fin du curseur</returns>
        public bool Read()
        {
            if(Curseur is null)
            {
                return false;
            }
            try
            {
                return Curseur.Read();
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Méthode qui retourne le champ désiré dans le curseur;
        /// </summary>
        /// <param name="champ">Champ voulu</param>
        /// <returns>null si le champ n'est pas présent dans le Curseur</returns>
        public object Field(string champ)
        {
            if(Curseur is null)
            {
                return null;
            }
            try
            {
                return Curseur[champ];
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Ferme le Curseur s'il n'est pas null
        /// </summary>
        public void Close()
        {
            if(Curseur is object)
            {
                Curseur.Close();
            }
        }

    }
}