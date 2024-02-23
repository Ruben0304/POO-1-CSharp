using POO_1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1.Models
{
    public class Store
    {
        public static Dictionary<int, Category> categories {  get; set; }
        public static Dictionary<int, Product> products { get; set; }

        public Store() {
           categories = new Dictionary<int, Category>();
           products = new Dictionary<int, Product>();
           Create10Categories();
           Create200Products();
        }


        private void Create10Categories()
        {
            Category c = null;

            for (int i = 0; i < 10; i++)
            {
                c = CategoryFaker.CreateCategory();

                categories.Add(c.id,c);
            }
        }

        private void Create200Products()
        {
            Product p = null;

            for (int i = 0; i < 200; i++)
            {
                p = ProductFaker.CreateProduct();

                products.Add(p.id, p);
            }
        }
    }
}
