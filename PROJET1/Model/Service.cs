using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Model
{
    /// <summary>
    /// Classe métier des personnels.
    /// </summary>
    public class Service
    {
        private readonly int IdService;
        private readonly string Nom;

        public Service(int idService, string nom)
        {
            IdService = idService;
            Nom = nom;
        }

        public int IdService1 { get => IdService; }
        public string Nom1 { get => Nom;  }

        /// <summary>
        /// Override de la méthode ToString();
        /// </summary>
        /// <returns>Retourne le nom du Service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}








