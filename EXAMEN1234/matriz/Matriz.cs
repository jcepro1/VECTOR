using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Matriz
    {
        const int MAXF = 100;
        const int MAXC = 100;
        private int[,] x;
        private int f, c;


        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0; c = 0;
        }

        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            int f1, c1;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }
        //public string descargar()
        //{
        //    string s = "";
        //    int f1, c1;
        //    for (f1 = 1; f1 <= f; f1++)
        //    {
        //        for (c1 = 1; c1 <= c; c1++)
        //        {
        //            s = s + x[f1, c1] + "\x09";
        //        }
        //        s = s + "\x0d" + "\x0a";
        //    }
        //    return s;
        //}

        public string descargar()
        {
            string s = "";
            for (int f1 = 1; f1 <= this.f; f1++)
            {
                s += "\r\n | ";
                for (int c1 = 1; c1 <= this.c; c1++)
                {
                    s += x[f1, c1] + " | ";
                }
            }
            return s;
        }

        // PREGUNTA 1
        //---------


        public void CantidadDeEleDifColocarAlFinalFila()
        {
            Matriz copia = new Matriz();
            CopiarMatriz(copia);
            for (int f = 1; f <= this.f; f++)
            {
                x[f, this.c + 1] = copia.CantidadDeEleDifFila(f);
            }
            this.c = this.c + 1;
            OrdenarPorUltimaColumna();
        }
        public int CantidadDeEleDifFila(int fr)
        {
            OrdenarFilAsc();
            int ce = 0;
            int c = 1;
            int ele = x[fr, c];

            while (c <= this.c)
            {
                ele = x[fr, c];
                while (c <= this.c && ele == x[fr, c])
                {
                    c++;
                }
                ce++;
            }

            return ce;
        }

        public void OrdenarFilAsc()
        {
            for (int f = 1; f <= this.f; f++)
            {
                for (int c1 = 1; c1 <= this.c; c1++)
                {
                    for (int c2 = c1 + 1; c2 <= this.c; c2++)
                    {
                        if (x[f, c1] > x[f, c2])
                        {
                            Intercambiar(f, c1, f, c2);
                        }
                    }
                }
            }
        }


        public void CopiarMatriz(Matriz copia)
        {
            for (int i = 1; i <= this.f; i++)
            {
                for (int j = 1; j <= this.c; j++)
                {
                    copia.x[i, j] = this.x[i, j];
                }
            }
            copia.f = this.f;
            copia.c = this.c;
        }




        public void OrdenarPorUltimaColumna()
        {
            // Crear un array temporal para almacenar las filas
            int[][] temp = new int[f][];
            for (int i = 1; i <= f; i++)
            {
                temp[i - 1] = new int[c];
                for (int j = 1; j <= c; j++)
                {
                    temp[i - 1][j - 1] = x[i, j];
                }
            }

            // Ordenar el array temporal basado en la última columna
            Array.Sort(temp, (a, b) => a[c - 1].CompareTo(b[c - 1]));

            // Copiar las filas ordenadas de vuelta a la matriz original
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    x[i, j] = temp[i - 1][j - 1];
                }
            }
        }

        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }
        //-------


        // PREGUNTA 2

        public void PREGUNTA2()
        {
            bool ban = true;
            for (int fi = 1; fi <= f - 1; fi++)
            {
                if (ban)
                {
                    for (int co = 1; co <= (c - fi); co++)
                    {
                        for (int fia = fi; fia <= f - 1; fia++)
                        {
                            int aux = (fi == fia) ? (co) : (1);
                            for (int coa = aux; coa <= (c - fia); coa++)
                            {
                                if (x[fi, co] > x[fia, coa])
                                {
                                    IntercambiarElementos(fi, co, fia, coa);
                                }
                            }
                        }
                    }
                    ban = false;
                }
                else
                {
                    for (int co = c - fi; co >= 1; co--)
                    {
                        for (int fia = fi; fia <= f - 1; fia++)
                        {
                            int aux = (fi == fia) ? (co) : (c - fia);
                            for (int coa = aux; coa >= 1; coa--)
                            {
                                if (x[fi, co] > x[fia, coa])
                                {
                                    IntercambiarElementos(fi, co, fia, coa);
                                }
                            }
                        }
                    }
                    ban = true;
                }

            }
        }

        private void IntercambiarElementos(int fi, int co, int fia, int coa)
        {
            int temp = x[fi, co];
            x[fi, co] = x[fia, coa];
            x[fia, coa] = temp;
        }

    }
}
