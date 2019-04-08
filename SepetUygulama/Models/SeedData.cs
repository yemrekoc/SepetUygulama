using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SepetUygulama.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            SepetAppContext context = app.ApplicationServices.GetRequiredService<SepetAppContext>();
            context.Database.Migrate();

            //if (!context.Products.Any())
            //{
            //    context.Products.AddRange(
            //        new Product() { PrintingArea = "üst köşe", PrintType = "logo", Type = "Cüzdan" },
            //        new Product() {  PrintingArea = "üst köşe", PrintType = "resim", Type = "Çanta" }
            //        );
            //    context.SaveChanges();
            //}
            //if (!context.Customers.Any())
            //{
            //    context.Customers.AddRange(
            //        new Customer() {  Name = "Gereksiz", Addres = "Lorem Ipsum dolor sit amet", Surname = "Gereksiz" },
            //        new Customer() {  Name = "Gereksiz", Addres = "Lorem Ipsum dolor sit amet", Surname = "Gereksiz" }

            //        );
            //    context.SaveChanges();
            //}
            //if (!context.Orders.Any())
            //{
            //    context.Orders.AddRange(
            //        new Order() { CustomerId = 1, ProductId = 1, Date = "10/10/2018" },
            //        new Order() { CustomerId = 2, ProductId = 2, Date = "10/10/2018" }
            //        );
            //    context.SaveChanges();
            //}

            
        }
    }
}
