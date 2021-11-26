using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netCore.Models;
// namespace 
namespace netCore.Data{

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        



    

        public DbSet<netCore.Models.Employee> Employee { get; set; }



    

        public DbSet<netCore.Models.Person> Person { get; set; }



    

        public DbSet<netCore.Models.Student> Student { get; set; }



    

        public DbSet<netCore.Models.Category> Category { get; set; }



    

        public DbSet<netCore.Models.Product> Product { get; set; }



    

        public DbSet<netCore.Models.Account> Account { get; set; }



    

        public DbSet<netCore.Models.Movie> Movie { get; set; }

    }
}
