using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetFleurWPF.Models
{
    public class FleurBouquet
    {
        [Key]
        public int FleurBouquetId { get; set; }

        public int BouquetId { get; set; }
        public Bouquet Bouquet { get; set; }

        public int FleurId { get; set; }
        public Fleur Fleur { get; set; }
    }
}
