using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;


namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Veuillez mettre un nom")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Veuillez mettre un prénom")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Veuillez mettre un genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Veuillez mettre une adresse")]
        public string Adresse { get; set; }               

        [Required(ErrorMessage = "Veuillez mettre un code postal")]
        // [StringLength(5, MinimumLength = 5, ErrorMessage = "Veuillez mettre un code postal à 5 chiffres")]
        [RegularExpression("([0-9]){5}", ErrorMessage = "Veuillez mettre un code postal à 5 chiffres")]
        public string Postal { get; set; }

        [Required(ErrorMessage = "Veuillez mettre une ville")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Veuillez mettre une adresse-mail")]
        [RegularExpression(@"^([\\w]+)@([\\w]+)\.( [\\w]+)$", ErrorMessage = "Veuillez mettre un format d'adresse-mail")]
        public string Mail { get; set; }


    
        [Required(ErrorMessage = "Veuillez mettre une date")]
        public string DateFormation { get; set; }

        [Required(ErrorMessage = "Veuillez choisir une formation")]
        public string Formation { get; set; }
    

  
        [Required(ErrorMessage = "Veuillez mettre un avis")]
        public string AvisCobol { get; set; }

        [Required(ErrorMessage = "Veuillez choisir un avis")]
        public string AvisCS { get; set; }

    }


}
