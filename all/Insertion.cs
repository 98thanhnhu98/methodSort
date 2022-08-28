using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSort
{
    internal class Insertion
    {
        public static void Main(string[] cmd)
        {
            int[] ary = new int[5] { 10, 3, 21, 6, 1 };
            int i, j, tmp;
            for(i = 0;i< 5; i++)
            {
                tmp = ary[i];
                j = i - 1;
                while(j >= 0 && tmp < ary[j])
                {
                    ary[j + 1] = ary[j];
                    j--;
                }
                ary[j + 1] = tmp;
            }

            Console.Write("Insection :\nHien thi mang da duoc xap sep: \n");
            for(i = 0;i< 5; i++)
            {
                Console.Write(ary[i] + " ");
            }
        }
    }
}
