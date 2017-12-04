using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPB2_HFA.Models
{
    public class Protocolo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titulo é obrigatorio")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Titulo é obrigatorio")]
        public string Detalhes  { get; set; }


    }
}