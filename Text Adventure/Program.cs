using System.ComponentModel.DataAnnotations;

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

            string optionChoice1 = Console.ReadLine();
            if (optionChoice1 == "A")
            {
                Console.WriteLine("\r\nAs you get closer and closer to the tavern your body begins to numb. You recall where you've felt this before: Magic radiation.\r\nYou see the tavern in the distance, ripped up and coroded. Despite this you hear voices. You can't make out what they're saying, it seems that \r\nthey are speaking a different language.");
                Console.WriteLine("\r\nWhat will you do?");
                Console.WriteLine("\r\nA)Solidify your choice and continue towards the tavern \r\nB)Skip the tavern and stay awake for the night");

                string optionChoice2 = Console.ReadLine();
                if (optionChoice2 == "A")
                {
                    Console.WriteLine("You cautiously (or not I don't control you) enter the tavern to be met with 3 sets of eyes. Shrieks could be heard the moment they saw you. Their bodies were decaying with a teal glow, you remember the day the Astral Plane reopened. \r\n\r\nMagic Infection. \r\n\r\n\"You there!\" An elderly elf called out, her hair falling apart as a side affect of the radiation. \"You seem... normal... Haven't you witnessed our savior?\" \r\n\r\n\"Praise our savior!\" The other two chanted, their skin cracked and torn with the same glow as the elderly elf. \r\n");
                    Console.WriteLine("\r\nHow do you respond?");
                    Console.WriteLine("A) Who? \r\nB) No, I haven't seen your diety. In fact, I don't even know of your diety. \r\nC) Of course I have!");

                    string optionChoice3 = Console.ReadLine();
                    if (optionChoice3 == "A")
                    {
                        Console.WriteLine("The elderly elf scowled. \"Who?\" They echoed, exchanging glances between the other two. \r\n\r\nThe the halfing stepped forwards. \"You don't know about our savior? Those of the silver blood?\" The halfing's voice was so distorted and raspy, showcasing the damage magic has had on their body. Their faces were riddled with hurt and betrayal. \r\n\r\n\"You must learn...\" A taller teifling called. \"You have to learn...\" \r\n\r\nThey're infected. They favor magic as it has poisened their minds. Due to this they're trying to lure others into it. If you stay long enough, you may become infected as well.");
                        Console.WriteLine("What do you do?");
                        Console.WriteLine("A) Draw your weapon \r\nB)Hear them out");

                        string optionChoice4 = Console.ReadLine();
                        if (optionChoice4 == "A")
                        {
                            Console.WriteLine("You charged forward, swinging your sword frantically. The infected shriek as they dodge and weave. You skill in the sword is only decent enough to fend them off for a moment, but there is power in numbers. The elf grabs your dominate wrist and the others devour you. Magic pours into your system with a searing pain, however, it slowly dies as your conciousness fades. \r\n\r\nGAME OVER.");
                        }

                        else if (optionChoice4 == "B")
                        {
                            Console.WriteLine("The three gather around you talking about their diety, how magic will save the world. You don't believe it for a second, but the moment your facade of interest falls your life would most likely end. Before you know it, sunlight peers through the tavern windows. You look outside to see the orange skies as the sun rises, but when you turn back the three infected were gone. \r\n\r\nYou surived, but you might as well rest here for the day. After all, you didn't get any rest. \r\n\r\nYOU SURVIVED! ");
                        }
                        else if (optionChoice3 == "B")
                        {
                            Console.WriteLine("The three gather around you talking about their diety, how magic will save the world. You don't believe it for a second, but the moment your facade of interest falls your life would most likely end. Before you know it, sunlight peers through the tavern windows. You look outside to see the orange skies as the sun rises, but when you turn back the three infected were gone. \r\n\r\nYou surived, but you might as well rest here for the day. After all, you didn't get any rest. \r\n\r\nYOU SURVIVED! ");
                        }
                        else if (optionChoice3 == "C")
                        {
                            Console.WriteLine("They gave you quizical looks. Their eyes scanning you for any inconsistancy in your facial expression or body languge. \r\n\r\n\"What's our diety's name, Wise One?\" The tiefling growled with judgment. \r\n\r\nPanic settled in as you looked around the room. Silence filled the room as the others grew more and more impatient. They pushed and pressured you many times before you caved and admitted the truth. \r\n\r\n\"I lied,\" You confessed. \"I don't know your deity.\"\r\n\r\nAngered shirlls suffocated your thoughts and the crazed pounced. You struggled as best you could, but they soon devoured you. Magic pours into your system with a searing pain, however, it slowly dies as your conciousness fades. \r\n\r\nGAME OVER. ");
                        }
                        else if (optionChoice2 == "B")
                        {
                            Console.WriteLine(DeathOne);
                        }

                    }
                    else if (optionChoice1 == "B")
                    {
                        Console.WriteLine("\r\nPerhaps it is safer if you didn't stop for the night. Who knows if you find anywhere safe to stay. If you stay awake, nothing will sneak up on you. This has to be the best thing to do, right? You follow your planned path even as the moon rises and the stars start to shine. The moon climbs higher and higher and your fatiuge only grows. Your eyes feel heavy, but you still push through. \r\n\r\n... \r\n\r\nYou yawn.\r\n\r\n...\r\n\r\nYou yawn again.\r\n\r\n...\r\n\r\nMaybe just a bit of shut eye won't hurt..? \r\n");
                    }
                    else if (optionChoice1 == "C")
                    {
                        Console.WriteLine("\r\nThe forest you had passed earlier was rather eerie meaning most would likely stray away from it. If anything, you hoped that the forest would hide you from anything dangerous that could bring harm. The deeper into the forest, the darker it got. Eventually you reach the cabin. There's no lights or noise coming from inside. ");
                    }
                }
            }
        }
    }
}


