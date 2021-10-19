using System;

namespace csharp_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Initialize();

            while(true) {

            Random rnd = new Random();
            int answer = rnd.Next(1, 21);

            GiveResult(ConsoleColor.Yellow, "Guess a number 1 to 20...");

            int guess = 0;

            while(guess != answer){
                string input = Console.ReadLine();

                if(!int.TryParse(input, out guess)){
                    GiveResult(ConsoleColor.Red, "Not a number");
                    continue;
                }

                guess = Convert.ToInt32(input);

                int difference = Math.Abs(guess - answer);

                if(guess != answer){
                    if(difference > 10) {
                        GiveResult(ConsoleColor.Red, "More than 10 away");
                    }else if(difference > 5) {
                        GiveResult(ConsoleColor.Red, "More than 5 away");
                    } else{
                        GiveResult(ConsoleColor.Red, "Within 5 away");
                    }
                }
            }

            GiveResult(ConsoleColor.Green, "Correct Answer");

            GiveResult(ConsoleColor.Yellow, "Play again? y/n :");

            string replay = Console.ReadLine();
            
            if(replay.ToLower() == "y"){
                continue;
            }
            if(replay.ToLower() == "n"){
                return;
            }
            
        }

        }

        static void Initialize(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CS is running...");
            Console.ResetColor();
        }

        static void GiveResult(ConsoleColor color, string message){
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
