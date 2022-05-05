using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MATRIX_2._0
{
    internal class Matrix
    {
        public int[,] value;
        public Matrix(int[,] input_matrix)
        {
            value = input_matrix;
        }

        /*public static Matrix Sum(Matrix m1, Matrix m2)// сумма
        {
            int[,] m3 = new int[m1.value.GetLength(0), m1.value.GetLength(1)];
            for (int i = 0; i < m1.value.GetLength(0); i++)
            {
                for (int j = 0; j < m1.value.GetLength(1); j++)
                {
                    m3[i, j] = m1.value[i, j] + m2.value[i, j];
                }

            }
            Matrix m3_mat = new Matrix(m3);
            return m3_mat;
        }

        public static Matrix Minus(Matrix m1, Matrix m2)//вычитание
        {
            int[,] m3 = new int[m1.value.GetLength(0), m1.value.GetLength(1)];
            for (int i = 0; i < m1.value.GetLength(0); i++)
            {
                for (int j = 0; j < m1.value.GetLength(1); j++)
                {
                    m3[i, j] = m1.value[i, j] - m2.value[i, j];
                }
            }
            Matrix m3_mat = new Matrix(m3);
            return m3_mat;
        }

        public static Matrix Multiplay(Matrix m1, Matrix m2)//умножение на матрицу
        {
            int[,] m3 = new int[m1.value.GetLength(0), m2.value.GetLength(1)];
            for (int i = 0; i < m1.value.GetLength(0); i++)
            {
                for (int j = 0; j < m2.value.GetLength(1); j++)
                {
                    for (int k = 0; k < m2.value.GetLength(0); k++)
                    {
                        m3[i, j] += m1.value[i, k] * m2.value[k, j];
                    }
                }
            }
            Matrix m3_mat = new Matrix(m3);
            return m3_mat;
        }

        public static Matrix MultiplayNum(Matrix m1, int k)//умножение на число
        {
            int[,] m3 = new int[m1.value.GetLength(0), m1.value.GetLength(1)];

            for (int i = 0; i < m1.value.GetLength(0); i++)
            {
                for (int j = 0; j < m1.value.GetLength(1); j++)
                {
                    m3[i, j] = m1.value[i, j] * k;
                }
            }
            Matrix m3_mat = new Matrix(m3);
            return m3_mat;
        }

        public static Matrix Transposition(Matrix m1)//транспонирование 
        {
            int[,] m3 = new int[m1.value.GetLength(1), m1.value.GetLength(0)];

            for (int i = 0; i < m1.value.GetLength(1); i++)
            {
                for (int j = 0; j < m1.value.GetLength(0); j++)
                {
                    m3[i, j] = m1.value[j, i];
                }
            }
            Matrix m3_mat = new Matrix(m3);
            return m3_mat;
        }

        public static double Determinant(Matrix m1, int n)//определитель
        {
            if(m1.value.GetLength(0) == 2)
            {
                return m1.value[0, 0] * m1.value[1, 1] - m1.value[0, 1] * m1.value[1, 0];
            }
            else if (m1.value.GetLength(0) == 1)
            {
                return m1.value[0, 0];
            }
            else
            {
                int a, b;
                double det = 0;
                int[,] m3 = new int[n-1, n-1];

                for (int i = 0; i < n; i++)
                {
                    a = 0;
                    for (int j = 1; j < n; j++)
                    {
                        b = 0;
                        for (int k = 0; k < n; k++)
                        {
                            if (k != i)
                            {
                                m3[a, b] = m1.value[j, k];
                                b++;
                            }
                        }
                        a++;
                    }
                    Matrix M3 = new Matrix(m3);
                    det += Math.Pow(-1,(double)i+2) * m1.value[0,i] * Matrix.Determinant(M3, n - 1);
                }
                return det;
            }
        }*/
    }  
}
