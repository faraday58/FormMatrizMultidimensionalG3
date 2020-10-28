

namespace FormMatrizMultidimensionalG3
{
    class Unidimensional:Matriz
    {
        private float[] A;

        public Unidimensional(int N)
        {
            this.N = N;
            A = new float[N];
        }        
        //Unidimensional.Leer(txtbMatriz1.Text)
        public static Unidimensional Leer(string A)
        {
            // 4,5,3,2
            string[] columnas = A.Split(',');
            Unidimensional matA = new Unidimensional(columnas.Length);
            for(int i=0; i < matA.N; i++)
            {
                matA.A[i] = float.Parse(columnas[i]);
            }
            return matA;
        }
        public static Unidimensional operator +(Unidimensional u1, Unidimensional u2)
        {
            Unidimensional u3 = new Unidimensional(u1.N);
            for(int i=0; i< u3.N; i++  )
            {
                u3.A[i] = u1.A[i] + u2.A[i];
            }
            return u3;
        }

        public override string ToString()
        {
            string A = "";
            for(int i=0; i< N; i++)
            {
                A = A + " " + this.A[i].ToString();
            }
            return A;
        }

    }
}
