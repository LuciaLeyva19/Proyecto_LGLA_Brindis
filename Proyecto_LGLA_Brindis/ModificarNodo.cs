using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class ModificarNodo
    {
        private ListaEnlazada lista;

        public ModificarNodo(ListaEnlazada lista)
        {
            this.lista = lista;
        }

        public void Ejecutar()
        {
            Console.Write("Ingrese el valor del nodo a modificar: ");
            int viejoValor = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nuevo valor: ");
            int nuevoValor = int.Parse(Console.ReadLine());
            bool modificado = lista.ModificarNodo(viejoValor, nuevoValor);
            Console.WriteLine(modificado ? "Nodo modificado." : "Nodo no encontrado.");
        }
    }
}
