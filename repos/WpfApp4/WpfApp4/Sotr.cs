using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.DataModel
{
    public class Sotr
    {
        public int sotrID { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        public string family { get; set; }
        public string otch { get; set; }
        public int rojd { get; set; }
        public string pas { get; set; }
        public int doljID { get; set; }
        public Dolj dolj { get; set; }
    }
}
