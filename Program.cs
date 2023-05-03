using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;

            Console.WriteLine("Find sum of all elements of Array" );

            Console.WriteLine("Input the number of elements stored in array");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array" );
            for (i = 0; i< n; i++)
            {
                Console.WriteLine("element - {0}", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        for(i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum of all elements stored in array is : {0}" , sum);
        }
    }
}
