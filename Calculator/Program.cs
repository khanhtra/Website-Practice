// See https://aka.ms/new-console-template for more information
namespace Calculator{
class Program{
    public static void Main(string[] args){
Console.WriteLine("Hello, I am a simple calculator using only two numbers");
Console.WriteLine("Please select two numbers");
Console.WriteLine("First number?");
String operation;
char first;
char second;
first = Console.ReadKey().KeyChar;

if (!Char.IsNumber(first)){
    Console.WriteLine("Please re-run and enter a valid numbers!");
}
Console.WriteLine();
Console.WriteLine("Second number?");
second = Console.ReadKey().KeyChar;

if (!Char.IsNumber(second)){
    Console.WriteLine("Please re-run and enter a valid numbers!");
}
Console.WriteLine();
Console.WriteLine("What operation would you like to use [addition, subtraction, multiplication, division]");
operation = Console.ReadLine();

double add;
double sub;
double mul;
double div;

add = first + second;
sub = first - second;
mul = first * second;
div = first / second;


switch(operation)
{
    case "addition":
    Console.WriteLine("The sum is: " + add);
    break;

    case "subtraction":
    Console.WriteLine("The difference is: " + sub);
    break;

    case "multiplication":
    Console.WriteLine("The product is: " + mul);
    break;

    case "division":
    Console.WriteLine("The quotient is: " + div);
    break;


}
}
}
}