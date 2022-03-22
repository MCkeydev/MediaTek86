﻿using System;
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
    public class Absence
    {
        private readonly int idPersonnel;
        private readonly DateTime dateDebut;
        private readonly int idMotif;
        private readonly DateTime dateFin;
        private readonly string motif;

        public Absence(int idPersonnel, DateTime dateDebut, int idMotif, DateTime dateFin, string motif)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.idMotif = idMotif;
            this.dateFin = dateFin;
            this.motif = motif;
        }

        public int IdPersonnel => idPersonnel;

        public string DateDebut => dateDebut.ToLongDateString();

        public int IdMotif => idMotif;

        public string DateFin => dateFin.ToLongDateString();

        public string Motif => motif;

      
    }
}
