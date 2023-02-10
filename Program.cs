namespace SnakeAndLadderGame
{
    public class program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("Welcome to the Snake and Ladder Game");

            int position = 0;

            Console.WriteLine("Welcome Player 1, Let's start the Game");
            Console.WriteLine("Player 1 is at position : " + position);

            Random random= new Random();
            int dice = random.Next(1,7);

            Console.WriteLine($"The Player rolls a dice and gets: {dice}");

        }
    }
}