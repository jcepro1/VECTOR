using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1EXAMEN
{
    class vector
    {
        const int MAX = 100;
        private int[] v;
        private int n;
        public vector()
        {
            n = 0;
            v = new int[MAX];
        }






        public void Cargar_rnd(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }

        }


        public string descargar()
        {
            string s;
            int i;
            s = "";
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + "  |  ";
            }
            return s;
        }


        public int frecuencia(int ele, int a, int b)
        {
            int c = 0;
            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }

        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }
        public void ordenar()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; i <= n; i++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }
        public void ejercicio1(int a, int b, int m)
        {
            vector pares = new vector();
            vector impares = new vector();
            for (int i = a; i <= b; i++)
            {
                if (i % m == 0)
                {
                    if (v[i] % 2 == 0)
                    {
                        pares.insertar(v[i]);
                    }
                    else
                    {
                        impares.insertar(v[i]);
                    }
                }
            }

            pares.ordenar();
            impares.ordenar();

            int ipares = 1;
            int iimpares = 1;

            for (int i = a; i <= b; i++)
            {
                if (i % m == 0)
                {
                    if (ipares <= pares.n)
                    {
                        v[i] = pares.v[ipares];
                        ipares++;
                    }
                    else
                    {
                        v[i] = impares.v[iimpares];
                        iimpares++;
                    }
                }
            }
        }
       

    }
}
