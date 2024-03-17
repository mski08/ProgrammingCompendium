// See https://aka.ms/new-console-template for more information

//% Modulus Returns the division remainder	x % y
int x = 5;
int y = 2;
Console.WriteLine(x % y);


Math.Max(5, 10);  // returns 10
Console.WriteLine(Math.Max(5, 10));
Math.Sqrt(64);  // returns 8
Console.WriteLine(Math.Sqrt(64));

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);
int txtLength = txt.Length;
Console.WriteLine("Ceci est la longeur mais diferent " + txt.Length);

/*
    Console.WriteLine("Enter de text you want tu lower: ");
    string text = Console.ReadLine();
    Console.WriteLine("The text in lower case: " + text.ToLower());
*/

Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//String Interpolation
Console.WriteLine("String Interpolation");
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

Console.WriteLine();

//String Methods
string myString = "Hello";
Console.WriteLine(myString[4]);

Console.WriteLine();

//IndexOf() Method
string  myString2= "Index";
Console.WriteLine(myString2.IndexOf("x")); 

Console.WriteLine();

//substring() Method
// Full name
string name2 = "John Doe";

// Location of the letter D
int charPos = name2.IndexOf("D");

// Get last name
string lastName2 = name2.Substring(charPos);

// Print the result
Console.WriteLine("substring() Method");
Console.WriteLine(lastName);

