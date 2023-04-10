using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics;


namespace Quiz.ConsoleApp
{
  class Program
  {
    static void Main(string[]args)
    {

        Console.WriteLine("Welcome to the number Quiz game!");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Hello, " + name + "!");
        bool plyAgain = true;
        while(plyAgain)
        {
            Stopwatch timer = new Stopwatch();

                string[] answer = new string[]{"Lyra", 
                            "Scorpius", 
                            "Gemini", 
                            "Canis Major", 
                            "Aries", 
                            "Virgo", 
                            "Cancer", 
                            "Leo", 
                            "Pisces", 
                            "Taurus"};

                const int timeLimit = 30;
                int points = 0;

                Console.WriteLine("1. The constellation is associated with the myth of the Greek musician and poet Orpheus.");
                Console.Write("answer :");
                timer.Start();
                string UserAnswer = Console.ReadLine();
                Console.WriteLine("");
                timer.Stop();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer  ==  answer[0])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");        
//second question
                Console.WriteLine("2. It represents the scorpion and is associated with the story of Orion in Greek mythology.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer1 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer1  ==  answer[1])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("3. It is located in the northern celestial hemisphere. Its name means “the twins” in Latin.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer2 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer2  ==  answer[2])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("4. Its name means “the greater dog” in Latin, and represents the bigger dog following Orion, the hunter in Greek mythology.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer3 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer3  ==  answer[3])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("5. It is usually associated with the story of the Golden Fleece in Greek mythology.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer4 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer4  ==  answer[4])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("6. Its is a constellation lies in the southern sky. Its name means “virgin” in Latin.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer5 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer5  ==  answer[5])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("7. Contains a number of famous deep sky objects, among them the open cluster Praesepe, also known as the Beehive Cluster");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer6 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer6  ==  answer[6])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("8. This constellation lies in the northern sky. It is one of the zodiac constellations and one of the largest constellations in the sky.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer7 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer7  ==  answer[7])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("9. I lies between Aries constellation to the east and Aquarius to the west.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer8 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer8  ==  answer[8])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("10. A large constellation in the northern sky. Its name means “bull” in Latin.");
                Console.Write("answer :");
                timer.Restart();
                string UserAnswer9 = Console.ReadLine();
                if(timer.Elapsed.TotalSeconds >= timeLimit)
                {
                    Console.WriteLine("You're out of time!!");
                }
                else if(UserAnswer9  ==  answer[9])
                {
                    points += 1;
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!!");
                }
                Console.WriteLine("");

                Console.WriteLine("Your Final points is " + points);
                Console.WriteLine("");
                if(points >= 7)
                {
                    Console.WriteLine("Congratulations you passed!!");
                }
                else
                {
                    Console.WriteLine("Sorry you failed!!:(");
                }
                Console.WriteLine("");
                Console.WriteLine("Do you want to play again? (Y/N)");
                string userInput = Console.ReadLine();
                if(!userInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    plyAgain = false;
                }
        }
        Console.WriteLine("Thank You for playing!!");


    }
  }  
}
