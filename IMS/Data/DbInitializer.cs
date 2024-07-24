using IMS.Models;

namespace IMS.Data
{
    public static class DbInitializer
    {
        public static void Initialize(InventoryDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
                return; //Database has been initialized

            var categories = new Category[]
            {
                new Category {Name = "Electronics"},
                new Category {Name = "Books"}
            };

            foreach (Category c in categories)
                context.Categories.Add(c);

            context.SaveChanges();

            var products = new Product[] {
                new Product {Name = "Laptop", Price = 999.99M, Category = categories[0]},
                new Product {Name = "Book", Price = 19.99M, Category = categories[1]}
            };

            foreach (Product p in products)
                context.Products.Add(p);

            context.SaveChanges();
        }
    }
}
