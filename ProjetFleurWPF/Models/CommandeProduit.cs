using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetFleurWPF.Models
{
    public class CommandeProduit
    {
        [Key]
        public int CommandeProduitId { get; set; }

        public int CommandeId { get; set; }
        public Commande Commande { get; set; }

        public int? FleurId { get; set; }
        public Fleur Fleur { get; set; }

        public int? BouquetId { get; set; }
        public Bouquet Bouquet { get; set; }

        public int? BouquetPreconfigureId { get; set; }
        public BouquetPreconfigure BouquetPreconfigure { get; set; }
    }
}
