using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET1.Model
{
    /// <summary>
    /// Classe représentant chaque personnel.
    /// </summary>
    class Personnel
    {
        private readonly int IdPersonnel;
        private readonly int IdService;
        private readonly string Nom;
        private readonly string Prenom;
        private readonly string Tel;
        private readonly string mail;
        private List<Absence> LesAbsences;

        public Personnel(int idPersonnel, int idService, string nom, string prenom, string tel, string mail)
        {
            IdPersonnel = idPersonnel;
            IdService = idService;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            this.mail = mail;
            this.LesAbsences = new List<Absence>();
        }

        public int IdPersonnel1 { get => IdPersonnel; }
        public int IdService1 { get => IdService;  }
        public string Nom1 { get => Nom;}
        public string Prenom1 { get => Prenom;  }
        public string Tel1 { get => Tel; }
        public string Mail { get => mail; }
    }
}
