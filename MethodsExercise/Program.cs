using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Threading.Channels;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine($"{userName} what is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"One day, {userName} was walking downtown while wearing a {favoriteColor} t shirt. {userName} saw a {favoriteAnimal} while listening to {favoriteBand}.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number; longhand version
                sum += number;
            }
            
            return sum;
        }
        
        static void Main(string[] args)
        { 
            // Madlib();
          // Console.WriteLine(Add(numOne:2, numTwo:2));
         // int addedNums = Add(numOne: 2, numTwo: 2);
         // Console.WriteLine(addedNums);
        // Console.WriteLine(Subtract(2, 2));
        //Console.WriteLine(Multiply(2, 2));
        //Console.WriteLine(Divide(4, 2));
        Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
}
