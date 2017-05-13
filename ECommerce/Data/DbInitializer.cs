using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            if (context.Users.Any())
            {
                return;
            }

            var users = new ApplicationUser[]
            {
                new ApplicationUser{ UserName = "ctester", PhoneNumber = "16688886666"},
                new ApplicationUser{ UserName = "stester", PhoneNumber = "17455556666"},
            };

            foreach (var item in users)
            {
                userManager.CreateAsync(item, "123456").Wait();
            }


            var sellers = new Seller[]
            {
                new Seller
                {
                    ApplicationUserID = context.Users.Single(i => i.UserName == "stester").Id,
                    Grade = Seller.DefaultGrade,
                    TotalGrade = 0.0,
                    GradeQuantity = 0,
                    CreditCardNumber = "11112222"
                }
            };

            foreach (var item in sellers)
            {
                context.Add(item);
                context.SaveChanges();
            }

            var customers = new Customer[]
            {
                new Customer
                {
                    ApplicationUserID = context.Users.Single(i => i.UserName == "ctester").Id,
                    CreditCardNumber = "12121212"
                }
            };

            foreach (var item in customers)
            {
                context.Add(item);
                context.SaveChanges();
            }

            var commodities = new Commodity[]
            {
                new Commodity
                {
                    Price = 20.5M,
                    Name = "Calculus",
                    Description = "A Calculus book.",
                    Quantity = 12,
                    SellerID = context.Seller.Single(
                        i => i.ApplicationUserID == context.Users.Single(j => j.UserName == "stester").Id).ID,
                }
            };

            foreach (var item in commodities)
            {
                context.Add(item);
                context.SaveChanges();
            }



        }
    }
}
