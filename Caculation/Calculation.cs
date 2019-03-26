using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculation
{
    class Calculation
    {
        static public int fibonacci(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return (fibonacci(x - 1) + fibonacci(x - 2));
            }
        }
        static public double factorial(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        static public double E(double n)
        {
            if (n == 20)
            {
                return 0;
            }
            else
            {
                return E(n + 1) + (1 / (factorial(n)));
            }
        }
        // infinte Sum which retruns pi/4
        static public double Pi(double n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return Pi(n -1 ) + (Math.Pow(-1, n) * (1/((2 * n) +1)));
            }
        }
        static public double power(double n, double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return power(n, x - 1) * n;
            }
        }
        //static public void sort(int[] x, int l, int r)
        //{
        //    int mid = (x.Length + 1) / 2;
        //    if (l < r)
        //    {
        //        int m = (l + r) / 2;
        //        sort(x, l, m);
        //        sort(x, m + 1, r);
        //        merge(x, l, m, r);
        //    }
        //}
        //private static int[] x;
        //static private void merge(int[] x, int l, int m, int r)
        //{
        //    int n1 = m - l + 1;
        //    int n2 = r - m;

        //    int[] temp1 = new int[n1];
        //    int[] temp2 = new int[n2];

        //    for (int n = 0; n < n1; ++n)
        //    {
        //        temp1[n] = x[l + n];
        //    }
        //    if (m == x.Length - 1)
        //    {
        //        m--;
        //    }
        //    for (int ii = 0; ii < n2; ++ii)
        //    {
        //        temp2[ii] = x[m + 1 + ii];
        //    }
        //    int i = 0;
        //    int j = 0;
        //    int k = l;
        //    while (i < n1 && j < n2)
        //    {
        //        if (temp1[i] <= temp2[j])
        //        {
        //            x[k] = temp1[i];
        //            i++;
        //        }
        //        else
        //        {
        //            x[k] = temp2[j];
        //            j++;
        //        }
        //        k++;
        //    }
        //    if (k == x.Length)
        //    {
        //        k--;
        //    }
        //    while (i < n1)
        //    {
        //        x[k] = temp1[i];
        //        i++;
        //        k++;
        //    }
        //    while (j < n2)
        //    {

        //        x[k] = temp2[j];
        //        j++;
        //        k++;
        //    }
        //    this.x
        //}

        //static  fe  /public int[] getX()
        //{
        //    return x;
        //}
    }
}
