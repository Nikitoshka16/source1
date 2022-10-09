using System;
using System.Data.Entity;
using System.Linq;

namespace Bb
{
    public class Model1 : DbContext
    {
       
        public Model1()
            : base("name=Model1")
        {
        }

       public DbSet<dolj> Doljs { get; set; }
    }

}