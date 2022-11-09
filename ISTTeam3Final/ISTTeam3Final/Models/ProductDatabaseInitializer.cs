using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

namespace ISTTeam3Final.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));

        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Category 1"
                },

                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Category 2"
                },

                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Category 3"
                },

                new Category()
                {
                    CategoryId = 4,
                    CategoryName = "Category 4"
                },

                new Category()
                {
                    CategoryId = 5,
                    CategoryName = "Category 5"
                },
            };
            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 11,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 12,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 13,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 14,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 15,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                },
                new Product
                {
                    ProductId = 16,
                    ProductName = "",
                    ProductDescription = "",
                    ImagePath = "",
                    UnitPrice = 0,
                    CategoryID = 0
                }

        };

            return products;
        }
    }
}