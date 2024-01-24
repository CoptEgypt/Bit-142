using System;
//Starting the program
namespace Major_CS_ASS_1_Dice_Game {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hi! Welcome to Geo's Dice Game. "); //Types the message
            Console.WriteLine("Let's Start");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");



            DiceGame game = new DiceGame();
            game.RunExercise();
        }
    }

    class DiceGame {

        public void RunExercise() {

            int counter = 0; // Counter for the amount of dice rolls.
            string answer;
            //Do while loop, to repeat the whole execution for the program.
            do {

                Random nums = new Random();

                int Dice1 = nums.Next(1, 7);// it's 1-7 because it goes all the way to 7 but stops at 6.
                int Dice2 = nums.Next(1, 7);

                Console.WriteLine("Dice 1: {0} ", Dice1);// creating dice 1
                Console.WriteLine("Dice 2: {0} ", Dice2);// creating dice 2

                Console.WriteLine("I got {0}, {1} ", Dice1, Dice2);
                counter++;


                if ((Dice1 + Dice2) % 2 == 0)// this is even because any even the remainder is 0
                    Console.WriteLine("Evens are better than odds ");

                else
                    Console.WriteLine("Odds are still cool. ");// any remainder other than 0 it's automatically an odd

                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine("*");

                Console.WriteLine("Do you want to play again? ");
                answer = Console.ReadLine();// what the user replies, after each roll of dice.
            } while (answer == "YES"); // this goes until the user types anything other than YES

            //Typing the end message for the program
            Console.WriteLine("The number of times the dice was thrown was: {0} ", counter);
            Console.WriteLine("Nice Game!");
            Console.WriteLine("Thanks for playing, Come play again soon. ");


        }


















    }






}

