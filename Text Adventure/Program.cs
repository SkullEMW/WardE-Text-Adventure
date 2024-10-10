using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Authentication;
using static System.Collections.Specialized.BitVector32;
using static Text_Adventure.Program;

namespace Text_Adventure
{
    internal class Program
    {
 
        static string gameOver;
        static string gameWin;
        static string gameFail;
        static string answer;
        static string question;
        static string DeathOne;
       
        static void VariableNames()
        {
            // Strings and what they are 
            DeathOne = "The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \r\n\r\nAs the night passed, infected had found your passed out body and you were consumed by magic. \r\nGAME OVER.";
            gameOver = "\r\nYou did not survive the night.";
            gameFail = "\r\nYou were infected during the night.";
            gameWin = "\r\nYou survived the night!";

        }
        static string PromptPlayer()
        {
            string answer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            answer = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            return answer;
        }

        static string Question()
        {
            string question;

            Console.ForegroundColor = ConsoleColor.Red;
            question = "\r\nWhat will you do?";
            Console.WriteLine(question);
            Console.ForegroundColor = ConsoleColor.Gray;

            return question;
        }
        static void ExpositionDump()
        {
            //INTRO ! 
            string Intro = "Dark clouds loomed over your head, threatening to rain on you. The cold fall wind blew aggressively as you shivered. \r\nIt wasn't long ago when the world seemingly ended. The Astral Plane reopened, magic poured in and chaos insued as people began to wither away.\r\n\nYou've seen your closest friends crazed by the weave. Animals once lively and happy now decayed. \r\nSometimes you think you can hear the forests cry out in pain as the magic entered their ecosystems. \r\n\nNights have become longer and more dangerous, so you knew you had to prepare as you watched the sun meet the horizon.";
            Console.WriteLine(Intro);
            Thread.Sleep(1000);
            Console.WriteLine();
        }

 

        // GAME START HERE 

