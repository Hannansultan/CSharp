using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingQuestionsof2016
{
    class Program
    {
        static void Main(string[] args)
        {

            //// find single duplicate number in array
            //findSingleDuplicateNum();

            //// find duplicate number in array
            //findDuplicateNum();


            //// find missing number in array
            //findMissingNum();

            //// find numbers that are not present in other array
            //findmissingintwoarrys();

            //// find second largest number in array
            //findsecondlargestNum();

            //// to find all pairs in array of integers whose sum is equal to given number
            //findPairsOfNum(7);

            int[] a = { 5, 7, 3, 5, 7 };
            int[] b = { 32, 12, 5, 7, 83, 7 ,7};
            findDuplicateNumFromArrays(a, b);

            Console.ReadLine();
        }

        public static void findSingleDuplicateNum()
        {
            int[] arry = new int[100];
            for (int i = 1; i < 100; i++)
            {
                arry[i] = i;
            }

            arry[60] = 10;
            Array.Sort(arry);
            for (int i = 1; i < arry.Length; i++)
            {
                if (i != arry.Length)
                {
                    if (arry[i] == arry[i + 1])  
                    {
                        Console.WriteLine(arry[i]);
                        break;
                    }
                    
                }
            }
        }

        public static void findDuplicateNumFromArrays(int[] a , int[] b)

        {
            Array.Sort(a);
            Array.Sort(b);
            int len = 0;
            if (a.Length > b.Length)
            {
                len = b.Length;
            }
            else
            {
                len = a.Length;
            }
            int[] common = new int[len];
            
            for (int i = 1; i < len; i++)
            {
                if (a[i] == b[i])
                {
                    common[i] = a[i];

                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(common[i]);
            }
            
        }

        public static void findMissingNum()
        {
            int[] arry = new int[100];
            for (int i = 1; i < 100; i++)
            {
                if (i == 54)
                {

                }
                else
                {
                    arry[i] = i;
                }
                
            }
            for (int i = 1; i < 100; i++)
            {
                if (arry[i] != i )
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        public static void findDuplicateNum()
        {
            int[] arry = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arry[i] = i;
            }

            arry[2] = 1;
            arry[70] = 13;
            arry[80] = 17;
            arry[90] = 78;
            arry[10] = 54;
            arry[30] = 67;
            arry[50] = 87;

            Array.Sort(arry);
            for (int i = 0; i < 100; i++)
            {
                if (i !=99)
                {
                    if (arry[i] == arry[i + 1])
                    {
                        Console.WriteLine(arry[i]);
                        

                    }
                }
                
            }
        }

        public static void findmissingintwoarrys()
        {
            int[] kashif = { 1, 2, 3, 4, 5 };
            int[] Hannan = { 2, 3, 4, 6, 7 };
            Array.Sort(kashif);
            Array.Sort(Hannan);
            for (int i = 0; i <kashif.Length; i++)
            {
                bool chk=false;
                int num = kashif[i];
                for (int j = 0; j < Hannan.Length; j++)
                {
                    if (Hannan[i] == num)
                    {
                        chk = true;
                        break;
                    }
                        
                }
                if (!chk)
                {
                    Console.WriteLine(num);
                }
                
            }
           
            
        }

        public static void findsecondlargestNum()
        {
            int[] array = { 1, 8, 9, 7, 3, 90, 84 };
            Array.Sort(array);
            Console.WriteLine(array[array.Length - 2]);
            
            
        }

        public static void findPairsOfNum(int num)
        {
            int[] arry = { 1, 2, 3, 4, 5 };
            int frstNum, scndNum,sum = num;
            for (int i = 0; i < arry.Length; i++)
            {
                frstNum = arry[i];
                for (int j = 0; j < arry.Length; j++)
                {
                    scndNum = arry[j];
                    if (frstNum + scndNum == sum)
                    {
                        Console.WriteLine(frstNum+" "+ scndNum);
                    }
                }
            }
        }



    }
}
