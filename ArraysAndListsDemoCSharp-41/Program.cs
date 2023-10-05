//using statement is just a library that has methods, classes, props, etc
using System.Collections.Generic;

namespace ArraysAndListsDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //Arrays have a set size that you define at creattion, and that size cannot change
            var numbers = new int[] {2, 3, 4};           

            //numbers[0] = 100;

            //Arrays have a property called "Length" that shows you the number of things in the Array
            //Console.WriteLine(numbers.Length);



            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            var names = new string[] {"Seth", "Cruz", "Jeremy"};

            //Console.WriteLine(names.Length);

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(names[i]);
            //}


            //Lists
            //Lists have a size that can change all you want

            var listNumbers = new List<int>() { 3, 4, 5, 6, 7};

            listNumbers.Add(2);
            listNumbers.Add(400);

            //listNumbers.Remove(400);

            //Lists have a property called "Count" that shows the number of things in the list
            Console.WriteLine(listNumbers.Count);

            //foreach (var number in listNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //for(int i = 0; i < listNumbers.Count; i++)
            //{
            //    Console.WriteLine(listNumbers[i]);
            //}

            List<string> students = new List<string>();

            students.Add("Cory");
            students.Add("David");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }



        }
    }
}