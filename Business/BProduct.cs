using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using System.Xml.Linq;

namespace Business
{
    public class BProduct
    {
        public List<Product> GetByName(string name)
        {
            List<Product> result = new List<Product>();

            DProduct data = new DProduct();

            var products = data.Get();
            
            result= products.Where(x=>x.name.Contains(name)).ToList();

            //foreach (var item in products) 
            //{
            //    if (item.name.ToLower() == name.ToLower())
            //    {
            //        result.Add(item);
            //    }
            //}

            return result;
        }

        public void UpdateProduct(Product product)
        {
            DProduct data = new DProduct();
            data.Update(product);
        }
        public void CrearProduct(Product product)
        {
            DProduct data = new DProduct();
            data.Update(product);
        }
        public void deleteProduct(int productId)
        {
            DProduct data = new DProduct();
            data.deleteProduct(productId);
        }

        
    }
}
