// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");

// Single Line Comment 
/* Multi Line Comment */

// Declaring Variables 
string name;
int score;
float health;

// Initialize Variables
score = 1000;
health = 45.9f;
name = "Justin";

// Escape Sequences
/*
 * \n: new line
 * \t: tab indent
 * \\: Backslash character
 * \": Quotes
 */

// Reading and Writing Strings

Console.WriteLine(""); // Write text to console(terminal)
Console.ReadLine(); // Reads the users input

// String Interpolation: Combining strings
string fullname = $"{firstName}{lastName}";

// Parsing Variables: To convert user input into proper variable types like numbers or Booleans
int.Parse();
float.Parse();
bool.Parse();

// Arithmetic Operators
/*
 * +: Add
 * -: Subtract
 * *: Multiplay
 *(/): Divide 
 * %: Remainder
 */

// Assignment Operators
/*
 * =: Assign value to variable
 * +=: Adds a value to the variable and assigns this amount to the same variable
 * -=: Subtracts a value to the variable and assigns this amount to the same variable
 * *=: Multiplys a value to the variable and assigns this amount to the same variable
 *(/)=: Divides a value to the variable and assigns this amount to the same variable
 * %= Divides a variable by a value and assigns the remainder to the same variable
 */

// Unary Arithmetic Operators
/*
 * ++: increments a value by one
 * --: decrements a value by one
 */

// Comparisson Operators
/*
 * ==: equal to
 * !=: not equal to 
 * >: greater than
 * <: less than
 * >=: greater than or equal to 
 * <=: Less than or equal to 
 */

// Logical Operators
/* !: Not operator
 * &&: And operator
 * ||: Or operator
 * ^: Exclusive Or Operator: Check if one boolean is true and the other is false
 */

// Operator Priority
/*
 * 1. inside brackets
 * 2. multiplication
 * 3. addision
 * 4. relation (<,>,<=,>=)
 * 5. equality (==, !=)
 * 6. and statements
 * 7. or statements
 * 8. assignment operators
 */

// Conditional Statements
if ()
{

} else if ()
{

} else () {

}

// String Functions

string variable;
variable.Contains(textToSearchFor);

variable.isNullOrEmpty();

variable.isNullOrWhiteSpace();

variable.Replace(whatToReplace, whatToReplaceWith);

variable.ToLower();

variable.ToUpper();