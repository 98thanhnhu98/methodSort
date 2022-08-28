using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSort
{
    internal class Binary
    {
        public static void Main(string[] cmd)
        {
            int[] ary = new int[10] { 2,4,6,8,10,12,14,16,18,20 };
            int low = 0;
            int high = 9;
            int mid;
            int giatri,timthay = 0;
            Console.WriteLine("Nhap 1 so gia tri nguyen :");
            giatri = int.Parse(Console.ReadLine());
            int i, j, tmp;
            while(low <= high)
            {
                mid = (low + high) / 2;
                if (ary[mid] == giatri)
                {
                    Console.WriteLine("Gia tri ban nhap " + giatri + " duoc tim thay o vi tri " + mid + " cua mang.");
                    timthay = 1;
                    break;
                }
                else if (ary[mid] > giatri)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            if(timthay  == 0)
            {
                Console.WriteLine("Gia tri ban nhap " + giatri + " khong duoc tim thay trong mang.");
            }
        }
    }
}
