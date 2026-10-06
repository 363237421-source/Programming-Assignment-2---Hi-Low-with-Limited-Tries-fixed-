namespace Programming_Assignment_2___Hi_Low_with_Limited_Tries
{
    internal class Program
    {

        static void Typer(string text) //extra
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
        
        
        
        
        static void Main(string[] args)
        {
            Random Generator = new Random();
            int flip, heads = 0, tails = 1;
            
            bool done = false;
            string coinFace;
            

            Typer("Hello, welcome to the Casino!");
            Typer("You will be playing a game of heads and tails.");
            Typer("You will start with 3 points, these are your lives. You will lose points if you guess wrong.");
            Typer("You can also increase your points by guessing right.");
            Typer("Lastly if you want to end the game for whatever reason, just input 'quit.'");
            Typer("Press enter if you are ready.");
            Console.ReadLine();
            Console.Clear();

            
            while (!done)
            {
                Typer("Head or Tail?");
                coinFace = Console.ReadLine();

                flip = Generator.Next(2);

                if (flip == heads)
                    Typer("Heads was flipped");
                else
                {
                    Typer("Tails was flipped");
                }
            }
        }
    }
}
