// Project # 8

// #1 the ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7]; 

// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c5";
            animalAge = "3";
            animalPhysicalDescription = "small gray tabby female with green eyes. very agile and loves to climb.";
            animalPersonalityDescription = "friendly and playful, loves to chase after laser pointers and nap in sunny spots.";
            animalNickname = "whiskers";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "rabbit";
            animalID = "r8";
            animalAge = "1";
            animalPhysicalDescription = "white with black spots. medium-sized, soft fur. very quick and loves hopping around.";
            animalPersonalityDescription = "curious and enjoys nibbling on fresh vegetables. tends to be shy but warms up with time.";
            animalNickname = "thumper";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }

    // Parse suggested donation before saving it into the array
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; 
    }

    // Store in the array, formatting the suggested donation as currency
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}"; 
}

// #5 display the top-level menu options
bool noMatchesDog = true;
string dogCharacteristic = ""; 

do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            if (noMatchesDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
            }
            break;

        case "2":
            while (dogCharacteristic == "")
            {
                Console.WriteLine($"\nEnter one desired dog characteristic to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                   dogCharacteristic = readResult.ToLower().Trim();
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");

string dogDescription = "";

// #6 loop through the ourAnimals array to search for matching animals
for (int i = 0; i < maxPets; i++)
{
    if (ourAnimals[i, 1].Contains("dog"))
    {
        // #7 Search combined descriptions and report results
        dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
        if (dogDescription.Contains(dogCharacteristic))
        {
            Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
            Console.WriteLine(dogDescription);

            noMatchesDog = false;
        }
    }
}
