using SuperStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperStore.DAL
{
    public class SuperStoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SuperStoreContext>

    {
        protected override void Seed(SuperStoreContext context)
        {
            var customer = new List<Customer>
            {
                new Customer {FirstName="Paul" , LastName="OConnor" , LastPurchase=DateTime.Parse("2004-09-10") },
                new Customer {FirstName="Michael", LastName="Phelps", LastPurchase=DateTime.Parse("2004-09-10") },
                new Customer {FirstName= "Bret", LastName="Johnson", LastPurchase=DateTime.Parse("2004-09-11")},
                new Customer {FirstName="Andy", LastName="Wright", LastPurchase=DateTime.Parse("2004-09-11") }
            };
            customer.ForEach(s => context.Customer.Add(s));
            context.SaveChanges();

            var employee = new List<Employee>
            {
                new Employee {FirstName="Michael", LastName="Jordan" },
                new Employee {FirstName="Katie", LastName="Ledecky" },
                new Employee {FirstName="Justin", LastName="Rose" },
                new Employee {FirstName="Sean", LastName="Thompson" },
                new Employee {FirstName="James", LastName="Lucena" }
            };

            var product = new List<Product>
            {
                new Product {Name="iPhone 6", ProductID=3495829, ProductPrice=600  },
                new Product {Name="TV", ProductID=9485037, ProductPrice=350 },
                new Product {Name="Laptop",ProductID=2849028, ProductPrice=1100 },
                new Product {Name="Large bag of pet food", ProductID=4905927, ProductPrice=50 }


            };
        }
    }
}