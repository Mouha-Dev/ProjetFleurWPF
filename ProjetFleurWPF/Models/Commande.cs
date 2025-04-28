using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class Commande
    {
        [Key]
        public int CommandeId { get; set; }
        public string NumeroCommande { get; set; }
        public DateTime DateCommande { get; set; } = DateTime.Now;
        public string Statut { get; set; } = "En attente";
        public string MoyenPaiement { get; set; }
        public string StatutPaiement { get; set; } = "Non Payé";
        public double MontantTotal { get; set; }
        public string MessagePersonnalise { get; set; }

        // Relations
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public int VendeurId { get; set; }
        [ForeignKey("VendeurId")]
        public Vendeur Vendeur { get; set; }

        public ICollection<CommandeProduit> CommandeProduits { get; set; }
    }
}
