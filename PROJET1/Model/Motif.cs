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
    public class Motif
    {
        private readonly int idMotif;
        private readonly string libelle;

        public Motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }
        public override string ToString()
        {
            return this.libelle;
        }

    }
}
