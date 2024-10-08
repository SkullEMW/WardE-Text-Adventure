using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Intro = "Dark clouds loomed over your head, threatening to rain on you. The cold fall wind blew aggressively as you shivered. \r\nIt wasn't long ago when the world seemingly ended. The Astral Plane reopened, magic poured in and chaos insued as people began to wither away.\r\nYou've seen your closest friends crazed by the weave. Animals once lively and happy now decayed. \r\nSometimes you think you can hear the forests cry out in pain as the magic entered their ecosystems. \r\nNights have become longer and more dangerous, so you knew you had to prepare as you watched the sun meet the horizon.";
            Console.WriteLine(Intro);
            string Question = "What will you do?";
            Console.WriteLine(Question);
            string Option1 = "A) Follow map towards a tavern, \r\nB) keep moving throughout the night, \r\nC) retrace your steps to locate a cabin in the woods";
            Console.WriteLine(Option1);
            string DeathOne = "The more you walk, the exhausion only increased. You settle with the idea of lying down for a moment. So that you did. You kneeled down, pat the ground and curled up. \r\n\r\nAs the night passed, infected had found your passed out body and you were consumed by magic. \r\nGAME OVER.";
            string answer = Convert.ToString(Console.ReadLine());
            string question = "\r\nWhat will you do?";
            string gameOver = "\r\nYou did not survive the night.";
            string gameFail = "\r\nYou were infected during the night.";
            string gameWin = "\r\nYou survived the night!";

            string optionChoice1 = answer;
            if (optionChoice1 == "A")
            {
                Console.Clear();
                Console.WriteLine("\r\nAs you get closer and closer to the tavern your body begins to numb. You recall where you've felt this before: Magic radiation.\r\nYou see the tavern in the distance, ripped up and coroded. Despite this you hear voices. You can't make out what they're saying, it seems that \r\nthey are speaking a different language.");
                Console.WriteLine(question);
                Console.WriteLine("\r\nA)Solidify your choice and continue towards the tavern \r\nB)Skip the tavern and stay awake for the night");

                string optionChoice2 = answer;
                if (optionChoice2 == "A")
                {
                    Console.Clear();
                    Console.WriteLine("You cautiously (or not I don't control you) enter the tavern to be met with 3 sets of eyes. Shrieks could be heard the moment they saw you. Their bodies were decaying with a teal glow, you remember the day the Astral Plane reopened. \r\n\r\nMagic Infection. \r\n\r\n\"You there!\" An elderly elf called out, her hair falling apart as a side affect of the radiation. \"You seem... normal... Haven't you witnessed our savior?\" \r\n\r\n\"Praise our savior!\" The other two chanted, their skin cracked and torn with the same glow as the elderly elf. \r\n");
                    Console.WriteLine("\r\nHow do you respond?");
                    Console.WriteLine("A) Who? \r\nB) No, I haven't seen your diety. In fact, I don't even know of your diety. \r\nC) Of course I have!");

                    string optionChoice3 = answer;
                    if (optionChoice3 == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("The elderly elf scowled. \"Who?\" They echoed, exchanging glances between the other two. \r\n\r\nThe the halfing stepped forwards. \"You don't know about our savior? Those of the silver blood?\" The halfing's voice was so distorted and raspy, showcasing the damage magic has had on their body. Their faces were riddled with hurt and betrayal. \r\n\r\n\"You must learn...\" A taller teifling called. \"You have to learn...\" \r\n\r\nThey're infected. They favor magic as it has poisened their minds. Due to this they're trying to lure others into it. If you stay long enough, you may become infected as well.");
                        Console.WriteLine(question);
                        Console.WriteLine("A) Draw your weapon \r\nB)Hear them out");

                        string optionChoice4 = answer;
                        if (optionChoice4 == "A")
                        {
                            Console.Clear();
                            Console.WriteLine("You charged forward, swinging your sword frantically. The infected shriek as they dodge and weave. You skill in the sword is only decent enough to fend them off for a moment, but there is power in numbers. The elf grabs your dominate wrist and the others devour you. Magic pours into your system with a searing pain, however, it slowly dies as your conciousness fades.");
                            Console.WriteLine(gameOver);
                        }

                        else if (optionChoice4 == "B")
                        {
                            Console.Clear();
                            Console.WriteLine("The three gather around you talking about their diety, how magic will save the world. You don't believe it for a second, but the moment your facade of interest falls your life would most likely end. Before you know it, sunlight peers through the tavern windows. You look outside to see the orange skies as the sun rises, but when you turn back the three infected were gone. \r\n\r\nYou surived, but you might as well rest here for the day. After all, you didn't get any rest.");
                            Console.WriteLine(gameWin);
                        }

                        else if (optionChoice3 == "C")
                        {
                            Console.Clear();
                            Console.WriteLine("They gave you quizical looks. Their eyes scanning you for any inconsistancy in your facial expression or body languge. \r\n\r\n\"What's our diety's name, Wise One?\" The tiefling growled with judgment. \r\n\r\nPanic settled in as you looked around the room. Silence filled the room as the others grew more and more impatient. They pushed and pressured you many times before you caved and admitted the truth. \r\n\r\n\"I lied,\" You confessed. \"I don't know your deity.\"\r\n\r\nAngered shirlls suffocated your thoughts and the crazed pounced. You struggled as best you could, but they soon devoured you. Magic pours into your system with a searing pain, however, it slowly dies as your conciousness fades.");
                            Console.WriteLine(gameOver);
                        }


                        else if (optionChoice2 == "B")
                        {
                            Console.Clear();
                            Console.WriteLine(DeathOne);
                            Console.WriteLine(gameOver); 
                        }
                    }


            else if (optionChoice1 == "B")
                    {
                      Console.Clear();
                      Console.WriteLine("\r\nPerhaps it is safer if you didn't stop for the night. Who knows if you find anywhere safe to stay. If you stay awake, nothing will sneak up on you. This has to be the best thing to do, right? You follow your planned path even as the moon rises and the stars start to shine. The moon climbs higher and higher and your fatiuge only grows. Your eyes feel heavy, but you still push through. \r\n\r\n... \r\n\r\nYou yawn.\r\n\r\n...\r\n\r\nYou yawn again.\r\n\r\n...\r\n\r\nMaybe just a bit of shut eye won't hurt..? \r\n");
                      Console.WriteLine(question);
                      Console.WriteLine("\r\nA) Keep moving anyways \r\nB)Quickly set up a camp just off the road"); 

                        string answerChoice7 = answer;
                        if (answerChoice7 == "A")
                        {
                            Console.Clear();
                            Console.WriteLine(DeathOne);
                            Console.WriteLine(gameOver);
                        }
                        else if (answerChoice7 == "B")
                        {
                            Console.Clear();
                            Console.WriteLine("You hastly set up a camp just off the road. You only set up the essentials: A fire for warmth, your sleeping bag, and you made sure to keep your weapons near for protection. It wasn't the prefered decision, but it would be a lot better than passing out along the road. You used the fire to warm up a can of food you had scavanged not too long ago and began settling in. ");
                            Console.WriteLine("\r\nThe crickets chirped and the owls hooted as the night continued. The ambiance was nice despite what has been going around. It's a good time to turn in. As you settle in you take a glance at the fire. It's a rather chilling night, it would be hard to sleep without the fire. However, the fire could draw unwanted attention.");
                            Console.WriteLine(question);
                            Console.WriteLine("\r\nA) Put out the fire \r\nB)Keep the fire going");

                            string answerChoice8 = answer;
                            if (answerChoice8 == "A")
                            {
                                Console.Clear();
                                Console.WriteLine("You shiver as the fire dies out, the embers fading away. You bury yourself into the sleeping bag, but it doesn't do much. The wind shook the trees and you'd look around paranoid. You can't shake the feeling your being watched. With the unending cold and the crippling paranoia, it takes you ages to fall asleep.");
                                Console.WriteLine("A sharp pain seers through your arm. Your eyes shot open to find a rather fresh wound in your arm. A teal glow illminates from your arm and your heart drops.");
                                Console.WriteLine(gameFail);
                            }
                            else if (answerChoice8 == "B")
                            {
                                Console.Clear();
                                Console.WriteLine("The fire crackles and pops as you add more wood to it. The warm was comforting especailly after walking in the cold all day. The wind shakes the trees and the critters around you sing out to the moon. ");
                                Console.WriteLine("\r\nIt's peaceful");
                                Console.WriteLine("\r\nYour heavy eyes close slowly as you're lulled to sleep.");
                                Console.WriteLine("\r\n\r\n\"Wake up.\" A stern, yet lighter voices calls. \"Come on. I said wake up.\" \r\n");
                                Console.WriteLine("Your eyes slowly flutter open to see a person with fluffy brown hair and goggles wearing a large trench coat with a wind breaker underneath. \"You shouldn't sleep in the open,\" They warned. They scanned you up and down. \"Infected?\" \r\n");
                                Console.WriteLine("\r\nYou shake your head.");
                                Console.WriteLine("\r\n\"Good,\" They nod in return. \"Name's Sloan Cameron. I got a group nearby. We call ourselves the Wayfinders Society... We got room if you want to join.");
                                Console.WriteLine(question);
                                Console.WriteLine("\r\nA) Take the offer and join their group \r\nB) Refuse the offer"); 
                            }
                        }
                    }
             else if (optionChoice1 == "C")
               {
                Console.Clear();
                Console.WriteLine("\r\nThe forest you had passed earlier was rather eerie meaning most would likely stray away from it. If anything, you hoped that the forest would hide you from anything dangerous that could bring harm. The deeper into the forest, the darker it got. Eventually you reach the cabin. There's no lights or noise coming from inside.");
                Console.WriteLine("\r\nWhat do you do?");
                Console.WriteLine("\r\nA) Enter the cabin \r\nB)Check to see if anyone is inside \r\nC) Leave because of the weird vibes");

                   string answerChoice5 = answer;
                      if (answerChoice5 == "A")
                        {
                          Console.Clear();
                          Console.WriteLine("");
                        }
                      else if (answerChoice5 == "B")
                        {
                          Console.Clear();
                          Console.WriteLine("You scour the broken building for a way to look in without being seen. In the back, you find a rather foggy window. You peer inside to see a figure lying on a scratched up sofa. You can't tell what they're doing, but you see a familiar teal glow coming off them. Magic infection. They're most likely crazed by the magic or are injured and need help. Of course, you couldn't tell with the angle you have.");
                          Console.WriteLine(question);
                          Console.WriteLine("\r\nA) Approach the figure to see if they need aid \r\bB) Leave them and attempt to find another place");
                            
                          string answerChoice6 = answer; 
                          if (answerChoice6 == "A")
                            {
                              Console.Clear();
                              Console.WriteLine();
                            }
                          else if (answerChoice6 == "B")
                            {
                              Console.Clear();
                              Console.WriteLine(DeathOne);
                              Console.WriteLine(gameOver);
                            }
                        }
                    }
                }
            }
        }
    }
}


