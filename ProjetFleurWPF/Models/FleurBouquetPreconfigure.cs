using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetFleurWPF.Models
{
    public class FleurBouquetPreconfigure
    {
        [Key]
        public int FleurBouquetPreconfigureId { get; set; }

        public int BouquetPreconfigureId { get; set; }
        public BouquetPreconfigure BouquetPreconfigure { get; set; }

        public int FleurId { get; set; }
        public Fleur Fleur { get; set; }
    }
}
