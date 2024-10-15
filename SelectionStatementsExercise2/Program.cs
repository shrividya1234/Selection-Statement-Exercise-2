using System.Collections;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            string favoriteSubject = Console.ReadLine();
            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("Math is my favorite subject!");
                    break;
                case "English":
                    Console.WriteLine("English is my favorite subject!");
                    break;
                case "French":
                    Console.WriteLine("French is my favorite subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is my favorite subject!");
                    break;
                case "History":
                    Console.WriteLine("History is my favorite subject!");
                    break;
                default:
                    Console.WriteLine("I don't understand what is my favorite subject!");
                    break;
            }
    }
    }
}