using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET1.Model
{
    /// <summary>
    /// Classe Métier des absences.
    /// </summary>
    class Motif
    {
        private readonly int IdMotif;
        private readonly string Libelle;

        public Motif(int idMotif, string libelle)
        {
            IdMotif = idMotif;
            Libelle = libelle;
        }

        public int IdMotif1 => IdMotif;

        public string Libelle1 => Libelle;
    }
}
