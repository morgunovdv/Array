using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Fillrand(int [] nums)
        {
            Random rdn = new Random();
            for (int i =0; i<nums.Length; i++)
            {
                nums[i] = rdn.Next(101);
            }
        }

        static void ArrayShow(int [] nums)
        {
            for (int i =0; i<nums.Length; i++)
            {
                Console.Write("| {0}", nums[i]);
            }
        }

        //static int Sort(int [] nums)
        //{
        //    int s = 0;
        //    int[] nums1 = new int [0];
        //    for (int i =1; i<nums1.Length; i++)
        //    {
        //        for (int j = 0; j < nums1.Length - 1; j++)
        //        {
        //            if (nums1[j] > nums1[j + 1])
        //            {
        //                s = nums1[j + 1];
        //                nums1[j + 1] = nums1[j];
        //                nums1[j] = s;
        //            }
        //        }
        //    }
        //    return s;
        //}

        

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите длину массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Вы не ввели число");
            }
            int s;
            int[] nums = new int[n];
            Fillrand(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] < nums[j + 1])
                    {
                        s = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = s;
                    }
                }
            }

            int[] nums1 = nums.Distinct().ToArray();
            
            
            ArrayShow(nums1);
            int M = nums1[1];
            Console.WriteLine("\n Второе по величине число в массиве: {0}", M);
           
            Console.ReadKey();

        }
    }
}
