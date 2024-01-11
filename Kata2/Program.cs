namespace Kata2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Here's the total sum converted into binary:");
            Console.WriteLine(AddBinary(a, b));
        }
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString((a + b), 2);
        }
    }
}
