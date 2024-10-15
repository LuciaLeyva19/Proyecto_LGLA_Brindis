using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class ImprimirLista
    {
        private ListaEnlazada lista;

        public ImprimirLista(ListaEnlazada lista)
        {
            this.lista = lista;
        }

        public void Ejecutar()
        {
            Console.WriteLine("Elementos de la lista:");
            lista.ImprimirLista();
        }
    }
}
