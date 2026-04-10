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
            #region Question 02
            
            //Console.Write("Age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Day (6=Fri, 7=Sat): ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Student (yes/no): ");
            //string student = Console.ReadLine();

            //double price = 0;

            //if (age < 5) price = 0;
            //else if (age <= 12) price = 30;
            //else if (age <= 59) price = 50;
            //else price = 25;

            
            //if (price > 0 && (day == 6 || day == 7)) price = price + 10;

            
            //if (student == "yes") price = price * 0.8;

            //Console.WriteLine("Final Price: " + price);
            #endregion


        }
    }
}
