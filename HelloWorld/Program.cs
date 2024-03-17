// See https://aka.ms/new-console-template for more information
//Ceci est un commentaire
Console.WriteLine("Hello, World!");
Console.WriteLine(3 * 4 + 1); //Ceci est aussi un commentaire
/*
    Commentaire
    sur
    plusieurs
    lignes
*/



/*
    In C#, there are different types of variables (defined with different keywords), for example:

    int - stores integers (whole numbers), without decimals, such as 123 or -123
    double - stores floating point numbers, with decimals, such as 19.99 or -19.99
    char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
    string - stores text, such as "Hello World". String values are surrounded by double quotes
    bool - stores values with two states: true or false

    int myNum = 5;               // Integer (whole number)
    double myDoubleNum = 5.99D;  // Floating point number
    char myLetter = 'D';         // Character
    bool myBool = true;          // Boolean
    string myText = "Hello";     // String 
*/
decimal tresgrandNombre2 = 79000000000000000000000000000m;
decimal tresgrandNombre1 = 7999999999999999999999999999m;
ulong bigNum = 18446744073709551615;
int number = 256;
double money = 25.66;
char letter = 'A';
string name = "John";
bool isOnline = true;
DateTime myDate = DateTime.Now;

Console.WriteLine(name);
Console.WriteLine(letter);
Console.WriteLine(number);
Console.WriteLine(money);
Console.WriteLine(isOnline);
Console.WriteLine(name + " is " + number + " years old.");
Console.WriteLine(letter+name);
Console.WriteLine("DateTimeNow:");
Console.WriteLine(myDate);

const int myNum = 15;
//myNum = 20; = error: cannot reassign a constant

//Adition 2 strings
string firstName = "Misaki ";
Console.WriteLine(firstName+"Boulay");

// Adition 2 int
int x = 5; 
int y = 6;
Console.WriteLine(x+y);

//Declare many variables
int a = 5, b = 6, c = 50;
Console.WriteLine(a+b+c);

// Good
int minutesPerHour = 60;

// OK, but not so easy to understand what m actually is
int m = 60;

Console.WriteLine(bigNum);

Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");


int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine("Int");
Console.WriteLine(myInt);   // Outputs 9
Console.WriteLine("Double");
Console.WriteLine(myDouble);   // Outputs 9

double myDouble2 = 9.78;

int myInt2 = (int)myDouble2;    // Manual casting: double to int
Console.WriteLine("Double2");
Console.WriteLine(myDouble2); // Outputs 9.78
Console.WriteLine("Int2");
Console.WriteLine(myInt2);      // Outputs 9

int myInt3 = 10;
double myDouble3 = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string