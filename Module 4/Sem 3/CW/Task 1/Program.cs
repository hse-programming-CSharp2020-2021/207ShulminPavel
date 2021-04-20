using System;

namespace Task_1
{
    class Matrix2
    {
        public double A11 { get; set; }
        public double A12 { get; set; }
        public double A21 { get; set; }
        public double A22 { get; set; }

        public Matrix2(double a11, double a12, double a21, double a22)
        {
            A11 = a11;
            A12 = a12;
            A21 = a21;
            A22 = a22;
        }

        public Matrix2(double a11, double a22)
        {
            A11 = a11;
            A22 = a22;
            A12 = 0;
            A21 = 0;
        }

        public Matrix2(Matrix2 matrix)
        {
            A11 = matrix.A11;
            A12 = matrix.A12;
            A21 = matrix.A21;
            A22 = matrix.A22;
        }

        public double Det()
        {
            return A11 * A22 - A12 * A21;
        }

        public Matrix2 Inverse()
        {
            if (Det() != 0)
            {
                double invDet = 1 / Det();
                return new Matrix2(invDet * A22, -invDet * A12, -invDet * A21, invDet * A11);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public Matrix2 Transpose()
        {
            double A12T = A21;
            double A21T = A12;
            return new Matrix2(A11, A12T, A21T, A22);
        }

        public static Matrix2 operator +(Matrix2 mat1, Matrix2 mat2)
        {
            return new Matrix2(mat1.A11 + mat2.A11, mat1.A12 + mat2.A12, 
                               mat1.A21 + mat2.A21, mat1.A22 + mat2.A22);
        }

        public static Matrix2 operator -(Matrix2 mat1, Matrix2 mat2)
        {
            return new Matrix2(mat1.A11 - mat2.A11, mat1.A12 - mat2.A12,
                               mat1.A21 - mat2.A21, mat1.A22 - mat2.A22);
        }

        public static Matrix2 operator *(Matrix2 mat1, Matrix2 mat2)
        {
            return new Matrix2(mat1.A11 * mat2.A11 + mat1.A12 * mat2.A21, mat1.A11 * mat2.A12 + mat1.A12 * mat2.A22,
                               mat1.A21 * mat2.A11 + mat1.A22 * mat2.A21, mat1.A21 * mat2.A12 + mat1.A22 * mat2.A21);
        }

        public static Matrix2 operator *(Matrix2 matrix, int a)
        {
            return new Matrix2(matrix.A11 * a, matrix.A12 * a, matrix.A21 * a, matrix.A22 * a);
        }

        public static Matrix2 operator /(Matrix2 matrix, int a)
        {
            return new Matrix2(matrix.A11 / a, matrix.A12 / a, matrix.A21 / a, matrix.A22 / a);
        }

        public override string ToString()
        {
            return $"a11 = {A11}, a12 = {A12}, a21 = {A21}, a22 = {A22}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
