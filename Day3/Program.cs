

// using System.Collections.Generic;
// using System;
// using System.Linq;

// namespace Testing
// {
//     class Analysis
//     {
//         static void Main()
//         {
//             int currTemp = 0;


//             string[] lines = File.ReadAllLines("input.txt");
//             int val = 0;
//             int i, x, a, y;
//             string temp;
//             int sum = 0;

//             int lineCount = 0;

//             // test if readin was correct

//             // Console.WriteLine("0 is" + lines[0]);
//             // Console.WriteLine("1 is" + lines[1]);
//             // Console.WriteLine("2 is" + lines[2]);
//             // Console.WriteLine("Length is " + lines.Length);

//             // main loop
//             sum = 0;
//             for (i = 0; i < lines.Length; i++)
//             {

//                 char sameChar = 'X';
//                 var MyString = lines[i];
//                 var first = MyString.Substring(0, (int)(MyString.Length / 2));
//                 var last = MyString.Substring((int)(MyString.Length / 2), (int)(MyString.Length / 2));
//                 char[] firstArr = first.ToCharArray();
//                 char[] lastArr = last.ToCharArray();

//                 Console.WriteLine("Line " + i + " : " + first + "  " + last);
//                 Console.WriteLine("SUM IS " + sum);

//                 for (y = 0; y < firstArr.Length; y++)
//                 {

//                     // Console.WriteLine("-------"+ lineCount +"-------");
//                     // Console.WriteLine("FirstChar is:" + firstArr[y]);

//                     for (a = 0; a < lastArr.Length; a++)
//                     {
//                         //char tempChar = lastArr[a];
//                         // Console.WriteLine("LastChar is:" + lastArr[a]);
//                         if (firstArr[y] == lastArr[a])
//                         {


//                             char c = firstArr[y];
//                             if (Char.IsUpper(firstArr[y]))
//                             {
//                                 sum = sum + (((int)c) - 38);
//                             }

//                             if (Char.IsLower(firstArr[y]))
//                             {
//                                 sum = sum + (((int)c) - 96);
//                             }


//                             Console.WriteLine("Found same char: " + firstArr[y]);

//                             y = firstArr.Length - 1;
//                             a = lastArr.Length - 1;
//                         }
//                     }

//                 }
//             }
//             Console.WriteLine("sum is " + sum);
//             Console.WriteLine("linecount  is " + lineCount);
//         }


//     }
// }

// // using System;

// // class GFG {

// //     // Main Method
// //     static public void Main()
// //     {

// //         // Declaration of data type
// //         bool result;

// //         // checking if G is a
// //         // uppercase letter or not
// //         char ch1 = 'G';
// //         result = Char.IsUpper(ch1);
// //         Console.WriteLine(result);

// //         // checking if 'g' is a
// //         // uppercase letter or not
// //         char ch2 = 'g';
// //         result = Char.IsUpper(ch2);
// //         Console.WriteLine(result);
// //     }
// // }

// PART 2




using System.Collections.Generic;
using System;
using System.Linq;

namespace Testing
{
    class Analysis
    {
        static void Main()
        {



            string[] lines = File.ReadAllLines("input.txt");
            int val = 0;
            int a, b, c, i, y;
            string temp;
            int sum = 0;

            int lineCount = 0;

            // test if readin was correct

            // Console.WriteLine("0 is" + lines[0]);
            // Console.WriteLine("1 is" + lines[1]);
            // Console.WriteLine("2 is" + lines[2]);
            // Console.WriteLine("Length is " + lines.Length);

            // main loop
            sum = 0;
            for (i = 0; i < 300; i++)
            {

                char sameChar = 'X';
                var myString = lines[i];
                var myString2 = lines[i+1];
                var myString3 = lines[i+2];

                char[] firstArr = myString.ToCharArray();
                char[] secondArr = myString2.ToCharArray();
                char[] thirdArr = myString3.ToCharArray();

                lineCount++;

                Console.WriteLine(myString + "  " + myString2 + "  " + myString3);
                Console.WriteLine("SUM IS " + sum);

                for (y = 0; y < firstArr.Length; y++)
                {
                    for (a = 0; a < secondArr.Length; a++)
                    {
                        //char tempChar = lastArr[a];
                        // Console.WriteLine("LastChar is:" + lastArr[a]);
                        if (firstArr[y] == secondArr[a])
                        {

                            for (b = 0; b < thirdArr.Length; b++)
                            {

                                if (firstArr[y] == thirdArr[b])
                                {




                                    char x = firstArr[y];
                                    if (Char.IsUpper(x))
                                    {
                                        sum = sum + (((int)x) - 38);
                                    }

                                    if (Char.IsLower(x))
                                    {
                                        sum = sum + (((int)x) - 96);
                                    }


                                    Console.WriteLine("Same Char on Package: " + lineCount + ":  -> " + firstArr[y]);

                                    y = firstArr.Length - 1;
                                    a = secondArr.Length - 1;
                                    b = thirdArr.Length - 1;

                                }
                            }
                        }






                    }
                    

                }

                i++;
                i++;
                Console.WriteLine ("I IS : "+i);
            }

            Console.WriteLine ("sum is : "+sum);
        }

    }

}


