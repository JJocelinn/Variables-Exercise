namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            String dogName = "Woody";
            int dogAge = 2;
            char dogGender = 'm';
            bool dogIsFriendly = true;
            double dogWeightInPounds = 14.5;
            decimal dogHeightInInches = 9.5M;

            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old.\nHe is Male({dogGender}). He is {dogWeightInPounds} pounds and {dogHeightInInches} inches.");
        }
    }
}
