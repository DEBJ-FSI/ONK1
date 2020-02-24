using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Vaerktoejskasse
    {
        public Haandvaerker Haandvaerker { get; set; }
        public DateTime VTKAnskaffet { get; set; }
        [ForeignKey("Haandvaerker")]
        public int VTKEjesAf { get; set; }
        public string VTKFabrikat { get; set; }
        public string VTKFarve { get; set; }
        [Key]
        public int VTKId { get; set; }
        public string VTKModel { get; set; }
        public string VTKSerienummer { get; set; }

        public List<Vaerktoej> Vaarktoejer { get; set; }
    }
}
