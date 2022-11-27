namespace Basic_Core_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to Calculate is Factors :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime  Factors are : ");
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }
            if (number > 1)
            {
                Console.WriteLine(number);
            }
          
        }
    }
}