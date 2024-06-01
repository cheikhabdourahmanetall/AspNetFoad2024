using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcFoad2024.Models
{
    public class BdtallContext: DbContext
    {
        public BdtallContext():base("conntallddb") 
        {
        
        }

        public DbSet<Memoire> memoire { get; set; }
        public DbSet<Utilisateur> utilisateur { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<Consultation> consultation { get; set; }
        public DbSet<Commentaire> commentaire { get; set; }
        public DbSet<Document> document { get; set; }
        public DbSet<Auteur> auteur { get; set; }

    }
}