using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the stacks
            var stacks = new List<Stack<char>>();
            for (int i = 1; i < 12; i++)
            {
                stacks.Add(new Stack<char>());
            }
            // Initialize Input: 

            string[] lines = File.ReadAllLines("input.txt");

            // Initialize the stacks
            stacks[1].Push('B');
            stacks[1].Push('Q');
            stacks[1].Push('C');


            stacks[2].Push('R');
            stacks[2].Push('Q');
            stacks[2].Push('W');
            stacks[2].Push('Z');


            stacks[3].Push('B');
            stacks[3].Push('M');
            stacks[3].Push('R');
            stacks[3].Push('L');
            stacks[3].Push('V');


            stacks[4].Push('C');
            stacks[4].Push('Z');
            stacks[4].Push('H');
            stacks[4].Push('V');
            stacks[4].Push('T');
            stacks[4].Push('W');



            stacks[5].Push('D');
            stacks[5].Push('Z');
            stacks[5].Push('H');
            stacks[5].Push('B');
            stacks[5].Push('N');
            stacks[5].Push('V');
            stacks[5].Push('G');

            stacks[6].Push('H');
            stacks[6].Push('N');
            stacks[6].Push('P');
            stacks[6].Push('C');
            stacks[6].Push('J');
            stacks[6].Push('F');
            stacks[6].Push('V');
            stacks[6].Push('Q');

            stacks[7].Push('D');
            stacks[7].Push('G');
            stacks[7].Push('T');
            stacks[7].Push('R');
            stacks[7].Push('W');
            stacks[7].Push('Z');
            stacks[7].Push('S');


            stacks[8].Push('C');
            stacks[8].Push('G');
            stacks[8].Push('M');
            stacks[8].Push('N');
            stacks[8].Push('B');
            stacks[8].Push('W');
            stacks[8].Push('Z');
            stacks[8].Push('P');

            stacks[9].Push('N');
            stacks[9].Push('J');
            stacks[9].Push('B');
            stacks[9].Push('M');
            stacks[9].Push('W');
            stacks[9].Push('Q');
            stacks[9].Push('F');
            stacks[9].Push('P');


            stacks[10].Push('X');

            // prepare input
            Console.WriteLine("INITIAL");
            for (int x = 1; x < 11; x++)
            {
                Console.Write("|" + x + "|");
                foreach (char item in stacks[x])
                {
                    Console.Write(item);
                }
                Console.WriteLine("");

            }
            Console.WriteLine("");
            for (int y = 0; y < lines.Length; y++)
            {
                string input = lines[y];

                MatchCollection matches = Regex.Matches(input, @"\d{1,2}");

                // Save the detected integers in separate variables
                int amount = int.Parse(matches[0].Value);
                int from = int.Parse(matches[1].Value);
                int to = int.Parse(matches[2].Value);



                Console.WriteLine("Amount " + amount + " FROM " + from + " to: " + to);
                if (amount < 2)
                {
                    Move(stacks[from], stacks[to], amount);
                }
                else if (amount >= 2)
                {
                    Movy(stacks[from], stacks[to], amount);
                }



                for (int x = 1; x < 11; x++)
                {
                    Console.Write("|" + x + "|");
                    foreach (char item in stacks[x])
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine("");




                }
                Console.WriteLine("-------");
            }

        }





        static void Move(Stack<char> from, Stack<char> to, int count)
        {

            if (count < 3)
            {
                // Iterate over the specified number of items
                for (int i = 0; i < count; i++)
                {
                    // Check if the from stack is empty
                    if (from.Count == 0)
                    {
                        break;
                    }

                    // Pop the item from the from stack and push it onto the to stack
                    to.Push(from.Pop());
                }
            }
        }


        static void Movy(Stack<char> from, Stack<char> to, int count)
        {

            
            
        Stack<char> tempStack = new Stack<char>();

            for (int i = 0; i < count; i++)
            {
                tempStack.Push(from.Pop());
            }
            


            for (int y=0; y<count; y++)
            {
                to.Push(tempStack.Pop());
            }




        }
    }
}
