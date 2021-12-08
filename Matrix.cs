namespace AppForMatrix
{
    public class Matrix
    {
        internal int N
        {
            set;
            get;
        }
        
        public int[,] Values
        {
            set;
            get;
        }

        public Matrix(int n)
        {
            N = n;
            Values = new int[n, n];
        }
        

        public Matrix Plus(Matrix m)
        {
            Matrix matrix = new Matrix(N);
            for (var i = 0; i < N; i++)
            for (var j = 0; j < N; j++)
                matrix.Values[i, j] = Values[i, j] + m.Values[i, j];
            return matrix;
        }
        
        public Matrix Minus(Matrix m)
        {
            Matrix matrix = new Matrix(N);
            for (var i = 0; i < N; i++)
            for (var j = 0; j < N; j++)
                matrix.Values[i, j] = Values[i, j] - m.Values[i, j];
            return matrix;
        }

        public Matrix Multiply(Matrix m)
        {
            Matrix mul = new Matrix(N);
            for (var i = 0; i < N; i++)
            for (var j = 0; j < N; j++)
            {
                mul.Values[i, j] = 0;
                for (var k = 0; k < N; k++)
                    mul.Values[i, j] += Values[k, j] * m.Values[i, k];
            }

            return mul;
        }
    }
}