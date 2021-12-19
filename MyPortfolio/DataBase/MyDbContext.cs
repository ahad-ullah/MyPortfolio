using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.DataBase
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }
        public DbSet<Users> Users{ get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<UserAddress> Addresses { get; set; }
    } 
}
