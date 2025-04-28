using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class Bouquet
    {
        [Key]
        public int BouquetId { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public string Message { get; set; }

        public ICollection<FleurBouquet> FleurBouquets { get; set; }
    }
}
