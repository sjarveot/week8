using System;

namespace FridayNightRandomRetun
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite", "water" };
            string[] movies = { "Ironman", "Fast and Furios", "Avatar", "Spiderman" };

            randomFood = PickRandomElemenentFromArray(foods);
            randomDrink = PickRandomElemenentFromArray(drinks);
            randomMovie = PickRandomElemenentFromArray(movies);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string PickRandomElemenentFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
    }

