
namespace FormMatrizMultidimensionalG3
{
    class Matriz
    {
        private int n;
        private int m;

        public int N
        {
            get => n;
            set
            {
                if(  value < 2  )
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }
                
            }
        }
        public int M
        {
            get => m;
            set
            {
                if (value < 2)
                {
                    m = 2;
                }
                else
                {
                    m = value;
                }
            }
        }
    }
}