        static void Main(string[] args)
        {
          ExpositionDump();
          runGame();

            static void runGame()
            {
                static void ChoiceOne()
                {
                    Question();
                    string Option1 = "A) Follow map towards a tavern, \r\nB) keep moving throughout the night, \r\nC) retrace your steps to locate a cabin in the woods";
                    Console.WriteLine(Option1);

                    string choice1 = PromptPlayer();

                    if (string.Compare(choice1, "Tavern", true) == 0)
                    {

                        if (string.Compare(choice1, "Tavern", true) == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("\r\nAs you get closer and closer to the tavern your body begins to numb. You recall where you've felt this before: Magic radiation.\r\nYou see the tavern in the distance, ripped up and coroded. Despite this you hear voices. You can't make out what they're saying, it seems that \r\nthey are speaking a different language.");
                            Thread.Sleep(1000);
                            Question();
                            Console.WriteLine("\r\nA)Solidify your choice and continue towards the tavern \r\nB)Skip the tavern and stay awake for the night");
                            string Choice2 = PromptPlayer();



                            if (string.Compare(Choice2, "Continue", true) == 0)
                            {
                                Console.WriteLine("The elderly elf scowled. \"Who?\" They echoed, exchanging glances between the other two. \r\n\r\nThe the halfing stepped forwards. \"You don't know about our savior? Those of the silver blood?\" The halfing's voice was so distorted and raspy, showcasing the damage magic has had on their body. Their faces were riddled with hurt and betrayal. \r\n\r\n\"You must learn...\" A taller teifling called. \"You have to learn...\" \r\n\r\nThey're infected. They favor magic as it has poisened their minds. Due to this they're trying to lure others into it. If you stay long enough, you may become infected as well. \r\n");
                                Thread.Sleep(1000);
                                Question();
                                Console.WriteLine("\r\nA) Draw your weapon \r\nB)Hear them out");

                                string choice = PromptPlayer(); Console.WriteLine("You cautiously (or not I don't control you) enter the tavern to be met with 3 sets of eyes. Shrieks could be heard the moment they saw you. Their bodies were decaying with a teal glow, you remember the day the Astral Plane reopened. \r\n\r\nMagic Infection. \r\n\r\n\"You there!\" An elderly elf called out, her hair falling apart as a side affect of the radiation. \"You seem... normal... Haven't you witnessed our savior?\" \r\n\r\n\"Praise our savior!\" The other two chanted, their skin cracked and torn with the same glow as the elderly elf. \r\n");
                                Thread.Sleep(1000);
                                Question();
                                Console.WriteLine("\r\nA) Who? \r\nB)No, I haven't seen your diety. \r\nC) Of course I have!");

                                string choice3 = PromptPlayer();

                                if (choice3 == "Who?")
                                {

                                }
                                else if (choice3 == "No")
                                {

                                }
                                else if (choice3 == "I have")
                                {

                                }
                                else
                                {
                                    Console.WriteLine("Please choose Who?, No, or I have.");

                                }
                            }

                            else if (Choice2 == "Skip")
                            {
                                Console.WriteLine(DeathOne);
                                Thread.Sleep(1000);
                                Console.WriteLine(gameOver);
                            }
                            else
                            {
                                Console.WriteLine("Please use Continue, or Skip");

                            }
                            }
                            else if (string.Compare(choice1, "Keep moving", true) == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("\r\nPerhaps it is safer if you didn't stop for the night. Who knows if you find anywhere safe to stay. If you stay awake, nothing will sneak up on you. This has to be the best thing to do, right? You follow your planned path even as the moon rises and the stars start to shine. The moon climbs higher and higher and your fatiuge only grows. Your eyes feel heavy, but you still push through. \r\n\r\n... \r\n\r\nYou yawn.\r\n\r\n...\r\n\r\nYou yawn again.\r\n\r\n...\r\n\r\nMaybe just a bit of shut eye won't hurt..? \r\n");
                                Thread.Sleep(1000);
                                Question();
                                Console.WriteLine("\r\nA) Keep moving anyways \r\nB)Quickly set up a camp just off the road");

                                string choice3 = PromptPlayer();

                                if (choice3 == "Continue Moving")
                                {
                                    Console.WriteLine(DeathOne);
                                    Thread.Sleep(1000);
                                    Console.WriteLine(gameOver);
                                }
                                else if (choice3 == "Set up camp")
                                {
                                    Console.WriteLine("You hastly set up a camp just off the road. You only set up the essentials: A fire for warmth, your sleeping bag, and you made sure to keep your weapons near for protection. It wasn't the prefered decision, but it would be a lot better than passing out along the road. You used the fire to warm up a can of food you had scavanged not too long ago and began settling in. ");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("\r\nThe crickets chirped and the owls hooted as the night continued. The ambiance was nice despite what has been going around. It's a good time to turn in. As you settle in you take a glance at the fire. It's a rather chilling night, it would be hard to sleep without the fire. However, the fire could draw unwanted attention.");
                                    Thread.Sleep(1000);

                                }
                                else
                                {
                                    Console.WriteLine("Please choose Continuing moving, or Set up camp.");

                                }
                            }
                            else if (string.Compare(choice1, "Cabin", true) == 0)
                            {
                                if (string.Compare(choice1, "Cabin", true) == 0)
                                {

                                    Console.WriteLine("\r\nThe forest you had passed earlier was rather eerie meaning most would likely stray away from it. If anything, you hoped that the forest would hide you from anything dangerous that could bring harm. The deeper into the forest, the darker it got. Eventually you reach the cabin. There's no lights or noise coming from inside.");

                                    Question();
                                    Console.WriteLine("\r\nA) Enter the cabin \r\nB)Check to see if anyone is inside \r\nC) Leave because of the weird vibes");

                                    string choice2 = PromptPlayer();

                                    if (choice2 == "Enter cabin")
                                    {

                                    }
                                    else if (choice2 == "Look inside")
                                    {

                                    }
                                    else if (choice2 == "Leave cabin")
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("Please choose Enter cabin, Look inside, or Leave cabin.");
                                     
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please choose Tavern, Keep moving, or Cabin.");
                                    ChoiceOne();
                                }



                            }

                        }
                    }
                }
            }
        }
    }
}









