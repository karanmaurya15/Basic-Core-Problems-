namespace Basic_Core_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to Check");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is an Even number", num);
            }
            else
            {
                Console.WriteLine("{0} is an Odd number", num);
            }
        }
    }
}