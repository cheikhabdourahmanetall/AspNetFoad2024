using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MvcFoad2024.Models
{
    [Table("td_utilisateur")]
    public class Utilisateur
    {

        [Key]
        public int IdUser { get; set; }

        [Display(Name = "Nom"), Required(ErrorMessage = "*"), MaxLength(50, ErrorMessage = "la taille maximale est de 200 caracteres")]
        public string Nom { get; set; }
        [Display(Name = "Prenom"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "la taille maximale est de 20 caracteres")]
        public string Prenom { get; set; }
        [Display(Name = "Telephone"), Required(ErrorMessage = "*"), MaxLength(50, ErrorMessage = "la taille maximale est de 100 caracteres")]
        public string Telephone { get; set; }
        [Display(Name = "Email"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "la taille maximale est de 10 caracteres")]
        public string Email { get; set; }
        [Display(Name = "MotDePasse"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "la taille maximale est de 150 caract")]
        public string MotDePassee { get; set; }
        
        [Display(Name = "Matricule"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "la taille maximale est de 2000 caracteres")]
        public string Matricule { get; set; }
        [Display(Name = "Etat"), Required(ErrorMessage = "*"), MaxLength(100, ErrorMessage = "la taille maximale est de 2000 caracteres")]
        public string Etat { get; set; }

       

      
        public virtual ICollection<Bibliothecaire> Bibliothecaire { get; set; }
      
     


    }

}

