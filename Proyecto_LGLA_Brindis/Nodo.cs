using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class Nodo
    {
        public int valor;
        public Nodo Sig;

        public Nodo(int valor)
        {
            this.valor = valor;
        }

        public int Valor { get => valor; set => valor = value; }
        internal Nodo sig { get => sig; set => sig = value; }
    }
}
