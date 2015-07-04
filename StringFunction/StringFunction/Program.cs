using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Dulan");
            myList.Add("Kasun");
            myList.Add("Nirmal");
            myList.Add("Gayan");
            myList.Add("Sameera");

            List<string> newList = Sort(myList, 'D');

            Console.Write(Convert.ToString(newList.Count));
            Console.Read();
        }

        //String sort function - by Dulan Chiranthaka 
        //Interview Phase 2 - Segment 4
        static public List<string> Sort(List<string> theList, char theChar)
        {
            List<string> newList = new List<string>();
            foreach (string word in theList)
            {
                if (word.StartsWith(Convert.ToString(theChar)))
                {
                    newList.Add(word);
                }
            }
            return newList;
        }

    }
}
