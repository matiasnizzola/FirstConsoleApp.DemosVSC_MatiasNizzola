//VARIABLES
// STEP 1: DECLARING VARIABLES

string firstName = String.Empty;
string lastName = String.Empty;
int age = 0;
string job = String.Empty;

//STEP 2: PROMPTING USER'S INPUT (INPUT)

/*
- Console.WriteLine(); for informing the user what do we need from him/her
- variable = Console.ReadLine(); for allowing the user to provide the information
*/

Console.WriteLine("Welcome to your first form. Please provide the following information");
Console.WriteLine("What's your first name?");

firstName = Console.ReadLine();

Console.WriteLine("What's your last name?");

lastName = Console.ReadLine();

Console.WriteLine("How old are you?");

age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What do you do for a living?");

job = Console.ReadLine();

//STEP 3: RESULT (OUTPUT)

Console.WriteLine("USER INPUTS");
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Job: {job}");

