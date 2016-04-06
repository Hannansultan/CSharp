﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationOfString
{
    class Program
    {
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            //a ^= b;
            //b ^= a;
            //a ^= b;
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list,
                0, x);
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        static void Main()
        {
            string str = "aamir";
            char[] arr = str.ToCharArray();
            GetPer(arr);

            Console.ReadLine();
        }
    }
}
