using System;
using System.Reflection;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var birdOne = new Bird();
            birdOne.Name = "Hummingbird";
            birdOne.Diet = "omnivore";
            birdOne.IsNocturnal = false;
            birdOne.NumLimbs = 4;
            birdOne.Wingspan = 5;
            birdOne.FeatherColor = "blue";
            birdOne.BeakType = "narrow";
            birdOne.IsFlightless = false;
            var articleName = vowelStart(birdOne.Name);
            var articleDiet = vowelStart(birdOne.Diet);

            Console.WriteLine($"The {birdOne.Name} is an interesting bird. While it may be surprising given their {birdOne.BeakType} beak,\n" +
                $"{articleName} {birdOne.Name} is actually {articleDiet} {birdOne.Diet}!\n" +
                $"Did you know that wings count as limbs? This means that birds have {birdOne.NumLimbs} just like humans!\n" +
                $"With a wingspan of only about {birdOne.Wingspan} inches, {articleName} {birdOne.Name} is quite small!\n" +
                $"And since it {isIsNot(birdOne.IsFlightless)} flightless, it uses quite a lot of energy.\n" +
                $"And while it does sleep a lot, it {isIsNot(birdOne.IsNocturnal)} nocturnal.\n" +
                $"Though it can be many different colors, one of the most common feather colors is {birdOne.FeatherColor}.\n\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var reptileOne = new Reptile();
            reptileOne.Name = "Snake";
            reptileOne.Diet = "carnivore";
            reptileOne.IsNocturnal = false;
            reptileOne.NumLimbs = 0;
            reptileOne.IsVenomous = true;
            reptileOne.IsPoisonous = false;
            reptileOne.ScalePattern = "diamond";
            reptileOne.IsAquatic = true;
            articleName = vowelStart(reptileOne.Name);
            articleDiet = vowelStart(reptileOne.Diet);

            Console.WriteLine($"One of the most interest and most feared animals in the animal kingdom is the {reptileOne.Name}\n" +
                $"An effective predator, despite its {reptileOne.NumLimbs} limbs, a {reptileOne.Name} is {articleDiet} {reptileOne.Diet}.\n" +
                $"Look out for the {reptileOne.ScalePattern} pattern! This could mean it {isIsNot(reptileOne.IsVenomous)} venomous!\n" +
                $"Depending on its diet, {articleName} {reptileOne.Name} may also be poisonous, but it generally {isIsNot(reptileOne.IsPoisonous)}.\n" +
                $"Without a common sleeping schedule, {articleName} {reptileOne.Name} {isIsNot(reptileOne.IsNocturnal)} considered nocturnal.\n" +
                $"And while most people don't imagine {reptileOne.Name}s in the water, it {isIsNot(reptileOne.IsAquatic)} possible.");

        }

        static string isIsNot (bool whatIs)
        {
            if (whatIs)
            {
                return "is";
            }
            else
            {
                return "is not";
            }
        }
        static string vowelStart(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for(int i = 0; i < vowels.Length; i++)
            {
                if (word[0]  == vowels[i])
                {
                    return "an";
                }
            }
            return "a";
        }
    }
}
