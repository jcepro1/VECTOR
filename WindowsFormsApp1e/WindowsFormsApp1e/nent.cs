using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1EXAMEN
{
    class nent
    {
        private int n;
        public nent()
        {
            n = 0;
        }

        public void cargar(int dato)
        {
            n = dato;
        }

        public int descargar()
        {
            return n;
        }


        public bool VerifPar()
        {
            int r;
            bool b;

            r = n % 2;
            if (r == 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;

        }
    }
}
