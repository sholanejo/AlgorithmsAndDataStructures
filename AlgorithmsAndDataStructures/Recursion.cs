using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures
{
   public static class Recursion
    {
        public static int Recursive(int n)
        {
            if(n == 0 | n == 1)
            {
                return 1;
            }
            return n * Recursive(n - 1);
        }
    }
}
