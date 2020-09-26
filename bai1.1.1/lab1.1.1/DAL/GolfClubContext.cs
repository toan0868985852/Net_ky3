using lab1._1._1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab1._1._1.DAL
{
    public class GolfClubContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}