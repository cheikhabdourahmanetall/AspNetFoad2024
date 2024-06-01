using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Expert:Utilisateur
    {
        public String Specialite { get; set; }
        public virtual ICollection<Commentaire> Commentaire { get; set; }
    }
}