using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using System.Security.Authentication;
using System.Security.Cryptography;
using static System.Collections.Specialized.BitVector32;
using static Text_Adventure.Program;

namespace Text_Adventure
{
    internal class Game
    {

        private static string gameOver;
        private static string gameWin;
        private static string gameFail;
        private static string DeathOne;
        //public string[] inventory;

        static void VariableNames()
        {
            // Strings and what they are 
            DeathOne = "The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \r\n\r\nAs the night passed, infected had found your passed out body and you were consumed by magic.";
            gameOver = "\r\nYou did not survive the night.";
            gameFail = "\r\nYou were infected during the night.";
            gameWin = "\r\nYou survived the night!";

        }
        static void Restart()
        {
            Console.WriteLine("Would you like to restart?");
            string restart = Console.ReadLine();

            if (string.Compare(restart, "restart", true) == 0)
            {
                Console.Clear();
                RunGame();
            }
            else if (string.Compare(restart, "quit", true) == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter restart in order to start over or quit to exit the game.");
            }
        }
        static string PromptPlayer()
        {
            // Response code so that it's clear what is the response to the questions.
            string answer;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            answer = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            return answer;
        }

        static string Question()
        {
            // Makes the quesiton more visable to seperate the question and the script of the story.
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
            WriteByLetter(Intro);
            Thread.Sleep(1000);
            Console.WriteLine();
        }

