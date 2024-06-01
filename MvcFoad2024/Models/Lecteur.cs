using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Lecteur:Utilisateur
    {
        public String Specialite { get; set; }
        public virtual ICollection<Consultation> Consultation { get; set; }
        public virtual ICollection<Commentaire> Commentaire { get; set; }
    }
}