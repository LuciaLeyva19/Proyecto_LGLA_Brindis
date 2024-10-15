using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LGLA_Brindis
{
    internal class Program
    {
        static void Main()
        {
            ListaEnlazada lista = new ListaEnlazada();
            InsertarNodo insertar = new InsertarNodo(lista);
            ImprimirTamaño imprimirTamaño = new ImprimirTamaño(lista);
            BuscarNodo buscarNodo = new BuscarNodo(lista);
            BorrarNodo borrarNodo = new BorrarNodo(lista);
            ModificarNodo modificarNodo = new ModificarNodo(lista);
            BuscarValor buscarValor = new BuscarValor(lista);
            ImprimirLista imprimirLista = new ImprimirLista(lista);

            int opcion;

            do
            {
                Console.WriteLine("MENU LISTAS");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Insertar Nodo");
                Console.WriteLine("2.- Imprimir Tamaño");
                Console.WriteLine("3.- Buscar Nodo");
                Console.WriteLine("4.- Borrar Nodo");
                Console.WriteLine("5.- Modificar Nodo");
                Console.WriteLine("6.- Buscar Valor");
                Console.WriteLine("7.- Imprimir Lista");
                Console.WriteLine("8.- Salir");
                Console.WriteLine("_____________________");
                Console.Write("Seleccionar Opción => ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        insertar.Ejecutar();
                        break;
                    case 2:
                        imprimirTamaño.Ejecutar();
                        break;
                    case 3:
                        buscarNodo.Ejecutar();
                        break;
                    case 4:
                        borrarNodo.Ejecutar();
                        break;
                    case 5:
                        modificarNodo.Ejecutar();
                        break;
                    case 6:
                        buscarValor.Ejecutar();
                        break;
                    case 7:
                        imprimirLista.Ejecutar();
                        break;
                    case 8:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intenta nuevamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 8);
        }

    }
}
