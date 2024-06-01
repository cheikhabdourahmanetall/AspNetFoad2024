using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Bibliothecaire:Utilisateur
    {

        public string type { get; set; }
        public ICollection<Memoire> Memoires { get; set; }
        
       

       
    }
}