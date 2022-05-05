using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIX_2._0
{
    internal interface IMatrixOperation
    {
        double Determinant(Matrix m1, int n);
        Matrix Sum(Matrix m1, Matrix m2);
        Matrix Minus(Matrix m1, Matrix m2);
        Matrix Multiplay(Matrix m1, Matrix m2);
        Matrix MultiplayNum(Matrix m1, int k);
        Matrix Transposition(Matrix m1);

    }
}
