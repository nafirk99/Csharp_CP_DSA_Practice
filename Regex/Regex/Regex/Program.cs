// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
/*
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - one or more characters in a row
 * ? - optional preceding character match
 * \ - escape character
 * \n - New line
 * \d - Digit
 * \D - Non-digit
 * \s - White space
 * \S - non-white space
 * \w - alphanumeric/underscore character (word chars)
 * \W - non-word characters
 * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
 * (x|y) - Alternative - x or y
 * 
 * [^x] - Anything but x (where x is whatever character you want)
 */

string pattern = @"(\s|^)Tim($|\s)";
//string tosearch = "";


Console.WriteLine("Tim Correy: " + Regex.IsMatch("Tim Correy:", pattern, RegexOptions.IgnoreCase));
Console.WriteLine("Timothy Correy: " + Regex.IsMatch("Timothy Correy:", pattern, RegexOptions.IgnoreCase));
Console.WriteLine("Correy: " + Regex.IsMatch("Correy:", pattern, RegexOptions.IgnoreCase));
Console.WriteLine("I am Tim Correy: " + Regex.IsMatch("I am Tim Correy:", pattern, RegexOptions.IgnoreCase));
Console.WriteLine("tim Correy: " + Regex.IsMatch("tim Correy:", pattern, RegexOptions.IgnoreCase));
Console.WriteLine("Always Tim: " + Regex.IsMatch("Always Tim", pattern, RegexOptions.IgnoreCase));


