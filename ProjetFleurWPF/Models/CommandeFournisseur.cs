using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class CommandeFournisseur
    {
        [Key]
        public int CommandeFournisseurId { get; set; }
        public string NomFleur { get; set; }
        public string Couleur { get; set; }
        public DateTime DateCommande { get; set; } = DateTime.Now;
        public string Statut { get; set; } = "En attente";
        public string ValidePar { get; set; }
        public DateTime? DateValidation { get; set; }
    }
}
