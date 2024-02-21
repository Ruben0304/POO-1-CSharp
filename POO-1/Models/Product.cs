using POO_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace POO_1.Models
{
    public class Product : Model,ITieneCategoria
    {
        public string name { get; set; }
        public float price { get; set; }
        public int category_id { get; set; }


        
        public Product(int id, string name,float price, int category_id) : base(id)
        {
            this.name = name;
            this.price = price;
            this.category_id = category_id;
      
        }


        public Category GetCategoria(Dictionary<int,Category> categories)
        {
            // Se va a asumir que los datos existen y son correctos, nunca devuelve null
            return categories.GetValueOrDefault(this.category_id);
        }



    

        
    }
}
