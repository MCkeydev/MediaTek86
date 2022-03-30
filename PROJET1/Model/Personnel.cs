using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Model
{
    /// <summary>
    /// Classe représentant chaque personnel.
    /// </summary>
    public class Personnel
    {
        private readonly int idPersonnel;
        private readonly int idService;
        private readonly string nom;
        private readonly string prenom;
        private readonly string tel;
        private readonly string mail;
        private readonly string service;
        

        public Personnel(int idPersonnel, string service, int idService, string nom, string prenom, string tel, string mail)
        {
            this.idPersonnel = idPersonnel;
            this.idService = idService;
            this.service = service;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
          
           
        }

        public int IdPersonnel => idPersonnel;

        public int IdService => idService;

        public string Nom => nom;

        public string Prenom => prenom;

        public string Tel => tel;

        public string Mail => mail;

        public string Service => service;

        
    }
}
