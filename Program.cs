using System;
using System.Linq;
using System.Collections.Generic;

namespace linqed_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // RESTRICTION/FILTERING OPERATIONS

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

            foreach (var word in LFruits)
            {
                Console.WriteLine(word);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            // IEnumerable<int> fourSixMultiples = numbers.Where(num =>
            // {
            //     var fourCompatible = num % 4;
            //     var sixCompatible = num % 6;
            //     if (fourCompatible % 1 == 0 || sixCompatible % 1 == 0) {
            //         Console.WriteLine(num);
            //     }
            // });

            // ORDERING OPERATIONS

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };
            
            // List<string> descend = from n in names
            // .OrderByDescending(n => n)
            // .ToList();
            // foreach (string d in descend) {
            //     Console.WriteLine(d);
            // }
            // var peopleInOrder = people.OrderByDescending(person => person.firstLetter);

            // Build a collection of these numbers sorted in ascending order
            List<int> moreNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            // List<int> ascend = from n in moreNumbers
            // .OrderBy(n => n).ToList();

            // AGGREGATE OPERATIONS

            // Output how many numbers are in moreNumbers list
            int numOfNum = moreNumbers.Count();
            Console.WriteLine("numOfNum", numOfNum);
        }
    }
}

