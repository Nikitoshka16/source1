using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Data
{
    public class Uslugi
    {
        [Key]
        public int uslugiID { get; set; }
        public string u_opis { get; set; }
        public double price { get; set; }
        public string vaj { get; set; }
    }
}
