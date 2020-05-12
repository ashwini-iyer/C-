using System;
using System.Collections.Generic;
using System.Text;

namespace AshwiniApp
{
    class StrReverse
    {
        public static void revStr(string sentence) {

            string str = sentence;
            string rev = "";
            str = str.Trim(); int count = 0;
            char[] chArr = str.ToCharArray();
            for(int i=str.Length-1;i>=0;i--) 
            {
                if ((chArr[i] != ' '))
                {

                    count++;
                }
                else
                {
                    for (int k = i + 1; count > 0; count--, k++)
                    {
                        Console.Write(str[k]);

                    }
                    Console.Write(" ");

                }
               
               
            }
            for (int j = 0; count > 0; j++, count--)
            {
                Console.Write(str[j]);
            }


        }
    }
}
