using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcFoad2024.Models
{
    public class Document
    {

     
            [Key]
            public int Id { get; set; }
            public string Extension { get; set; }
            public byte[] Contenu { get; set; }

            public ICollection<Memoire> Memoires { get; set; }

        }
    }