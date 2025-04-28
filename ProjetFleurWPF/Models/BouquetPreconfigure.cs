using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFleurWPF.Models
{
    public class BouquetPreconfigure
    {
        [Key]
        public int BouquetPreconfigureId { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public string Description { get; set; }

        public ICollection<FleurBouquetPreconfigure> FleurBouquetPreconfigures { get; set; }
    }
}
