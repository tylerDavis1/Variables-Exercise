namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           
            string dogName = "jack";
            int age = 2;
            char middleName = 'j';
            bool nameIsjack = true;
            double currentWeight = 66.3;
            decimal currentPrice = 1200.73m;

            Console.WriteLine($"I love {dogName}, he weighs {currentWeight}, he is {age}, and he's Pricey coming in at {currentPrice}. {dogName}'s real name is {nameIsjack}, he also has my middle name {middleName}.");

        }
    }
}
