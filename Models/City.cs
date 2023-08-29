using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAbd.Models
{
    public class City
    {
        [Key]

        public int Id { get; set; }
        public string PName { get; set; }
        public string Image { get; set; }
        public string Place { get; set; }

    }
}
