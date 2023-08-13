using System;

class Program
{
    static void Main(string[] args)
    {
        bool playing = true;
        Random randomGenerator = new Random();

        while (playing == true)
        {
            int magic_num = randomGenerator.Next(1,100);

            Console.WriteLine("");
            int guess = 0;
            int tries = 0;

            while (guess != magic_num)
            {
                Console.Write("What is your guess? ");
                string user_input = Console.ReadLine();
                guess = int.Parse(user_input);
                tries += 1;

                if(guess < magic_num)
                {
                    Console.WriteLine("Higher");
                }

                else if(guess > magic_num)
                {
                    Console.WriteLine("Lower");
                }

                else{
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {tries} tries to guess the number.");

                    Console.WriteLine("Play again? (Y or N)");
                    string answer = Console.ReadLine();

                    if (answer == "Y"){
                        continue;
                    }

                    else{
                        playing = false;
                    }

                }
            }
        }
        
        
    }
}