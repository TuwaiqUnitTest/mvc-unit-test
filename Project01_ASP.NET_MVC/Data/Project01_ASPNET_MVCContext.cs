using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project01_ASP.NET_MVC.Models;

namespace Project01_ASP.NET_MVC.Data
{
    public class Project01_ASPNET_MVCContext : DbContext
    {
        public Project01_ASPNET_MVCContext (DbContextOptions<Project01_ASPNET_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Project01_ASP.NET_MVC.Models.Book> Book { get; set; }
    }
}
