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
            
            while(position != 100)
            {
                int dice = random.Next(1, 7);

                Console.WriteLine($"The Player rolls a dice and gets: {dice}");

                int option = random.Next(0, 3);

                if (option == 0)
                {
                    Console.WriteLine("Player stays at same Position");
                }
                else if (option == 1)
                {
                    Console.WriteLine("Player Moves Ahead by {0} from ladder", dice);
                    position += dice;
                }
                else
                {
                    Console.WriteLine("Player Moves Behind by {0} from Snake", dice);
                    position -= dice;
                }
                if(position < 0)
                {
                    position = 0;
                }
                Console.WriteLine("Player Current Position is at : {0}", position);

            }
            Console.WriteLine("Player is at Position : {0}", position);

        }
    }
}