        static void WriteByLetter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(20);
            }
        }

        // enum ChoiceType
        //  {
        //   A,
        //   B,
        //   C
        //  }

        // struct PlayerData
        // {
        //  health = 10,
        //  mana 5,
        //  isAlive = true,
        //  name = VeryCoolName,
        //  whenCreated = DeltaTime.Now,
        //  lastEdited = DeltaTime.Now
        // }

        // static void MakeChoice(int index, parabs info.inventory[] items)
        // {
        //  for (int i = 0; i < items.length, ++i)
        //   {
        //     WriteByLetter(items[i].ToString().ToUpper(), 0);

        //     if (i < item.length - 1)
        //      WriteByLetter(" | " 
        //   }
        // }





        /// GAME START HERE 


        static void Main(string[] args)
        {
            // info.inventory = new string[] { "Bread", "Cheese", "Artwork", "Overwatch"};
           
            // info. inventory[0] = "Lolipop" -- changes the string in the array to the new string starting at 0. 

           // int playerHealth = 10;
           // float playerMana = 5.5f;
           // bool isPlayerAlive = true;
           // string playerName = "A very cool name";
           // DateTime playerLastEdited;

           // PlayerData player1 = new()
           //  {
           //    health = 10,
           //    mana = 5.5f;
           //    isAlive = true
           //    name = "veryCoolName"
           //    lastEdited = DateTimeNow;
           //  }
            
           // Console.WriteLine(player1) 

           // Repeat code but change player1 --> player2 for a new set 

            RunGame();
            Restart();
        }

        //TAVERN BRANCH
        static void Tavern()
        {
            // Tavern pathway 
            Console.WriteLine();
            WriteByLetter("\r\nAs you get closer and closer to the tavern your body begins to numb. You recall where you've felt this before: Magic radiation.\r\nYou see the tavern in the distance, ripped up and coroded. Despite this you hear voices. You can't make out what they're saying, it seems that \r\nthey are speaking a different language.");
            Thread.Sleep(1000);
            Question();
            WriteByLetter("\r\nA)Solidify your choice and continue towards the tavern \r\nB) Skip the tavern and stay awake for the night");
            string Choice2 = PromptPlayer();



            if (string.Compare(Choice2, "A", true) == 0)
            {
                Console.WriteLine();
                WriteByLetter("You cautiously (or not I don't control you) enter the tavern to be met with 3 sets of eyes. Shrieks could be heard the moment they saw you. Their bodies were decaying with a teal glow, you remember the day the Astral Plane reopened. \r\n\r\nMagic Infection. \r\n\r\n\"You there!\" An elderly elf called out, her hair falling apart as a side affect of the radiation. \"You seem... normal... Haven't you witnessed our savior?\" \r\n\r\n\"Praise our savior!\" The other two chanted, their skin cracked and torn with the same glow as the elderly elf. \r\n");
                Thread.Sleep(1000);
                Question();
                WriteByLetter("\r\nA) Who? \r\nB)No, I haven't seen your diety. \r\nC) Of course I have!");

                string choice3 = PromptPlayer();
                if (string.Compare(choice3, "A", true) == 0)
                {
                    Console.WriteLine();
                    WriteByLetter("The elderly elf scowled. \"Who?\" They echoed, exchanging glances between the other two. \r\n\r\nThe the halfing stepped forwards. \"You don't know about our savior? Those of the silver blood?\" The halfing's voice was so distorted and raspy, showcasing the damage magic has had on their body. Their faces were riddled with hurt and betrayal. \r\n\r\n\"You must learn...\" A taller teifling called. \"You have to learn...\" \r\n\r\nThey're infected. They favor magic as it has poisened their minds. Due to this they're trying to lure others into it. If you stay long enough, you may become infected as well. ");
                    Thread.Sleep(1000);
                    Question();
                    WriteByLetter("\r\nA) Draw your weapon, \r\nB)Hear them out");

                    string choice4 = PromptPlayer();
                    if (string.Compare(choice4, "A", true) == 0)
                    {
                        Console.WriteLine();
                        WriteByLetter("You charged forward, swinging your sword frantically. The infected shriek as they dodge and weave. You skill in the sword is only decent enough to fend them off for a moment, but there is power in numbers. The elf grabs your dominate wrist and the others devour you. Magic pours into your system with a searing pain, however, it slowly dies as your conciousness fades. ");
                        Thread.Sleep(1000);
                        Console.Write(gameOver);
                        Restart();
                    }
                    if (string.Compare(choice4, "B", true) == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The three gather around you talking about their diety, how magic will save the world. You don't believe it for a second, but the moment your facade of interest falls your life would most likely end. Before you know it, sunlight peers through the tavern windows. You look outside to see the orange skies as the sun rises, but when you turn back the three infected were gone. \r\n\r\nYou surived, but you might as well rest here for the day. After all, you didn't get any rest.");
                        Thread.Sleep(1000);
                        Console.WriteLine(gameWin);
                        Restart();
                    }
                }
                else if (string.Compare(choice3, "B", true) == 0)
                {
                    Console.WriteLine();
                    WriteByLetter("The three gather around you talking about their diety, how magic will save the world. You don't believe it for a second, but the moment your facade of interest falls your life would most likely end. Before you know it, sunlight peers through the tavern windows. You look outside to see the orange skies as the sun rises, but when you turn back the three infected were gone. \r\n\r\nYou surived, but you might as well rest here for the day. After all, you didn't get any rest.");
                    Thread.Sleep(1000);
                    Console.Write(gameWin);
                    Restart();
                }
                else if (string.Compare(choice3, "C", true) == 0)
                {
                    Console.WriteLine();
                    WriteByLetter("They gave you quizical looks. Their eyes scanning you for any inconsistancy in your facial expression or body languge. \r\n\r\n\"What's our diety's name, Wise One?\" The tiefling growled with judgment. \r\n\r\nPanic settled in as you looked around the room. Silence filled the room as the others grew more and more impatient. They pushed and pressured you many times before you caved and admitted the truth. \r\n\r\n\"I lied,\" You confessed. \"I don't know your deity.\"\r\n\r\nAngered shirlls suffocated your thoughts and the crazed pounced. You struggled as best you could, but they soon devoured you. Magic pours into your system with a searing pain, however, it slowly dies as your conciousness fades. \r\n");
                    Thread.Sleep(1000);
                    Console.Write(gameOver);
                    Restart();
                }
                else
                {
                    WriteByLetter("Please choose Who, No, or I have.");

                }
            }

            else if (string.Compare(Choice2, "B", true) == 0)
            {
                Console.WriteLine();

                WriteByLetter("The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \r\n\r\nAs the night passed, infected had found your passed out body and you were consumed by magic.");

                Console.WriteLine();

                Thread.Sleep(1000);

                Console.WriteLine();

                Console.Write("You didn't survive the night.");

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please use Continue, or Skip");
                Tavern();
            }
        }

        //KEEP MOVING BRANCH
        static void KeepMoving()
        {
            // Keep Moving Branch -- 
            Console.WriteLine();
            WriteByLetter("\r\nPerhaps it is safer if you didn't stop for the night. Who knows if you find anywhere safe to stay. If you stay awake, nothing will sneak up on you. This has to be the best thing to do, right? You follow your planned path even as the moon rises and the stars start to shine. The moon climbs higher and higher and your fatiuge only grows. Your eyes feel heavy, but you still push through. \r\n\r\n... \r\n\r\nYou yawn.\r\n\r\n...\r\n\r\nYou yawn again.\r\n\r\n...\r\n\r\nMaybe just a bit of shut eye won't hurt..? \r\n");
            Thread.Sleep(1000);
            Question();
            Console.WriteLine("\r\nA) Keep moving anyways \r\nB)Quickly set up a camp just off the road");

            string choice3 = PromptPlayer();

            if (string.Compare(choice3, "A", true) == 0)
            {
                Console.WriteLine();
                WriteByLetter("\"The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \\r\\n\\r\\nAs the night passed, infected had found your passed out body and you were consumed by magic.");

                Console.WriteLine();

                Thread.Sleep(1000);

                Console.WriteLine();

                Console.Write("You didn't survive the night.");

                Console.WriteLine();

                Restart();

            }
            else if (string.Compare(choice3, "B", true) == 0) 
            {
                Console.WriteLine();
                WriteByLetter("You hastly set up a camp just off the road. You only set up the essentials: A fire for warmth, your sleeping bag, and you made sure to keep your weapons near for protection. It wasn't the prefered decision, but it would be a lot better than passing out along the road. You used the fire to warm up a can of food you had scavanged not too long ago and began settling in. ");
                Thread.Sleep(1000);
                Console.WriteLine();
                WriteByLetter("\r\nThe crickets chirped and the owls hooted as the night continued. The ambiance was nice despite what has been going around. It's a good time to turn in. As you settle in you take a glance at the fire. It's a rather chilling night, it would be hard to sleep without the fire. However, the fire could draw unwanted attention.");
                Thread.Sleep(1000);
                Console.WriteLine();

                Question();
                WriteByLetter("\r\nA) Put out the fire \r\nB)Keep the fire going");

                string choice5 = PromptPlayer();

                if (string.Compare(choice5, "A", true) == 0) // Death
                {
                    Console.WriteLine();
                    WriteByLetter("You shiver as the fire dies out, the embers fading away. You bury yourself into the sleeping bag, but it doesn't do much. The wind shook the trees and you'd look around paranoid. You can't shake the feeling your being watched. With the unending cold and the crippling paranoia, it takes you ages to fall asleep. \r\n\r\nA sharp pain seers through your arm. Your eyes shot open to find a rather fresh wound in your arm. A teal glow illminates from your arm and your heart drops. \r\n");
                    Thread.Sleep(1000);
                    Console.Write(gameFail);
                    Restart();
                }
                else if (string.Compare(choice5, "B", true) == 0) // Sloan Cameron introduction path 
                {
                    Console.WriteLine();
                    WriteByLetter("The fire crackles and pops as you add more wood to it. The warm was comforting especailly after walking in the cold all day. The wind shakes the trees and the critters around you sing out to the moon. ");
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    WriteByLetter("It's peaceful.");
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    WriteByLetter("Your heavy eyes slowly close as you're lulled to sleep.");
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    WriteByLetter("\"Wake up.\" A stern, yet lighter voices calls. \"Come on. I said wake up.\" ");
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    WriteByLetter("Your eyes slowly flutter open to see a person with fluffy brown hair and goggles wearing a large trench coat with a wind breaker underneath. \"You shouldn't sleep in the open,\" They warned. They scanned you up and down. \"Infected?\" \r\n");
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    WriteByLetter("You shake your head.\r\n\r\n\"Good,\" They nod in return. \"Name's Sloan Cameron. I got a group nearby. We call ourselves the Wayfinders Society... We got room if you want to join.\" \r\n");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    
                    Question();
                    WriteByLetter("\r\nA) Take the offer \r\nB) Refuse the offer ");

                    string choice6 = PromptPlayer();

                    // Take offer branch (AKA THE VENTURE OVERWATCH BRANCH)
                    if (string.Compare(choice6, "A", true) == 0) // Win
                    {
                        Console.WriteLine();
                        WriteByLetter("Sloan smiled brightly, despite the darker look they had earlier. They helped you pack up the camp you made last second. The described their group excitedly, stopping themselves to get talk about something off topic every other sentence. ");
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        WriteByLetter("Soon after, they lead you into the forest and you two walked for ages. The deeper and deeper you got, the less you trusted this rambunctious fella. They kept promising that the camp was nearby over and over. You thought about running off the second they got distracted again. ");
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        WriteByLetter("Finally Sloan loudly announced that you had made it. They introduced you to the other members who kindly welcomed you. ");
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        Console.Write(gameWin);
                        Console.WriteLine();
                    }
                    // Refuse offer branch 
                    else if (string.Compare(choice6, "B", true) == 0) // Win
                    {
                        Console.WriteLine();
                        WriteByLetter("Sloan nods understandly, you guys are strangers after all. The stranger leaves you as you are and disapears into the forest. The surprise interaction distracted you from the world around you. The sun barely pierced the canopy overhead, so it was understandable you didn't realize it was day. \r\n");
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        WriteByLetter("You pack up the messy camp you made at the last second. Taking a sip of water and popping a can of fruit open, you snacked on it as you took inventory, \r\n");
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        WriteByLetter("The new world is harsh, you can't trust anyone or anything. You don't even know if it will return to the busling life it once was. You sighed, putting everything else away as slinging on your bag, walking out of the forest and continuing you journey to survive. ");
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        Console.Write(gameWin);
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                    else
                    {
                        WriteByLetter("Please choice Take offer, or Refuse offer.");
                    }




                }
            }
            else
            {
                WriteByLetter("Please choose Continue Moving, or Set up camp.");
                KeepMoving();
            }
        }

        //CABIN BRANCH
        static void Cabin()
        {
            // Cabin Branch -- 

            Console.WriteLine();
            WriteByLetter("\r\nThe forest you had passed earlier was rather eerie meaning most would likely stray away from it. If anything, you hoped that the forest would hide you from anything dangerous that could bring harm. The deeper into the forest, the darker it got. Eventually you reach the cabin. There's no lights or noise coming from inside.");

            Question();
            WriteByLetter("\r\nA) Enter the cabin \r\nB)Check to see if anyone is inside \r\nC) Leave because of the weird vibes");
           
            string choice2 = PromptPlayer();

            if (string.Compare(choice2, "A", true) == 0)
            {
                CabinTwo();

            }
            else if (string.Compare(choice2, "B", true) == 0)
            {
                Console.WriteLine();
                WriteByLetter("You scower the broken building for a way to look in without being seen. In the back you find a rather foggy window. You peer inside to see a figure lying on a stratched up sofa. You can't tell what they're doing, but you see a familar teal glow coming off of the. Magic infection. They're most likely crazed by the magic or are injured and need help. Of course, you couldn't tell with the angle you have. ");
                Thread.Sleep(1000);
                Question();
                Thread.Sleep(1000);
                WriteByLetter("\r\nA) Enter the cabin see what's wrong \r\nB) Avoid the person and leave the cabin");

                string choice6 = PromptPlayer();

                if (string.Compare(choice6, "A", true) == 0)
                {
                    CabinTwo();
                }
                else if (string.Compare(choice6, "B", true) == 0)
                {
                    Console.WriteLine();
                    WriteByLetter("\"The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \\r\\n\\r\\nAs the night passed, infected had found your passed out body and you were consumed by magic.");

                    Console.WriteLine();

                    Thread.Sleep(1000);

                    Console.WriteLine();

                    Console.Write("You didn't survive the night.");

                    Console.WriteLine();
                }
                else
                {
                    WriteByLetter("Please choose Enter cabin, or Leave cabin.");
                }

            }
            else if (string.Compare(choice2, "C", true) == 0)
            {
                Console.WriteLine();
                WriteByLetter("\"The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \\r\\n\\r\\nAs the night passed, infected had found your passed out body and you were consumed by magic.");

                Console.WriteLine();

                Thread.Sleep(1000);

                Console.WriteLine();

                Console.Write("You didn't survive the night.");

                Console.WriteLine();
            }
            else
            {
                WriteByLetter("Please choose Enter cabin, Look inside, or Leave cabin.");
                CabinTwo();
            }

            static void CabinTwo()
            {
                string EnterCabin = "You slowly push the door open, making sure to be quiet. You hear harsh coughing echo throught the cabin. Your heart stops as you hear a heavy voice call out. \r\n\r\n\"It hurts...\" They groan. Their voice is gritty and scratching, you could easy hear the difficulty to speak. They groaned out again. \"It hurts..!\" \r\n\r\nYou stand still for a moment. What were you suppose to do in this situation? You prayed that they didn't know you were there. \r\n\r\n\"Traveler...\" They huffed. \"Help me...\" ";

                WriteByLetter(EnterCabin);
                Thread.Sleep(1000);
                Question();
                Thread.Sleep(1000);
                WriteByLetter("\r\nA) Leave and don't interact with the figure \r\nB) Talk to the figure");

                string choice7 = PromptPlayer();

                if (string.Compare(choice7, "B", true) == 0)
                {
                    Console.WriteLine();
                    WriteByLetter("\"How do I help?\" You ask, slowly walking up to the couch, however, as you got closer your body buzzed and felt numb. You know what's going on instantly: Magic radiation. However, it seemed that this person was trying to resist the craving of magic... The way they called out was rather heartbreaking, but also determined. \r\n");
                    Thread.Sleep(1000);
                    WriteByLetter("\r\n\"I don't want to... give into the infection...\" Their raspy voice hid the fact that this person what rather young. In fact, they seem like around the late teens. \"I don't want to lose my mind over that.\" \r\n");
                    Thread.Sleep(1000); 
                    WriteByLetter("\r\nTheir breathing was short and choppy. Their body had already sustained major damage from the exposure of magic. Their arms nearly showed bone and their cheeks had holes in them. \"It hurts...\" They cried once more. \r\n");
                    Thread.Sleep(1000);
                    Question();
                    Thread.Sleep(1000);
                    WriteByLetter("\r\nA) Attempt to aid them \r\nB) Leave them there and exit the cabin");

                    string choice8 = PromptPlayer();

                    if (string.Compare(choice8, "A", true) == 0)
                    {
                        Console.WriteLine();
                        WriteByLetter("Medicine check! Roll for your skill check.");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("> ");


                        Random rng = new Random();
                        int Medicine = rng.Next(0, 21);
                        string myString = Medicine.ToString();

                        Console.ReadKey(true);
                        Console.WriteLine();
                        WriteByLetter("You rolled a " + Medicine + " for your medicine check.");

                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.ReadKey(true);
                        Thread.Sleep(1000);
                        Console.WriteLine();

                        if (Medicine <= 12) // Roll Fail
                        {
                            Console.WriteLine();
                            WriteByLetter("You looked around the room for any medical supplies, but of course this place has been ransacked. There's not even a can expired food. You sigh as you glance at the boy who lied on the couch curled up in a ball. Your heart sinks as you realize you can't do anything. ");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            WriteByLetter("The boy shivers and winces at the pain, yet you can't do anything to help him.");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Question();
                            Thread.Sleep(1000);
                            WriteByLetter("\r\nA) Leave the boy to rest in piece and leave the cabin. \r\nB)Take care of the boy");

                            string choice9 = PromptPlayer();

                            if (string.Compare(choice9, "A", true) == 0)
                            {
                                Console.WriteLine();
                                WriteByLetter("\"The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \\r\\n\\r\\nAs the night passed, infected had found your passed out body and you were consumed by magic.");
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.WriteLine();

                                Console.Write("You didn't survive the night.");
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Restart();
                            }
                            else if (string.Compare(choice9, "B", true) == 0) // Win
                            {
                                Console.WriteLine();
                                WriteByLetter("\"May I watch over you for now..?\" You ask. \r\n");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                WriteByLetter("They take a moment before responding with a weak, \"Yes, please.\"");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                WriteByLetter("You smiled, and begin settling in. You start a fire in the fireplace to keep the cabin warm. You boil some soup for you and the boy. \r\n\r\n\"What's your name?\" You ask them.\r\n");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                WriteByLetter("\"Cassidy,\" They replied, grateful for the food. Despite their injuries, the food made them seem a lot more lively. \r\n\r\nAfter the meal, the two of you rest for the night. \r\n");
                                Thread.Sleep(1000);

                                Console.Write(gameWin);
                                Restart();
                            }

                        }
                        else if (Medicine >= 13) // Roll Pass -- Win
                            {
                            Console.WriteLine();
                            WriteByLetter("You tore a curtain down from the window and used it to carefully wrap up their arms. The gentle touch wasn't enough as the brittle boy's skin crumbled at the touch. You pushed through anyways sucessfully wrapping their arms up. \r\n");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine();

                            WriteByLetter("\"May I watch over you for now..?\" You ask. \r\n");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            WriteByLetter("They take a moment before responding with a weak, \"Yes, please.\"");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            WriteByLetter("You smiled, and begin settling in. You start a fire in the fireplace to keep the cabin warm. You boil some soup for you and the boy. \r\n\r\n\"What's your name?\" You ask them.\r\n");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            WriteByLetter("\"Cassidy,\" They replied, grateful for the food. Despite their injuries, the food made them seem a lot more lively. \r\n\r\nAfter the meal, the two of you rest for the night. \r\n");
                            Thread.Sleep(1000);

                            Console.Write(gameWin);
                            Restart(); 
                        }


                    }
                    else if (string.Compare(choice8, "B", true) == 0)
                    {
                        Console.WriteLine();
                        WriteByLetter("\"The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \\r\\n\\r\\nAs the night passed, infected had found your passed out body and you were consumed by magic.");

                        Console.WriteLine();

                        Thread.Sleep(1000);

                        Console.WriteLine();

                        Console.Write("You didn't survive the night.");

                        Console.WriteLine();
                    }
                    else
                    {
                        WriteByLetter("Please choose Aid, or Leave Cabin");
                        CabinTwo(); 
                    }
                }
            }
        }

        //GAME RUN
        static void RunGame()       
        {
            ExpositionDump();
            Question();
            string Option1 = "A) Follow map towards a tavern, \r\nB) keep moving throughout the night, \r\nC) retrace your steps to locate a cabin in the woods";
            WriteByLetter(Option1);

            // ChoiceType choiceType = ChoiceType.choice1  -- Enum practice

            string choice1 = PromptPlayer();
            if (string.Compare(choice1, "A", true) == 0) // if (choiceType == ChoiceType.A)
            {
                Tavern();
            }
            else if (string.Compare(choice1, "B", true) == 0) // else if (choiceType == ChoiceType.B)
            {
                KeepMoving();
            }
            else if (string.Compare(choice1, "C", true) == 0)  // else if (choiceType == ChoiceType.B)
            {
                Cabin();
            }


            else
            {
                Console.WriteLine("Please choose Tavern, Keep moving, or Cabin.");
                RunGame();
            }

            // switch (ChoiceType)
            //  {

            // case ChoiceType.A:
            // Tavern()
            //     break;

            //   case ChoiceType.B:
            //   KeepMoving();
            //     break;

            //   case ChoiceType.C:
            //   Cabin();
            //     break;
            //  } 

        }
    }
}
          