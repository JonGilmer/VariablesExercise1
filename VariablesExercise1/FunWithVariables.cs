using System;

namespace VariablesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringCheese = "string cheese is a good snack,";
            int stringCheeseAmount = 10;
            char charizardFirstLetter = 'C';
            bool charizardIsPokemon = true;
            double trouble = 3.666666667;
            decimal point = 1.45m;

            //string interpolation
            Console.WriteLine($"My mom says {stringCheese} but don't eat all {stringCheeseAmount} of them at once!");

            Console.WriteLine($"It is {charizardIsPokemon} that Charizard is a popular pokemon that starts with the letter {charizardFirstLetter}.");

            Console.WriteLine($"{trouble} percent of the group always gets into trouble, {point} percent of the time.");
        }
    }
}
