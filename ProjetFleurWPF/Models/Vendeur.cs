using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class Vendeur
    {
        [Key]
        public int VendeurId { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }

        public ICollection<Commande> Commandes { get; set; }
    }
}
