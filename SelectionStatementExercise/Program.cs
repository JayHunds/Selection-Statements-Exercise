namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 42;

          
            Console.WriteLine("Guess my favorite number:");
            int guessedNumber = int.Parse(Console.ReadLine());

            
            if (guessedNumber < favoriteNumber)
            {
                Console.WriteLine("Too low");
            }
           
            else if (guessedNumber > favoriteNumber)
            {
                Console.WriteLine("Too high");
            }
            
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
    }
}
