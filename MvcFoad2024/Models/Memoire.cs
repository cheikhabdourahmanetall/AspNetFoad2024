using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MvcFoad2024.Models
{
    [Table("td_memoire")]
    public class Memoire
    {
        [Key]
        public int IdMemoire { get; set; }

        [Display(Name = "Titre memoire"), Required(ErrorMessage = "*"), MaxLength(200, ErrorMessage = "la taille maximale est de 200 caracteres")]
        public string Nom { get; set; }
        [Display(Name = "Niveau"), Required(ErrorMessage = "*"), MaxLength(20, ErrorMessage = "la taille maximale est de 20 caracteres")]
        public string Niveau { get; set; }
        [Display(Name = "Auteur ou redacteur"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "la taille maximale est de 100 caracteres")]
        public string Auteur { get; set; }
        [Display(Name = "Annee de memoire"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "la taille maximale est de 10 caracteres")]
        public string Annee { get; set; }
        [Display(Name = "specialite"), Required(ErrorMessage = "*"), MaxLength(150, ErrorMessage = "la taille maximale est de 150 caract")]
        public string Specialite { get; set; }
        [Display(Name = "Description"), Required(ErrorMessage = "*"), MaxLength(2000, ErrorMessage = "la taille maximale est de 2000 caracteres")]
        public string Description { get; set; }

        [Display(Name = "Etat"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        public string etat { get; set; }
        public int noteFinale { get; set; }
        [Display(Name = "Appreciation"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        public string appreciation { get; set; }
        [Display(Name = "Verdict"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "Trop long")]
        
        public string verdict { get; set; }

        [ForeignKey("Document")]
        public int DocumentId { get; set; }

        public Document Document { get; set; }

        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public ICollection<Auteur> Auteurs { get; set; }
        public ICollection<Commentaire> Commentaires { get; set; }
        public ICollection<Consultation> Consultations { get; set; }



    }
}
    