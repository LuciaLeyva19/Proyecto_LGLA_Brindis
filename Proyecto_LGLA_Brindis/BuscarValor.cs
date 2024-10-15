using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class BuscarValor
    {
        private ListaEnlazada lista;

        public BuscarValor(ListaEnlazada lista)
        {
            this.lista = lista;
        }

        public void Ejecutar()
        {
            Console.Write("Ingrese el valor a buscar: ");
            int valor = int.Parse(Console.ReadLine());
            Nodo valorBuscado = lista.BuscarValor(valor);
            Console.WriteLine(valorBuscado != null ? "Valor encontrado: " + valorBuscado.Valor : "Valor no encontrado.");
        }
    }
}
