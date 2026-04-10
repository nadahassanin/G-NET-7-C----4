using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // (a) Why is it bad?
            // Because the computer creates a new string every time we add a number. 
            // This makes the memory very busy and slow.

            // (b) Simple StringBuilder:
            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append(i + ",");
            //}
            //Console.WriteLine(sb.ToString());

            // (c) Timing (The easiest way):
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            // ... put code here ...
            //watch.Stop();
            //Console.WriteLine("Time: " + watch.ElapsedMilliseconds);
            #endregion

        }
    }
}
