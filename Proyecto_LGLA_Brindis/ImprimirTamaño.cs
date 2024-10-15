using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class ImprimirTamaño
    {
        private ListaEnlazada lista;

        public ImprimirTamaño(ListaEnlazada lista)
        {
            this.lista = lista;
        }

        public void Ejecutar()
        {
            Console.WriteLine("Tamaño de la lista: " + lista.ImprimirTamaño());
        }
    }
}
