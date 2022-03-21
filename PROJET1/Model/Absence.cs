using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// summary
/// </summary>
namespace PROJET1.Model
{ 
    /// <summary>
    /// Classe Métier correspondant à la table Absence de la BDD.
    /// </summary>
    class Absence
    {
        private readonly int IdPersonnel;
        private readonly string DateDebut;
        private readonly int IdMotif;
        private readonly string DateFin;

        public Absence(int idPersonnel, string dateDebut, int idMotif, string dateFin)
        {
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            IdMotif = idMotif;
            DateFin = dateFin;
        }

        public int IdPersonnel1 { get => IdPersonnel; }
        public string DateDebut1 { get => DateDebut; }
        public int IdMotif1 { get => IdMotif;  }
        public string DateFin1 { get => DateFin;  }
    }
}
