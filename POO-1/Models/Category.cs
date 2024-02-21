using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1.Models
{
    public class Category : Model
    {
        public string nombre { get; set; }


        public Category(int id,string nombre) : base(id) {

          this.nombre = nombre;

        }


        
    }
}
