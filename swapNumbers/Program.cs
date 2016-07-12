using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "4Always0 5look8 4on9 7the2 4bright8 9side7 3of8 5life5";
            //Split the sentence into individual words
            string[] swapWords = line.Split();

            //Assigning variables outside loop to avoid local variable error
            char hold;
            int tempLength;
            char hold2;
            string removedNums;
            string wordPrint = "";
            string finalHolder = "";
            int i = 0;
            // ^^^ finished defining variables

            // For loop to check each word in swapWords Array
            for (i = 0; i < swapWords.Length; i++)
            {
                //Save the value of the first index of the word at i
                hold = swapWords[i][0];
                //save the length of the word at i
                tempLength = swapWords[i].Length;
                //save the last index of the word at i
                hold2 = swapWords[i][tempLength - 1];
                //Remove 1 character starting at 0, then again starting at length -2
                //-2 because I've already removed the first character, so everything else slides over
                removedNums = swapWords[i].Remove(0, 1).Remove(tempLength - 2, 1);
                //Rearrange the stored variables to swap the numbers
                wordPrint = hold2 + removedNums + hold;
                //store each new word in the finalHolder variable to prep the final output
                finalHolder = finalHolder + wordPrint +" ";
            }
            //output answer
            Console.WriteLine(finalHolder);
        }
    }
}
