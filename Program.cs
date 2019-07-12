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

            IEnumerable<int> fourSixMultiples = numbers.Where(num =>
            {
                var fourCompatible = num % 4;
                var sixCompatible = num % 6;
                if (fourCompatible % 1 == 0 || sixCompatible % 1 == 0) {
                    Console.WriteLine(num);
                }
            });

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
            
            List<string> descend = from n in names
            .OrderByDescending(n => n)
            .ToList();
            foreach (string d in descend) {
                Console.WriteLine(d);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> moreNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> ascend = from n in moreNumbers
            .OrderBy(n => n).ToList();

            // AGGREGATE OPERATIONS

            // Output how many numbers are in moreNumbers list
            int numOfNum = moreNumbers.Count();
            Console.WriteLine("numOfNum", numOfNum);

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            double sumOfPurchases = purchases.Sum();
            Console.WriteLine("sumOfPurchases", sumOfPurchases);

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            double highestPrice = prices.Max();
            Console.WriteLine("highestPrice", highestPrice);

            // PARTITIONING OPERATIONS
            /*
            Store each number in the following List until a perfect square is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
             */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            int sqrtResult = wheresSquaredo.Math.Sqrt();
        }
    }
}

