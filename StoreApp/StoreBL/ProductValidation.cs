using System;
using StoreDB;
using System.Collections.Generic;

namespace StoreBL
{
    public class ProductValidation
    {
        ProductRepo repo = new ProductRepo();
        public List<Product> CheckProducts(){
            var products=repo.GetAllProducts();
            if(products == null){
                throw new NullReferenceException("Products Not found. Check your DB");
            }
            else{
                return products;
            }
        }
    }
}
