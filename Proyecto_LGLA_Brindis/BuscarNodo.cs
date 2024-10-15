using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class BuscarNodo
    {
        private ListaEnlazada lista;

        public BuscarNodo(ListaEnlazada lista)
        {
            this.lista = lista;
        }

        public void Ejecutar()
        {
            Console.Write("Ingrese el valor a buscar: ");
            int valor = int.Parse(Console.ReadLine());
            Nodo encontrado = lista.BuscarNodo(valor);
            Console.WriteLine(encontrado != null ? "Nodo encontrado: " + encontrado.Valor : "Nodo no encontrado.");
        }
    }
}
