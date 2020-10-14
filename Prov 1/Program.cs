using System;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            bool answerIsCorrect = false;
            bool tryGuess = false;
            int correctAnswer = 5;
            string guess;
            int guessInt;

            //Prints game instructions
            Console.WriteLine("Välkommen till sänka skepp.\nDetta spel går utt på att du ska hitta en koordinat som är någonstans mellan 1-10");

            //Loops as long as the answer is not correct
            while (!answerIsCorrect)
            {
                Console.Write("Gissa på en koordinat: ");
                guess = Console.ReadLine();

                tryGuess = int.TryParse(guess, out guessInt);

                if (tryGuess == true)
                {
                    if (guessInt <= 10)
                    {
                        if (guessInt >= 1)
                        {
                            if (guessInt == correctAnswer)
                            {
                                Console.WriteLine("Hit!");
                                answerIsCorrect = true;
                            }
                            else if (guessInt >= correctAnswer - 2 && guessInt <= correctAnswer + 2)
                            {
                                Console.WriteLine("Near Miss!");
                            }
                            else
                            {
                                Console.WriteLine("Miss!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Den där koordinaten är för liten. Skriv en koordinat mellan 1-10");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Den där koordinaten är för stor. Skriv en koordinat mellan 1-10");
                    }
                }
                else
                {
                    Console.WriteLine("Det där är inte en giltig koordinat. Använd ett tal istället");
                }
            }

            //Makes it so the terminal doesn't instantly close as soon as you win
            Console.Write("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
