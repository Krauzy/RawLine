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

        private static double[][] Zerar(double[][] M)
        {
            for(int i = 0; i < M.Length; i++)
            {
                for(int j = 0; j < M[i].Length; j++)
                {
                    M[i][j] = 0;
                }
            }
            return M;
        }

        public static double[][] GetMatrizAcumulado(double[][] M1, double[][] M2, double[][] M3)
        {
            double[][] res1 = new double[3][];
            res1[0] = new double[3];
            res1[1] = new double[3];
            res1[2] = new double[3];
            res1 = Zerar(res1);
            for(int i = 0; i < M2.Length; i++)
            {
                for(int j = 0; j < M1.Length; j++)
                {
                    res1[i][j] += M1[i][j] * M2[j][i];
                }
            }
            double[][] res2 = new double[3][];
            res2[0] = new double[3];
            res2[1] = new double[3];
            res2[2] = new double[3];
            res2 = Zerar(res1);
            for (int i = 0; i < M2.Length; i++)
            {
                for (int j = 0; j < M1.Length; j++)
                {
                    res2[i][j] += res1[i][j] * M3[j][i];
                }
            }
            return res2;
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
