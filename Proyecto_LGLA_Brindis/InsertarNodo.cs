using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class InsertarNodo
    {
        private ListaEnlazada lista;

        public InsertarNodo(ListaEnlazada lista)
        {
            this.lista = lista;
        }

        public void Ejecutar()
        {
            Console.Write("Ingrese el valor del nodo: ");
            int valor = int.Parse(Console.ReadLine());
            lista.InsertarNodo(valor);
        }
    }
}
