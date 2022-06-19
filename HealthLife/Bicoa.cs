using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthlife
{
    internal class Bicoa
    {
        Nodo primero, ultimo;
        
       
        public void insertarNodo(String a, String b, String c, String d)
        {
            Nodo nuevo = new Nodo(a, b, c, d, primero, ultimo);
            nuevo.nombre = a;
            nuevo.dni = b;
            nuevo.telefono = c;
            nuevo.direccion = d;
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Anterior = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;

            }
        }
            public void verbicola(DataGridView bicola)
        {
            Nodo actual;
            actual = primero;
            while (actual != null)
            {
                bicola.Text += actual.nombre+actual.dni+actual.telefono+actual.direccion;
                actual = actual.Siguiente;
            }
        }
        
        
}
}
