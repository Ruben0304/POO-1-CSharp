using POO_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1.Interfaces
{
    public interface ITieneCategoria
    {
        Category GetCategoria(Dictionary<int, Category> categorias);
    }
}
