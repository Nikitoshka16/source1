using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.DataModel
{
    public class Dolj
    {
        public int doljID { get; set; }
        [Required]
        [MaxLength(100)]
        public string obiz { get; set; }
        public int zp { get; set; }

        public string nal { get; set; }



    }
}
