// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am a simple calculator using only two numbers");
            Console.WriteLine("Please select two numbers");
            Console.WriteLine("First number?");
            String operation;

            double first = 0;
            double second = 0;

            try {
                first = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e){
                Console.WriteLine("Please enter a valid number!");
                return;
            }

            Console.WriteLine("Second number?");

             try {
                second = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e){
                Console.WriteLine("Please enter a valid number!");
                return;
            }

            Console.WriteLine("What operation would you like to use [addition, subtraction, multiplication, division]");
            operation = Console.ReadLine();

            double add;
            double sub;
            double mul;
            double div;
           

            add = first + second;
            sub = Convert.ToDouble(first) - Convert.ToDouble(second);
            mul = Convert.ToDouble(first) * Convert.ToDouble(second);
            div = Convert.ToDouble(first) / Convert.ToDouble(second);


            switch (operation)
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
                default:
                Console.WriteLine("Please enter a valid operation from the given choices!");
                break;
            }
        }
    }
}