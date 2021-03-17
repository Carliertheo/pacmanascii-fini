using System;

namespace pacmanascii
{
    class SumNEntiers
    {
        private int n = 42;
        
        public int N 
        {
            get => n;
            set => n = value;
        }

        private int sum()
        {
            int i = 0;
            int sum = 0;
            while (i < n) 
            {
                sum = sum + i;
                i = i+1;
            }
            return sum;
        }
    }

    class TestSumNEntiers : AbstractTest
    {
        public TestSumNEntiers(string name) : base(name) 
        {

        }

        private int oracle(int n)
        {
            int test;
            if (n == 0) 
            {
                test = 0;
            } 
            else 
            {
                int n1 = n-1;
                test = (n1*(n1+1))/2;
            }
            return test;
        }
        
        override public bool test()
        {
            SumNEntiers sum = new SumNEntiers();

            if (sum.N == 42)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }
}




