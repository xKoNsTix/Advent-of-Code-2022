// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Diagnostics;
// using System.IO;

// namespace Testing
// {
//     class Analysis
//     {
//         static void Main()
//         {
//             int currTemp = 0;

//             int y = 1;
//             string[] lines = File.ReadAllLines("input.txt");
//             int val = 0;
//             string first;
//             string second;

//             Console.WriteLine("0 is" + lines[0]);
//             Console.WriteLine("1 is" + lines[1]);
//             Console.WriteLine("2 is" + lines[2]);
//             Console.WriteLine("Length is " + lines.Length);
//             for (int i = 0; i < 2500; i++)

//             {




//                 first = lines[i];

//                 if (first == "A X")
//                 {


//                     currTemp = currTemp + 4;

//                 }
//                 if (first == "A Y")
//                 {

//                     currTemp = currTemp + 8;
//                     Console.WriteLine("im am here check");

//                 }

//                 if (first == "A Z")
//                 {

//                     currTemp = currTemp + 3;

//                 }

//                 if (first == "B X")
//                 {

//                     currTemp = currTemp + 1;

//                 }
//                 if (first == "B Y")
//                 {

//                     currTemp = currTemp + 5;

//                 }

//                 if (first == "B Z")
//                 {

//                     currTemp = currTemp + 9;

//                 }
//                 if (first == "C X")
//                 {

//                     currTemp = currTemp + 7;

//                 }
//                 if (first == "C Y")
//                 {

//                     currTemp = currTemp + 2;

//                 }

//                 if (first == "C Z")
//                 {

//                     currTemp = currTemp + 6;

//                 }

//                 Console.WriteLine(currTemp);
//             }

//         }


//     }

// }

// SECOND

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
            int currTemp = 0;

            int y = 1;
            string[] lines = File.ReadAllLines("input.txt");
            int val = 0;
            string first;
            string second;

            Console.WriteLine("0 is" + lines[0]);
            Console.WriteLine("1 is" + lines[1]);
            Console.WriteLine("2 is" + lines[2]);
            Console.WriteLine("Length is " + lines.Length);
            for (int i = 0; i < 2500; i++)

            {




                first = lines[i];

                if (first == "A X")
                {


                    currTemp = currTemp + 3;

                }
                if (first == "A Y")
                {

                    currTemp = currTemp + 4;
                    Console.WriteLine("im am here check");

                }

                if (first == "A Z")
                {

                    currTemp = currTemp + 8;

                }

                if (first == "B X")
                {

                    currTemp = currTemp + 1;

                }
                if (first == "B Y")
                {

                    currTemp = currTemp + 5;

                }

                if (first == "B Z")
                {

                    currTemp = currTemp + 9;

                }
                if (first == "C X")
                {

                    currTemp = currTemp + 2;

                }
                if (first == "C Y")
                {

                    currTemp = currTemp + 6;

                }

                if (first == "C Z")
                {

                    currTemp = currTemp + 7;

                }

                Console.WriteLine(currTemp);
            }

        }


    }

}











































