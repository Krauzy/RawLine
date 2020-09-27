using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawLine.Tools
{
    class Matrix
    {
        public static double[] SUM(double[] M1, double[] M2)
        {
            double[] M = null;
            if (M1.Length == M2.Length)
            {
                M = new double[M1.Length];
                for (int i = 0; i < M1.Length; i++)
                {
                    M[i] = M1[i] + M2[i];
                }
            }
            return M;
        }

        public static double[] Homogenar(double[][] M1, double[] M2)
        {
            double[] res = new double[M2.Length];
            bool flag = false;
            for(int i = 0; i < M2.Length; i++)
            {
                flag = true;
                for(int j = 0; j < M2.Length; j++)
                {
                    if (flag)
                    {
                        res[i] = M1[i][j] * M2[j];
                        flag = !flag;
                    }
                    else
                        res[i] += M1[i][j] * M2[j];
                }
            }
            return res;
        }

        public static double[] MULT(double[][] M1, double[] M2)
        {
            double[] M = new double[M1.Length];
            for(int i = 0; i < M.Length; i++)
            {
                M[i] = M1[i][0] * M2[0] + M1[i][1] * M2[1];
            }
            return M;
        }
    }
}
