namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Dorian";
            int age = 18;
            char grade = 'A';
            bool isPassing = true;
            double rating = 4.9;
            decimal netWorth = 9999999999999.99m;
            
            Console.WriteLine($"My name is {name}, I am {age} years old. \nMy grade in class is {grade}, and it is {isPassing}" +
                              $"that I am passing. \nMy rating is {rating} and my net worth is ${netWorth} (aka loaded)");
        }
    }
}
