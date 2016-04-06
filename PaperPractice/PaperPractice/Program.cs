using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PaperPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "level";

            //string str2 = "level";
            //char result = str2.FirstOrDefault(ch => str2.IndexOf(ch) == str2.LastIndexOf(ch));

            //Console.WriteLine(result);



            // removing index of array
            // removeIndexofArray();
            //int a = 4;
            //int[] arry = { 1, 2, 3, 4, 5, 3, 4, 4 };
            //int[] dupArry = { 3, 4 };
            ////arry = arry.Except(new int[] {dupArry[1], dupArry[0] }).ToArray();
            //for (int i = 0; i < dupArry.Length; i++)
            //{
            //    arry = arry.Except(new int[] { dupArry[i] }).ToArray();
            //}
            //foreach (int item in arry)
            //{
            //    Console.WriteLine(item);
            //}

            ////finding largestPalindrome
            //string input = "ABCBAHELLOHOWRLEVELACECARAREYOUILOVEUEVOLIIAMAIDOINGGOOD"; 
            //Console.WriteLine(LargestPalindrome(input));

            // checking anagram string
            //Console.WriteLine(anagram("rasp", "spar"));




            //Average obj = new Average();
            //Console.WriteLine(obj.calAverage());

            ////// Char array  to string
            //char[] chars = { 'k', 'a', 's', 'h', 'i', 'f' };

            //string _string = new string(chars);
            //char[] newChars = _string.ToCharArray();

            //Console.WriteLine(_string);
            //for (int i = 0; i < newChars.Length; i++)
            //{
            //    Console.WriteLine(newChars[i]);
            //}

            //// date time to string

            //string stringMonth = "Today is " + DateTime.Now.ToString("Y");
            //Console.WriteLine(stringMonth);

            ////

            //string sentence = "Kashif is a bad boy";
            //string fourthWord = sentence.Substring(sentence.IndexOf('b'), sentence.IndexOf(" ", sentence.IndexOf('b')) - sentence.IndexOf('b'));

            //Console.WriteLine(fourthWord);

            //DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            //double temperature = 68.3;
            //string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
            //                              dateAndTime, temperature);
            //Console.WriteLine(result);

            //// Counting numbers of words in string
            string s1 = "This string consists of a single short sentence.";
            int nWords = 0;

            s1 = s1.Trim();
            foreach (char ch in s1)
            {
                if (Char.IsPunctuation(ch) | Char.IsWhiteSpace(ch))
                    nWords++;
            }
            Console.WriteLine("The sentence\n   {0}\nhas {1} words.",
                              s1, nWords);

            string s2 = "This string consists of a single short sentence.";
            // s2 = s2.Trim(' ');
            //s2 = s2.Remove(4, 6);
            //Regex.Replace(s2, @"\s+", "");
            Console.WriteLine("The sentence is\n   {0}",
                              s2.Replace(" ", string.Empty));


            ////Cheack weather the string is empty or not
            //string strOne = "Hannan";
            //if (strOne.Equals(String.Empty))
            //{

            //}
            //else {
            //    Console.WriteLine("Not null");
            //}

            ////// Copy string to another string
            //string strOrignal = "orignal string";
            //string strCopied = String.Copy(strOrignal);

            //char[] charArray = { 'a', 'p', 'p', 'e', 'n','d' };
            //strOrignal.CopyTo(0, charArray, 2, 3);

            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    Console.WriteLine(charArray[i]);
            //}


            // Point:
            //int? a = null;
            //string b = null;
            //float? c = null;

            //byte _byte = 255;

            //checked
            //{
            //    _byte++;
            //    Console.WriteLine(_byte);
            //}
            //    goto Point;
            //int a = 20;
            //byValue(a);
            //Console.WriteLine(a);
            //byRef(ref a);
            //Console.WriteLine(a);
            //Console.WriteLine(a);
            //// second largest in array

            //int[] array = { 1, 2, 45, 67, 98, 32, 85 };
            //Array.Sort(array);
            //Console.WriteLine("Enter ssize of array");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbersArry = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    numbersArry[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(numbersArry);

            //Console.WriteLine(numbersArry[numbersArry.Length - 2]);

            //// Reverse method called
            //if (str == reverse(str))
            //{
            //    Console.WriteLine(" bhar me ja");
            //}

            ////////////////// my name is hannan.

            Console.ReadLine();
            }

            /// <summary>
            /// To take reverse of input string
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
        public static string reverse(string str)
        {
            char[] arry = str.ToCharArray();
            Array.Reverse(arry);
            

            

            return new string(arry);

        }
            
            
        public static void removeIndexofArray()
        {
            int[] arry = { 1, 2, 3, 4, 5, 6, 7, 3, 4, 5, 4 };

            arry = Array.FindAll(arry, isNotFound).ToArray();

            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
            
        }
        public static bool isNotFound(int n)
        {

            return n != 4;
        }
        public static void byValue(int a)
        {
            Console.WriteLine("Initial value of a");
            Console.WriteLine(a);

            a = 10;
            Console.WriteLine("value of a after adding 10");
            Console.WriteLine(a);
        }
        public static void byRef(ref int a)
        {
            Console.WriteLine("Initial value of a");
            Console.WriteLine(a);

            a = 100;
            Console.WriteLine("value of a after adding 10");
            Console.WriteLine(a);
        }
        static string LargestPalindrome(string input)
        {
            string output = "";
            int minimum = 3;
            for (int i = 0; i < input.Length - minimum; i++)  //12
            {
                for (int j = i + minimum; j < input.Length - minimum; j++) // j = 4 , //12
                {
                    string forstr = input.Substring(i, j - i);
                    string revstr = new string(forstr.Reverse().ToArray());
                    if (forstr == revstr && forstr.Length > minimum)
                    {
                        output = forstr;
                        minimum = forstr.Length;
                    }
                }
            }
            return output;
        }

        public static bool anagram(string input1, string input2)
        {
            char[] chars1 = input1.ToCharArray();
            Array.Sort(chars1);
            char[] chars2 = input1.ToCharArray();
            Array.Sort(chars2);

            if (new string (chars1).Equals(new string(chars2)))
            {
                return true;
            }


            return false;
        }

    }

    public class Average
    {
        int avrg = 0;
        public Average()
        { }
        int[] arry = { 1, 2, 3, 4, 5, 6 };

        public int calAverage()
        {
            foreach (int item in arry)
            {
                avrg = item + avrg;
            }
            avrg = avrg / arry.Length;
            return avrg;

        }

    }
}
