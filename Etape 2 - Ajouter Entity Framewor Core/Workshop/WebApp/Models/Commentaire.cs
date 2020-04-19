﻿using System;
using System.ComponentModel.DataAnnotations;


namespace WebApp.Models
{
    public class Commentaire
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Adresse Mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Commemtaire")]
        public string Texte { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCommentaire { get; set; }
    }
}
