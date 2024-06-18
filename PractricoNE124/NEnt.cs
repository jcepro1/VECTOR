using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractricoNE124
{
    class NEnt
    {
        private int n;
        public NEnt()
        {
            n = 0;
        }

        public void Cargar(int dato)
        {
            n = dato;
        }

        public int Descargar()
        {
            return n;
        }

        //1

        public double Factorial()
        {
            double Fac = 1.0;
            if (n != 0)
            {
                int num = Math.Abs(n);
                for (int c = num; c >= 1; c = c - 1)
                {
                    Fac *= (double)c;
                }
                if (n < 0)
                {
                    Fac = -Fac;
                }
            }
            return Fac;
        }


        //2
        public bool verif_fibo()
        {
            int a = -1;
            int b = 1;
            int c;
            do
            {
                c = a + b;
                a = b;
                b = c;
            }
            while (!((c == n) || (c > n)));
            return c == n;
        }
        //3
        public bool ejercicio3()
        {
            int c = 0;
           Double exp;
            do
            {

                exp = Math.Pow(2, c);
                c = c + 1;
            }
            while (!((exp == n) || (exp > n)));
            return exp == n;
        }

        //4
        public bool Verif_num_mult(NEnt num)
        {
            int r;
            bool b;

            r = n % num.n;
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

        //5
        public bool Verif_num_submult(NEnt num)
        {
            int r;
            bool b;

            r = num.n % n;
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

        //6
        public int Cant_digs_nd()
        {
            int na = n;
            int cd = 0;
            while (na > 0)
            {
                na = na / 10;
                cd = cd + 1;


            }
            return cd;
        }
        public void Unir2NE(NEnt num)
        {
            int nn = 0;
            nn = n * (int)Math.Pow(10, num.Cant_digs_nd()) + num.n;
            n = nn;

        }
        public void ejercicio8(NEnt num)
        {
            NEnt nn;
            nn = new NEnt();
            nn.Cargar(n);

            if (n > num.n)
            {

                num.Unir2NE(nn);
                n = num.n;
            }
            else
            {

                nn.Unir2NE(num);
                n = nn.n;

            }

        }

        //7
        public void ejercicio9(NEnt b, NEnt c)
        {

            NEnt a;
            a = new NEnt();
            a.Cargar(n);
            NEnt nn;
            nn = new NEnt();
            nn.Cargar(n);

            if (a.n >= b.n && a.n >= c.n)  //el mayor es a  
            {
                b.ejercicio8(c);

                b.Unir2NE(a);
                n = b.n;

            }
            else if (b.n >= a.n && b.n >= c.n) //el mayor es b
            {
                a.ejercicio8(c);

                a.Unir2NE(b);
                n = a.n;
            }
            else if (c.n >= a.n && c.n >= b.n) //el mayor es c
            {
                a.ejercicio8(b);

                a.Unir2NE(c);
                n = a.n;
            }



        }

        //8
        public void ejercicio10(NEnt b, NEnt c, NEnt d)
        {

            NEnt a;
            a = new NEnt();
            a.Cargar(n);

            if (a.n >= b.n && a.n >= c.n)  //el mayor es a  
            {
                d.n = 1;

            }
            else
            if (b.n >= a.n && b.n >= c.n) //el mayor es b 
            {
                d.n = 2;
            }
            else
            if (c.n >= a.n && c.n >= b.n) //el mayor es c 
            {
                d.n = 3;
            }



        }

        //9
        public Boolean ejercicio11()
        {
            int na = n;
            int dr = na % 10;
            int d = 0;
            Boolean b = true;
            while ((na > 0) && (b == true))
            {
                d = na % 10;
                na = na / 10;
                if (d != dr)
                {
                    b = false;
                }
            }
            return b;
        }

        //10
        public Boolean ejercicio12()
        {
            int na = n;
            int dr = na % 10;
            int d = 0;
            Boolean b = true;
            while ((na > 0) && (b == true))
            {
                d = na % 10;
                na = na / 10;
                if (d % 2 == 0)
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
            }
            return b;
        }

    }
}
