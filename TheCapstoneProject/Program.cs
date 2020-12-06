using System;

namespace TheCapstoneProject
// *************************************************************
// Application:     The Capstone Project
// Author:          Voss, Connor E.
// Description:     An application that allows the user to create a D&D character
//                  and assign them a backstory and traits
// Date Created:    11/20/2020
// Date Revised:    12/05/2020
// *************************************************************
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            string charRace;
            string charName;
            string charClass;
            string charStory;
            string strengthT;
            string dexterityT;
            string conT;
            string intelT;
            string wisdomT;
            string charismaT;
            int strength;
            int dexterity;
            int constitution;
            int intelligence;
            int wisdom;
            int charisma;

            //
            // Theme
            //
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(150, 40);
            Console.Clear();

            // ************************************  
            // *         Opening Screen           *
            // ************************************

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tDungeons & Dragons Character Creator");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("\tPress any key to continue");
            Console.ReadKey();

            // ****************************************
            // *            Instructions              *
            // ****************************************

            Console.Clear();
            Console.WriteLine("\t\tInstructions:");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("In this application, you will be able to create a basic character for use within the Dungeons & Dragons Universe.\n" +
                "You will be able to create a character and choose their Name, Race, Class, Backstory, and Statistics.");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Press any key to continue.");
            Console.ReadKey();

            // *****************************
            // *        User Race          * 
            // *****************************

            Console.Clear();
            Console.WriteLine("\t\tRace:");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("First, let's start with your character's race.  Since the world of D&D has so many races, and for the sake of my own sanity,\nonly a select few will be available for choosing in this application.");

            Console.WriteLine();
            Console.WriteLine("The races available to you are:");
            Console.WriteLine();
            Console.WriteLine("\t Human");                
            Console.WriteLine("\t Elf");
            Console.WriteLine("\t Dwarf");
            Console.WriteLine("\t Halfling");
            Console.WriteLine("\t Gnome");
            Console.WriteLine("\t Half-Elf");
            Console.WriteLine("\t Half-Orc");
            Console.WriteLine("\t Tiefling");

            Console.WriteLine();
            Console.Write("Once you have chosen a race, please type it in to the console.\n");
            charRace = Console.ReadLine();

            switch (charRace)
            {
                case "Human":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;

                case "Elf":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;

                case "Dwarf":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;

                case "Halfling":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;

                case "Gnome":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;

                case "Half-Elf":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;

                case "Half-Orc":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;

                case "Tiefling":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, let's give your {charRace.ToLower()} a proper name.");
                    Console.ReadKey();
                    break;
            }


            // ****************************
            // *        User Name         *
            // ****************************

            Console.Clear();
            Console.WriteLine("\t\tName");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Now it's time to give your {charRace.ToLower()} a proper name. ");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Please give your character a first and last name.\n");
            charName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Now it's time to give {charName} a proper class.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // ****************************
            // *        User Class        *
            // ****************************

            Console.Clear();
            Console.WriteLine("\t\tClass");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"This is where we'll give {charName} their class.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Your class will help to determine your statiistics for your character.  The classes available to your are: ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("\t Barbarian");
            Console.WriteLine("\t Bard");
            Console.WriteLine("\t Cleric");
            Console.WriteLine("\t Druid");
            Console.WriteLine("\t Fighter");
            Console.WriteLine("\t Monk");
            Console.WriteLine("\t Paladin");
            Console.WriteLine("\t Ranger");
            Console.WriteLine("\t Rogue");
            Console.WriteLine("\t Sorcerer");
            Console.WriteLine("\t Warlock");
            Console.WriteLine("\t Wizard");

            Console.WriteLine();
            Console.Write("Once you have chosen a class, please type it in to the console.\n");
            charClass = Console.ReadLine();

            switch (charClass)
            {
                case "Barbarian":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Bard":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Cleric":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Druid":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Fighter":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Monk":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Paladin":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Ranger":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Rogue":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Sorcerer":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Warlock":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;

                case "Wizard":
                    Console.WriteLine();
                    Console.WriteLine($"Alright, now let's give {charName} a backstory.");
                    Console.ReadKey();
                    break;
            }

            // ************************************
            // *          User Backstory          *
            // ************************************

            Console.Clear();
            Console.WriteLine("\t\tBackstory");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Now we're going to give {charName} a little bit of a backstory.  Make sure to not give too extensive of a backstory,\nbut just enough for you to form a stronger connection with your character.");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"Go ahead and give {charName} a short backstory below.  Once you're finished, please press 'Enter'\n");
            charStory = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // *********************************
            // *          User Stats           *
            // *********************************

            Console.Clear();
            Console.WriteLine("\t\tStatistics");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Finally, we're going to give {charName} their stats.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("First, let's set your strength.  This will measure your physical power.\nEnter what you would like your strength to be set at.\n");
            strengthT = Console.ReadLine();
            int.TryParse(strengthT, out strength);

            Console.WriteLine();
            Console.WriteLine("Next, let's enter your dexterity.  This will measure your agility.\nEnter what you would like your agility to be set at.\n");
            dexterityT = Console.ReadLine();
            int.TryParse(dexterityT, out dexterity);

            Console.WriteLine();
            Console.WriteLine("Next, let's enter your constitution.  This will measure your endurance.\nEnter what you would like your constitution to be.\n");
            conT = Console.ReadLine();
            int.TryParse(conT, out constitution);

            Console.WriteLine();
            Console.WriteLine("Next, let's enter your intelligence.  This will measure your reasoning and memory.\nEnter what you would like your intelligence to be.\n");
            intelT = Console.ReadLine();
            int.TryParse(intelT, out intelligence);

            Console.WriteLine();
            Console.WriteLine("Next, let's enter your wisdom.  This will measure your perception and insight.\nEnter what you would like your wisdom to be.\n");
            wisdomT = Console.ReadLine();
            int.TryParse(wisdomT, out wisdom);

            Console.WriteLine();
            Console.WriteLine("Finally, let's enter your charisma.  This will measure your force of personality.\nEnter what you would like your wisdom to be.\n");
            charismaT = Console.ReadLine();
            int.TryParse(charismaT, out charisma);

            // **************************************
            // *          Character Table           *
            // **************************************

            Console.Clear();
            Console.WriteLine("\t\tCharacter Table");
            Console.WriteLine();

            Console.WriteLine(
                "Name:".PadLeft(10) +
                "Race:".PadLeft(20) +
                "Class:".PadLeft(20)
                );

            Console.WriteLine();
            Console.WriteLine(
                $"{charName}".PadLeft(5) +
                $"{charRace}".PadLeft(13) +
                $"{charClass}".PadLeft(21)
                );

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(
                "Strength:".PadLeft(5) +
                $"{strength}".PadLeft(3) +
                " Dexterity:".PadLeft(15) +
                $"{dexterity}".PadLeft(3) +
                " Constitution:".PadLeft(15) +
                $"{constitution}".PadLeft(3)
                );

            Console.WriteLine();
            Console.WriteLine(
                "Intelligence:".PadLeft(5) +
                $"{intelligence}".PadLeft(3) +
                " Wisdom:".PadLeft(15) +
                $"{wisdom}".PadLeft(3) +
                " Charisma:".PadLeft(15) +
                $"{charisma}".PadLeft(3)
                );

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{charStory}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key once you're finished.");
            Console.ReadKey();

            // **************************************
            // *          Closing Screen            *
            // **************************************

            Console.Clear();
            Console.WriteLine("\t\tClosing Screen");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Thank you for using this application.  Once you're finished, press any key to exit.");
            Console.ReadKey();











        }
    }
}
