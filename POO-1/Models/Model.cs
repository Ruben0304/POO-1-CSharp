using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1.Models
{
    public abstract class Model
    {
        public int id { get; set; }

        public Model(int id) { this.id = id; }
    }
}
