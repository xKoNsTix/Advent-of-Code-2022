// using System.Collections.Generic;
// using System;
// using System.Linq;

// namespace Testing
// {
//     class Analysis
//     {
//         static void Main()
//         {


//             int sum = 0;
//             string[] lines = File.ReadAllLines("input.txt");
//             for (int i = 0; i < lines.Length; i++)
//             {
//                 int line = i + 1;
//                 Console.WriteLine("Line: " + line);
//                 string first = lines[i];
//                 string[] splitString = first.Split(",");

//                 string left = splitString[0];
//                 string right = splitString[1];
//                 Console.WriteLine("LEFT: " + left + " RIGHT: " + right);

//                 string[] leftFirst = left.Split("-");
//                 string leftLeft = leftFirst[0];
//                 string leftRight = leftFirst[1];
//                 int one = int.Parse(leftLeft);
//                 int two = int.Parse(leftRight);

//                 string[] rightFirst = right.Split("-");
//                 string rightLeft = rightFirst[0];
//                 string rightRight = rightFirst[1];
//                 int three = int.Parse(rightLeft);
//                 int four = int.Parse(rightRight);

//                 Console.WriteLine("1 2 3 4 |||" + one + " " + two + " " + three + " " + four);



//                 // left fits into right
//                 if ((four <= two) && three >= one)
//                 {

//                     Console.WriteLine("DONE HERE");
//                     sum++;

//                 }

//                 else if (one >= three && two <= four)
//                 {
//                     Console.WriteLine("DONE HERE");

//                     sum++;
//                 }





//                 Console.WriteLine("-------------------------");


//             }
//             Console.WriteLine("SUM is " + sum);

//         }
//     }
// }

using System.Collections.Generic;
using System;
using System.Linq;

namespace Testing
{
    class Analysis
    {
        static void Main()
        {


            int sum = 0;
            string[] lines = File.ReadAllLines("input.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                int line = i + 1;
                //Console.WriteLine("Line: " + line);
                string first = lines[i];
                string[] splitString = first.Split(",");

                string left = splitString[0];
                string right = splitString[1];
                //Console.WriteLine("LEFT: " + left + " RIGHT: " + right);

                string[] leftFirst = left.Split("-");
                string leftLeft = leftFirst[0];
                string leftRight = leftFirst[1];
                int one = int.Parse(leftLeft);
                int two = int.Parse(leftRight);

                string[] rightFirst = right.Split("-");
                string rightLeft = rightFirst[0];
                string rightRight = rightFirst[1];
                int three = int.Parse(rightLeft);
                int four = int.Parse(rightRight);

                //Console.WriteLine("1 2 3 4 |||" + one + " " + two + " " + three + " " + four);



                // left fits into right
                // if(four>=one && three<=four &&four <=three){
                //     sum++;
                //     Console.WriteLine("DONE HERE");
                // }

                //  else if(two>=three && one<= two && two <= four){
                //     sum++;
                //     Console.WriteLine("DONE HERE");
                // }

                // else if ((four <= two) && three >= one)
                // {

                //     Console.WriteLine("DONE HERE");
                //     sum++;

                // }

                // else if (one >= three && two <= four)
                // {
                //     Console.WriteLine("DONE HERE");

                //     sum++;
                // }


                // else if (one >= three && one <=four && two >=three && two >=four)
                // {
                //     Console.WriteLine("DONE HERE");

                //     sum++;
                // }

                // else if (three >= one && three <= two && four >= two && four >= two)
                // {
                //     Console.WriteLine("DONE HERE");

                //     sum++;
                // }

               

                 if(one > three && two> three && one > four && two > four){
                    Console.WriteLine("LINE WITH NO MATCH IS:"+line);
                    sum++;


                }


                else if(one < three && two< three && one < four && two < four){
                    Console.WriteLine("LINE WITH NO MATCH IS:"+line);
                    sum++;


                }





                Console.WriteLine("-------------------------");


            }
            Console.WriteLine("SUM is " + sum);

        }
    }
}