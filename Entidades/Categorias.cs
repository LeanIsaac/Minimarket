using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categorias
    {
        private int codigo_ca;
        private string descripcion_ca;

        public int Codigo_ca { get => codigo_ca; set => codigo_ca = value; }
        public string Descripcion_ca { get => descripcion_ca; set => descripcion_ca = value; }
    }
}
