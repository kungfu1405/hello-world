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
        //public static void miniMaxSum(List<int> arr)
        //{
        //    List<long> listMin = arr.OrderBy(x=>x).Take(4).Select(e=>(long)e).ToList();
        //    List<long> listMax = arr.OrderByDescending(x =>x).Take(4).Select(e => (long)e).ToList();         
        //    Console.WriteLine(listMin.Sum(e => e).ToString() + " " + listMax.Sum(e => e).ToString());



        //}
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            var tallist = candles.Where(e => e == max);

            return 2;
        }
        public static string timeConversion(string s)
        {
            var time = Convert.ToDateTime(s);            
            return time.ToString("HH:mm:ss");
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> gradList = new List<int>();
            foreach(int mark in grades)
            {
                int outMark = 0;                
                    int soDu = mark % 5; int hieuso = 5 - soDu; int next = mark + hieuso;                
                    outMark = ((next - mark) < 3) && (next >= 40) ? next : mark;
                    gradList.Add(outMark);                
            }
            return gradList;

        }
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            //List<int> appleCollections = new List<int>();
            //List<int> orangeCollections = new List<int>();
            
            //foreach(int ap in apples)
            //{
            //    if( ((ap + a) >= s) && ((ap + a) <= t))
            //    {
            //        appleCollections.Add(ap);
            //    }
                        
            //}
            //foreach(int org in oranges)
            //{
            //    if((org + b) >= s && (org + b) <= t)
            //    {
            //        orangeCollections.Add(org);
            //    }
            //}
            int c = apples.Select(e => e + a).Where(a => a >= s && a <= t).Count();
            int e = oranges.Select(e => e + b).Where(a => a >= s && a <= t).Count();

            Console.WriteLine(c);
            Console.WriteLine(e);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            Result.countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
