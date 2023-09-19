using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU1_Manuel
{
    public class ArbolBinario
    {
        public Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        //INSERTAR NODO
        public void Insertar(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
            }
            else
            {
                InsertarEnSubarbol(raiz, valor);
            }
        }

        public void InsertarEnSubarbol(Nodo nodo, int valor)
        {
            if (valor < nodo.Valor)
            {
                if (nodo.NodoIzquierdo == null)
                {
                    nodo.NodoIzquierdo = new Nodo(valor);
                }
                else
                {
                    InsertarEnSubarbol(nodo.NodoIzquierdo, valor);
                }
            }
            else
            {
                if (nodo.NodoDerecho == null)
                {
                    nodo.NodoDerecho = new Nodo(valor);
                }
                else
                {
                    InsertarEnSubarbol(nodo.NodoDerecho, valor);
                }
            }
        }



    }
}
