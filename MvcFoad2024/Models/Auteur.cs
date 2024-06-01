using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Auteur
    {
        public int AuteurId { get; set; }
        public Memoire Memoire { get; set; }

        [ForeignKey("Utilisateur")]
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }

    }
}