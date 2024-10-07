namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();

            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(10, 5);
            Console.WriteLine(subtracted);

            int mult = Multiply(2, 5);
            Console.WriteLine(mult);

            int Div = Divide(4, 2);
            Console.WriteLine(Div);

            int result = Sum(5, 5, 5, 5, 5);
            Console.WriteLine(result);
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            String favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"One day, {userName} was joggging throught the woods while wearing a {favColor} pullover. {userName} saw a {favAnimal} while listening to {favBand}.");
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

        public static int Sum (params int[] values)
        {
            int sum = 0; 
            foreach (int value in values)
            {
                sum += value;
            }

            return sum;
        }

    }
}
