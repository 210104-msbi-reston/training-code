using System;
using System.Collections.Generic;
namespace StoreDB
{
    /// <summary>
    /// This class has all the methods to perform CRUD operations
    /// </summary>
    public class ProductRepo
    {
        /// <summary>
        /// This method returns all products from DB (for now its returning from in-memory data)
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            List<Product> product=new List<Product>(){
                new Product(){Id=1,Name="Coffee", Created=new DateTime(28/01/1990), LocationId=1,Price=5.00M},
                new Product(){Id=2,Name="Tea", Created=new DateTime(28/01/1980), LocationId=1,Price=3.00M}
            };   
            return product;         
        }
    }
}