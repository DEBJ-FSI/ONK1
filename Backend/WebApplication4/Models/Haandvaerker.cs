using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FITONKgrp7Backend.Models
{
    public class Haandvaerker
    {
        public DateTime HVAnsaettelsedato { get; set; }
        public string HVEfternavn { get; set; }
        public string HVFagomraade { get; set; }
        public string HVFornavn { get; set; }
        [Key]
        public int HaandvaerkerId { get; set; }

        public Vaerktoejskasse Vaerktoejskasse { get; set; }
    }
}
