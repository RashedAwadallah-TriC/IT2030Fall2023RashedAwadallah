using System.Collections.Generic;

namespace RashedApparel.Models
{
    public class ProductData
    {


        public static List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel{
                    ProductId = 1,
                    ProductName = "Liverpool Home Kit 23/24",
                    ProductDescription = "Official Jersey",
                    ProductImage = "/images/product1.png",
                    ProductPrice = 70.00m
                },

               new ProductModel{
                    ProductId = 2,
                    ProductName = "Liverpool Away Kit 23/24",
                    ProductDescription = "Official Jersey",
                    ProductImage = "/images/product2.png",
                    ProductPrice = 79.00m
                },

               new ProductModel{
                    ProductId = 3,
                    ProductName = "Man City Home Kit 23/24",
                    ProductDescription = "Official Jersey",
                    ProductImage = "/images/product3.png",
                    ProductPrice = 85.00m
                },

               new ProductModel{
                    ProductId = 4,
                    ProductName = "Man City Away Kit 23/24",
                    ProductDescription = "Official Jersey",
                    ProductImage = "/images/product4.png",
                    ProductPrice = 80.00m
                },

               new ProductModel{
                    ProductId = 5,
                    ProductName = "Arsenal Home Kit 23/24",
                    ProductDescription = "Official Jersey",
                    ProductImage = "/images/product5.png",
                    ProductPrice = 85.00m
                },

                new ProductModel{
                    ProductId = 6,
                    ProductName = "Arsenal 3rd Kit 23/24",
                    ProductDescription = "Official Jersey",
                    ProductImage = "/images/product6.png",
                    ProductPrice = 75.00m
                }
            };

            return products;
        }
    
        public static ProductModel GetProduct(int id)
        {
            List<ProductModel> products = ProductData.GetProducts();
            foreach (ProductModel product in products)
            {
                if(product.ProductId == id)
                    return product;
            }
            return new ProductModel();
        }
    }
}
