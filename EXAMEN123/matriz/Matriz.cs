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
        public void pregunta1()
        {
            int s;
            for (int j = 1; j <= this.c; j++)
            {
                s = 0;
                for (int i = 1; i <= this.f; i++)
                {
                    if (!this.pertenece(1, i - 1, j, x[i, j]))
                        s++;
                }
                x[f + 1, j] = s;
            }
            f++;
            Ord_las_col_x_el_nro_de_eles_difsme();
        }

        public bool pertenece(int a, int b, int j, int g)
        {
            int s = 0;
            while (a <= b)
            {
                if (x[a, j] == g)
                {
                    s++;
                }
                a++;
            }
            return s > 0;
        }



        public void Ord_las_col_x_el_nro_de_eles_difsme()
        {
            for (var p = 1; p <= c - 1; p++)
            {
                for (var d = p + 1; d <= c; d++)
                {
                    if (x[f, p] > x[f, d])
                        Intercambiar_col(d, p);
                }
            }
        }
        public void Intercambiar_col(int c1, int c2)
        {
            for (var f1 = 1; f1 <= f; f1++)
                Intercambiar(f1, c1, f1, c2);
        }
        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }


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
