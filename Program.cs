using System.ComponentModel.Design;

namespace CheckTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is temperature outside");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x >= 12 && x <= 26)
            {
                Console.WriteLine("its warm outside");
            }
            else if (x >= 50 || x <= -50)
            {
                Console.WriteLine("dont go outside");
            }
            
        }
    }
}
