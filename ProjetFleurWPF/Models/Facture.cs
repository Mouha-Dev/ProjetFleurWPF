using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class Facture
    {
        [Key]
        public int FactureId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string MoyenPaiement { get; set; }
        public double MontantTotal { get; set; }
        public string MessagePersonnalise { get; set; }

        // Relation vers Commande
        public int CommandeId { get; set; }
        [ForeignKey("CommandeId")]
        public Commande Commande { get; set; }
    }
}
