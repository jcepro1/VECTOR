﻿using System;
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
        public string descargar()
        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }

        //examnes
        //pregunta 1//////////////////////// SI
        public void pregunta1()
        {
            int may = 0;
            int elemay = 0;
            for (int f1 = 1; f1 <= f; f1++)
            {
                may = 0;
                for (int c1 = 1; c1 <= c; c1++)
                {
                    int ele = x[f1, c1];
                    int fr = frecuenciaFil(f1, ele);
                    if (fr > may)
                    {
                        may = fr;
                        elemay = ele;
                    }
                }
                x[f1, c + 1] = elemay;

            }
            c = c + 1;
            Ord_las_FILA_x_el_nro_de_eles_difsme();
        }

        int frecuenciaFil(int f1, int ele)
        {
            int fr = 0;
            for (int c1 = 1; c1 <= c; c1++)
            {
                if (x[f1, c1] == ele)
                {
                    fr++;
                }
            }
            return fr;
        }

        public void Ord_las_FILA_x_el_nro_de_eles_difsme()
        {
            for (var p = 1; p <= f - 1; p++)
            {
                for (var d = p + 1; d <= f; d++)
                {
                    if (x[p, c] > x[d, c])
                        Intercambiar_filas(d, p);
                }
            }
        }



        public void Intercambiar_filas(int f1, int f2)
        {
            for (var c1 = 1; c1 <= c; c1++)
                Intercambiar(f1, c1, f2, c1);
        }
        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }

        //preggunta 2 //////////////// SI



        public void OrdSenozoidalF()
        {
            bool r = true;
            for (int F = 1; F <= f; F++)
            {
                if (r)
                {
                    for (int C = 1; C <= c; C++)
                    {
                        int Ci = C;
                        bool t = r;
                        for (int I = F; I <= f; I++)
                        {
                            if (t)
                            {
                                for (int J = Ci; J <= c; J++)
                                {
                                    if (x[I, J] < x[F, C])
                                    {
                                        int aux = x[F, C];
                                        x[F, C] = x[I, J];
                                        x[I, J] = aux;
                                    }
                                }
                                t = false;
                                Ci = 1;
                            }
                            else
                            {
                                for (int J = c; J >= 1; J--)
                                {
                                    if (x[I, J] < x[F, C])
                                    {
                                        int aux = x[F, C];
                                        x[F, C] = x[I, J];
                                        x[I, J] = aux;
                                    }
                                }
                                t = true;
                            }
                        }
                    }
                    r = false;
                }
                else
                {
                    for (int C = c; C >= 1; C--)
                    {
                        int ci = C;
                        bool t = r;
                        for (int I = F; I <= f; I++)
                        {
                            if (!t)
                            {
                                for (int J = ci; J >= 1; J--)
                                {
                                    if (x[I, J] < x[F, C])
                                    {
                                        int aux = x[F, C];
                                        x[F, C] = x[I, J];
                                        x[I, J] = aux;
                                    }
                                }
                                t = true;
                                ci = c;
                            }
                            else
                            {
                                for (int J = 1; J <= c; J++)
                                {
                                    if (x[I, J] < x[F, C])
                                    {
                                        int aux = x[F, C];
                                        x[F, C] = x[I, J];
                                        x[I, J] = aux;
                                    }
                                }
                                t = false;
                            }
                        }
                    }
                    r = true;
                }
            }
        }








    }
}
