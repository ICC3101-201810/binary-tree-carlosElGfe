using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarry_tree
{
    public class Arbol
    {
        public Type T;
        public class Nodo<T>
        {
            public T info;
            public Nodo<T> izq, der;
            public Nodo(T minfo)
            {
                info = minfo;
                this.izq = null;
                this.der = null;
            }
            Nodo<T> raiz;
            
            public void insertarnodo(List<int> a, T info)
            {
                if (raiz == null)
                {
                    Nodo<T> nodonuevo = new Nodo<T>(info);
                }
                if (raiz != null)
                {
                    raiz[a[0]];
                }
            }
        }
        

    }
}
