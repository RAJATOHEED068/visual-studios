namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)//purpose of programn to take (value or input) from user;
        {
            double x;
            double y;
            double result;
            Console.Write("enter first number:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter second number:");
            y= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("choose operator");
            switch (Console.ReadLine())
            {
                case "+":
                    result = x + y;
                    Console.WriteLine("result is=" + result);
                    break;
                case "-":
                    result = x - y;
                    Console.WriteLine("result is=" + result);
                    break;
                case "*":
                    result = x * y;
                    Console.WriteLine("result is=" + result);
                    break;
                case "/":
                    result = x /y;
                    Console.WriteLine("result is=" + result);
                    break;
                default:
                    Console.WriteLine("invalid statment");
                    break;




            }



        }
    }
}
