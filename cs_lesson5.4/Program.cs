﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = { ' ' }; //split by blank places
            string[] myWords;
            myWords = myString.Split(separator);
            
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }
            Console.ReadKey();
            

        }
    }
}
