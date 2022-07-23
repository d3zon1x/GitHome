
using System.Text;

namespace CSharp 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            double a, b;
            Console.WriteLine("Enter a : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            b = double.Parse(Console.ReadLine());
            double c = a + b;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("a + b = " + c);
            }
        }
    }
}

