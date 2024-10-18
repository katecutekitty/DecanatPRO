using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
                
        public DataContext() : base("DefaultConnection")
        { }

    }


}
