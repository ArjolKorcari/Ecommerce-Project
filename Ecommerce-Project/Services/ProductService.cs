using System.Collections.Generic;
using Ecommerce_Project.Models;

namespace Ecommerce_Project.Services
{
    public class ProductsService
    {
        private List<Products> productList = new List<Products>();

        public ProductsService()
        {
            // Inicializimi i listës së produkteve në konstruktor
            productList = new List<Products>
            {
                new Products(1, "Watch", "An elegant watch for men"),
                new Products(2, "Laptop", "Expensive Laptop"),
                new Products(3, "Iphone 15 Pro", "Quality phone")
            };
        }

        public List<Products> GetAllProducts()
        {
            return productList;
        }

        public void AddProduct(Products product)
        {

            productList.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            Products productToRemove = FindProductById(productId);
            if (productToRemove != null)
                productList.Remove(productToRemove);
        }
       
        public void UpdateProduct(Products updatedProduct)
        {
            DeleteProduct(updatedProduct.Id);
            productList.Add(updatedProduct);
        }

        public Products FindProductById(int productId)
        {
            return productList.Find(p => p.Id == productId);
        }

    }
}
