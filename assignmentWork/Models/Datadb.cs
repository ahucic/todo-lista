using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentWork.Models
{
    public class Datadb : DbContext
    {
        public Datadb(DbContextOptions<Datadb> options) : base(options)
        {

        }
        public DbSet<Register> regtb { get; set; }
        public DbSet<list> listtb { get; set; }
    }
}
