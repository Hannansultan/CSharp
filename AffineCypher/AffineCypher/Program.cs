using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCypher
{
    class AffineCypher
    {
        int numOne, numTwo,remainderOne, remainderTwo, letterLimit;
        double encCharVal, decCharVal;
        string alphaLow = "abcdefghijklmnopqrstuvwxyz";
        string alphaUp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder encInput = new StringBuilder();
        StringBuilder decInput = new StringBuilder();
        char[] inputVal ;
        public AffineCypher(int a, int b, string c)
        {
            
            numOne = a; numTwo = b;
            inputVal = c.ToCharArray();
            letterLimit = 26;
            
        }

        /// <summary>
        /// To check common divsor between two inputs and 26
        /// </summary>
        /// <returns></returns>
        public bool chkCommonDiv(int a)
        {
           
            remainderOne = letterLimit % a;
            if (remainderOne == 0)
            {
                return true;
            }
            else if (remainderOne != 0)
            {
                remainderTwo = a % remainderOne;
                if (remainderTwo == 0)
                {
                    return true;
                }
                else
                {
                    remainderOne = remainderOne % remainderTwo;
                    if ((remainderOne + remainderTwo) == a)
                    {
                        return true;
                    }
                }
            }
            
            


            return false;
        }

        public string encrypt()
        {
            if (chkCommonDiv(numOne) && chkCommonDiv(numTwo))
            {
                Console.WriteLine("Input  key one shouldn't have common divisor with 26");
                return null;
            }
            else
            {
               
                for (int i = 0; i < inputVal.Length; i++)
                {
                    if (Char.IsLower(inputVal[i]))
                    {
                        encCharVal = ((numOne * alphaLow.IndexOf(inputVal[i]) + numTwo));
                        encCharVal = mod(Convert.ToInt32(encCharVal), 26);
                        encInput.Append( alphaLow[Convert.ToInt32(encCharVal)]);
                    }
                    else if (Char.IsUpper(inputVal[i]))
                    {
                        encCharVal = ((numOne * alphaUp.IndexOf(inputVal[i])) + numTwo);
                        encCharVal = mod(Convert.ToInt32(encCharVal), 26);
                        encInput.Append(alphaUp[Convert.ToInt32(encCharVal)]);
                    }
                    else
                    {
                        encInput.Append(" ");
                    }
                }
                
            }
           
            return encInput.ToString();
        }
        public string decrypt()
        {

            for (int i = 0; i < encInput.Length; i++)
            {
                if (Char.IsLower(encInput[i]))
                {
                    decCharVal = ((modInverse(5,26)) * (alphaLow.IndexOf(encInput[i]) - numTwo));
                    decCharVal = mod(Convert.ToInt32(decCharVal),26);
                    decInput.Append(alphaLow[Math.Abs(Convert.ToInt32(decCharVal))]);
                }
                else if (Char.IsUpper(encInput[i]))
                {
                    decCharVal = ((modInverse(5, 26)) * (alphaUp.IndexOf(encInput[i]) - numTwo));
                    decCharVal = mod(Convert.ToInt32(decCharVal), 26);
                    decInput.Append(alphaUp[Math.Abs(Convert.ToInt32(decCharVal))]);
                }
                else
                {
                    decInput.Append(" ");
                }
            }
            return decInput.ToString();
        }
        int mod(int x, int m)
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }
        int modInverse(int num, int mod)
        {
            int i = mod, v = 0, d = 1;
            while (num > 0)
            {
                int t = i / num, x = num;
                num = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= mod;
            if (v < 0) v = (v + mod) % mod;
            return v;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int numOne, numTwo, choice;
            string input;
            Console.WriteLine("Enter Two keys values for encryption \n(Input  key one  value should not have common div with 26)\n(i.e range of Input  key one  is (1,3,5,7,9,11,15,17,19,21,23,25))");
            Console.WriteLine("Key One");
            numOne = int.Parse( Console.ReadLine());
            Console.WriteLine("Key Two");
            numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter input ");
            input = Console.ReadLine();

            AffineCypher obj = new AffineCypher(numOne, numTwo, input);

            Console.WriteLine("\nEncrypted Value of input is\n"+ obj.encrypt());

            Console.WriteLine("Press 1 to decrypt ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine( obj.decrypt());
            }

            Console.ReadLine();
        }
    }
}
