using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FITONKgrp7Backend.Models
{
    public class Vaerktoej
    {
        public Vaerktoejskasse Vaerktoejskasse { get; set; }
        [ForeignKey("Vaerktoejskasse")]
        public int Liggerivtk { get; set; }
        public DateTime VTAnskaffet { get; set; }
        public string VTFabrikat { get; set; }
        [Key]
        public int VTId { get; set; }
        public string VTModel { get; set; }
        public string VTSerienr { get; set; }
        public string VTType { get; set; }
    }
}
