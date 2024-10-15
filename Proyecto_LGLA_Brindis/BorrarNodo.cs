using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class BorrarNodo
    {
        private ListaEnlazada lista;

        public BorrarNodo(ListaEnlazada lista)
        {
            this.lista = lista;
        }

        public void Ejecutar()
        {
            Console.Write("Ingrese el valor a borrar: ");
            int valor = int.Parse(Console.ReadLine());
            bool borrado = lista.BorrarNodo(valor);
            Console.WriteLine(borrado ? "Nodo borrado." : "Nodo no encontrado.");
        }
    }
}
