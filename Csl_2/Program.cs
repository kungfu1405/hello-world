using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace Csl_2
{
    class Result
    {
        public static void plusMinus(List<int> arr)
        //public static void plusMinus()
        {
            double d = ((double)2 / 3);
            Console.Write(d.ToString("0.000000\n"));
            Console.Write(d);
            Console.ReadLine();
            List<int> positiveList = new List<int>();
            List<int> negativeList = new List<int>();
            List<int> zeroList = new List<int>();
            foreach(int i in arr)
            {
               if()
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus();
        }
    }
}
