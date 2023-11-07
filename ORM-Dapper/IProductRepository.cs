using System;
using System.Collections.Generic;


namespace ORM_Dapper
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(); 
        void CreateProduct(string name, double price, int categoryID); 

    }
}
