using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using netCore.Data;
using System;
using System.Linq;
using netCore.Models;
namespace netCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                // if (context.Person.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Pe.AddRange(
                   
                //     },

                //     new Student
                //     {
                        
                //     }
                // );
                // context.SaveChanges();
            }
        }
    }
}