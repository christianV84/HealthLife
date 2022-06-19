using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthlife
{
    internal class Nodo
    {
        public String nombre;
        public String dni;
        public String telefono;
        public String direccion;
        private Nodo anterior;
        private Nodo siguiente;

        internal Nodo Anterior { get => anterior; set => anterior = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public Nodo(string nombre, string dni, string telefono, string direccion, Nodo anterior, Nodo siguiente)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.Anterior = anterior;
            this.Siguiente = siguiente;
        }
    }
}
