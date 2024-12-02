
Random random = new Random();
int coin = random.Next(0,10);

Console.WriteLine($"{( coin > 5 ? "head" : "tails" )}");


string permission = "Admin|Manager";
int level = 56;


Console.WriteLine(  (permission.Contains("Admin") )? ( ( level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user. " ) : (permission.Contains("Manager")) ? ( level > 20 ) ? "Contact an Admin for access." : "You do not have sufficient privileges.": "You do not have sufficient privileges.");


/* CODE BLOCKS AND SCOPE  */


bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");

bool flag = true;
int value=0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");


bool flag = true;
int value=0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");


using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

int x1 = 5;
if ( x1 > 0 )
{
    int x2 = 6;
    x1 +=  x2;
}
Console.WriteLine(x1);

/* REMOVE BRACES IF STATEMENTS -- Readability */

bool flag = true;
if (flag)
    Console.WriteLine(flag);


string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");



string name = "steve";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if 
    (name == "steve") Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false ; 

foreach (int number in numbers)
{


    total += number;

    if (number == 42)
        found = true;


}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

/* USING THE SWITCH CASE ------ wHEN TO USE SWITCH */

int employeeLevel = 201;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


int employeeLevel = 300;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");



string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";


switch(product[0])
{
    case "01":
        type = "sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch(product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch(product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}




Console.WriteLine($"Product: {size} {color} {type}");


/*------------------------------------------------------------------------------------------------------------------------ ITERATIONS USING --- FOR */

for ( int i =0; i < 10; i ++ ){
    Console.WriteLine( "" + i );
}


for ( int i = 10 ; i > 0 ; i-- )
{
    Console.WriteLine( "" + i );
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if( i == 7 )
        break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i <= names.Length-1 ; i++)
{
    if ( names[i] == "David")
                names[i] = "Sammy";
    Console.WriteLine(names[i]);
}


for ( int i = 1 ; i < 101 ; i++)
{
    if ( i%5 == 0  && i%3 == 0 )
        Console.WriteLine( $"{i} + ----FizzBuzz" );
    else if ( i%3 == 0 )
        Console.WriteLine( i + "----Fizz" );
    else if ( i%5 == 0 )
        Console.WriteLine( i + "----Buzz" );
    else
        Console.WriteLine( i );


}


/*------------------------------------------------------------------------------------------------------------------------ DO WHILE AND WHILE -------------- */


Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);




Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");




Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);







//challenge

int heroHealth = 10;
int monsterHealth = 10;
Random random= new Random();
do
{

    int attack = random.Next(0,10);
    monsterHealth -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0) continue;
    if (monsterHealth > 0)
    {
        attack = random.Next(0,10);
        heroHealth -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
    }

} while( monsterHealth > 0 && heroHealth > 0 );

Console.WriteLine($"{(heroHealth > monsterHealth ? "Hero wins!!!! " : "Monster wins ")}");



challenge

using System.Runtime.InteropServices;

string? readResult;
int numericValue = 0;
bool validEntry = false;
Console.WriteLine("Enter a number between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    bool validNumber = int.TryParse(readResult, out numericValue);
    if (readResult != null ) 
    {

        if ( numericValue > 5 && numericValue < 10 )
        {
            validEntry = true;
            Console.WriteLine("Your input is has been accepted");
        }
        else if  ( validNumber == false )
        {
            Console.WriteLine("Please enter a number");
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }

} while (validEntry == false);



string? role;

bool validEntry = false;
do
{
    role  = Console.ReadLine().Trim().ToLower();
    if( role != null )
    {


        if ( role == "administrator" ||  role == "manager" ||  role == "user"  )
        {
            validEntry = true;
            Console.WriteLine($"Your input value ({role}) has been accepted.");
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
    else
    {
        Console.WriteLine("Please enter string");
    }

} while ( validEntry == false );


/*------------------------------------------ G U I D E D  P R O J E C T -----------------------------------------------------*/


// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;


    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue");

    // // pause code execution
    // readResult = Console.ReadLine();

    int selectionNumber = 0;
    int.TryParse(menuSelection, out selectionNumber);

    switch (selectionNumber)
    {
        case 1:
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);

                    }
                }

            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case 2:
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                }
                while (validEntry == false);
                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                // get the pet's age. can be ? at initial entry. 
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }

                    }



                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
            
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;



                petCount++;
                if (petCount < maxPets)
                {
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;
        case 3:
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        default:
            break;
    }
} while (menuSelection != "exit");









