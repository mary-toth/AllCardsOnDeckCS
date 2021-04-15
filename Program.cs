using System;
using AllCardsOnDeckCS.Models;
using System.Linq;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {

            var rankList = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            var suitList = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };


            var myList = new List<string>();

            for (var rankIndex = 0; rankIndex < rankList.Count; rankIndex++)
            {
                for (var suitIndex = 0; suitIndex < suitList.Count; suitIndex++)
                {
                    var fullCard = $"{rankList[rankIndex]} of {suitList[suitIndex]}";
                    myList.Add(fullCard);
                }
            }
            foreach (var num in myList)
            {
                Console.WriteLine($"{num}");

            }
            Console.WriteLine("");
            Console.WriteLine("");

            var numberOfRank = myList.Count;



            for (var rightIndex = numberOfRank - 1; rightIndex >= 0; rightIndex--)
            {

                var leftIndex = new Random().Next(0, rightIndex);

                var rightNum = myList[rightIndex];

                myList[rightIndex] = myList[leftIndex];

                myList[leftIndex] = rightNum;


            }
            foreach (var rank in myList)
            {
                Console.WriteLine($"{rank}");

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Top Two Cards:");
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);



        }
    }
}


















