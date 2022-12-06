using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 6. Заменить отрицательные элементы в числовом массиве из n 
    чисел (n>10) их квадратами, оставив остальные без изменения. */

namespace Lab_4_1_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++) 
                arr[i] = r.Next(-10, 10);
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)            
                if (arr[i] < 0)                
                    arr[i] = arr[i] * arr[i];            
            foreach (var item in arr)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
