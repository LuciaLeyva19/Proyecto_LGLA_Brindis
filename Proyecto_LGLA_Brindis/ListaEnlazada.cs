using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        public Nodo Cabeza => cabeza;

        public void InsertarNodo(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Sig != null)
                {
                    temp = temp.Sig;
                }
                temp.Sig = nuevoNodo;
            }
            Console.WriteLine("Nodo insertado: " + valor);
        }

        public int ImprimirTamaño()
        {
            int tamaño = 0;
            Nodo temp = cabeza;
            while (temp != null)
            {
                tamaño++;
                temp = temp.Sig;
            }
            return tamaño;
        }

        public Nodo BuscarNodo(int valor)
        {
            Nodo temp = cabeza;
            while (temp != null)
            {
                if (temp.Valor == valor)
                    return temp;
                temp = temp.Sig;
            }
            return null;
        }

        public bool BorrarNodo(int valor)
        {
            if (cabeza == null) return false;

            if (cabeza.Valor == valor)
            {
                cabeza = cabeza.Sig;
                return true;
            }

            Nodo temp = cabeza;
            while (temp.Sig != null)
            {
                if (temp.Sig.Valor == valor)
                {
                    temp.Sig = temp.Sig.Sig;
                    return true;
                }
                temp = temp.Sig;
            }
            return false;
        }

        public bool ModificarNodo(int viejoValor, int nuevoValor)
        {
            Nodo nodo = BuscarNodo(viejoValor);
            if (nodo != null)
            {
                nodo.Valor = nuevoValor;
                return true;
            }
            return false;
        }

        public Nodo BuscarValor(int valor)
        {
            return BuscarNodo(valor);
        }

        public void ImprimirLista()
        {
            Nodo temp = cabeza;
            if (temp == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.Valor + " ");
                temp = temp.Sig;
            }
            Console.WriteLine();
        }
    }
}
