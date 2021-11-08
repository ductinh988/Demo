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
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        ProductID = "001",
                        ProductName = "Vũ Văn Nhân",
                        UnitPrice = "oi bạn ơi",
                        Quantity = "123"
                    },

                    new Product
                    {
                        ProductID = "002 ",
                        ProductName = "Đinh Thế Du",
                        UnitPrice = "Comedy",
                        Quantity = "345"
                    },

                    new Product
                    {
                        ProductID = "003",
                        ProductName = "Nguyễn Quang Anh",
                        UnitPrice = "Comedy",
                        Quantity = "678"
                    },

                    new Product
                    {
                        ProductID = "004",
                        ProductName = "Vũ Văn Đức",
                        UnitPrice = "Western",
                        Quantity = "JQK"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}