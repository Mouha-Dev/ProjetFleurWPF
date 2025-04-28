using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class Fleur
    {
        [Key]
        public int FleurId { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public string Couleur { get; set; }
        public string Description { get; set; }
    }
}
