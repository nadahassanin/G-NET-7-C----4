using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            #region Question 03


            //int score = 85;


            //switch (score)
            //{
            //    case 100:
            //        Console.WriteLine("Perfect");
            //        break;
            //    case 90:
            //        Console.WriteLine("Excellent");
            //        break;
            //    default:
            //        Console.WriteLine("Keep trying");
            //        break;
            //}


            //string result = score switch
            //{
            //    100 => "Perfect",
            //    90 => "Excellent",
            //    _ => "Keep trying" 
            //};

            //Console.WriteLine(result);

            #endregion
            #region Question 04
            //int score = 85;
            //string status = (score >= 50) ? "Passed" : "Failed";


            // It's shorter, but if-else is easier to read for beginners. 
            // Use it for very simple things only.
            #endregion
            #region Question 05

            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine("Enter Password: ");
            //    string p = Console.ReadLine();

            //    if (p.Length >= 8 && !p.Contains(" "))
            //    {
            //        Console.WriteLine("Accepted!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong! Try again.");
            //        count++;
            //    }

            //    if (count == 5) Console.WriteLine("Locked!");
            //}
            #endregion
            #region Question 06
            
            //int[] scores = { 45, 92, 38, 75, 50, 95 };

           
            //foreach (int s in scores)
            //{
            //    if (s < 50) Console.WriteLine("Fail: " + s);
            //}

           
            //foreach (int s in scores)
            //{
            //    if (s > 90)
            //    {
            //        Console.WriteLine("Found: " + s);
            //        break;
            //    }
            //}

          
            //double total = 0; int students = 0;
            //foreach (int s in scores)
            //{
            //    if (s >= 40)
            //    {
            //        total += s;
            //        students++;
            //    }
            //}
            //Console.WriteLine("Average: " + (total / students));
            #endregion
        }
    }
}
