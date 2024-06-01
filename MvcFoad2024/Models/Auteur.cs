﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Auteur:Utilisateur
    {
        public String Specialite { get; set; }
        public virtual ICollection<Memoire> Memoire { get; set; }
     

        
    }
}