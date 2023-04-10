using System;
using System.Linq;

namespace Loops_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for a sentence
            Console.WriteLine("Write a sentence");
            //reads the sentence and saves it as a string
            string myString = Console.ReadLine();
            //counts the number of spaces
            int spaceCount = myString.Count(x => x == ' ');
            //prints the string and how many spaces it has
            Console.WriteLine($"\"{myString}\" has {spaceCount} spaces in it");

            //asks for a number
            Console.WriteLine("Write an int");
            //reads the numbers you write and saves it as a string
            string addInt = Console.ReadLine();

            //makes and int that's the length of the string
            int addIndex = addInt.Length;
            //creates a special tool that will help us later
            double forScience = 0;
            //for loop that runs for every digit in the number
            for (int i = 0; i < addIndex; i++)
            {
                //saves a single character in the string as a double
                double addNum = char.GetNumericValue(addInt, i);
                //adds the double addNum to our earlier double
                forScience = forScience + addNum;
            }
            //prints the forScience double
            Console.WriteLine($"the digits in that number add up to {forScience}");
        }
    }
}
