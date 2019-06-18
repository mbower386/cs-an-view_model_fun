using System;
using System.Collections.Generic;

namespace ViewModelFun.Models
{
    public class Numbers
    {
        public int[] NumArray;

        public Numbers ()
        {
            NumArray = new int[10];
            Random rand = new Random ();

            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i] = rand.Next (1, 50);
            }
        }
    }
}