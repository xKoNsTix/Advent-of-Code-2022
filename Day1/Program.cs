using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Testing
{
    class Analysis
    {
        static void Main()
        {
            int highest = 0;

            int y = 1;
            string[] lines = File.ReadAllLines("input.txt");

            int[] ints = new int[2247];

            int length = lines.Length;
            int tempMax = 0;
            int secondHighest = 0;
            int thirdHighest = 0;



            for (int i = 1; i < length - 1; i++)
            {
                y = y + 1;
                if (lines[i] == "")
                {
                    for (int x = -1; x != y + 1; x++)
                    {
                        // Console.WriteLine(i +" - "+y); 
                        Console.WriteLine(i + " - " + x + " = " + (i + 1 - x) + "Realvalueis" + (ints[(i + 1 - x)]));
                        tempMax = tempMax + ints[(i + 1 - x)];

                    }
                    Console.WriteLine(tempMax);
                    Console.WriteLine("------------------");
                    if (tempMax > thirdHighest)
                    {
                        Console.WriteLine("tempmax is:" + tempMax);
                        thirdHighest = tempMax;
                        tempMax = 0;
                        Console.WriteLine("thirdHighest is now:" + thirdHighest);
                    }

                    if (thirdHighest > secondHighest)
                    {
                        Console.WriteLine("tempmax is:" + tempMax);
                        int tempValue = secondHighest;
                        secondHighest = thirdHighest;
                        thirdHighest = tempValue;
                        tempMax = 0;
                        Console.WriteLine("secondHighest is now:" + secondHighest);
                    }

                    if (secondHighest > highest)
                    {
                        Console.WriteLine("tempmax is:" + tempMax);
                        int tempValue = highest;
                        highest = secondHighest;
                        secondHighest = tempValue;
                        tempMax = 0;
                        Console.WriteLine("secondHighest is now:" + secondHighest);
                    }


                    y = 1;
                    tempMax = 0;
                    i = i + 1;

                }
                int temp = Int32.Parse(lines[i]);
                ints[i] = temp;
                // Console.WriteLine(highest);


            }
            Console.WriteLine(highest);
            Console.WriteLine(secondHighest);
            Console.WriteLine(thirdHighest);
            Console.WriteLine(highest+secondHighest+thirdHighest);


            // for (int i = 0; i < lines.Length; i++)
            // {
            //     y = y + 1;
            //     if (lines[i] == "")
            //     {
            //         for (int x = y; x > y; x--)
            //         {
            //             temp = temp + ints[i - y];

            //         }
            //         if (temp > highest)
            //         {
            //             highest = temp;
            //             temp = 0;
            //         }
            //         y = 0;
            //         temp = 0;
            //     }


            // }
        }
    }
}
