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

            int points = 3;

            bool done = false, validChoice = false;
            string coinGuess, exit;


            Console.WriteLine("Hello, welcome to the Casino!");
            Console.WriteLine("You will be playing a game of heads and tails.");
            Console.WriteLine("You will start with 3 points, these are your lives. You will lose points if you guess wrong.");
            Console.WriteLine("You can also increase your points by guessing right.");
            Console.WriteLine("Lastly if you want to end the game for whatever reason, just input 'quit.'");
            Console.WriteLine("Press enter if you are ready.");
            Console.ReadLine();
            Console.Clear();


            while (!done)
            {
                Console.WriteLine("Head (H) or Tail (T)?");
                coinGuess = Console.ReadLine().ToLower();

                while (coinGuess != "head" && coinGuess != "h" && coinGuess != "(h)" && coinGuess != "heads" && coinGuess != "tail" && coinGuess != "t" && coinGuess != "tails" && coinGuess != "(t)" && coinGuess != "quit" && coinGuess != "q" && coinGuess != "end")
                {
                    if (points <= 0)
                    {
                        Console.WriteLine("You don't have enough points. GAME OVER");
                        done = true;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Error, you did not insert the head or tail, please try again.");
                    Console.WriteLine();
                    Console.WriteLine("Head (H) or Tail (T) or Quit (Q)");
                    coinGuess = Console.ReadLine().ToLower();
                }



                flip = Generator.Next(2);

                if (coinGuess == "quit" || coinGuess == "q")
                {
                    while (!validChoice)
                    {
                        Typer("You have earned " + points + " points.");
                        Typer("Are you sure you wish to quit the game? Yes (Y) or No (N)");
                        coinGuess = Console.ReadLine().ToLower();
                        if (coinGuess == "yes" || coinGuess == "y" || coinGuess == "(y)")
                        {
                            Typer("Thank you for playing. See you next time!");
                            validChoice = true;
                            done = true;
                        }
                        else if (coinGuess == "no" || coinGuess == "n" || coinGuess == "(no)")
                        {
                            validChoice = true;
                        }
                        else
                        {
                            Console.WriteLine("You did not answer properly, please try again");
                        }
                    }
                }
                else if (points <= 0)
                {
                    Console.WriteLine("You don't have enough points. GAME OVER");
                    done = true;
                }
                else if (flip == heads)
                {
                    Console.WriteLine("Heads was flipped");
                    DrawHeads();

                    if (coinGuess == "head" || coinGuess == "h" || coinGuess == "(h)" || coinGuess == "heads")
                    {
                        Console.WriteLine("You guess correctly! +1 point.");
                        points += 1;
                        Console.WriteLine("You have " + points + " points left.");
                    }
                    else if (coinGuess == "tail" || coinGuess == "t" || coinGuess == "tails" || coinGuess == "(t)")
                    {
                        Console.WriteLine("You guessed wrong! -1 point.");
                        points -= 1;
                        Console.WriteLine("You have " + points + " points left");
                    }
                }
                else if (flip == tails)
                {
                    Console.WriteLine("Tails was flipped");
                    DrawTails();

                    if (coinGuess == "tail" || coinGuess == "t" || coinGuess == "tails" || coinGuess == "(t)")
                    {
                        Console.WriteLine("You guessed correctly! +1 point");
                        points += 1;
                        Console.WriteLine("You have " + points + " points left");
                    }
                    else if (coinGuess == "head" || coinGuess == "h" || coinGuess == "(h)" || coinGuess == "heads")
                    {
                        Console.WriteLine("You guessed wrong! -1 point.");
                        points -= 1;
                        Console.WriteLine("You have " + points + " points left");
                    }
                }
              
            }
        }

        public static void DrawTails()
        {
            Console.WriteLine("  ,---.");
            Console.WriteLine(" ' __O>`");
            Console.WriteLine("( (__/  )");
            Console.WriteLine(" .-----,");
            Console.WriteLine("  `---'");
        }
      
        public static void DrawHeads()
        {
            Console.WriteLine("  ,---.");
            Console.WriteLine(" ' ^ ^ `");
            Console.WriteLine("(  0 0  )");
            Console.WriteLine(" . ___ ,");
            Console.WriteLine("  `---'");
        }

    }
}
