using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class Fournisseur
    {
        [Key]
        public int FournisseurId { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
    }
}
