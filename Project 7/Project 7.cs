// Project # 7

using System;
using System.Collections.Generic;

public class Animal
{
    public string PetId { get; set; }
    public string PetNickname { get; set; }
    public string PetPersonalityDescription { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> ourAnimals = new List<Animal>
        {
            new Animal { PetId = "c4", PetNickname = "", PetPersonalityDescription = "" },
            new Animal { PetId = "default", PetNickname = "Fluffy", PetPersonalityDescription = "Loves to play" },
            new Animal { PetId = "b7", PetNickname = "", PetPersonalityDescription = "" },
            new Animal { PetId = "a1", PetNickname = "Buddy", PetPersonalityDescription = "" }
        };

        ValidatePetsData(ourAnimals);
    }

    static void ValidatePetsData(List<Animal> ourAnimals)
    {
        bool allDataComplete = true;

        foreach (var pet in ourAnimals)
        {
            if (pet.PetId == "default")
            {
                continue;
            }

            if (string.IsNullOrEmpty(pet.PetNickname))
            {
                Console.WriteLine($"Enter a nickname for ID #: {pet.PetId}");
                while (string.IsNullOrEmpty(pet.PetNickname))
                {
                    pet.PetNickname = Console.ReadLine();
                    if (string.IsNullOrEmpty(pet.PetNickname))
                    {
                        Console.WriteLine("Nickname cannot be empty. Please enter a valid nickname.");
                    }
                }
            }

            if (string.IsNullOrEmpty(pet.PetPersonalityDescription))
            {
                Console.WriteLine($"Enter a personality description for ID #: {pet.PetId} (likes or dislikes, tricks, energy level)");
                while (string.IsNullOrEmpty(pet.PetPersonalityDescription))
                {
                    pet.PetPersonalityDescription = Console.ReadLine();
                    if (string.IsNullOrEmpty(pet.PetPersonalityDescription))
                    {
                        Console.WriteLine("Personality description cannot be empty. Please enter a valid description.");
                    }
                }
            }
        }

        foreach (var pet in ourAnimals)
        {
            if (string.IsNullOrEmpty(pet.PetNickname) || string.IsNullOrEmpty(pet.PetPersonalityDescription))
            {
                allDataComplete = false;
                break;
            }
        }

        if (allDataComplete)
        {
            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
