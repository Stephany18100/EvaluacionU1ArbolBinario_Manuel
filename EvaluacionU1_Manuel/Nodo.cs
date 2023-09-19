using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU1_Manuel
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo NodoIzquierdo { get; set; }
        public Nodo NodoDerecho { get; set; }
        public int Nivel { get; set; }

        public int Peso { get; set; }
        public Nodo(int valor)
        {
            Valor = valor;
            NodoIzquierdo = null;
            NodoDerecho = null;

        }
    }
}
