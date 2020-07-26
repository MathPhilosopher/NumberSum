using System;
using System.Collections.Generic;
using System.Linq;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 1, 2, 2, 5, 7, 7 };
            var Sumboard = SumOf(arr, 7);

            foreach (var sum in Sumboard)
            {
                Console.WriteLine(sum);
            }


            Console.ReadLine();
        }


        static List<(int, int)> SumOf(int[] arr, int sum)
        {
            List<(int, int)> res = new List<(int, int)>();

            List<int> tmp = arr.ToList();
            tmp.Sort();

            
            int z = tmp.Count-1,
                i = 0;

            while (i < tmp.Count)                                                       //A more efficient solution than O(n^2) 
            {        
                int Last = tmp[z];

                if (Last + tmp[i] == sum)
                {
                    res.Add((Last, tmp[i]));
                    i++;
                }
                else
                {
                    if (Last + tmp[i]> sum)
                    {
                        if (z==0)
                        {
                            break;
                        }
                        else
                        {
                            z--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return res;
        }
    }
}
