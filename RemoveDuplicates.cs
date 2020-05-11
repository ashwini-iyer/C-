using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace AshwiniApp
{
    class RemoveDuplicates
    {
        //using a hashset
        public static String[] removeDuplicates(String[] names) 
        {

            HashSet<String> hs = new HashSet<string>(names);
            string[] afterArr = new string[hs.Count]; 
            afterArr = hs.ToArray<String>();
            Console.WriteLine("Hurray here is my no duplicates  array using hashset!");
            for (int i=0;i<afterArr.Length;i++) {
                Console.WriteLine(afterArr[i]);
            
            }
            return afterArr;
        }
        //using a list
        public static String[] noDups(String[] names)
        {
            List<string> nodups = new List<string>();
            foreach (string s in names) {

                if (nodups.Contains(s))
                {
                    continue;
                }
                else { nodups.Add(s); }
            
            }

            string[] arr = nodups.ToArray<String>();
            Console.WriteLine("Hurray here is my no duplicates  array using list!");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            return nodups.ToArray<String>();

        }
    }
}
