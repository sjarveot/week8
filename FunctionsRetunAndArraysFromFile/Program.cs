using System;

namespace FunctionsRetunAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        
            {
                DisplayRandomFood();
                DisplayRandomDrink();
                DisplayRandomMovie();
            }

            private static void DisplayRandomFood()
            {
                string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, foods.Length);

                string randomFood = foods[randomIndex];
                Console.WriteLine($"Compuer picked: {randomFood}");
            }

            private static void DisplayRandomDrink()
            {
                string[] drinks = { "apple juice", "coke", "fanta", "sprite", "water" };
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, drinks.Length);

                string randomDrink = drinks[randomIndex];
                Console.WriteLine($"Compuer picked: {randomDrink}");
            }
            private static void DisplayRandomMovie()
            {
                string[] movies = { "Ironman", "Fast and Furios", "Avatar", "Spiderman" };
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, movies.Length);

                string randomDrink = movies[randomIndex];
                Console.WriteLine($"Compuer picked: {randomDrink}");
            }
        
    }
}