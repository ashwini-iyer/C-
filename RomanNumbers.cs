using System;
using System.Collections.Generic;
using System.Text;

namespace AshwiniApp
{
    class RomanNumbers
    {
        public static void Main() {
            int i = ConvertToNum("XIX");
            Console.WriteLine("i value is "+i);
            string[] names = new string[]{ "aa","ab","aa","ab","aut"};
            RemoveDuplicates.removeDuplicates(names);
            RemoveDuplicates.noDups(names);

            
        
        }
        //I-1 L-L50 V-5 C-100 M-1000
        public static int ConvertToNum(String s) 
        {
            s = s.ToUpper();
            int total = 0;
            for (int i=0;i<s.Length;i++) {
                if (i != s.Length - 1)
                {
                    if (getVAl(s[i]) >= getVAl(s[i + 1]))
                    {
                        total += getVAl(s[i]);
                    }
                    else
                    {
                        int temp = getVAl(s[i + 1]) - getVAl(s[i]);
                        total += temp;
                        i++;
                    }
                }
                else { total+= getVAl(s[i]); }
            
            }
            return total;
        }
        public static int getVAl(char c ) {
            switch (c) {
                case 'I': return (int)RomanNumerals.I;
                case 'X': return (int)RomanNumerals.X;
                case 'L': return (int)RomanNumerals.L;
                case 'V': return (int)RomanNumerals.V;
                case 'C': return (int)RomanNumerals.C;
                case 'M': return (int)RomanNumerals.M;
                default:return 0;
            
            
            }
        
        }
        enum RomanNumerals { 
        I=1,
        X=10,
        L=50,
        V=5,
        C=100,
        M=1000
        
        
        }
    }
}
